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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Carga el Articulo con los datos ingresados
            var ArticuloAgregar = new Articulo();
            ArticuloAgregar.Codigo = txtCodProducto.Text;
            ArticuloAgregar.Descripcion = txtDescripcion.Text;
            ArticuloAgregar.Precio = float.Parse(txtPrecio.Text);
            ArticuloAgregar.Nombre = txtNombre.Text;
            ArticuloAgregar.Marca = (Marca)cboMarca.SelectedItem;
            ArticuloAgregar.Categoria = (Categoria)cboCategoria.SelectedItem;
            ArticuloAgregar.Imagen = new Imagen();
            ArticuloAgregar.Imagen.Url = txtUrlImg.Text;

            //llamar a Metodo para hacer Insert en BD



            MessageBox.Show("Articulo agregado correctamente");

            this.Close();


        }
    }
}
