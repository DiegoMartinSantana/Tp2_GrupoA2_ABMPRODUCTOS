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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblHome = new System.Windows.Forms.Label();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.verArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoFuncionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwgArticulos = new System.Windows.Forms.DataGridView();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.cbo3 = new System.Windows.Forms.ComboBox();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgArticulos)).BeginInit();
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
            this.agregarArticuloToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(834, 24);
            this.menu1.TabIndex = 3;
            this.menu1.Text = "menuStrip1";
            // 
            // verArticulosToolStripMenuItem
            // 
            this.verArticulosToolStripMenuItem.Name = "verArticulosToolStripMenuItem";
            this.verArticulosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.verArticulosToolStripMenuItem.Text = "Ver Articulos";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Articulo";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backGroundColorToolStripMenuItem,
            this.sizeTextToolStripMenuItem,
            this.otherToolStripMenuItem2,
            this.ayudaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // backGroundColorToolStripMenuItem
            // 
            this.backGroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.otherToolStripMenuItem1});
            this.backGroundColorToolStripMenuItem.Name = "backGroundColorToolStripMenuItem";
            this.backGroundColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backGroundColorToolStripMenuItem.Text = "BackGround Color";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whiteToolStripMenuItem.Text = "White";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // otherToolStripMenuItem1
            // 
            this.otherToolStripMenuItem1.Name = "otherToolStripMenuItem1";
            this.otherToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem1.Text = "Other";
            // 
            // sizeTextToolStripMenuItem
            // 
            this.sizeTextToolStripMenuItem.Name = "sizeTextToolStripMenuItem";
            this.sizeTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeTextToolStripMenuItem.Text = "Size Text?";
            // 
            // otherToolStripMenuItem2
            // 
            this.otherToolStripMenuItem2.Name = "otherToolStripMenuItem2";
            this.otherToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem2.Text = "Other?";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoFuncionaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // comoFuncionaToolStripMenuItem
            // 
            this.comoFuncionaToolStripMenuItem.Name = "comoFuncionaToolStripMenuItem";
            this.comoFuncionaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.comoFuncionaToolStripMenuItem.Text = "Como Funciona?";
            // 
            // dwgArticulos
            // 
            this.dwgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgArticulos.Location = new System.Drawing.Point(56, 182);
            this.dwgArticulos.Name = "dwgArticulos";
            this.dwgArticulos.Size = new System.Drawing.Size(580, 273);
            this.dwgArticulos.TabIndex = 4;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(658, 432);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
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
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(65, 134);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 21);
            this.cbo1.TabIndex = 7;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(62, 105);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(94, 13);
            this.lblFiltrar.TabIndex = 8;
            this.lblFiltrar.Text = "Filtrar Articulo por :";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(62, 65);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 13);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Buscar Articulo";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(162, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(271, 20);
            this.txtBuscar.TabIndex = 10;
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(228, 134);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(121, 21);
            this.cbo2.TabIndex = 11;
            // 
            // cbo3
            // 
            this.cbo3.FormattingEnabled = true;
            this.cbo3.Location = new System.Drawing.Point(402, 134);
            this.cbo3.Name = "cbo3";
            this.cbo3.Size = new System.Drawing.Size(121, 21);
            this.cbo3.TabIndex = 12;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.cbo3);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dwgArticulos);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menu1);
            this.MainMenuStrip = this.menu1;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem verArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.DataGridView dwgArticulos;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backGroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sizeTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem2;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoFuncionaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.ComboBox cbo3;
    }
}

