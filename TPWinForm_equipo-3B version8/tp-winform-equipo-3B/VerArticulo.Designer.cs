namespace tp_winform_equipo_3B
{
    partial class VerArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerArticulo));
            this.VerArticuloText = new System.Windows.Forms.Label();
            this.VerArtText = new System.Windows.Forms.Label();
            this.ListaVerArt = new System.Windows.Forms.ListView();
            this.VerArtTextBox = new System.Windows.Forms.TextBox();
            this.VerArtBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerArticuloText
            // 
            this.VerArticuloText.AutoSize = true;
            this.VerArticuloText.Font = new System.Drawing.Font("Old English Text MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.VerArticuloText.Location = new System.Drawing.Point(312, 48);
            this.VerArticuloText.Name = "VerArticuloText";
            this.VerArticuloText.Size = new System.Drawing.Size(164, 32);
            this.VerArticuloText.TabIndex = 0;
            this.VerArticuloText.Text = "Ver Articulo";
            // 
            // VerArtText
            // 
            this.VerArtText.AutoSize = true;
            this.VerArtText.Location = new System.Drawing.Point(152, 86);
            this.VerArtText.Name = "VerArtText";
            this.VerArtText.Size = new System.Drawing.Size(137, 13);
            this.VerArtText.TabIndex = 1;
            this.VerArtText.Text = "Ingresar nombre del articulo";
            // 
            // ListaVerArt
            // 
            this.ListaVerArt.HideSelection = false;
            this.ListaVerArt.Location = new System.Drawing.Point(289, 141);
            this.ListaVerArt.Name = "ListaVerArt";
            this.ListaVerArt.Size = new System.Drawing.Size(213, 231);
            this.ListaVerArt.TabIndex = 2;
            this.ListaVerArt.UseCompatibleStateImageBehavior = false;
            // 
            // VerArtTextBox
            // 
            this.VerArtTextBox.Location = new System.Drawing.Point(289, 86);
            this.VerArtTextBox.Name = "VerArtTextBox";
            this.VerArtTextBox.Size = new System.Drawing.Size(213, 20);
            this.VerArtTextBox.TabIndex = 3;
            // 
            // VerArtBoton
            // 
            this.VerArtBoton.Location = new System.Drawing.Point(355, 112);
            this.VerArtBoton.Name = "VerArtBoton";
            this.VerArtBoton.Size = new System.Drawing.Size(75, 23);
            this.VerArtBoton.TabIndex = 4;
            this.VerArtBoton.Text = "Ver";
            this.VerArtBoton.UseVisualStyleBackColor = true;
            // 
            // VerArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerArtBoton);
            this.Controls.Add(this.VerArtTextBox);
            this.Controls.Add(this.ListaVerArt);
            this.Controls.Add(this.VerArtText);
            this.Controls.Add(this.VerArticuloText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerArticulo";
            this.Text = "VerArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VerArticuloText;
        private System.Windows.Forms.Label VerArtText;
        private System.Windows.Forms.ListView ListaVerArt;
        private System.Windows.Forms.TextBox VerArtTextBox;
        private System.Windows.Forms.Button VerArtBoton;
    }
}