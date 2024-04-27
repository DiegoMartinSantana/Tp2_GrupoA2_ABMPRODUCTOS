using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            List<TextBox> list = new List<TextBox>(); // creo una lista de textbox para agregarle los textboxes que corresponda y luego llamar a la funcion
                                                      // que valida que los textboxes no contengan valores nulos
                                                      
            list.Add(txtCodProducto);
            list.Add(txtDescripcion);
            list.Add(txtPrecio);
            list.Add(txtNombre);
          

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


                //-------------------------------!


                //llamar a Metodo para hacer Insert ARTICULO en BD


                //metodo para validar ARTICULO ENTERO + EXISTENCIA DE UNA IMAGEN AL MENOS.

                ArtGestion.Add(ArticuloAgregar);


                var UltimoInsertado = ArtGestion.Listado().Last(); // obtenemos ultimo insertado


                //llamar a metodo para hacer inserte en TABLA DE IMAGENES
                //-------------------------------!
                var ImgGestion = new ImagenGestion();
                var Img = new Imagen() { IdArticulo = UltimoInsertado.Id, UrlImagen = txtUrlImg.Text };

                ImgGestion.Add(Img);

                MessageBox.Show("Se ha añadido el Articulo correctamente.");

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un Error, intente nuevamente mas tarde.");
                this.Close();

            }
            }



            this.Close();

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
        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            try
            {
                lblErrorImg.Visible = false;

                pictureImg.Load(txtUrlImg.Text);

                listUrlAdd = new List<string> (); 

                listUrlAdd.Add(txtUrlImg.Text); // cada vez que inserta una imagen correctamente, se añade al listado de strings su url.

            }
            catch (Exception)
            {
                lblErrorImg.Visible = true;
                MessageBox.Show("La url proporcionada no se ha podido cargar.");
            }
        }
    }


}
