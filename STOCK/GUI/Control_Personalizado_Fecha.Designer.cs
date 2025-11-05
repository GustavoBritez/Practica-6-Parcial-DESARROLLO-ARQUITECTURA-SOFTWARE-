namespace GUI
{
    partial class Control_Personalizado_Fecha
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.PICTURE_BOX = new System.Windows.Forms.PictureBox();
            this.Label_Dni = new System.Windows.Forms.Label();
            this.Label_NRO_Dni = new System.Windows.Forms.Label();
            this.Label_Descripcion = new System.Windows.Forms.Label();
            this.RTB_Descripcion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(31, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Label_Nombre.TabIndex = 0;
            this.Label_Nombre.Text = "Nombre";
            // 
            // PICTURE_BOX
            // 
            this.PICTURE_BOX.Location = new System.Drawing.Point(3, 16);
            this.PICTURE_BOX.Name = "PICTURE_BOX";
            this.PICTURE_BOX.Size = new System.Drawing.Size(112, 56);
            this.PICTURE_BOX.TabIndex = 1;
            this.PICTURE_BOX.TabStop = false;
            // 
            // Label_Dni
            // 
            this.Label_Dni.AutoSize = true;
            this.Label_Dni.Location = new System.Drawing.Point(3, 75);
            this.Label_Dni.Name = "Label_Dni";
            this.Label_Dni.Size = new System.Drawing.Size(23, 13);
            this.Label_Dni.TabIndex = 2;
            this.Label_Dni.Text = "Dni";
            // 
            // Label_NRO_Dni
            // 
            this.Label_NRO_Dni.AutoSize = true;
            this.Label_NRO_Dni.Location = new System.Drawing.Point(32, 75);
            this.Label_NRO_Dni.Name = "Label_NRO_Dni";
            this.Label_NRO_Dni.Size = new System.Drawing.Size(69, 13);
            this.Label_NRO_Dni.TabIndex = 3;
            this.Label_NRO_Dni.Text = "XX XXX XXX";
            // 
            // Label_Descripcion
            // 
            this.Label_Descripcion.AutoSize = true;
            this.Label_Descripcion.Location = new System.Drawing.Point(211, 0);
            this.Label_Descripcion.Name = "Label_Descripcion";
            this.Label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Label_Descripcion.TabIndex = 4;
            this.Label_Descripcion.Text = "Descripcion";
            // 
            // RTB_Descripcion
            // 
            this.RTB_Descripcion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RTB_Descripcion.Location = new System.Drawing.Point(121, 16);
            this.RTB_Descripcion.Name = "RTB_Descripcion";
            this.RTB_Descripcion.Size = new System.Drawing.Size(241, 72);
            this.RTB_Descripcion.TabIndex = 5;
            this.RTB_Descripcion.Text = "";
            // 
            // Control_Personalizado_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RTB_Descripcion);
            this.Controls.Add(this.Label_Descripcion);
            this.Controls.Add(this.Label_NRO_Dni);
            this.Controls.Add(this.Label_Dni);
            this.Controls.Add(this.PICTURE_BOX);
            this.Controls.Add(this.Label_Nombre);
            this.Name = "Control_Personalizado_Fecha";
            this.Size = new System.Drawing.Size(366, 93);
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.PictureBox PICTURE_BOX;
        private System.Windows.Forms.Label Label_Dni;
        private System.Windows.Forms.Label Label_NRO_Dni;
        private System.Windows.Forms.Label Label_Descripcion;
        private System.Windows.Forms.RichTextBox RTB_Descripcion;
    }
}
