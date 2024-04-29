using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
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

        List<string> listUrlAdd;

        private void Agregar_Load(object sender, EventArgs e)
        {
            listUrlAdd = new List<string>();
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
            ValidarCodigo();

            if (!Validaciones.decimalValido(txtPrecio.Text))
            {
                lblPrecioNumerico.Text = "Formato Erroneo";
                lblPrecioNumerico.Visible = true;
                return;
            }

            if (Validaciones.SoloNumeros(txtPrecio.Text))
            {
                lblPrecioNumerico.Text = "Valor numerico unicamente";
                lblPrecioNumerico.Visible = true;
                return;
            }

            lblPrecioNumerico.Visible = false;

            List<Control> list = new List<Control>();
            // creo una lista de textbox para agregarle los textboxes que corresponda y luego llamar a la funcion
            // que valida que los textboxes no contengan valores nulos

            list.Add(txtCodProducto);
            list.Add(txtDescripcion);
            list.Add(txtPrecio);
            list.Add(txtNombre);
            list.Add(cboCategoria);
            list.Add(cboMarca);
            list.Add(txtUrlImg);

            ArticuloGestion ArtGestion = new ArticuloGestion();
            var ArticuloAgregar = new Articulo();

            if (Validaciones.ValidarTextBoxes(list))
            {
                try
                {
                    //Carga el Articulo con los datos ingresados
                    ArticuloAgregar.Codigo = txtCodProducto.Text;
                    ArticuloAgregar.Descripcion = txtDescripcion.Text;
                    ArticuloAgregar.Precio = decimal.Parse(txtPrecio.Text);
                    ArticuloAgregar.Nombre = txtNombre.Text;
                    ArticuloAgregar.Marca = (Marca)cboMarca.SelectedItem;
                    ArticuloAgregar.Categoria = (Categoria)cboCategoria.SelectedItem;

                    ArtGestion.Add(ArticuloAgregar);

                    var UltimoInsertado = ArtGestion.Listado().Last(); // obtenemos ultimo insertado

                    //llamar a metodo para hacer inserte en TABLA DE IMAGENES
                    //-------------------------------!
                    var ImgGestion = new ImagenGestion();
                    var Img = new Imagen();



                    foreach (var item in listUrlAdd) //recorre la lista de url y guarda!
                    {
                        Img.IdArticulo = UltimoInsertado.Id;
                        Img.UrlImagen = txtUrlImg.Text;
                        ImgGestion.Add(Img);

                    }

                    MessageBox.Show("Se ha añadido el Articulo correctamente.");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un Error, intente nuevamente mas tarde.");
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Faltan campos por completar.");

            }



        }

        public void CargarImagenes()
        {

            //llena la lista con el id correspondiente una vez se guardo correctamente
            var listImgs = new List<Imagen>();
            var artGestion = new ArticuloGestion();
            var imgGestion = new ImagenGestion();
            foreach (var url in listUrlAdd)
            {
                var imgAux = new Imagen();
                imgAux.UrlImagen = url;
                imgAux.IdArticulo = artGestion.Listado().Last().Id; //accede al ultimo id insertado!

                listImgs.Add(imgAux);

                imgGestion.Add(imgAux); // añadimos x cada vuelta la imagen a la BD.

            }


        }
        public bool validarCargaImagen()
        {
            try
            {
                lblErrorImg.Visible = false;

                pictureImg.Load(txtUrlImg.Text);
                return true;

            }
            catch (Exception)
            {
                lblErrorImg.Visible = true;
                MessageBox.Show("La url proporcionada no se ha podido cargar.");
                return false;
            }
        }
        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            try
            {
                if (validarCargaImagen())
                {

                 

                    listUrlAdd.Add(txtUrlImg.Text); // cada vez que inserta una imagen correctamente, se añade al listado de strings su url.

                }
            }
            catch (Exception)
            {
                lblErrorImg.Visible = true;
                MessageBox.Show("La url proporcionada no se ha podido cargar.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        public bool ValidarCodigo()
        {


            var artGestion = new ArticuloGestion();
            try
            {

                if (artGestion.ExistenciaCodigo(txtCodProducto.Text))
                {
                    lblCodigoExistente.Visible = true;

                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un Error, intente nuevamente mas tarde.");
                this.Close();

            }
            lblCodigoExistente.Visible = false;
            return true;
        }

    }

}
