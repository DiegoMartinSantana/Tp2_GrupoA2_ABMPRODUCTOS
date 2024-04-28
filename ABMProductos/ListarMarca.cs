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
    public partial class frmListarMarca : Form
    {
        public frmListarMarca()
        {
            InitializeComponent();
        }
        private List<Marca> ListMarcas;
        public void Cargar()
        {
            MarcaGestion marGestion = new MarcaGestion();
            ListMarcas = marGestion.Listado();
            dgvListaDeMarcas.DataSource = ListMarcas;
        }
        private void frmListarMarca_Load(object sender, EventArgs e)
        {
            Cargar();

            // Ocultar columnas que no son necesarias en el listado, es solo para consultar el Nombre
            dgvListaDeMarcas.Columns["Id"].Visible = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e) // Boton para eliminar una marca
        {
            MarcaGestion marGestion = new MarcaGestion();
            Marca seleccionado;

            try
            {
                if(dgvListaDeMarcas.CurrentRow != null)
                {
                    seleccionado = (Marca)dgvListaDeMarcas.CurrentRow.DataBoundItem;

                    if (marGestion.ExistenciaArticulos(seleccionado.Id))
                    {
                        //Verdadero si existe
                        MessageBox.Show("No es posible eliminar una marca con articulos asociados.","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar la marca de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (respuesta == DialogResult.Yes)
                        {
                            seleccionado = (Marca)dgvListaDeMarcas.CurrentRow.DataBoundItem;
                            marGestion.Eliminar(seleccionado.Id);
                            Cargar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No ha selecionado ninguna categoria");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListaDeMarcas.CurrentRow != null)
            {
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
            }
            else
            {
                MessageBox.Show("No ha selecionado ninguna categoria");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaDeMarcas.CurrentRow != null)
                {
                    Marca seleccionada = (Marca)dgvListaDeMarcas.CurrentRow.DataBoundItem;

                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        lblVacioModificar.Visible = true;
                        return;
                    }
                    else
                    {
                        lblVacioModificar.Visible = false;

                        // Crear una nueva instancia de la marca con la descripción modificada
                        Marca marcaModificada = new Marca
                        {
                            Id = seleccionada.Id,
                            Descripcion = txtNombre.Text
                        };

                        MarcaGestion marGestion = new MarcaGestion();
                        marGestion.Editar(marcaModificada); // Llamar al método Editar con la marca modificada
                        Cargar();
                    }

                    lblNombre.Visible = false;
                    txtNombre.Visible = false;
                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ninguna marca.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar la marca");
            }
        }
    }
}
