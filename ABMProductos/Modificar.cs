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
    public partial class Modificar : Form
    {
        List<Imagen> listImgs;
        int indiceImagen;
        Articulo articulo = null;
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
            indiceImagen = 0;
            CategoriaGestion CatGestion = new CategoriaGestion();
            MarcaGestion MarcaGestion = new MarcaGestion();

            cboCategoria.DataSource = CatGestion.Listado();
            cboCategoria.DisplayMember = "Descripcion"; // MUESTRA ESTO 
            cboCategoria.ValueMember = "Id"; // MANEJA INTERNAMENTE ESTO

            cboMarca.DataSource = MarcaGestion.Listado();
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Id";

            cboMarca.DataSource = MarcaGestion.Listado();
            cboCategoria.DataSource = CatGestion.Listado();

            txtCodProducto.Text = articulo.Codigo.ToString();
            txtNombre.Text = articulo.Nombre.ToString();
            txtDescripcion.Text = articulo.Descripcion.ToString();
            cboMarca.SelectedValue = articulo.Marca.Id;
            cboCategoria.SelectedValue = articulo.Categoria.Id;
            txtPrecio.Text = articulo.Precio.ToString();

            txtUrlImg.Text = "";
            

            var imgGestion = new ImagenGestion();
            if (imgGestion.ListByIdArticulo(articulo.Id) != null && imgGestion.ListByIdArticulo(articulo.Id).Count>0 )
            {

                listImgs = imgGestion.ListByIdArticulo(articulo.Id);
                
                txtUrlImg.Text = listImgs[indiceImagen].UrlImagen;

                if (listImgs.Count > 0)
                {

                    btnAnterior.Visible = true;
                    btnSiguiente.Visible = true;
                    CargarImagen(); // le envio la posicion del indice en el listado

                }
                else
                {
                    btnAnterior.Visible = false;
                    btnSiguiente.Visible = false;
                    CargarImagen();
                }
            }
            else
            {
                pictureImg.Load("https://static.wikia.nocookie.net/mitologa/images/a/a3/Imagen_por_defecto.png/revision/latest/thumbnail/width/360/height/360?cb=20150824230838&path-prefix=es");

            }


        }

        public void CargarImagen()
        {
            try
            {
                pictureImg.Load(listImgs[indiceImagen].UrlImagen);
            }
            catch (Exception)
            {

                pictureImg.Load("https://static.wikia.nocookie.net/mitologa/images/a/a3/Imagen_por_defecto.png/revision/latest/thumbnail/width/360/height/360?cb=20150824230838&path-prefix=es");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!ValidarCodigo())
            {
                return;
            }
            if (!Validaciones.decimalValido(txtPrecio.Text))
            {
                lblPrecioNumerico.Text = "Formato Erroneo";
                lblPrecioNumerico.Visible = true;
                return;
            }
            if (Validaciones.SoloNumeros(txtPrecio.Text))
            {
                lblPrecioNumerico.Visible = true;
                return;
            }
            lblPrecioNumerico.Visible = false;
            //agregar url valida y eso 




            ArticuloGestion ArtGestion = new ArticuloGestion();
            Articulo modificado = new Articulo();
            try
            {
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
                if (!Validaciones.ValidarTextBoxes(list))
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                        
                }
                else
                {
                    modificado.Id = articulo.Id;
                    modificado.Marca = new Marca();
                    modificado.Categoria = new Categoria();
                    modificado.Codigo = txtCodProducto.Text;
                    modificado.Nombre = txtNombre.Text;
                    modificado.Descripcion = txtDescripcion.Text;
                    modificado.Precio = decimal.Parse(txtPrecio.Text);
                    modificado.Marca = (Marca)cboMarca.SelectedItem;
                    modificado.Categoria = (Categoria)cboCategoria.SelectedItem;

                }
                ArtGestion.Modificar(modificado);
                var ImgGestion = new ImagenGestion();
                var Img = new Imagen() { IdArticulo = modificado.Id, UrlImagen = txtUrlImg.Text };

                ImgGestion.Add(Img);

                MessageBox.Show("Se ha modificado el articulo correctamente", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
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
            if (validarCargaImagen())
                try
                {
                    var ImgGestion = new ImagenGestion();
                    var Img = new Imagen() { IdArticulo = articulo.Id, UrlImagen = txtUrlImg.Text };

                    ImgGestion.Add(Img);
                }
                catch (Exception ex)
                {

                    throw ex;
                }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceImagen < (listImgs.Count() - 1))
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

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            var imgGestion = new ImagenGestion();
            if (imgGestion.ListByIdArticulo(articulo.Id).Count > 0)
            {

                DialogResult respuesta = MessageBox.Show("¿Desea eliminar la imagen de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        var aux = new Imagen() { IdArticulo = articulo.Id, UrlImagen = listImgs[indiceImagen].UrlImagen };
                        imgGestion.Eliminar(aux);
                        listImgs = imgGestion.ListByIdArticulo(articulo.Id);
                        if (listImgs.Count < 0)
                        {
                            btnAnterior.Visible = false;
                            btnSiguiente.Visible = false;
                            CargarImagen();
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
            }
            else
            {
                MessageBox.Show("El articulo no posee imagenes asociadas");
            }


        }
        public bool ValidarCodigo()
        {
            if(txtCodProducto.Text == articulo.Codigo)
            {
                return true;
            }

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
