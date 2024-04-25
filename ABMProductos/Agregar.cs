using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
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
            CategoriaGestion CatGestion = new CategoriaGestion();
            MarcaGestion MarcaGestion = new MarcaGestion();

            cboCategoria.DataSource = CatGestion.Listado();
            cboCategoria.DisplayMember = "Descripcion"; // MUESTRA ESTO 
            cboCategoria.ValueMember = "Id"; // MANEJA INTERNAMENTE ESTO

            cboMarca.DataSource = MarcaGestion.Listado();
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Id";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloGestion ArtGestion = new ArticuloGestion();
            var ArticuloAgregar = new Articulo();

            try
            {
                //Carga el Articulo con los datos ingresados
                ArticuloAgregar.Codigo = txtCodProducto.Text;
                ArticuloAgregar.Descripcion = txtDescripcion.Text;
                ArticuloAgregar.Precio = decimal.Parse(txtPrecio.Text);
                ArticuloAgregar.Nombre = txtNombre.Text;
                ArticuloAgregar.Marca = (Marca)cboMarca.SelectedItem;
                ArticuloAgregar.Categoria = (Categoria)cboCategoria.SelectedItem;
                ArticuloAgregar.Imagen = new Imagen();

                //validar que funcione DECIDIR SI PONE UNA GENERICA EN BD O NO DEJA CARGAR SINO
                //-------------------------------!

                ArticuloAgregar.Imagen.Url = txtUrlImg.Text;

                //llamar a Metodo para hacer Insert ARTICULO en BD

                ArtGestion.Add(ArticuloAgregar);

                //llamar a metodo para hacer inserte en TABLA DE IMAGENES
                 //-------------------------------!



            }
            catch (Exception )
            {
                MessageBox.Show("Ha ocurrido un Error, intente nuevamente mas tarde.");
                this.Close();
                
            }
            
            

            MessageBox.Show("Articulo agregado correctamente");

            this.Close();


        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            //validar carga 
            pictureImg.ImageLocation = txtUrlImg.Text;

        }
    }
}
