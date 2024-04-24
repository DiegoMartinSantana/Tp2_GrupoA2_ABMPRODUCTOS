namespace ABMProductos
{
    partial class Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar));
            this.lblListaDeArticulos = new System.Windows.Forms.Label();
            this.dgvListaDeArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaDeArticulos
            // 
            this.lblListaDeArticulos.AutoSize = true;
            this.lblListaDeArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeArticulos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaDeArticulos.Location = new System.Drawing.Point(137, 31);
            this.lblListaDeArticulos.Name = "lblListaDeArticulos";
            this.lblListaDeArticulos.Size = new System.Drawing.Size(137, 13);
            this.lblListaDeArticulos.TabIndex = 2;
            this.lblListaDeArticulos.Text = "LISTA DE ARTICULOS";
            // 
            // dgvListaDeArticulos
            // 
            this.dgvListaDeArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDeArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDeArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaDeArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeArticulos.Location = new System.Drawing.Point(12, 78);
            this.dgvListaDeArticulos.Name = "dgvListaDeArticulos";
            this.dgvListaDeArticulos.Size = new System.Drawing.Size(395, 450);
            this.dgvListaDeArticulos.TabIndex = 3;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(419, 540);
            this.Controls.Add(this.dgvListaDeArticulos);
            this.Controls.Add(this.lblListaDeArticulos);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 579);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 579);
            this.Name = "Listar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaDeArticulos;
        private System.Windows.Forms.DataGridView dgvListaDeArticulos;
    }
}