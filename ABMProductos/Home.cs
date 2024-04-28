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

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        private void articuloiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Agregar = new Agregar();
            Agregar.ShowDialog();

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;

            var Detalle = new Detalle(seleccionado);
            Detalle.ShowDialog();
        }

        private void verArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Listar = new Listar();
            Listar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;

            var Modificar = new Modificar(seleccionado);
            Modificar.ShowDialog();
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

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            var Acceso = new ArticuloGestion();
            dvgArticulos.DataSource = Acceso.Listado();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var acceso = new ArticuloGestion();
            string filtro = txtBuscar.Text;

            List<Articulo> listFiltrada;

            if (filtro.Length > 3)
            {
                //realizo busqueda 
                listFiltrada= ListArticulos.FindAll(Item => Item.Nombre.ToUpper().Contains(filtro.ToUpper()));  
            }
            else
            {

                listFiltrada = ListArticulos;
            }

            dvgArticulos.DataSource = null; // piso el valor con nulo para limpiarla
            dvgArticulos.DataSource = listFiltrada;
            OcultarColumnas();


        }
        
        public void OcultarColumnas()
        {
            dvgArticulos.Columns["Id"].Visible = false;
            dvgArticulos.Columns["Codigo"].Visible =false;
            dvgArticulos.Columns["Descripcion"].Visible = false;
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
                    artGestion.eliminar(seleccionado.Codigo);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
