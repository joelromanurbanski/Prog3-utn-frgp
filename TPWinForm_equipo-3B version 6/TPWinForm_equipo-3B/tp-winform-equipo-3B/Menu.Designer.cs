using System;

namespace tp_winform_equipo_3B
{
    partial class Catalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.AgregarArticulo = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.VerUnArticulo = new System.Windows.Forms.Button();
            this.ListadoDeArticulos = new System.Windows.Forms.Button();
            this.BuscarArticulo = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AgregarArticulo
            // 
            this.AgregarArticulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarArticulo.Location = new System.Drawing.Point(114, 103);
            this.AgregarArticulo.Name = "AgregarArticulo";
            this.AgregarArticulo.Size = new System.Drawing.Size(115, 25);
            this.AgregarArticulo.TabIndex = 0;
            this.AgregarArticulo.Text = "Agregar Articulo\r\n";
            this.AgregarArticulo.UseVisualStyleBackColor = false;
            this.AgregarArticulo.Click += new System.EventHandler(this.AgregarArticuloClick);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modificar.Location = new System.Drawing.Point(114, 227);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(115, 25);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar ";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.ModificarClick);
            // 
            // VerUnArticulo
            // 
            this.VerUnArticulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VerUnArticulo.Location = new System.Drawing.Point(114, 196);
            this.VerUnArticulo.Name = "VerUnArticulo";
            this.VerUnArticulo.Size = new System.Drawing.Size(115, 25);
            this.VerUnArticulo.TabIndex = 2;
            this.VerUnArticulo.Text = "Ver un Articulo\r\n";
            this.VerUnArticulo.UseVisualStyleBackColor = false;
            this.VerUnArticulo.Click += new System.EventHandler(this.VerUnArticuloClick);
            // 
            // ListadoDeArticulos
            // 
            this.ListadoDeArticulos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListadoDeArticulos.Location = new System.Drawing.Point(114, 165);
            this.ListadoDeArticulos.Name = "ListadoDeArticulos";
            this.ListadoDeArticulos.Size = new System.Drawing.Size(115, 25);
            this.ListadoDeArticulos.TabIndex = 3;
            this.ListadoDeArticulos.Text = "Listado De Articulos";
            this.ListadoDeArticulos.UseVisualStyleBackColor = false;
            this.ListadoDeArticulos.Click += new System.EventHandler(this.ListadoDeArticulosClick);
            // 
            // BuscarArticulo
            // 
            this.BuscarArticulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuscarArticulo.Location = new System.Drawing.Point(114, 134);
            this.BuscarArticulo.Name = "BuscarArticulo";
            this.BuscarArticulo.Size = new System.Drawing.Size(115, 25);
            this.BuscarArticulo.TabIndex = 4;
            this.BuscarArticulo.Text = "Buscar  Articulo";
            this.BuscarArticulo.UseVisualStyleBackColor = false;
            this.BuscarArticulo.Click += new System.EventHandler(this.BuscarArticuloClick);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Eliminar.Location = new System.Drawing.Point(114, 258);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(115, 25);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.EliminarClick);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Old English Text MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(130, 59);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(85, 32);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "Menu";
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 404);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.BuscarArticulo);
            this.Controls.Add(this.ListadoDeArticulos);
            this.Controls.Add(this.VerUnArticulo);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.AgregarArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 443);
            this.MinimumSize = new System.Drawing.Size(360, 443);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarArticulo;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button VerUnArticulo;
        private System.Windows.Forms.Button ListadoDeArticulos;
        private System.Windows.Forms.Button BuscarArticulo;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label Menu;
    }
}

