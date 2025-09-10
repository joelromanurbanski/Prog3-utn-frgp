namespace tp_winform_equipo_3B
{
    partial class BuscarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarArticulo));
            this.BuscarArt = new System.Windows.Forms.Label();
            this.BuscarArtText = new System.Windows.Forms.Label();
            this.BuscardorArt = new System.Windows.Forms.ComboBox();
            this.ResultadoBuscarArt = new System.Windows.Forms.ListView();
            this.BuscarArtBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscarArt
            // 
            this.BuscarArt.AutoSize = true;
            this.BuscarArt.Font = new System.Drawing.Font("Old English Text MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BuscarArt.Location = new System.Drawing.Point(286, 61);
            this.BuscarArt.Name = "BuscarArt";
            this.BuscarArt.Size = new System.Drawing.Size(206, 32);
            this.BuscarArt.TabIndex = 0;
            this.BuscarArt.Text = "Buscar Articulo";
            // 
            // BuscarArtText
            // 
            this.BuscarArtText.AutoSize = true;
            this.BuscarArtText.Location = new System.Drawing.Point(215, 106);
            this.BuscarArtText.Name = "BuscarArtText";
            this.BuscarArtText.Size = new System.Drawing.Size(78, 13);
            this.BuscarArtText.TabIndex = 1;
            this.BuscarArtText.Text = "Buscar Articulo";
            // 
            // BuscardorArt
            // 
            this.BuscardorArt.FormattingEnabled = true;
            this.BuscardorArt.Location = new System.Drawing.Point(292, 103);
            this.BuscardorArt.Name = "BuscardorArt";
            this.BuscardorArt.Size = new System.Drawing.Size(200, 21);
            this.BuscardorArt.TabIndex = 2;
            // 
            // ResultadoBuscarArt
            // 
            this.ResultadoBuscarArt.HideSelection = false;
            this.ResultadoBuscarArt.Location = new System.Drawing.Point(292, 164);
            this.ResultadoBuscarArt.Name = "ResultadoBuscarArt";
            this.ResultadoBuscarArt.Size = new System.Drawing.Size(200, 155);
            this.ResultadoBuscarArt.TabIndex = 3;
            this.ResultadoBuscarArt.UseCompatibleStateImageBehavior = false;
            // 
            // BuscarArtBoton
            // 
            this.BuscarArtBoton.Location = new System.Drawing.Point(353, 130);
            this.BuscarArtBoton.Name = "BuscarArtBoton";
            this.BuscarArtBoton.Size = new System.Drawing.Size(84, 19);
            this.BuscarArtBoton.TabIndex = 4;
            this.BuscarArtBoton.Text = "Buscar";
            this.BuscarArtBoton.UseVisualStyleBackColor = true;
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuscarArtBoton);
            this.Controls.Add(this.ResultadoBuscarArt);
            this.Controls.Add(this.BuscardorArt);
            this.Controls.Add(this.BuscarArtText);
            this.Controls.Add(this.BuscarArt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarArticulo";
            this.Text = "BuscarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuscarArt;
        private System.Windows.Forms.Label BuscarArtText;
        private System.Windows.Forms.ComboBox BuscardorArt;
        private System.Windows.Forms.ListView ResultadoBuscarArt;
        private System.Windows.Forms.Button BuscarArtBoton;
    }
}