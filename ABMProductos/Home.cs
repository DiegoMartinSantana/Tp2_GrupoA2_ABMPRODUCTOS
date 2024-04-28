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


            cbo1.Items.Add("Categoria");
            cbo1.Items.Add("Precio");
            cbo1.Items.Add("Marca");


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
        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string campo = cbo1.SelectedItem.ToString();
            if (campo == "Precio")
            {
                cbo2.Items.Clear();

                cbo2.Items.Add("Mayor a :");
                cbo2.Items.Add("Menor a :");
                cbo2.Items.Add("Igual :");

            }
            else
            {
                cbo2.Items.Clear();

                cbo2.Items.Add("Contiene :");
                cbo2.Items.Add("Termina con :");
                cbo2.Items.Add("Empieza con :");

            }

        }
        // BOTONES
        private void btnBuscar_Click(object sender, EventArgs e) // Boton para buscar Articulo
        {
            try
            {
                var Acceso = new ArticuloGestion();
                dvgArticulos.DataSource = Acceso.Listado();
                string campo, criterio, filtro;
                campo = cbo1.SelectedItem.ToString();
                criterio = cbo2.SelectedItem.ToString();
                filtro = txtFiltradoCriterio.Text;
                dvgArticulos.DataSource = Acceso.FiltroCriterios(campo, criterio, filtro);
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un Error, intente nuevamente mas tarde.");

            }

        }
        private void btnEliminar_Click(object sender, EventArgs e) // Boton para eliminar Articulo
        {
            ArticuloGestion artGestion = new ArticuloGestion();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el artículo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                    artGestion.eliminar(seleccionado.Id);
                
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnModificar_Click(object sender, EventArgs e) // Boton para modificar Articulo
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;

            var Modificar = new Modificar(seleccionado);
            Modificar.ShowDialog();
        }
        private void btnRefrescar_Click(object sender, EventArgs e) // Boton para refrescar cuadro de busqueda de Articulos
        {
            var Acceso = new ArticuloGestion();
            dvgArticulos.DataSource = Acceso.Listado();
        }
        private void btnDetalle_Click(object sender, EventArgs e) // Boton para ver detalles del Arrticulo
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;

            var Detalle = new Detalle(seleccionado);
            Detalle.ShowDialog();
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
    }
}