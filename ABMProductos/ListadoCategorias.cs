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

namespace ABMProductos
{
    public partial class ListadoCategorias : Form
    {
        public ListadoCategorias()
        {
            InitializeComponent();
        }
        private void ListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }
        public void CargarDgv()
        {
            var gestionCat = new CategoriaGestion();
            dgvCat.DataSource = gestionCat.Listado();
            OcultarColumnas();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCat.CurrentRow != null)
            {
                lblNombre.Visible = true;
                txtNombreCat.Visible = true;
                btnGuardarCambios.Visible = true;
                btnCancelar.Visible = true;
            }
            else
            {
                MessageBox.Show("No ha selecionado ninguna categoria");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminar categoria
            var gestionCat = new CategoriaGestion();

            Categoria seleccionada;
            try
            {
                if (dgvCat.CurrentRow != null)
                {

                    seleccionada = (Categoria)dgvCat.CurrentRow.DataBoundItem;


                        if (!gestionCat.ExistenciaArticulos(seleccionada.Id))
                        {
                            
                            MessageBox.Show("No es posible eliminar una categoria con articulos asociados.");
                            return;
                        }
                        else
                        {
                           
                            gestionCat.Eliminar(seleccionada.Id);
                            MessageBox.Show("Se ha eliminado correctamente.");
                            CargarDgv(); // actualizamos la lista

                        }
                    
                }
                else
                {
                    MessageBox.Show("No ha selecionado ninguna categoria");

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void OcultarColumnas()
        {
            dgvCat.Columns["Id"].Visible = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            txtNombreCat.Visible = false;
            btnGuardarCambios.Visible = false;
            btnCancelar.Visible = false;

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //editar categoria
            try
            {
                if ( dgvCat.CurrentRow != null )
                {
                    Categoria seleccionada;
                    seleccionada = (Categoria)dgvCat.CurrentRow.DataBoundItem;
                    var gestionCat = new CategoriaGestion();

                    if (string.IsNullOrEmpty(txtNombreCat.Text))
                    {
                        lblVacioModificar.Visible = true;
                        return;
                    }
                    else
                    {
                        lblVacioModificar.Visible = false;
                        gestionCat.Editar(seleccionada);
                        CargarDgv();
                    }
                }
                else
                {
                    MessageBox.Show("No ha selecionado ninguna categoria");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
