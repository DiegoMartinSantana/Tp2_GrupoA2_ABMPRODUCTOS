﻿namespace ABMProductos
{
    partial class ListadoCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoCategorias));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblVacioModificar = new System.Windows.Forms.Label();
            this.lblListaDeCategorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(288, 272);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(288, 301);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(28, 98);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(206, 13);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = " Seleccione una para realizar una accion .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estas son sus Categorias disponibles ";
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(155, 358);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCat.TabIndex = 1;
            this.txtNombreCat.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 360);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(121, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Ingrese nuevo Nombre :";
            this.lblNombre.Visible = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(288, 358);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(65, 23);
            this.btnGuardarCambios.TabIndex = 4;
            this.btnGuardarCambios.Text = "Guardar";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // dgvCat
            // 
            this.dgvCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCat.Location = new System.Drawing.Point(31, 129);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCat.Size = new System.Drawing.Size(251, 196);
            this.dgvCat.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblVacioModificar
            // 
            this.lblVacioModificar.AutoSize = true;
            this.lblVacioModificar.ForeColor = System.Drawing.Color.Red;
            this.lblVacioModificar.Location = new System.Drawing.Point(155, 385);
            this.lblVacioModificar.Name = "lblVacioModificar";
            this.lblVacioModificar.Size = new System.Drawing.Size(97, 13);
            this.lblVacioModificar.TabIndex = 9;
            this.lblVacioModificar.Text = "Ingrese un Nombre";
            this.lblVacioModificar.Visible = false;
            // 
            // lblListaDeCategorias
            // 
            this.lblListaDeCategorias.AutoSize = true;
            this.lblListaDeCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeCategorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaDeCategorias.Location = new System.Drawing.Point(152, 25);
            this.lblListaDeCategorias.Name = "lblListaDeCategorias";
            this.lblListaDeCategorias.Size = new System.Drawing.Size(146, 13);
            this.lblListaDeCategorias.TabIndex = 10;
            this.lblListaDeCategorias.Text = "LISTA DE CATEGORIAS";
            // 
            // ListadoCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(419, 540);
            this.Controls.Add(this.lblListaDeCategorias);
            this.Controls.Add(this.lblVacioModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCat);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 579);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 579);
            this.Name = "ListadoCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Categorias";
            this.Load += new System.EventHandler(this.ListadoCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVacioModificar;
        private System.Windows.Forms.Label lblListaDeCategorias;
    }
}