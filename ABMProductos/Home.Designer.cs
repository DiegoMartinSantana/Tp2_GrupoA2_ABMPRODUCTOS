namespace ABMProductos
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.Label();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.verArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvgArticulos = new System.Windows.Forms.DataGridView();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.txtFiltradoCriterio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(489, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(1, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(0, 13);
            this.lblHome.TabIndex = 2;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verArticulosToolStripMenuItem,
            this.agregarArticuloToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(834, 24);
            this.menu1.TabIndex = 3;
            this.menu1.Text = "menuStrip1";
            // 
            // verArticulosToolStripMenuItem
            // 
            this.verArticulosToolStripMenuItem.Name = "verArticulosToolStripMenuItem";
            this.verArticulosToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.verArticulosToolStripMenuItem.Text = "Listar Articulos";
            this.verArticulosToolStripMenuItem.Click += new System.EventHandler(this.verArticulosToolStripMenuItem_Click);
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloiToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.tipoArticuloToolStripMenuItem});
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // articuloiToolStripMenuItem
            // 
            this.articuloiToolStripMenuItem.Name = "articuloiToolStripMenuItem";
            this.articuloiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.articuloiToolStripMenuItem.Text = "Articulo";
            this.articuloiToolStripMenuItem.Click += new System.EventHandler(this.articuloiToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // tipoArticuloToolStripMenuItem
            // 
            this.tipoArticuloToolStripMenuItem.Name = "tipoArticuloToolStripMenuItem";
            this.tipoArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoArticuloToolStripMenuItem.Text = "Tipo Articulo";
            // 
            // dvgArticulos
            // 
            this.dvgArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgArticulos.Location = new System.Drawing.Point(56, 195);
            this.dvgArticulos.MultiSelect = false;
            this.dvgArticulos.Name = "dvgArticulos";
            this.dvgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgArticulos.Size = new System.Drawing.Size(635, 273);
            this.dvgArticulos.TabIndex = 4;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(708, 385);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Ver Detalles";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // cbo1
            // 
            this.cbo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(56, 134);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 21);
            this.cbo1.TabIndex = 7;
            this.cbo1.SelectedIndexChanged += new System.EventHandler(this.cbo1_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(53, 103);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(94, 13);
            this.lblFiltrar.TabIndex = 8;
            this.lblFiltrar.Text = "Filtrar Articulo por :";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(53, 65);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(81, 13);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Buscar Articulo:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(161, 65);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(271, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(224, 134);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(121, 21);
            this.cbo2.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(708, 443);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(708, 414);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ABMProductos.Properties.Resources.abmproductos_logo;
            this.picLogo.Location = new System.Drawing.Point(658, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(164, 151);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefrescar.Location = new System.Drawing.Point(697, 195);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 16;
            this.btnRefrescar.Text = "Refresh";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtFiltradoCriterio
            // 
            this.txtFiltradoCriterio.Location = new System.Drawing.Point(383, 134);
            this.txtFiltradoCriterio.Name = "txtFiltradoCriterio";
            this.txtFiltradoCriterio.Size = new System.Drawing.Size(100, 20);
            this.txtFiltradoCriterio.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(532, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltradoCriterio);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dvgArticulos);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu1;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem verArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.DataGridView dvgArticulos;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TextBox txtFiltradoCriterio;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ToolStripMenuItem articuloiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoArticuloToolStripMenuItem;
    }
}

