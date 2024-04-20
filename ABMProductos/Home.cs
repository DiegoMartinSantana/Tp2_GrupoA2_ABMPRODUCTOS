using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Agregar = new Agregar();
            Agregar.ShowDialog();
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

        }

        private void verArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Listar = new Listar();
            Listar.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
