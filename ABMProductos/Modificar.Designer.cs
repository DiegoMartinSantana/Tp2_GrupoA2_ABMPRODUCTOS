namespace ABMProductos
{
    partial class Modificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureImg = new System.Windows.Forms.PictureBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecioNumerico = new System.Windows.Forms.Label();
            this.lblErrorImg = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCodigoExistente = new System.Windows.Forms.Label();
            this.lblArticulosinimg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardar.Location = new System.Drawing.Point(370, 586);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(148, 240);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(148, 194);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(148, 120);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(198, 57);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(148, 323);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(198, 20);
            this.txtUrlImg.TabIndex = 6;
            this.txtUrlImg.Leave += new System.EventHandler(this.txtUrlImg_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(148, 286);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(148, 40);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProducto.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(112, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "SOBREESCRIBA LOS CAMPOS A MODIFICAR";
            // 
            // pictureImg
            // 
            this.pictureImg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureImg.Location = new System.Drawing.Point(94, 396);
            this.pictureImg.Name = "pictureImg";
            this.pictureImg.Size = new System.Drawing.Size(270, 163);
            this.pictureImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImg.TabIndex = 30;
            this.pictureImg.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(35, 243);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(35, 289);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(35, 194);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca :";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.ForeColor = System.Drawing.Color.Black;
            this.lblUrl.Location = new System.Drawing.Point(35, 326);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(26, 13);
            this.lblUrl.TabIndex = 16;
            this.lblUrl.Text = "Url :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(35, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre : ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(35, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(107, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo de Producto :";
            // 
            // lblPrecioNumerico
            // 
            this.lblPrecioNumerico.AutoSize = true;
            this.lblPrecioNumerico.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioNumerico.Location = new System.Drawing.Point(266, 292);
            this.lblPrecioNumerico.Name = "lblPrecioNumerico";
            this.lblPrecioNumerico.Size = new System.Drawing.Size(138, 13);
            this.lblPrecioNumerico.TabIndex = 31;
            this.lblPrecioNumerico.Text = "Valor numerico unicamente.";
            this.lblPrecioNumerico.Visible = false;
            // 
            // lblErrorImg
            // 
            this.lblErrorImg.AutoSize = true;
            this.lblErrorImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorImg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorImg.Location = new System.Drawing.Point(352, 321);
            this.lblErrorImg.Name = "lblErrorImg";
            this.lblErrorImg.Size = new System.Drawing.Size(20, 25);
            this.lblErrorImg.TabIndex = 32;
            this.lblErrorImg.Text = "*";
            this.lblErrorImg.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiguiente.Location = new System.Drawing.Point(370, 525);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(37, 34);
            this.btnSiguiente.TabIndex = 33;
            this.btnSiguiente.Text = "--->";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnterior.Location = new System.Drawing.Point(49, 525);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(39, 34);
            this.btnAnterior.TabIndex = 34;
            this.btnAnterior.Text = "<---";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Visible = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminarImagen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEliminarImagen.Location = new System.Drawing.Point(180, 565);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarImagen.TabIndex = 35;
            this.btnEliminarImagen.Text = "Eliminar Imagen";
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinfo.Location = new System.Drawing.Point(128, 346);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(276, 13);
            this.lblinfo.TabIndex = 36;
            this.lblinfo.Text = "Para agregar una imagen, ingrese su url y presione Save.";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.Location = new System.Drawing.Point(378, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblCodigoExistente
            // 
            this.lblCodigoExistente.AutoSize = true;
            this.lblCodigoExistente.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoExistente.Location = new System.Drawing.Point(260, 47);
            this.lblCodigoExistente.Name = "lblCodigoExistente";
            this.lblCodigoExistente.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoExistente.TabIndex = 38;
            this.lblCodigoExistente.Text = "Codigo Existente";
            this.lblCodigoExistente.Visible = false;
            // 
            // lblArticulosinimg
            // 
            this.lblArticulosinimg.AutoSize = true;
            this.lblArticulosinimg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArticulosinimg.Location = new System.Drawing.Point(128, 368);
            this.lblArticulosinimg.Name = "lblArticulosinimg";
            this.lblArticulosinimg.Size = new System.Drawing.Size(297, 13);
            this.lblArticulosinimg.TabIndex = 39;
            this.lblArticulosinimg.Text = "Si el Articulo no posee una imagen. Debera proporcionar una.";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(471, 611);
            this.Controls.Add(this.lblArticulosinimg);
            this.Controls.Add(this.lblCodigoExistente);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblErrorImg);
            this.Controls.Add(this.lblPrecioNumerico);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUrlImg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureImg);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 57);
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureImg;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecioNumerico;
        private System.Windows.Forms.Label lblErrorImg;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCodigoExistente;
        private System.Windows.Forms.Label lblArticulosinimg;
    }
}