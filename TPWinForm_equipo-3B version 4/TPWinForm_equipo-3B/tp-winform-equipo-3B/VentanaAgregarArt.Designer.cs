namespace tp_winform_equipo_3B
{
    partial class VentanaAgregarArt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarArt));
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.Imagen = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.DescripcionText = new System.Windows.Forms.TextBox();
            this.PrecioText = new System.Windows.Forms.TextBox();
            this.MarcaBox = new System.Windows.Forms.ComboBox();
            this.CategoriaBox = new System.Windows.Forms.ComboBox();
            this.ImagenBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(281, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Articulo";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(254, 95);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 1;
            this.Codigo.Text = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(250, 124);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(231, 149);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 3;
            this.Descripcion.Text = "Descripcion";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(257, 176);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 4;
            this.Marca.Text = "Marca";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(243, 206);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(52, 13);
            this.Categoria.TabIndex = 5;
            this.Categoria.Text = "Categoria";
            // 
            // Imagen
            // 
            this.Imagen.AutoSize = true;
            this.Imagen.Location = new System.Drawing.Point(252, 240);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(42, 13);
            this.Imagen.TabIndex = 6;
            this.Imagen.Text = "Imagen";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(257, 266);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 7;
            this.Precio.Text = "Precio";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(360, 285);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // CodigoText
            // 
            this.CodigoText.Location = new System.Drawing.Point(301, 95);
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.Size = new System.Drawing.Size(200, 20);
            this.CodigoText.TabIndex = 9;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(301, 121);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(200, 20);
            this.NombreText.TabIndex = 10;
            // 
            // DescripcionText
            // 
            this.DescripcionText.Location = new System.Drawing.Point(301, 146);
            this.DescripcionText.Name = "DescripcionText";
            this.DescripcionText.Size = new System.Drawing.Size(200, 20);
            this.DescripcionText.TabIndex = 11;
            // 
            // PrecioText
            // 
            this.PrecioText.Location = new System.Drawing.Point(300, 259);
            this.PrecioText.Name = "PrecioText";
            this.PrecioText.Size = new System.Drawing.Size(200, 20);
            this.PrecioText.TabIndex = 12;
            // 
            // MarcaBox
            // 
            this.MarcaBox.FormattingEnabled = true;
            this.MarcaBox.Location = new System.Drawing.Point(301, 176);
            this.MarcaBox.Name = "MarcaBox";
            this.MarcaBox.Size = new System.Drawing.Size(200, 21);
            this.MarcaBox.TabIndex = 13;
            // 
            // CategoriaBox
            // 
            this.CategoriaBox.FormattingEnabled = true;
            this.CategoriaBox.Location = new System.Drawing.Point(301, 203);
            this.CategoriaBox.Name = "CategoriaBox";
            this.CategoriaBox.Size = new System.Drawing.Size(200, 21);
            this.CategoriaBox.TabIndex = 14;
            // 
            // ImagenBox
            // 
            this.ImagenBox.Location = new System.Drawing.Point(300, 230);
            this.ImagenBox.Name = "ImagenBox";
            this.ImagenBox.Size = new System.Drawing.Size(201, 23);
            this.ImagenBox.TabIndex = 15;
            this.ImagenBox.TabStop = false;
            // 
            // VentanaAgregarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagenBox);
            this.Controls.Add(this.CategoriaBox);
            this.Controls.Add(this.MarcaBox);
            this.Controls.Add(this.PrecioText);
            this.Controls.Add(this.DescripcionText);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.CodigoText);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaAgregarArt";
            this.Text = "VentanaAgregarArt";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label Imagen;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox CodigoText;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox DescripcionText;
        private System.Windows.Forms.TextBox PrecioText;
        private System.Windows.Forms.ComboBox MarcaBox;
        private System.Windows.Forms.ComboBox CategoriaBox;
        private System.Windows.Forms.PictureBox ImagenBox;
    }
}