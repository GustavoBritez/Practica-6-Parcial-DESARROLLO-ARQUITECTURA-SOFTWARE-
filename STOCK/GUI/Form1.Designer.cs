namespace GUI
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Cliente = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_TELEFONO_CLIENTE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_NOMBRE_CLIENTE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_CODIGO_PRODUCTO = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.asdasda = new System.Windows.Forms.Label();
            this.TXT_CANTIDAD_PROD = new System.Windows.Forms.TextBox();
            this.TXT_PRECIO_PROD = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE_PROD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_COMPRAR = new System.Windows.Forms.Button();
            this.Grilla_Carrito = new System.Windows.Forms.DataGridView();
            this.BTN_AGREGAR_CARRITO = new System.Windows.Forms.Button();
            this.BTN_AGREGAR_PRODUCTO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Grilla_Producto = new System.Windows.Forms.DataGridView();
            this.BTN_ELIMINAR_CLIENTE = new System.Windows.Forms.Button();
            this.BTN_AGREGAR_CLIENTE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Grilla_Cliente = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Tab_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Cliente);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_Cliente
            // 
            this.Tab_Cliente.BackColor = System.Drawing.Color.DimGray;
            this.Tab_Cliente.Controls.Add(this.button1);
            this.Tab_Cliente.Controls.Add(this.label7);
            this.Tab_Cliente.Controls.Add(this.TXT_TELEFONO_CLIENTE);
            this.Tab_Cliente.Controls.Add(this.label6);
            this.Tab_Cliente.Controls.Add(this.TXT_NOMBRE_CLIENTE);
            this.Tab_Cliente.Controls.Add(this.label4);
            this.Tab_Cliente.Controls.Add(this.TXT_CODIGO_PRODUCTO);
            this.Tab_Cliente.Controls.Add(this.Cantidad);
            this.Tab_Cliente.Controls.Add(this.label5);
            this.Tab_Cliente.Controls.Add(this.asdasda);
            this.Tab_Cliente.Controls.Add(this.TXT_CANTIDAD_PROD);
            this.Tab_Cliente.Controls.Add(this.TXT_PRECIO_PROD);
            this.Tab_Cliente.Controls.Add(this.TXT_NOMBRE_PROD);
            this.Tab_Cliente.Controls.Add(this.label3);
            this.Tab_Cliente.Controls.Add(this.BTN_COMPRAR);
            this.Tab_Cliente.Controls.Add(this.Grilla_Carrito);
            this.Tab_Cliente.Controls.Add(this.BTN_AGREGAR_CARRITO);
            this.Tab_Cliente.Controls.Add(this.BTN_AGREGAR_PRODUCTO);
            this.Tab_Cliente.Controls.Add(this.label2);
            this.Tab_Cliente.Controls.Add(this.Grilla_Producto);
            this.Tab_Cliente.Controls.Add(this.BTN_ELIMINAR_CLIENTE);
            this.Tab_Cliente.Controls.Add(this.BTN_AGREGAR_CLIENTE);
            this.Tab_Cliente.Controls.Add(this.label1);
            this.Tab_Cliente.Controls.Add(this.Grilla_Cliente);
            this.Tab_Cliente.Location = new System.Drawing.Point(4, 22);
            this.Tab_Cliente.Name = "Tab_Cliente";
            this.Tab_Cliente.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Cliente.Size = new System.Drawing.Size(810, 406);
            this.Tab_Cliente.TabIndex = 0;
            this.Tab_Cliente.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Telefono";
            // 
            // TXT_TELEFONO_CLIENTE
            // 
            this.TXT_TELEFONO_CLIENTE.Location = new System.Drawing.Point(263, 178);
            this.TXT_TELEFONO_CLIENTE.Name = "TXT_TELEFONO_CLIENTE";
            this.TXT_TELEFONO_CLIENTE.Size = new System.Drawing.Size(100, 20);
            this.TXT_TELEFONO_CLIENTE.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombre";
            // 
            // TXT_NOMBRE_CLIENTE
            // 
            this.TXT_NOMBRE_CLIENTE.Location = new System.Drawing.Point(263, 149);
            this.TXT_NOMBRE_CLIENTE.Name = "TXT_NOMBRE_CLIENTE";
            this.TXT_NOMBRE_CLIENTE.Size = new System.Drawing.Size(100, 20);
            this.TXT_NOMBRE_CLIENTE.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Codigo";
            // 
            // TXT_CODIGO_PRODUCTO
            // 
            this.TXT_CODIGO_PRODUCTO.Location = new System.Drawing.Point(693, 290);
            this.TXT_CODIGO_PRODUCTO.Name = "TXT_CODIGO_PRODUCTO";
            this.TXT_CODIGO_PRODUCTO.Size = new System.Drawing.Size(100, 20);
            this.TXT_CODIGO_PRODUCTO.TabIndex = 16;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(638, 257);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 18;
            this.Cantidad.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precio";
            // 
            // asdasda
            // 
            this.asdasda.AutoSize = true;
            this.asdasda.Location = new System.Drawing.Point(643, 181);
            this.asdasda.Name = "asdasda";
            this.asdasda.Size = new System.Drawing.Size(44, 13);
            this.asdasda.TabIndex = 16;
            this.asdasda.Text = "Nombre";
            // 
            // TXT_CANTIDAD_PROD
            // 
            this.TXT_CANTIDAD_PROD.Location = new System.Drawing.Point(693, 254);
            this.TXT_CANTIDAD_PROD.Name = "TXT_CANTIDAD_PROD";
            this.TXT_CANTIDAD_PROD.Size = new System.Drawing.Size(100, 20);
            this.TXT_CANTIDAD_PROD.TabIndex = 15;
            // 
            // TXT_PRECIO_PROD
            // 
            this.TXT_PRECIO_PROD.Location = new System.Drawing.Point(693, 214);
            this.TXT_PRECIO_PROD.Name = "TXT_PRECIO_PROD";
            this.TXT_PRECIO_PROD.Size = new System.Drawing.Size(100, 20);
            this.TXT_PRECIO_PROD.TabIndex = 14;
            // 
            // TXT_NOMBRE_PROD
            // 
            this.TXT_NOMBRE_PROD.Location = new System.Drawing.Point(693, 178);
            this.TXT_NOMBRE_PROD.Name = "TXT_NOMBRE_PROD";
            this.TXT_NOMBRE_PROD.Size = new System.Drawing.Size(100, 20);
            this.TXT_NOMBRE_PROD.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Carrito";
            // 
            // BTN_COMPRAR
            // 
            this.BTN_COMPRAR.Location = new System.Drawing.Point(311, 377);
            this.BTN_COMPRAR.Name = "BTN_COMPRAR";
            this.BTN_COMPRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_COMPRAR.TabIndex = 11;
            this.BTN_COMPRAR.Text = "Comprar";
            this.BTN_COMPRAR.UseVisualStyleBackColor = true;
            // 
            // Grilla_Carrito
            // 
            this.Grilla_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Carrito.Location = new System.Drawing.Point(6, 241);
            this.Grilla_Carrito.Name = "Grilla_Carrito";
            this.Grilla_Carrito.Size = new System.Drawing.Size(299, 162);
            this.Grilla_Carrito.TabIndex = 10;
            // 
            // BTN_AGREGAR_CARRITO
            // 
            this.BTN_AGREGAR_CARRITO.Location = new System.Drawing.Point(348, 48);
            this.BTN_AGREGAR_CARRITO.Name = "BTN_AGREGAR_CARRITO";
            this.BTN_AGREGAR_CARRITO.Size = new System.Drawing.Size(129, 37);
            this.BTN_AGREGAR_CARRITO.TabIndex = 9;
            this.BTN_AGREGAR_CARRITO.Text = "Agregar Carrito";
            this.BTN_AGREGAR_CARRITO.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR_CARRITO.Click += new System.EventHandler(this.BTN_AGREGAR_CARRITO_Click);
            // 
            // BTN_AGREGAR_PRODUCTO
            // 
            this.BTN_AGREGAR_PRODUCTO.Location = new System.Drawing.Point(479, 175);
            this.BTN_AGREGAR_PRODUCTO.Name = "BTN_AGREGAR_PRODUCTO";
            this.BTN_AGREGAR_PRODUCTO.Size = new System.Drawing.Size(75, 23);
            this.BTN_AGREGAR_PRODUCTO.TabIndex = 8;
            this.BTN_AGREGAR_PRODUCTO.Text = "Agregar";
            this.BTN_AGREGAR_PRODUCTO.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR_PRODUCTO.Click += new System.EventHandler(this.BTN_AGREGAR_PRODUCTO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // Grilla_Producto
            // 
            this.Grilla_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Producto.Location = new System.Drawing.Point(483, 31);
            this.Grilla_Producto.Name = "Grilla_Producto";
            this.Grilla_Producto.Size = new System.Drawing.Size(299, 138);
            this.Grilla_Producto.TabIndex = 5;
            // 
            // BTN_ELIMINAR_CLIENTE
            // 
            this.BTN_ELIMINAR_CLIENTE.Location = new System.Drawing.Point(127, 146);
            this.BTN_ELIMINAR_CLIENTE.Name = "BTN_ELIMINAR_CLIENTE";
            this.BTN_ELIMINAR_CLIENTE.Size = new System.Drawing.Size(75, 23);
            this.BTN_ELIMINAR_CLIENTE.TabIndex = 3;
            this.BTN_ELIMINAR_CLIENTE.Text = "Eliminar";
            this.BTN_ELIMINAR_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR_CLIENTE.Click += new System.EventHandler(this.BTN_ELIMINAR_CLIENTE_Click);
            // 
            // BTN_AGREGAR_CLIENTE
            // 
            this.BTN_AGREGAR_CLIENTE.Location = new System.Drawing.Point(6, 146);
            this.BTN_AGREGAR_CLIENTE.Name = "BTN_AGREGAR_CLIENTE";
            this.BTN_AGREGAR_CLIENTE.Size = new System.Drawing.Size(75, 23);
            this.BTN_AGREGAR_CLIENTE.TabIndex = 2;
            this.BTN_AGREGAR_CLIENTE.Text = "Agregar";
            this.BTN_AGREGAR_CLIENTE.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR_CLIENTE.Click += new System.EventHandler(this.BTN_AGREGAR_CLIENTE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // Grilla_Cliente
            // 
            this.Grilla_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Cliente.Location = new System.Drawing.Point(6, 31);
            this.Grilla_Cliente.Name = "Grilla_Cliente";
            this.Grilla_Cliente.Size = new System.Drawing.Size(326, 112);
            this.Grilla_Cliente.TabIndex = 0;
            this.Grilla_Cliente.SelectionChanged += new System.EventHandler(this.Grilla_Cliente_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(810, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Empleado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 432);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Tab_Cliente.ResumeLayout(false);
            this.Tab_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grilla_Cliente;
        private System.Windows.Forms.Button BTN_AGREGAR_CARRITO;
        private System.Windows.Forms.Button BTN_AGREGAR_PRODUCTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grilla_Producto;
        private System.Windows.Forms.Button BTN_ELIMINAR_CLIENTE;
        private System.Windows.Forms.Button BTN_AGREGAR_CLIENTE;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView Grilla_Carrito;
        private System.Windows.Forms.Button BTN_COMPRAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_CANTIDAD_PROD;
        private System.Windows.Forms.TextBox TXT_PRECIO_PROD;
        private System.Windows.Forms.TextBox TXT_NOMBRE_PROD;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label asdasda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_CODIGO_PRODUCTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_TELEFONO_CLIENTE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_NOMBRE_CLIENTE;
        private System.Windows.Forms.Button button1;
    }
}

