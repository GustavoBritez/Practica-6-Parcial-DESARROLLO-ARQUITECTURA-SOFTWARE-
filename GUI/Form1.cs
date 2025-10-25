using BE;
using VALIDACION;
using BLL;
using BLL.BLL_Personas;
namespace GUI
{
    public partial class Form1 : Form
    {
        Cliente_BLL Cliente_BLL = new Cliente_BLL();
        Due�o_BLL Due�o_BLL = new Due�o_BLL();
        bool reporte_open = false;
        Validar_Persona validar_Persona = new Validar_Persona();

        public Form1()
        {
            InitializeComponent();
            Grilla_Clientes.DataSource = null;
            Grilla_Clientes.DataSource = Cliente_BLL.ObtenerClientes();
            Grilla_Due�o.DataSource = null;
            Grilla_Due�o.DataSource = Due�o_BLL.ObtenerDue�os();
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

        private void BTN_AGREGAR_DUE�O_Click(object sender, EventArgs e)
        {
            try
            {
                validar_Persona.Validar_Nombre(TXT_NOMBRE_DUE�O.Text);
                validar_Persona.Validar_Telefono(TXT_TELEFONO_DUE�O.Text);
                validar_Persona.Validar_Mail(TXT_MAIL_DUE�O.Text);

                string nombre = TXT_NOMBRE_DUE�O.Text;
                string telefono = TXT_TELEFONO_DUE�O.Text;
                string mail = TXT_MAIL_DUE�O.Text;


                Due�o_BLL.Agregar_Due�o(new Due�oBE(001, nombre, telefono, mail));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Due�o.DataSource = null;
                Grilla_Due�o.DataSource = Due�o_BLL.ObtenerDue�os();
            }
        }

        private void BTN_ELIMINAR_DUE�O_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Due�o.SelectedRows.Count == 0) throw new ArgumentException("Debe seleccionar algo para eliminar");
                int id_due�o = Convert.ToInt32(Grilla_Due�o.CurrentRow.Cells["Id_Admin"].Value);
                Due�o_BLL.Eliminar_Due�o(id_due�o);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Grilla_Due�o.DataSource = null;
                Grilla_Due�o.DataSource = Due�o_BLL.ObtenerDue�os();
            }
        }

        private void BTN_MODIFICAR_DUE�O_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Due�o.SelectedRows.Count != 0)
                {


                    validar_Persona.Validar_Nombre(TXT_NOMBRE_DUE�O.Text);
                    validar_Persona.Validar_Telefono(TXT_TELEFONO_DUE�O.Text);
                    validar_Persona.Validar_Mail(TXT_MAIL_DUE�O.Text);

                    Due�oBE due�o_modificado = new Due�oBE(
                                                                    Convert.ToInt32(Grilla_Due�o.CurrentRow.Cells["Id_Admin"].Value),
                                                                    TXT_NOMBRE_DUE�O.Text,
                                                                    TXT_TELEFONO_DUE�O.Text,
                                                                    TXT_MAIL_DUE�O.Text
                                                                );

                    Due�o_BLL.Modificar_Due�o(due�o_modificado);
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
                Grilla_Due�o.DataSource = null;
                Grilla_Due�o.DataSource = Due�o_BLL.ObtenerDue�os();
            }
        }

        private void BTN_REPORTE_Click(object sender, EventArgs e)
        {
            REPORTE reporte = new REPORTE();

            if (reporte_open == false)
            {
                reporte.Show();
                reporte_open = true;    

                reporte.FormClosed += (s, args) => { reporte_open = false; };
            }
        }
    }
}
