namespace GUI
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
            Tab_Dueño = new TabPage();
            BTN_REPORTE = new Button();
            label7 = new Label();
            BTN_ELIMINAR_DUEÑO = new Button();
            BTN_MODIFICAR_DUEÑO = new Button();
            BTN_AGREGAR_DUEÑO = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TXT_MAIL_DUEÑO = new TextBox();
            TXT_TELEFONO_DUEÑO = new TextBox();
            TXT_NOMBRE_DUEÑO = new TextBox();
            Grilla_Dueño = new DataGridView();
            Tab_Cliente = new TabPage();
            label8 = new Label();
            txt_Mail_Cliente = new TextBox();
            txt_Telefono_Cliente = new TextBox();
            txt_Nombre_Cliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            BTN_Eliminar_Cliente = new Button();
            BTN_Agregar_Cliente = new Button();
            BTN_Modificar_Cliente = new Button();
            Grilla_Clientes = new DataGridView();
            Control_Vista = new TabControl();
            tabPage1 = new TabPage();
            BTN_MODIFICAR = new Button();
            BTN_ELIMINAR = new Button();
            BTN_AGREGAR = new Button();
            label9 = new Label();
            TXT_BUSQUEDA = new TextBox();
            Lista_Productos = new ListBox();
            Tab_Dueño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Dueño).BeginInit();
            Tab_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Clientes).BeginInit();
            Control_Vista.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // Tab_Dueño
            // 
            Tab_Dueño.BackColor = Color.DimGray;
            Tab_Dueño.Controls.Add(BTN_REPORTE);
            Tab_Dueño.Controls.Add(label7);
            Tab_Dueño.Controls.Add(BTN_ELIMINAR_DUEÑO);
            Tab_Dueño.Controls.Add(BTN_MODIFICAR_DUEÑO);
            Tab_Dueño.Controls.Add(BTN_AGREGAR_DUEÑO);
            Tab_Dueño.Controls.Add(label6);
            Tab_Dueño.Controls.Add(label5);
            Tab_Dueño.Controls.Add(label4);
            Tab_Dueño.Controls.Add(TXT_MAIL_DUEÑO);
            Tab_Dueño.Controls.Add(TXT_TELEFONO_DUEÑO);
            Tab_Dueño.Controls.Add(TXT_NOMBRE_DUEÑO);
            Tab_Dueño.Controls.Add(Grilla_Dueño);
            Tab_Dueño.ForeColor = SystemColors.ControlDark;
            Tab_Dueño.Location = new Point(4, 24);
            Tab_Dueño.Name = "Tab_Dueño";
            Tab_Dueño.Padding = new Padding(3);
            Tab_Dueño.Size = new Size(792, 422);
            Tab_Dueño.TabIndex = 3;
            Tab_Dueño.Text = "Dueño";
            // 
            // BTN_REPORTE
            // 
            BTN_REPORTE.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_REPORTE.ForeColor = SystemColors.ActiveCaptionText;
            BTN_REPORTE.Location = new Point(199, 362);
            BTN_REPORTE.Name = "BTN_REPORTE";
            BTN_REPORTE.Size = new Size(397, 33);
            BTN_REPORTE.TabIndex = 11;
            BTN_REPORTE.Text = "Generar Reporte";
            BTN_REPORTE.UseVisualStyleBackColor = true;
            BTN_REPORTE.Click += BTN_REPORTE_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(199, 47);
            label7.Name = "label7";
            label7.Size = new Size(101, 37);
            label7.TabIndex = 10;
            label7.Text = "Dueño";
            // 
            // BTN_ELIMINAR_DUEÑO
            // 
            BTN_ELIMINAR_DUEÑO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_ELIMINAR_DUEÑO.ForeColor = SystemColors.ActiveCaptionText;
            BTN_ELIMINAR_DUEÑO.Location = new Point(383, 292);
            BTN_ELIMINAR_DUEÑO.Name = "BTN_ELIMINAR_DUEÑO";
            BTN_ELIMINAR_DUEÑO.Size = new Size(75, 23);
            BTN_ELIMINAR_DUEÑO.TabIndex = 9;
            BTN_ELIMINAR_DUEÑO.Text = "Eliminar";
            BTN_ELIMINAR_DUEÑO.UseVisualStyleBackColor = true;
            BTN_ELIMINAR_DUEÑO.Click += BTN_ELIMINAR_DUEÑO_Click;
            // 
            // BTN_MODIFICAR_DUEÑO
            // 
            BTN_MODIFICAR_DUEÑO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_MODIFICAR_DUEÑO.ForeColor = SystemColors.ActiveCaptionText;
            BTN_MODIFICAR_DUEÑO.Location = new Point(209, 292);
            BTN_MODIFICAR_DUEÑO.Name = "BTN_MODIFICAR_DUEÑO";
            BTN_MODIFICAR_DUEÑO.Size = new Size(75, 23);
            BTN_MODIFICAR_DUEÑO.TabIndex = 8;
            BTN_MODIFICAR_DUEÑO.Text = "Modificar";
            BTN_MODIFICAR_DUEÑO.UseVisualStyleBackColor = true;
            BTN_MODIFICAR_DUEÑO.Click += BTN_MODIFICAR_DUEÑO_Click;
            // 
            // BTN_AGREGAR_DUEÑO
            // 
            BTN_AGREGAR_DUEÑO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_AGREGAR_DUEÑO.ForeColor = SystemColors.ActiveCaptionText;
            BTN_AGREGAR_DUEÑO.Location = new Point(49, 292);
            BTN_AGREGAR_DUEÑO.Name = "BTN_AGREGAR_DUEÑO";
            BTN_AGREGAR_DUEÑO.Size = new Size(75, 23);
            BTN_AGREGAR_DUEÑO.TabIndex = 7;
            BTN_AGREGAR_DUEÑO.Text = "Agregar";
            BTN_AGREGAR_DUEÑO.UseVisualStyleBackColor = true;
            BTN_AGREGAR_DUEÑO.Click += BTN_AGREGAR_DUEÑO_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(543, 229);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 6;
            label6.Text = "Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(525, 174);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 5;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(528, 117);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Nombre";
            // 
            // TXT_MAIL_DUEÑO
            // 
            TXT_MAIL_DUEÑO.Location = new Point(584, 221);
            TXT_MAIL_DUEÑO.Name = "TXT_MAIL_DUEÑO";
            TXT_MAIL_DUEÑO.Size = new Size(160, 23);
            TXT_MAIL_DUEÑO.TabIndex = 3;
            // 
            // TXT_TELEFONO_DUEÑO
            // 
            TXT_TELEFONO_DUEÑO.Location = new Point(584, 166);
            TXT_TELEFONO_DUEÑO.Name = "TXT_TELEFONO_DUEÑO";
            TXT_TELEFONO_DUEÑO.Size = new Size(160, 23);
            TXT_TELEFONO_DUEÑO.TabIndex = 2;
            // 
            // TXT_NOMBRE_DUEÑO
            // 
            TXT_NOMBRE_DUEÑO.Location = new Point(584, 109);
            TXT_NOMBRE_DUEÑO.Name = "TXT_NOMBRE_DUEÑO";
            TXT_NOMBRE_DUEÑO.Size = new Size(160, 23);
            TXT_NOMBRE_DUEÑO.TabIndex = 1;
            // 
            // Grilla_Dueño
            // 
            Grilla_Dueño.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Dueño.Location = new Point(8, 87);
            Grilla_Dueño.Name = "Grilla_Dueño";
            Grilla_Dueño.Size = new Size(492, 199);
            Grilla_Dueño.TabIndex = 0;
            // 
            // Tab_Cliente
            // 
            Tab_Cliente.BackColor = Color.Gray;
            Tab_Cliente.Controls.Add(label8);
            Tab_Cliente.Controls.Add(txt_Mail_Cliente);
            Tab_Cliente.Controls.Add(txt_Telefono_Cliente);
            Tab_Cliente.Controls.Add(txt_Nombre_Cliente);
            Tab_Cliente.Controls.Add(label3);
            Tab_Cliente.Controls.Add(label2);
            Tab_Cliente.Controls.Add(Label1);
            Tab_Cliente.Controls.Add(BTN_Eliminar_Cliente);
            Tab_Cliente.Controls.Add(BTN_Agregar_Cliente);
            Tab_Cliente.Controls.Add(BTN_Modificar_Cliente);
            Tab_Cliente.Controls.Add(Grilla_Clientes);
            Tab_Cliente.Location = new Point(4, 24);
            Tab_Cliente.Name = "Tab_Cliente";
            Tab_Cliente.Padding = new Padding(3);
            Tab_Cliente.Size = new Size(792, 422);
            Tab_Cliente.TabIndex = 0;
            Tab_Cliente.Text = "Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(188, 50);
            label8.Name = "label8";
            label8.Size = new Size(107, 37);
            label8.TabIndex = 9;
            label8.Text = "Cliente";
            // 
            // txt_Mail_Cliente
            // 
            txt_Mail_Cliente.Location = new Point(571, 250);
            txt_Mail_Cliente.Name = "txt_Mail_Cliente";
            txt_Mail_Cliente.Size = new Size(187, 23);
            txt_Mail_Cliente.TabIndex = 8;
            // 
            // txt_Telefono_Cliente
            // 
            txt_Telefono_Cliente.Location = new Point(571, 203);
            txt_Telefono_Cliente.Name = "txt_Telefono_Cliente";
            txt_Telefono_Cliente.Size = new Size(187, 23);
            txt_Telefono_Cliente.TabIndex = 4;
            // 
            // txt_Nombre_Cliente
            // 
            txt_Nombre_Cliente.Location = new Point(571, 155);
            txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            txt_Nombre_Cliente.Size = new Size(187, 23);
            txt_Nombre_Cliente.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(535, 258);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(514, 211);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefono";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label1.Location = new Point(514, 163);
            Label1.Name = "Label1";
            Label1.Size = new Size(53, 15);
            Label1.TabIndex = 5;
            Label1.Text = "Nombre";
            // 
            // BTN_Eliminar_Cliente
            // 
            BTN_Eliminar_Cliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_Eliminar_Cliente.Location = new Point(405, 279);
            BTN_Eliminar_Cliente.Name = "BTN_Eliminar_Cliente";
            BTN_Eliminar_Cliente.Size = new Size(75, 23);
            BTN_Eliminar_Cliente.TabIndex = 3;
            BTN_Eliminar_Cliente.Text = "Eliminar";
            BTN_Eliminar_Cliente.UseVisualStyleBackColor = true;
            BTN_Eliminar_Cliente.Click += BTN_Eliminar_Cliente_Click;
            // 
            // BTN_Agregar_Cliente
            // 
            BTN_Agregar_Cliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_Agregar_Cliente.Location = new Point(46, 279);
            BTN_Agregar_Cliente.Name = "BTN_Agregar_Cliente";
            BTN_Agregar_Cliente.Size = new Size(75, 23);
            BTN_Agregar_Cliente.TabIndex = 2;
            BTN_Agregar_Cliente.Text = "Agregar";
            BTN_Agregar_Cliente.UseVisualStyleBackColor = true;
            BTN_Agregar_Cliente.Click += BTN_Agregar_Cliente_Click;
            // 
            // BTN_Modificar_Cliente
            // 
            BTN_Modificar_Cliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_Modificar_Cliente.Location = new Point(220, 279);
            BTN_Modificar_Cliente.Name = "BTN_Modificar_Cliente";
            BTN_Modificar_Cliente.Size = new Size(75, 23);
            BTN_Modificar_Cliente.TabIndex = 1;
            BTN_Modificar_Cliente.Text = "Modificar";
            BTN_Modificar_Cliente.UseVisualStyleBackColor = true;
            BTN_Modificar_Cliente.Click += BTN_Modificar_Cliente_Click;
            // 
            // Grilla_Clientes
            // 
            Grilla_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Clientes.Location = new Point(8, 90);
            Grilla_Clientes.Name = "Grilla_Clientes";
            Grilla_Clientes.Size = new Size(500, 183);
            Grilla_Clientes.TabIndex = 0;
            // 
            // Control_Vista
            // 
            Control_Vista.Controls.Add(Tab_Cliente);
            Control_Vista.Controls.Add(Tab_Dueño);
            Control_Vista.Controls.Add(tabPage1);
            Control_Vista.Dock = DockStyle.Fill;
            Control_Vista.Location = new Point(0, 0);
            Control_Vista.Name = "Control_Vista";
            Control_Vista.SelectedIndex = 0;
            Control_Vista.Size = new Size(800, 450);
            Control_Vista.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.Controls.Add(BTN_MODIFICAR);
            tabPage1.Controls.Add(BTN_ELIMINAR);
            tabPage1.Controls.Add(BTN_AGREGAR);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(TXT_BUSQUEDA);
            tabPage1.Controls.Add(Lista_Productos);
            tabPage1.ForeColor = Color.CornflowerBlue;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Panaderia";
            // 
            // BTN_MODIFICAR
            // 
            BTN_MODIFICAR.Location = new Point(419, 329);
            BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            BTN_MODIFICAR.Size = new Size(75, 23);
            BTN_MODIFICAR.TabIndex = 6;
            BTN_MODIFICAR.Text = "Modificar";
            BTN_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new Point(325, 328);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new Size(75, 23);
            BTN_ELIMINAR.TabIndex = 5;
            BTN_ELIMINAR.Text = "Eliminar";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(223, 328);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 4;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(3, 327);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 2;
            label9.Text = "Buscar";
            // 
            // TXT_BUSQUEDA
            // 
            TXT_BUSQUEDA.Location = new Point(71, 329);
            TXT_BUSQUEDA.Name = "TXT_BUSQUEDA";
            TXT_BUSQUEDA.Size = new Size(114, 23);
            TXT_BUSQUEDA.TabIndex = 1;
            // 
            // Lista_Productos
            // 
            Lista_Productos.Dock = DockStyle.Bottom;
            Lista_Productos.FormattingEnabled = true;
            Lista_Productos.Location = new Point(3, 355);
            Lista_Productos.Name = "Lista_Productos";
            Lista_Productos.Size = new Size(786, 64);
            Lista_Productos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Control_Vista);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STOCK Productos y Materias Primas";
            Tab_Dueño.ResumeLayout(false);
            Tab_Dueño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Dueño).EndInit();
            Tab_Cliente.ResumeLayout(false);
            Tab_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Clientes).EndInit();
            Control_Vista.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage Tab_Dueño;
        private Button BTN_REPORTE;
        private Label label7;
        private Button BTN_ELIMINAR_DUEÑO;
        private Button BTN_MODIFICAR_DUEÑO;
        private Button BTN_AGREGAR_DUEÑO;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TXT_MAIL_DUEÑO;
        private TextBox TXT_TELEFONO_DUEÑO;
        private TextBox TXT_NOMBRE_DUEÑO;
        private DataGridView Grilla_Dueño;
        private TabPage Tab_Cliente;
        private Label label8;
        private TextBox txt_Mail_Cliente;
        private TextBox txt_Telefono_Cliente;
        private TextBox txt_Nombre_Cliente;
        private Label label3;
        private Label label2;
        private Label Label1;
        private Button BTN_Eliminar_Cliente;
        private Button BTN_Agregar_Cliente;
        private Button BTN_Modificar_Cliente;
        private DataGridView Grilla_Clientes;
        private TabControl Control_Vista;
        private TabPage tabPage1;
        private TabPage TabPage;
        private Label label9;
        private TextBox TXT_BUSQUEDA;
        private ListBox Lista_Productos;
        private Button BTN_MODIFICAR;
        private Button BTN_ELIMINAR;
        private Button BTN_AGREGAR;
    }
}
