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
            Control_Vista = new TabControl();
            Tab_Cliente = new TabPage();
            txt_Mail_Cliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            txt_Telefono_Cliente = new TextBox();
            txt_Nombre_Cliente = new TextBox();
            BTN_Eliminar_Cliente = new Button();
            BTN_Agregar_Cliente = new Button();
            BTN_Modificar_Cliente = new Button();
            Grilla_Clientes = new DataGridView();
            Tab_Empleado = new TabPage();
            Tab_Proveedor = new TabPage();
            Tab_Dueño = new TabPage();
            Control_Vista.SuspendLayout();
            Tab_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Clientes).BeginInit();
            SuspendLayout();
            // 
            // Control_Vista
            // 
            Control_Vista.Controls.Add(Tab_Cliente);
            Control_Vista.Controls.Add(Tab_Empleado);
            Control_Vista.Controls.Add(Tab_Proveedor);
            Control_Vista.Controls.Add(Tab_Dueño);
            Control_Vista.Dock = DockStyle.Fill;
            Control_Vista.Location = new Point(0, 0);
            Control_Vista.Name = "Control_Vista";
            Control_Vista.SelectedIndex = 0;
            Control_Vista.Size = new Size(800, 450);
            Control_Vista.TabIndex = 0;
            // 
            // Tab_Cliente
            // 
            Tab_Cliente.BackColor = Color.Gray;
            Tab_Cliente.Controls.Add(txt_Mail_Cliente);
            Tab_Cliente.Controls.Add(label3);
            Tab_Cliente.Controls.Add(label2);
            Tab_Cliente.Controls.Add(Label1);
            Tab_Cliente.Controls.Add(txt_Telefono_Cliente);
            Tab_Cliente.Controls.Add(txt_Nombre_Cliente);
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
            // txt_Mail_Cliente
            // 
            txt_Mail_Cliente.Location = new Point(472, 193);
            txt_Mail_Cliente.Name = "txt_Mail_Cliente";
            txt_Mail_Cliente.Size = new Size(187, 23);
            txt_Mail_Cliente.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 201);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 172);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefono";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(415, 143);
            Label1.Name = "Label1";
            Label1.Size = new Size(51, 15);
            Label1.TabIndex = 5;
            Label1.Text = "Nombre";
            // 
            // txt_Telefono_Cliente
            // 
            txt_Telefono_Cliente.Location = new Point(472, 164);
            txt_Telefono_Cliente.Name = "txt_Telefono_Cliente";
            txt_Telefono_Cliente.Size = new Size(187, 23);
            txt_Telefono_Cliente.TabIndex = 4;
            // 
            // txt_Nombre_Cliente
            // 
            txt_Nombre_Cliente.Location = new Point(472, 135);
            txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            txt_Nombre_Cliente.Size = new Size(187, 23);
            txt_Nombre_Cliente.TabIndex = 4;
            // 
            // BTN_Eliminar_Cliente
            // 
            BTN_Eliminar_Cliente.Location = new Point(286, 279);
            BTN_Eliminar_Cliente.Name = "BTN_Eliminar_Cliente";
            BTN_Eliminar_Cliente.Size = new Size(75, 23);
            BTN_Eliminar_Cliente.TabIndex = 3;
            BTN_Eliminar_Cliente.Text = "Eliminar";
            BTN_Eliminar_Cliente.UseVisualStyleBackColor = true;
            BTN_Eliminar_Cliente.Click += BTN_Eliminar_Cliente_Click;
            // 
            // BTN_Agregar_Cliente
            // 
            BTN_Agregar_Cliente.Location = new Point(39, 279);
            BTN_Agregar_Cliente.Name = "BTN_Agregar_Cliente";
            BTN_Agregar_Cliente.Size = new Size(75, 23);
            BTN_Agregar_Cliente.TabIndex = 2;
            BTN_Agregar_Cliente.Text = "Agregar";
            BTN_Agregar_Cliente.UseVisualStyleBackColor = true;
            BTN_Agregar_Cliente.Click += BTN_Agregar_Cliente_Click;
            // 
            // BTN_Modificar_Cliente
            // 
            BTN_Modificar_Cliente.Location = new Point(162, 279);
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
            Grilla_Clientes.Size = new Size(401, 183);
            Grilla_Clientes.TabIndex = 0;
            // 
            // Tab_Empleado
            // 
            Tab_Empleado.Location = new Point(4, 24);
            Tab_Empleado.Name = "Tab_Empleado";
            Tab_Empleado.Padding = new Padding(3);
            Tab_Empleado.Size = new Size(792, 422);
            Tab_Empleado.TabIndex = 1;
            Tab_Empleado.Text = "Empleado";
            Tab_Empleado.UseVisualStyleBackColor = true;
            // 
            // Tab_Proveedor
            // 
            Tab_Proveedor.Location = new Point(4, 24);
            Tab_Proveedor.Name = "Tab_Proveedor";
            Tab_Proveedor.Padding = new Padding(3);
            Tab_Proveedor.Size = new Size(792, 422);
            Tab_Proveedor.TabIndex = 2;
            Tab_Proveedor.Text = "Proveedor";
            Tab_Proveedor.UseVisualStyleBackColor = true;
            // 
            // Tab_Dueño
            // 
            Tab_Dueño.Location = new Point(4, 24);
            Tab_Dueño.Name = "Tab_Dueño";
            Tab_Dueño.Padding = new Padding(3);
            Tab_Dueño.Size = new Size(792, 422);
            Tab_Dueño.TabIndex = 3;
            Tab_Dueño.Text = "Dueño";
            Tab_Dueño.UseVisualStyleBackColor = true;
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
            Control_Vista.ResumeLayout(false);
            Tab_Cliente.ResumeLayout(false);
            Tab_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Control_Vista;
        private TabPage Tab_Cliente;
        private TabPage Tab_Empleado;
        private TabPage Tab_Proveedor;
        private TabPage Tab_Dueño;
        private Label Label1;
        private TextBox txt_Nombre_Cliente;
        private Button BTN_Eliminar_Cliente;
        private Button BTN_Agregar_Cliente;
        private Button BTN_Modificar_Cliente;
        private DataGridView Grilla_Clientes;
        private TextBox txt_Mail_Cliente;
        private Label label3;
        private Label label2;
        private TextBox txt_Telefono_Cliente;
    }
}
