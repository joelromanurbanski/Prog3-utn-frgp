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
            this.ListadoLista = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.AutoSize = true;
            this.Listado.Font = new System.Drawing.Font("Old English Text MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Listado.Location = new System.Drawing.Point(339, 36);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(106, 32);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listado";
            // 
            // ListadoLista
            // 
            this.ListadoLista.HideSelection = false;
            this.ListadoLista.Location = new System.Drawing.Point(248, 71);
            this.ListadoLista.Name = "ListadoLista";
            this.ListadoLista.Size = new System.Drawing.Size(293, 349);
            this.ListadoLista.TabIndex = 1;
            this.ListadoLista.UseCompatibleStateImageBehavior = false;
            // 
            // ListadoDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadoLista);
            this.Controls.Add(this.Listado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoDeArticulos";
            this.Text = "ListadoDeArticulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Listado;
        private System.Windows.Forms.ListView ListadoLista;
    }
}