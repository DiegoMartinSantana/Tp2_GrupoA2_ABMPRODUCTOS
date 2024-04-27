using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ABMProductos
{
    public partial class Detalle : Form
    {
        //--

        List<Imagen> listImgs;
        int indiceImagen;

        //--
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
            try
            {
                txtCodigo.Text = articulo.Codigo.ToString();
                txtNombre.Text = articulo.Nombre.ToString();
                txtMarca.Text = articulo.Marca.ToString();
                txtPrecio.Text = articulo.Precio.ToString();
                txtDescripcion.Text = articulo.Descripcion.ToString();
                txtCategoria.Text = articulo.Categoria.ToString();

                var ImgGestion = new ImagenGestion();
                listImgs = ImgGestion.ListByIdArticulo(articulo.Id);

                if (listImgs.Count > 0)
                {
                    indiceImagen = 0;
                    btnAnterior.Visible = true;
                    btnSiguiente.Visible = true;
                    CargarImagen(); // le envio la posicion del indice en el listado
                   
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
      
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (indiceImagen < (listImgs.Count() - 1)) // xque el indice va de  0 a 3 x ejem  ( 4 elem)
            {
                indiceImagen++;
                CargarImagen();

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceImagen > 0)
            {
                indiceImagen--;
                CargarImagen();
            }
        }
        public void CargarImagen()
        {
            try
            {
                pbxImg.Load(listImgs[indiceImagen].UrlImagen);
            }
            catch (Exception)
            {

                pbxImg.Load("https://static.wikia.nocookie.net/mitologa/images/a/a3/Imagen_por_defecto.png/revision/latest/thumbnail/width/360/height/360?cb=20150824230838&path-prefix=es");
            }
        }
    }
}

