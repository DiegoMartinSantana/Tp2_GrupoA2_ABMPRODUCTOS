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
            this.lstListaDeArticulos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblListaDeArticulos
            // 
            this.lblListaDeArticulos.AutoSize = true;
            this.lblListaDeArticulos.Location = new System.Drawing.Point(142, 40);
            this.lblListaDeArticulos.Name = "lblListaDeArticulos";
            this.lblListaDeArticulos.Size = new System.Drawing.Size(119, 13);
            this.lblListaDeArticulos.TabIndex = 2;
            this.lblListaDeArticulos.Text = "LISTA DE ARTICULOS";
            // 
            // lstListaDeArticulos
            // 
            this.lstListaDeArticulos.FormattingEnabled = true;
            this.lstListaDeArticulos.Location = new System.Drawing.Point(12, 79);
            this.lstListaDeArticulos.Name = "lstListaDeArticulos";
            this.lstListaDeArticulos.Size = new System.Drawing.Size(395, 433);
            this.lstListaDeArticulos.TabIndex = 3;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 540);
            this.Controls.Add(this.lstListaDeArticulos);
            this.Controls.Add(this.lblListaDeArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Articulos";
            this.Load += new System.EventHandler(this.Listar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaDeArticulos;
        private System.Windows.Forms.ListBox lstListaDeArticulos;
    }
}