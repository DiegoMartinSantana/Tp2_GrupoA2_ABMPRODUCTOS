using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ABMProductos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private List<Articulo> ListArticulos;

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();

            OcultarColumnas();

            //cboCampo.Items.Clear(); 
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Marca");


        }
        public void Cargar()
        {
            ArticuloGestion artGestion = new ArticuloGestion();
            ListArticulos = artGestion.Listado();
            dvgArticulos.DataSource = ListArticulos;
        }
        public void OcultarColumnas()
        {
            dvgArticulos.Columns["Id"].Visible = false;
            dvgArticulos.Columns["Codigo"].Visible = false;
            dvgArticulos.Columns["Descripcion"].Visible = false;
        }
        // BUSCAR ARTICULO
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var acceso = new ArticuloGestion();
            string filtro = txtBuscar.Text;

            List<Articulo> listFiltrada;

            if (filtro.Length > 3)
            {
                //realizo busqueda 
                listFiltrada = ListArticulos.FindAll(Item => Item.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {

                listFiltrada = ListArticulos;
            }

            dvgArticulos.DataSource = null; // piso el valor con nulo para limpiarla
            dvgArticulos.DataSource = listFiltrada;
            OcultarColumnas();


        }
       
        // BOTONES
        private void btnBuscar_Click(object sender, EventArgs e) // Boton para buscar Articulo
        {
            if (cboCampo.SelectedItem != null && cboCriterio.SelectedItem != null && !(string.IsNullOrEmpty(txtFiltradoCriterio.Text))){
                lblNofiltro.Visible = false;
                try
                {
                    var Acceso = new ArticuloGestion();
                    dvgArticulos.DataSource = Acceso.Listado();
                    string campo, criterio, filtro;
                    campo = cboCampo.SelectedItem.ToString();
                    criterio = cboCriterio.SelectedItem.ToString();
                    filtro = txtFiltradoCriterio.Text;
                    dvgArticulos.DataSource = Acceso.FiltroCriterios(campo, criterio, filtro);
                }
                catch (Exception)
                {
                    MessageBox.Show("Se ha producido un Error, intente nuevamente mas tarde.");

                }
            }
            else
            {
                lblNofiltro.Visible = true;
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e) // Boton para eliminar Articulo
        {
            ArticuloGestion artGestion = new ArticuloGestion();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el artículo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    if (dvgArticulos.CurrentRow != null)
                    {
                        seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                        artGestion.eliminar(seleccionado.Id);
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ningun articulo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnModificar_Click(object sender, EventArgs e) // Boton para modificar Articulo
        {
            if (dvgArticulos.CurrentRow != null)
            {

                Articulo seleccionado;
                seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;

                var Modificar = new Modificar(seleccionado);
                Modificar.ShowDialog();

                Cargar();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun articulo");
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e) // Boton para refrescar cuadro de busqueda de Articulos
        {
            var Acceso = new ArticuloGestion();
            dvgArticulos.DataSource = Acceso.Listado();
        }
        private void btnDetalle_Click(object sender, EventArgs e) // Boton para ver detalles del Arrticulo
        {
            Articulo seleccionado;
            if (dvgArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                var Detalle = new Detalle(seleccionado);
                Detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun articulo");
            }

        }
        // DESPLEGABLES PARA AGREGAR
        private void articuloToolStripMenuItem_Click(object sender, EventArgs e) // Opcion para Agregar Articulo
        {
            var Agregar = new Agregar();
            Agregar.ShowDialog();
        }
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e) // Opcion para Agregar Marca
        {
            var frmAgregarMarca = new frmAgregarMarca();
            frmAgregarMarca.ShowDialog();
        }
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e) // Opcion para Agregar Categoria
        {
            var frmAgregarCat = new AgregarCategoria();
            frmAgregarCat.ShowDialog();
        }
        // DESPLEGABLE PARA LISTAR
        private void articulosListarToolStripMenuItem_Click(object sender, EventArgs e) // Opcion para Listar Articulos
        {
            var Listar = new Listar();
            Listar.ShowDialog();
        }
        private void marcasListarToolStripMenuItem_Click(object sender, EventArgs e) // Opcion para Listar Marcas
        {
            var frmListarMarca = new frmListarMarca();
            frmListarMarca.ShowDialog();
        }
        private void categoriasListarToolStripMenuItem_Click(object sender, EventArgs e) // Opcion para Listar Categorias
        {
            var frmListadoCat = new ListadoCategorias();
            frmListadoCat.ShowDialog();

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampo.SelectedItem.ToString();
            if (campo == "Precio")
            {
                cboCriterio.Items.Clear();

                cboCriterio.Items.Add("Mayor a :");
                cboCriterio.Items.Add("Menor a :");
                cboCriterio.Items.Add("Igual :");

            }
            else
            {
                cboCriterio.Items.Clear();

                cboCriterio.Items.Add("Contiene :");
                cboCriterio.Items.Add("Termina con :");
                cboCriterio.Items.Add("Empieza con :");

            }
        }
    }
}