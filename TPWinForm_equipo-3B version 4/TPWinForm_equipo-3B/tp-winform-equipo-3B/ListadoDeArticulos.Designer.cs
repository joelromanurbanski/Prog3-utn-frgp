namespace tp_winform_equipo_3B
{
    partial class ListadoDeArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoDeArticulos));
            this.Listado = new System.Windows.Forms.Label();
            this.ListadoLista = new System.Windows.Forms.DataGridView();
            this.PictureBoxArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.AutoSize = true;
            this.Listado.Font = new System.Drawing.Font("Old English Text MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Listado.Location = new System.Drawing.Point(341, 21);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(106, 32);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listado";
            // 
            // ListadoLista
            // 
            this.ListadoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoLista.Location = new System.Drawing.Point(21, 71);
            this.ListadoLista.Name = "ListadoLista";
            this.ListadoLista.Size = new System.Drawing.Size(571, 293);
            this.ListadoLista.TabIndex = 2;
            this.ListadoLista.SelectionChanged += new System.EventHandler(this.ListadoLista_SelectionChanged);
            // 
            // PictureBoxArt
            // 
            this.PictureBoxArt.Location = new System.Drawing.Point(616, 71);
            this.PictureBoxArt.Name = "PictureBoxArt";
            this.PictureBoxArt.Size = new System.Drawing.Size(318, 293);
            this.PictureBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxArt.TabIndex = 4;
            this.PictureBoxArt.TabStop = false;
            // 
            // ListadoDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 470);
            this.Controls.Add(this.PictureBoxArt);
            this.Controls.Add(this.ListadoLista);
            this.Controls.Add(this.Listado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoDeArticulos";
            this.Text = "ListadoDeArticulos";
            this.Load += new System.EventHandler(this.ListadoDeArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Listado;
        private System.Windows.Forms.DataGridView ListadoLista;
        private System.Windows.Forms.PictureBox PictureBoxArt;
    }
}