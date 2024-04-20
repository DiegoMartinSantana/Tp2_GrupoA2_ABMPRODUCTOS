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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            // Buscar en la base de datos los articulos y agregarlos en la lista de productos.
            // Lo siguiente es solo un ejemplo para ver como quedaria la lista:

            var articulo = new Articulo();
            articulo.Nombre = "Computadora";
            lstListaDeArticulos.Items.Add(articulo.Nombre);
            articulo.Nombre = "Telefono";
            lstListaDeArticulos.Items.Add(articulo.Nombre);
        }
    }
}
