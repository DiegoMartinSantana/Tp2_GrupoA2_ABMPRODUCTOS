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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            // Cargar en dvgListaDeArticulos los datos adquiridos de la BD.
            ArticuloGestion artGestion = new ArticuloGestion();
            var ListArticulos = artGestion.Listado();
            dgvListaDeArticulos.DataSource = ListArticulos;

            // Ocultar columnas que no son necesarias en el listado, es solo para consultar Codigo, Nombre y Precio
            dgvListaDeArticulos.Columns["Id"].Visible = false;
            dgvListaDeArticulos.Columns["Descripcion"].Visible = false;
            dgvListaDeArticulos.Columns["Marca"].Visible = false;
            dgvListaDeArticulos.Columns["Categoria"].Visible = false;
            //dgvListaDeArticulos.Columns["Imagen"].Visible = false;
        }
    }
}
