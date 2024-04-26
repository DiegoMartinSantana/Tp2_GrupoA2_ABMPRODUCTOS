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
    public partial class Detalle : Form
    {
        Articulo articulo;
        public Detalle()
        {
            InitializeComponent();
        } 
        public Detalle(Articulo articulo)
        {

            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
           txtCodigo.Text = articulo.Codigo.ToString();
            txtNombre.Text = articulo.Nombre.ToString();
            txtMarca.Text = articulo.Marca. ToString();
            txtPrecio.Text = articulo.Precio.ToString();
            txtDescripcion.Text = articulo.Descripcion.ToString();


            txtCategoria.Text = articulo.Categoria.ToString();
        }
    }
}
