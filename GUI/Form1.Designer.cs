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
            button1 = new Button();
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
            BNTN_ELIMINAR_MATERIA_PRIMA = new Button();
            label3 = new Label();
            BNTN_AGREGAR_MATERIA_PRIMA = new Button();
            Grilla_Materia_Prima = new DataGridView();
            label2 = new Label();
            Grilla_Carrito = new DataGridView();
            BTN_COMPRAR_PRODUCTO = new Button();
            BTN_ADD_PRODUCTO = new Button();
            Grilla_Productos = new DataGridView();
            label1 = new Label();
            label8 = new Label();
            BTN_Eliminar_Cliente = new Button();
            BTN_Agregar_Cliente = new Button();
            BTN_Modificar_Cliente = new Button();
            Grilla_Clientes = new DataGridView();
            Control_Vista = new TabControl();
            Tab_Empleado = new TabPage();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            TXT_MAIL_EMPLEADO = new TextBox();
            TXT_TELEFONO_EMPLEADO = new TextBox();
            TXT_NOMBRE_EMPLEADO = new TextBox();
            BTN_MODIFICADO_EMPLEADO = new Button();
            BTN_EMPLEADO_ELIMINAR = new Button();
            BTN_AGREGAR_EMPLEADO = new Button();
            Grilla_Empleado = new DataGridView();
            Tab_Proveedor = new TabPage();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            TXT_MAIL_PROVEEDOR = new TextBox();
            TXT_TELEFONO_PROVEEDOR = new TextBox();
            TXT_NOMBRE_PROVEEDOR = new TextBox();
            LABEL154 = new Label();
            BTN_MODIFICARPROVEEDOR = new Button();
            BTN_ELIMINAR_PROVEEDOR = new Button();
            BTN_AGREGAR_PROVEEDOR = new Button();
            Grilla_Proveedor = new DataGridView();
            Tab_Dueño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Dueño).BeginInit();
            Tab_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Materia_Prima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Carrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Clientes).BeginInit();
            Control_Vista.SuspendLayout();
            Tab_Empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Empleado).BeginInit();
            Tab_Proveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Proveedor).BeginInit();
            SuspendLayout();
            // 
            // Tab_Dueño
            // 
            Tab_Dueño.BackColor = Color.DimGray;
            Tab_Dueño.Controls.Add(button1);
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
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(199, 362);
            button1.Name = "button1";
            button1.Size = new Size(397, 33);
            button1.TabIndex = 11;
            button1.Text = "Generar Reporte";
            button1.UseVisualStyleBackColor = true;
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
            label5.Size = new Size(52, 15);
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
            Tab_Cliente.Controls.Add(BNTN_ELIMINAR_MATERIA_PRIMA);
            Tab_Cliente.Controls.Add(label3);
            Tab_Cliente.Controls.Add(BNTN_AGREGAR_MATERIA_PRIMA);
            Tab_Cliente.Controls.Add(Grilla_Materia_Prima);
            Tab_Cliente.Controls.Add(label2);
            Tab_Cliente.Controls.Add(Grilla_Carrito);
            Tab_Cliente.Controls.Add(BTN_COMPRAR_PRODUCTO);
            Tab_Cliente.Controls.Add(BTN_ADD_PRODUCTO);
            Tab_Cliente.Controls.Add(Grilla_Productos);
            Tab_Cliente.Controls.Add(label1);
            Tab_Cliente.Controls.Add(label8);
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
            // BNTN_ELIMINAR_MATERIA_PRIMA
            // 
            BNTN_ELIMINAR_MATERIA_PRIMA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BNTN_ELIMINAR_MATERIA_PRIMA.Location = new Point(662, 391);
            BNTN_ELIMINAR_MATERIA_PRIMA.Name = "BNTN_ELIMINAR_MATERIA_PRIMA";
            BNTN_ELIMINAR_MATERIA_PRIMA.Size = new Size(98, 23);
            BNTN_ELIMINAR_MATERIA_PRIMA.TabIndex = 22;
            BNTN_ELIMINAR_MATERIA_PRIMA.Text = "Eliminar MP";
            BNTN_ELIMINAR_MATERIA_PRIMA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(507, 232);
            label3.Name = "label3";
            label3.Size = new Size(201, 37);
            label3.TabIndex = 21;
            label3.Text = "Materia Prima";
            // 
            // BNTN_AGREGAR_MATERIA_PRIMA
            // 
            BNTN_AGREGAR_MATERIA_PRIMA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BNTN_AGREGAR_MATERIA_PRIMA.Location = new Point(441, 391);
            BNTN_AGREGAR_MATERIA_PRIMA.Name = "BNTN_AGREGAR_MATERIA_PRIMA";
            BNTN_AGREGAR_MATERIA_PRIMA.Size = new Size(110, 23);
            BNTN_AGREGAR_MATERIA_PRIMA.TabIndex = 20;
            BNTN_AGREGAR_MATERIA_PRIMA.Text = "Agregar MP";
            BNTN_AGREGAR_MATERIA_PRIMA.UseVisualStyleBackColor = true;
            // 
            // Grilla_Materia_Prima
            // 
            Grilla_Materia_Prima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Materia_Prima.Location = new Point(441, 272);
            Grilla_Materia_Prima.Name = "Grilla_Materia_Prima";
            Grilla_Materia_Prima.Size = new Size(319, 115);
            Grilla_Materia_Prima.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 232);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 18;
            label2.Text = "Carrito";
            // 
            // Grilla_Carrito
            // 
            Grilla_Carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Carrito.Location = new Point(8, 272);
            Grilla_Carrito.Name = "Grilla_Carrito";
            Grilla_Carrito.Size = new Size(304, 115);
            Grilla_Carrito.TabIndex = 17;
            // 
            // BTN_COMPRAR_PRODUCTO
            // 
            BTN_COMPRAR_PRODUCTO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_COMPRAR_PRODUCTO.Location = new Point(183, 393);
            BTN_COMPRAR_PRODUCTO.Name = "BTN_COMPRAR_PRODUCTO";
            BTN_COMPRAR_PRODUCTO.Size = new Size(110, 23);
            BTN_COMPRAR_PRODUCTO.TabIndex = 16;
            BTN_COMPRAR_PRODUCTO.Text = "Comprar";
            BTN_COMPRAR_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // BTN_ADD_PRODUCTO
            // 
            BTN_ADD_PRODUCTO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_ADD_PRODUCTO.Location = new Point(441, 210);
            BTN_ADD_PRODUCTO.Name = "BTN_ADD_PRODUCTO";
            BTN_ADD_PRODUCTO.Size = new Size(110, 23);
            BTN_ADD_PRODUCTO.TabIndex = 12;
            BTN_ADD_PRODUCTO.Text = "Add Producto";
            BTN_ADD_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // Grilla_Productos
            // 
            Grilla_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Productos.Location = new Point(441, 64);
            Grilla_Productos.Name = "Grilla_Productos";
            Grilla_Productos.Size = new Size(319, 140);
            Grilla_Productos.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(519, 24);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 10;
            label1.Text = "Producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(121, 50);
            label8.Name = "label8";
            label8.Size = new Size(107, 37);
            label8.TabIndex = 9;
            label8.Text = "Cliente";
            // 
            // BTN_Eliminar_Cliente
            // 
            BTN_Eliminar_Cliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_Eliminar_Cliente.Location = new Point(218, 196);
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
            BTN_Agregar_Cliente.Location = new Point(27, 196);
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
            BTN_Modificar_Cliente.Location = new Point(125, 196);
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
            Grilla_Clientes.Size = new Size(304, 100);
            Grilla_Clientes.TabIndex = 0;
            // 
            // Control_Vista
            // 
            Control_Vista.Controls.Add(Tab_Cliente);
            Control_Vista.Controls.Add(Tab_Dueño);
            Control_Vista.Controls.Add(Tab_Empleado);
            Control_Vista.Controls.Add(Tab_Proveedor);
            Control_Vista.Dock = DockStyle.Fill;
            Control_Vista.Location = new Point(0, 0);
            Control_Vista.Name = "Control_Vista";
            Control_Vista.SelectedIndex = 0;
            Control_Vista.Size = new Size(800, 450);
            Control_Vista.TabIndex = 0;
            // 
            // Tab_Empleado
            // 
            Tab_Empleado.BackColor = Color.DimGray;
            Tab_Empleado.Controls.Add(label12);
            Tab_Empleado.Controls.Add(label9);
            Tab_Empleado.Controls.Add(label10);
            Tab_Empleado.Controls.Add(label11);
            Tab_Empleado.Controls.Add(TXT_MAIL_EMPLEADO);
            Tab_Empleado.Controls.Add(TXT_TELEFONO_EMPLEADO);
            Tab_Empleado.Controls.Add(TXT_NOMBRE_EMPLEADO);
            Tab_Empleado.Controls.Add(BTN_MODIFICADO_EMPLEADO);
            Tab_Empleado.Controls.Add(BTN_EMPLEADO_ELIMINAR);
            Tab_Empleado.Controls.Add(BTN_AGREGAR_EMPLEADO);
            Tab_Empleado.Controls.Add(Grilla_Empleado);
            Tab_Empleado.Location = new Point(4, 24);
            Tab_Empleado.Name = "Tab_Empleado";
            Tab_Empleado.Padding = new Padding(3);
            Tab_Empleado.Size = new Size(792, 422);
            Tab_Empleado.TabIndex = 4;
            Tab_Empleado.Text = "Empleado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(196, 25);
            label12.Name = "label12";
            label12.Size = new Size(145, 37);
            label12.TabIndex = 17;
            label12.Text = "Empleado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(585, 283);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 16;
            label9.Text = "Mail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(567, 228);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 15;
            label10.Text = "Telefono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(570, 171);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 14;
            label11.Text = "Nombre";
            // 
            // TXT_MAIL_EMPLEADO
            // 
            TXT_MAIL_EMPLEADO.Location = new Point(626, 275);
            TXT_MAIL_EMPLEADO.Name = "TXT_MAIL_EMPLEADO";
            TXT_MAIL_EMPLEADO.Size = new Size(160, 23);
            TXT_MAIL_EMPLEADO.TabIndex = 13;
            // 
            // TXT_TELEFONO_EMPLEADO
            // 
            TXT_TELEFONO_EMPLEADO.Location = new Point(626, 220);
            TXT_TELEFONO_EMPLEADO.Name = "TXT_TELEFONO_EMPLEADO";
            TXT_TELEFONO_EMPLEADO.Size = new Size(160, 23);
            TXT_TELEFONO_EMPLEADO.TabIndex = 12;
            // 
            // TXT_NOMBRE_EMPLEADO
            // 
            TXT_NOMBRE_EMPLEADO.Location = new Point(626, 163);
            TXT_NOMBRE_EMPLEADO.Name = "TXT_NOMBRE_EMPLEADO";
            TXT_NOMBRE_EMPLEADO.Size = new Size(160, 23);
            TXT_NOMBRE_EMPLEADO.TabIndex = 11;
            // 
            // BTN_MODIFICADO_EMPLEADO
            // 
            BTN_MODIFICADO_EMPLEADO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_MODIFICADO_EMPLEADO.ForeColor = SystemColors.ActiveCaptionText;
            BTN_MODIFICADO_EMPLEADO.Location = new Point(461, 350);
            BTN_MODIFICADO_EMPLEADO.Name = "BTN_MODIFICADO_EMPLEADO";
            BTN_MODIFICADO_EMPLEADO.Size = new Size(75, 23);
            BTN_MODIFICADO_EMPLEADO.TabIndex = 10;
            BTN_MODIFICADO_EMPLEADO.Text = "Modificar";
            BTN_MODIFICADO_EMPLEADO.UseVisualStyleBackColor = true;
            // 
            // BTN_EMPLEADO_ELIMINAR
            // 
            BTN_EMPLEADO_ELIMINAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_EMPLEADO_ELIMINAR.ForeColor = SystemColors.ActiveCaptionText;
            BTN_EMPLEADO_ELIMINAR.Location = new Point(238, 350);
            BTN_EMPLEADO_ELIMINAR.Name = "BTN_EMPLEADO_ELIMINAR";
            BTN_EMPLEADO_ELIMINAR.Size = new Size(75, 23);
            BTN_EMPLEADO_ELIMINAR.TabIndex = 9;
            BTN_EMPLEADO_ELIMINAR.Text = "Eliminar";
            BTN_EMPLEADO_ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTN_AGREGAR_EMPLEADO
            // 
            BTN_AGREGAR_EMPLEADO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTN_AGREGAR_EMPLEADO.ForeColor = SystemColors.ActiveCaptionText;
            BTN_AGREGAR_EMPLEADO.Location = new Point(25, 350);
            BTN_AGREGAR_EMPLEADO.Name = "BTN_AGREGAR_EMPLEADO";
            BTN_AGREGAR_EMPLEADO.Size = new Size(75, 23);
            BTN_AGREGAR_EMPLEADO.TabIndex = 8;
            BTN_AGREGAR_EMPLEADO.Text = "Agregar";
            BTN_AGREGAR_EMPLEADO.UseVisualStyleBackColor = true;
            // 
            // Grilla_Empleado
            // 
            Grilla_Empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Empleado.Location = new Point(8, 65);
            Grilla_Empleado.Name = "Grilla_Empleado";
            Grilla_Empleado.Size = new Size(556, 279);
            Grilla_Empleado.TabIndex = 0;
            // 
            // Tab_Proveedor
            // 
            Tab_Proveedor.BackColor = Color.DimGray;
            Tab_Proveedor.Controls.Add(label13);
            Tab_Proveedor.Controls.Add(label14);
            Tab_Proveedor.Controls.Add(label15);
            Tab_Proveedor.Controls.Add(TXT_MAIL_PROVEEDOR);
            Tab_Proveedor.Controls.Add(TXT_TELEFONO_PROVEEDOR);
            Tab_Proveedor.Controls.Add(TXT_NOMBRE_PROVEEDOR);
            Tab_Proveedor.Controls.Add(LABEL154);
            Tab_Proveedor.Controls.Add(BTN_MODIFICARPROVEEDOR);
            Tab_Proveedor.Controls.Add(BTN_ELIMINAR_PROVEEDOR);
            Tab_Proveedor.Controls.Add(BTN_AGREGAR_PROVEEDOR);
            Tab_Proveedor.Controls.Add(Grilla_Proveedor);
            Tab_Proveedor.Location = new Point(4, 24);
            Tab_Proveedor.Name = "Tab_Proveedor";
            Tab_Proveedor.Padding = new Padding(3);
            Tab_Proveedor.Size = new Size(792, 422);
            Tab_Proveedor.TabIndex = 5;
            Tab_Proveedor.Text = "Provedor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(562, 267);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 22;
            label13.Text = "Mail";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(544, 212);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 21;
            label14.Text = "Telefono";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(547, 155);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 20;
            label15.Text = "Nombre";
            // 
            // TXT_MAIL_PROVEEDOR
            // 
            TXT_MAIL_PROVEEDOR.Location = new Point(603, 259);
            TXT_MAIL_PROVEEDOR.Name = "TXT_MAIL_PROVEEDOR";
            TXT_MAIL_PROVEEDOR.Size = new Size(160, 23);
            TXT_MAIL_PROVEEDOR.TabIndex = 19;
            // 
            // TXT_TELEFONO_PROVEEDOR
            // 
            TXT_TELEFONO_PROVEEDOR.Location = new Point(603, 204);
            TXT_TELEFONO_PROVEEDOR.Name = "TXT_TELEFONO_PROVEEDOR";
            TXT_TELEFONO_PROVEEDOR.Size = new Size(160, 23);
            TXT_TELEFONO_PROVEEDOR.TabIndex = 18;
            // 
            // TXT_NOMBRE_PROVEEDOR
            // 
            TXT_NOMBRE_PROVEEDOR.Location = new Point(603, 147);
            TXT_NOMBRE_PROVEEDOR.Name = "TXT_NOMBRE_PROVEEDOR";
            TXT_NOMBRE_PROVEEDOR.Size = new Size(160, 23);
            TXT_NOMBRE_PROVEEDOR.TabIndex = 17;
            // 
            // LABEL154
            // 
            LABEL154.AutoSize = true;
            LABEL154.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL154.Location = new Point(187, 26);
            LABEL154.Name = "LABEL154";
            LABEL154.Size = new Size(152, 37);
            LABEL154.TabIndex = 5;
            LABEL154.Text = "Proveedor";
            // 
            // BTN_MODIFICARPROVEEDOR
            // 
            BTN_MODIFICARPROVEEDOR.Location = new Point(437, 335);
            BTN_MODIFICARPROVEEDOR.Name = "BTN_MODIFICARPROVEEDOR";
            BTN_MODIFICARPROVEEDOR.Size = new Size(75, 23);
            BTN_MODIFICARPROVEEDOR.TabIndex = 4;
            BTN_MODIFICARPROVEEDOR.Text = "Modificar";
            BTN_MODIFICARPROVEEDOR.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIMINAR_PROVEEDOR
            // 
            BTN_ELIMINAR_PROVEEDOR.Location = new Point(225, 335);
            BTN_ELIMINAR_PROVEEDOR.Name = "BTN_ELIMINAR_PROVEEDOR";
            BTN_ELIMINAR_PROVEEDOR.Size = new Size(75, 23);
            BTN_ELIMINAR_PROVEEDOR.TabIndex = 3;
            BTN_ELIMINAR_PROVEEDOR.Text = "Eliminar";
            BTN_ELIMINAR_PROVEEDOR.UseVisualStyleBackColor = true;
            // 
            // BTN_AGREGAR_PROVEEDOR
            // 
            BTN_AGREGAR_PROVEEDOR.Location = new Point(19, 335);
            BTN_AGREGAR_PROVEEDOR.Name = "BTN_AGREGAR_PROVEEDOR";
            BTN_AGREGAR_PROVEEDOR.Size = new Size(75, 23);
            BTN_AGREGAR_PROVEEDOR.TabIndex = 2;
            BTN_AGREGAR_PROVEEDOR.Text = "Agregar";
            BTN_AGREGAR_PROVEEDOR.UseVisualStyleBackColor = true;
            // 
            // Grilla_Proveedor
            // 
            Grilla_Proveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Proveedor.Location = new Point(8, 66);
            Grilla_Proveedor.Name = "Grilla_Proveedor";
            Grilla_Proveedor.Size = new Size(531, 263);
            Grilla_Proveedor.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)Grilla_Materia_Prima).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Carrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Clientes).EndInit();
            Control_Vista.ResumeLayout(false);
            Tab_Empleado.ResumeLayout(false);
            Tab_Empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Empleado).EndInit();
            Tab_Proveedor.ResumeLayout(false);
            Tab_Proveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grilla_Proveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage TabPage;
        private TabPage Tab_Dueño;
        private Button button1;
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
        private Button BTN_Eliminar_Cliente;
        private Button BTN_Agregar_Cliente;
        private Button BTN_Modificar_Cliente;
        private DataGridView Grilla_Clientes;
        private TabControl Control_Vista;
        private TabPage Tab_Empleado;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox TXT_MAIL_EMPLEADO;
        private TextBox TXT_TELEFONO_EMPLEADO;
        private TextBox TXT_NOMBRE_EMPLEADO;
        private Button BTN_MODIFICADO_EMPLEADO;
        private Button BTN_EMPLEADO_ELIMINAR;
        private Button BTN_AGREGAR_EMPLEADO;
        private DataGridView Grilla_Empleado;
        private Label label12;
        private TabPage Tab_Proveedor;
        private Label LABEL154;
        private Button BTN_MODIFICARPROVEEDOR;
        private Button BTN_ELIMINAR_PROVEEDOR;
        private Button BTN_AGREGAR_PROVEEDOR;
        private DataGridView Grilla_Proveedor;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox TXT_MAIL_PROVEEDOR;
        private TextBox TXT_TELEFONO_PROVEEDOR;
        private TextBox TXT_NOMBRE_PROVEEDOR;
        private Button BTN_ADD_PRODUCTO;
        private DataGridView Grilla_Productos;
        private Label label1;
        private Button BTN_COMPRAR_PRODUCTO;
        private Label label2;
        private DataGridView Grilla_Carrito;
        private Button BNTN_ELIMINAR_MATERIA_PRIMA;
        private Label label3;
        private Button BNTN_AGREGAR_MATERIA_PRIMA;
        private DataGridView Grilla_Materia_Prima;
    }
}
