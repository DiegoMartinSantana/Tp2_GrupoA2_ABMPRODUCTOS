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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }
        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e) // Boton de Guardar
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length < 3)
            {
                lblVacio.Visible = true;
                lblVacio.Text = "Minimo de 3 Caracteres.";
                return;
            }
            Marca marca = new Marca();
            MarcaGestion marcaGestion = new MarcaGestion();
            try
            {
                marca.Descripcion = txtNombre.Text;
                marcaGestion.Add(marca);
                MessageBox.Show("¡La marca ha sido agregada correctamente!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e) // Boton de Cancelar
        {
            Close();
        }
    }
}
