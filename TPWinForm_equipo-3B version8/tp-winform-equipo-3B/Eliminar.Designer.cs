namespace tp_winform_equipo_3B
{
    partial class Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            this.EliminarArtBoton = new System.Windows.Forms.Button();
            this.EliminarArtTextBox = new System.Windows.Forms.TextBox();
            this.EliminarArtText = new System.Windows.Forms.Label();
            this.EliminarArt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EliminarArtBoton
            // 
            this.EliminarArtBoton.Location = new System.Drawing.Point(357, 130);
            this.EliminarArtBoton.Name = "EliminarArtBoton";
            this.EliminarArtBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarArtBoton.TabIndex = 8;
            this.EliminarArtBoton.Text = "Eliminar";
            this.EliminarArtBoton.UseVisualStyleBackColor = true;
            // 
            // EliminarArtTextBox
            // 
            this.EliminarArtTextBox.Location = new System.Drawing.Point(291, 104);
            this.EliminarArtTextBox.Name = "EliminarArtTextBox";
            this.EliminarArtTextBox.Size = new System.Drawing.Size(213, 20);
            this.EliminarArtTextBox.TabIndex = 7;
            // 
            // EliminarArtText
            // 
            this.EliminarArtText.AutoSize = true;
            this.EliminarArtText.Location = new System.Drawing.Point(148, 107);
            this.EliminarArtText.Name = "EliminarArtText";
            this.EliminarArtText.Size = new System.Drawing.Size(134, 13);
            this.EliminarArtText.TabIndex = 6;
            this.EliminarArtText.Text = "Ingresar codigo del articulo";
            // 
            // EliminarArt
            // 
            this.EliminarArt.AutoSize = true;
            this.EliminarArt.Font = new System.Drawing.Font("Old English Text MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EliminarArt.Location = new System.Drawing.Point(285, 59);
            this.EliminarArt.Name = "EliminarArt";
            this.EliminarArt.Size = new System.Drawing.Size(229, 32);
            this.EliminarArt.TabIndex = 5;
            this.EliminarArt.Text = "Eliminar Articulo";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EliminarArtBoton);
            this.Controls.Add(this.EliminarArtTextBox);
            this.Controls.Add(this.EliminarArtText);
            this.Controls.Add(this.EliminarArt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarArtBoton;
        private System.Windows.Forms.TextBox EliminarArtTextBox;
        private System.Windows.Forms.Label EliminarArtText;
        private System.Windows.Forms.Label EliminarArt;
    }
}