using Negocio;
using System;
using System.Windows.Forms;
namespace ABMProductos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloGestion artGestion = new ArticuloGestion();
            var ListArticulos = artGestion.Listado();
           dvgArticulos.DataSource = ListArticulos;
            //posible separacion en metodos.
            dvgArticulos.Columns["Id"].Visible = false;
            dvgArticulos.Columns["Imagen"].Visible = false;
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Agregar = new Agregar();
            Agregar.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            var Detalle = new Detalle();
            Detalle.ShowDialog();
        }

        private void verArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle VentanaDetalle = new Detalle();
            VentanaDetalle.ShowDialog();
        }
    }
}
