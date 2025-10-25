using BE;
using BLL;
using BLL.BLL_Personas;
using Microsoft.VisualBasic;
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


        public Form1()
        {
            InitializeComponent();
            Grilla_Clientes.DataSource = null;
            Grilla_Clientes.DataSource = Cliente_BLL.ObtenerClientes();
            Grilla_Dueño.DataSource = null;
            Grilla_Dueño.DataSource = Dueño_BLL.ObtenerDueños();

            Grilla_Productos.DataSource = null;
            Grilla_Productos.DataSource = Productos_BLL.Retornar_Lista_productos();
        }

        private void BTN_Agregar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                /// Paso 1 Obtenemos los datos
                string nombre = Interaction.InputBox("Ingrese Nombre del CLiente");
                string telefono = Interaction.InputBox("Ingrese Telefono");
                string mail = Interaction.InputBox("Ingrese Gmail ");

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
                validar_Persona.Validar_Nombre(Interaction.InputBox("Ingrese Nombre del CLiente"));
                validar_Persona.Validar_Telefono(Interaction.InputBox("Ingrese Telefono"));
                validar_Persona.Validar_Mail(Interaction.InputBox("Ingrese Gmail "));

                ClienteBE cliente_modificado = new ClienteBE(
                                                                Convert.ToInt32(Grilla_Clientes.CurrentRow.Cells["Id_cliente"].Value),
                                                                Interaction.InputBox("Ingrese Nombre del CLiente"),
                                                                Interaction.InputBox("Ingrese Telefono"),
                                                                Interaction.InputBox("Ingrese Gmail ")
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


       
    
    }
}
