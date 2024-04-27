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
    public partial class Modificar : Form
    {   
        Articulo articulo;
        public Modificar()
        {
            InitializeComponent();
        }
         public Modificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
           

            txtCodProducto.Text = articulo.Codigo.ToString();   
            txtNombre.Text=articulo.Nombre.ToString();
            txtDescripcion.Text=articulo.Descripcion.ToString();
            cboMarca.Text = articulo.Marca.ToString();
            cboCategoria.Text = articulo.Categoria.ToString();
            txtPrecio.Text = articulo.Precio.ToString(); 
           //  agregar url imagen
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
