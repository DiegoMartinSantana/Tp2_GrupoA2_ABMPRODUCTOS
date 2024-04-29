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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length<3)
            {
                lblVacio.Visible = true;
                lblVacio.Text = "Minimo de 3 Caracteres.";
                return;
            }
            

            try
            {
                var gestionCat = new CategoriaGestion();
                var aux = new Categoria() { Descripcion = txtNombre.Text };
                gestionCat.Add(aux);
                MessageBox.Show("La categoria se ha añadido correctamente!");

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error. Reintente nuevamente mas tarde.");
            }
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
