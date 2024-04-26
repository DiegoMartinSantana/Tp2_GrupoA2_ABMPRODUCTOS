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
          
            //posible separacion en metodos.
            dvgArticulos.Columns["Id"].Visible = false;
            dvgArticulos.Columns["Imagen"].Visible = false;
         
            cbo1.Items.Add("pepe");
            cbo1.Items.Add("juana");

        }
        public void Cargar()
        {
            ArticuloGestion artGestion = new ArticuloGestion();
             ListArticulos = artGestion.Listado();
            dvgArticulos.DataSource = ListArticulos;
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
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
            var Modificar = new Modificar();
            Modificar.ShowDialog();
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string campo = cbo1.SelectedItem.ToString();
            if (campo == "pepe")
            {
                cbo2.Items.Clear();

                cbo2.Items.Add("base a pepe");
                cbo2.Items.Add("base a peep 2");

            }
            else
            {
                cbo2.Items.Clear();
                cbo2.Items.Add("dakdjka");
                cbo2.Items.Add("154");
            }
        }
    }
}
