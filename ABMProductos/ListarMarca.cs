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
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar la marca de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvListaDeMarcas.CurrentRow.DataBoundItem;
                    marGestion.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
