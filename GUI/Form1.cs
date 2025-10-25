using BE;
using BLL;
using BLL.BLL_Personas;
using System.Windows.Forms;
using VALIDACION;
namespace GUI
{
    public partial class Form1 : Form
    {
        Cliente_BLL Cliente_BLL = new Cliente_BLL();
        Dueño_BLL Dueño_BLL = new Dueño_BLL();
        BLL_Producto Productos_BLL = new BLL_Producto();

        Validar_Persona validar_Persona = new Validar_Persona();


        List<object> listaProductos;
        List<object> listaCarrito = new List<object>();
        public Form1()
        {
            InitializeComponent();
            Grilla_Clientes.DataSource = null;
            Grilla_Clientes.DataSource = Cliente_BLL.ObtenerClientes();
            Grilla_Dueño.DataSource = null;
            Grilla_Dueño.DataSource = Dueño_BLL.ObtenerDueños();

            Grilla_Productos.DataSource = null;
            Grilla_Productos.DataSource = Productos_BLL.Retornar_Lista_productos();
            listaProductos = Productos_BLL.Retornar_Lista_productos();
        }

        private void BTN_Agregar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                /// Paso 1 Obtenemos los datos
                string nombre = txt_Nombre_Cliente.Text;
                string telefono = txt_Telefono_Cliente.Text;
                string mail = txt_Mail_Cliente.Text;

                /// Paso 2 Validamos los datos
                validar_Persona.Validar_Nombre(nombre);
                validar_Persona.Validar_Telefono(telefono);
                validar_Persona.Validar_Mail(mail);

                /// Paso 3 Creamos el objeto
                /// Aqui debemos generar una funcion que genere un ID aleatorio
                /// Tambien podemos hacer que el usuario carge el ID y luego en la BLL verificamos si ya existe y si existe mandamos un error
                /// Lo dejo a tu criterio XD
                ClienteBE cliente = new ClienteBE(001, nombre, telefono, mail);

                /// Paso 4 Lo enviamos a la capa BLL
                Cliente_BLL.Agregar_Cliente(cliente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                /// Paso 5 Actualizamos la grilla
                Grilla_Clientes.DataSource = null;
                Grilla_Clientes.DataSource = Cliente_BLL.ObtenerClientes();
            }
        }

        private void BTN_Modificar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Clientes.SelectedRows.Count != 0) MessageBox.Show(" Se cambiara la fila seleccionada por los datos de los text box");

                validar_Persona.Validar_Nombre(txt_Nombre_Cliente.Text);
                validar_Persona.Validar_Telefono(txt_Telefono_Cliente.Text);
                validar_Persona.Validar_Mail(txt_Mail_Cliente.Text);


                ClienteBE cliente_modificado = new ClienteBE(
                                                                Convert.ToInt32(Grilla_Clientes.CurrentRow.Cells["Id_cliente"].Value),
                                                                txt_Nombre_Cliente.Text,
                                                                txt_Telefono_Cliente.Text,
                                                                txt_Mail_Cliente.Text
                                                            );

                Cliente_BLL.Modificar_Cliente(cliente_modificado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Clientes.DataSource = null;
                Grilla_Clientes.DataSource = Cliente_BLL.ObtenerClientes();
            }
        }

        private void BTN_Eliminar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Clientes.SelectedRows.Count == 0) throw new ArgumentException("Debe seleccionar algo para eliminar");
                int id_cliente = Convert.ToInt32(Grilla_Clientes.CurrentRow.Cells["Id_Cliente"].Value);

                Cliente_BLL.Eliminar_Cliente(id_cliente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Clientes.DataSource = null;
                Grilla_Clientes.DataSource = Cliente_BLL.ObtenerClientes();
            }
        }

        private void BTN_AGREGAR_DUEÑO_Click(object sender, EventArgs e)
        {
            try
            {
                validar_Persona.Validar_Nombre(TXT_NOMBRE_DUEÑO.Text);
                validar_Persona.Validar_Telefono(TXT_TELEFONO_DUEÑO.Text);
                validar_Persona.Validar_Mail(TXT_MAIL_DUEÑO.Text);

                string nombre = TXT_NOMBRE_DUEÑO.Text;
                string telefono = TXT_TELEFONO_DUEÑO.Text;
                string mail = TXT_MAIL_DUEÑO.Text;


                Dueño_BLL.Agregar_Dueño(new DueñoBE(001, nombre, telefono, mail));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Dueño.DataSource = null;
                Grilla_Dueño.DataSource = Dueño_BLL.ObtenerDueños();
            }
        }

        private void BTN_ELIMINAR_DUEÑO_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Dueño.SelectedRows.Count == 0) throw new ArgumentException("Debe seleccionar algo para eliminar");
                int id_dueño = Convert.ToInt32(Grilla_Dueño.CurrentRow.Cells["Id_Admin"].Value);
                Dueño_BLL.Eliminar_Dueño(id_dueño);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Dueño.DataSource = null;
                Grilla_Dueño.DataSource = Dueño_BLL.ObtenerDueños();
            }
        }

        private void BTN_MODIFICAR_DUEÑO_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Dueño.SelectedRows.Count != 0)
                {


                    validar_Persona.Validar_Nombre(TXT_NOMBRE_DUEÑO.Text);
                    validar_Persona.Validar_Telefono(TXT_TELEFONO_DUEÑO.Text);
                    validar_Persona.Validar_Mail(TXT_MAIL_DUEÑO.Text);

                    DueñoBE dueño_modificado = new DueñoBE(
                                                                    Convert.ToInt32(Grilla_Dueño.CurrentRow.Cells["Id_Admin"].Value),
                                                                    TXT_NOMBRE_DUEÑO.Text,
                                                                    TXT_TELEFONO_DUEÑO.Text,
                                                                    TXT_MAIL_DUEÑO.Text
                                                                );

                    Dueño_BLL.Modificar_Dueño(dueño_modificado);
                    MessageBox.Show("La fila seleccionada obtendra los valores de los texbox");
                }
                else
                {
                    throw new ArgumentException("Debe seleccionar una fila para modificar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Dueño.DataSource = null;
                Grilla_Dueño.DataSource = Dueño_BLL.ObtenerDueños();
            }
        }



        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Dueño.SelectedRows.Count != 0)
                {
                    var select = Grilla_Productos.SelectedRows[0].DataBoundItem;
                    listaCarrito.Add( select );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Dueño.SelectedRows.Count != 0)
                {
                    var select = Grilla_Productos.SelectedRows[0].DataBoundItem;
                    bool encontrado = false;
                    foreach (var p in listaCarrito)
                    {
                        if (p == select)  // Compara la referencia del objeto
                        {
                            encontrado = true;
                            break; // Sale del bucle al encontrarlo
                        }
                    }
                    if (encontrado)
                    {
                        listaCarrito.Remove(select);
                    }
                    else throw new Exception("No se encontro ese producto");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_MODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Dueño.SelectedRows.Count != 0)
                {
                    var select = Grilla_Productos.SelectedRows[0].DataBoundItem;
                    bool encontrado = false;
                    foreach (var p in listaCarrito)
                    {
                        if (p == select)  // Compara la referencia del objeto
                        {
                            encontrado = true;
                            break; // Sale del bucle al encontrarlo
                        }
                    }
                    if (encontrado)
                    {
                        int x = 
                    }
                    else throw new Exception("No se encontro ese producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CONFIMAR_COMPRA_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TXT_BUSQUEDA_TextChanged(object sender, EventArgs e)
        {
            if (CambioDeEstado_Productos.Checked!)
            {
                string texto = TXT_BUSQUEDA.Text.ToLower();
                
                var filtrados = listaProductos
                 .Where(obj =>
                  {
                      var prop = obj.GetType().GetProperty("Nombre");
                      if (prop == null) return false;
                      var valor = prop.GetValue(obj)?.ToString()?.ToLower();
                      return valor != null && valor.Contains(texto);
                  })
                .ToList();

                Grilla_Productos.DataSource = null;
                Grilla_Productos.DataSource = filtrados;
            }
        }

        private void CambioDeEstado_Productos_CheckedChanged(object sender, EventArgs e)
        {
            if (CambioDeEstado_Productos.Checked)
            {
                CambioDeEstado_Productos.Text = "Ver productos";
                Grilla_Productos.DataSource = null;
                Grilla_Productos.DataSource = listaCarrito;
            }
            else
            {
                CambioDeEstado_Productos.Text = "Ver tus compras";
                Grilla_Productos.DataSource = null;
                Grilla_Productos.DataSource = listaProductos;
            }
        }
    }
}
