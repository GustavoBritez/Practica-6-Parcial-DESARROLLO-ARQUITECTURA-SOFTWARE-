namespace Gestion_Hotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Grilla_Habitaciones = new DataGridView();
            BTN_ADD_HABITACION = new Button();
            BTN_REMOVE_HABITACION = new Button();
            BTN_MOD_HABITACION = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grilla_Habitaciones).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Habitaciones
            // 
            Grilla_Habitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Habitaciones.Location = new Point(12, 21);
            Grilla_Habitaciones.Name = "Grilla_Habitaciones";
            Grilla_Habitaciones.Size = new Size(329, 111);
            Grilla_Habitaciones.TabIndex = 0;
            // 
            // BTN_ADD_HABITACION
            // 
            BTN_ADD_HABITACION.Location = new Point(347, 34);
            BTN_ADD_HABITACION.Name = "BTN_ADD_HABITACION";
            BTN_ADD_HABITACION.Size = new Size(75, 23);
            BTN_ADD_HABITACION.TabIndex = 1;
            BTN_ADD_HABITACION.Text = "Agregar";
            BTN_ADD_HABITACION.UseVisualStyleBackColor = true;
            BTN_ADD_HABITACION.Click += BTN_ADD_HABITACION_Click;
            // 
            // BTN_REMOVE_HABITACION
            // 
            BTN_REMOVE_HABITACION.Location = new Point(347, 63);
            BTN_REMOVE_HABITACION.Name = "BTN_REMOVE_HABITACION";
            BTN_REMOVE_HABITACION.Size = new Size(75, 23);
            BTN_REMOVE_HABITACION.TabIndex = 2;
            BTN_REMOVE_HABITACION.Text = "Remover";
            BTN_REMOVE_HABITACION.UseVisualStyleBackColor = true;
            BTN_REMOVE_HABITACION.Click += BTN_REMOVE_HABITACION_Click;
            // 
            // BTN_MOD_HABITACION
            // 
            BTN_MOD_HABITACION.Location = new Point(347, 92);
            BTN_MOD_HABITACION.Name = "BTN_MOD_HABITACION";
            BTN_MOD_HABITACION.Size = new Size(75, 23);
            BTN_MOD_HABITACION.TabIndex = 3;
            BTN_MOD_HABITACION.Text = "Modificar";
            BTN_MOD_HABITACION.UseVisualStyleBackColor = true;
            BTN_MOD_HABITACION.Click += BTN_MOD_HABITACION_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 3);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Habitaciones ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BTN_MOD_HABITACION);
            Controls.Add(BTN_REMOVE_HABITACION);
            Controls.Add(BTN_ADD_HABITACION);
            Controls.Add(Grilla_Habitaciones);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Habitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Habitaciones;
        private Button BTN_ADD_HABITACION;
        private Button BTN_REMOVE_HABITACION;
        private Button BTN_MOD_HABITACION;
        private Label label1;
    }
}
