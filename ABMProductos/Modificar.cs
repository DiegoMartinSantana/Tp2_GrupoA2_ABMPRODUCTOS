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
    public partial class Modificar : Form
    {   
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
            txtNombre.Text=articulo.Nombre.ToString();
            txtDescripcion.Text=articulo.Descripcion.ToString();
            cboMarca.SelectedValue = articulo.Marca.Id;
            cboCategoria.SelectedValue = articulo.Categoria.Id;
            txtPrecio.Text = articulo.Precio.ToString();             
           //  agregar url imagen
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloGestion ArtGestion = new ArticuloGestion();
            Articulo modificado= new Articulo();
            try
            {
            List<Control> list = new List<Control>(); // creo una lista de textbox para agregarle los textboxes que corresponda y luego llamar a la funcion
                                                     // que valida que los textboxes no contengan valores nulos
            list.Add(txtCodProducto);
            list.Add(txtDescripcion);
            list.Add(txtPrecio);
            list.Add(txtNombre);
            list.Add(cboCategoria);
            list.Add(cboMarca);
                if (!Validaciones.ValidarTextBoxes(list))
                {
                    MessageBox.Show("Complete todos los campos");
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

                MessageBox.Show("Se ha modificado el articulo correctamente","Modificacion exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                this.Close();
            }

        }
    }
}
