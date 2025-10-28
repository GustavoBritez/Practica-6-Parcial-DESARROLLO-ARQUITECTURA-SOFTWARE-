using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VALIDACION;
using BLL;
using BE;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Validar_Persona persona= new Validar_Persona();

        private Validar_Producto producto= new Validar_Producto();

        private Cliente_BLL clientebll = new Cliente_BLL();
        
        private BLL_Producto productobll = new BLL_Producto();

        public Form1()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            Lista_S.ListaClientesCarritos = clientebll.ObtenerClientes();

            Grilla_Cliente.DataSource = null;
            Grilla_Cliente.DataSource = clientebll.ObtenerClientes();

            Grilla_Producto.DataSource = null;
            Grilla_Producto.DataSource = productobll.Obtener_Productos();
        }
        
        private void BTN_AGREGAR_CLIENTE_Click(object sender, EventArgs e)
        {
            try
            {
                persona.Validar_Telefono(TXT_TELEFONO_CLIENTE.Text);

                ClienteBE newCliente =  newCliente = new ClienteBE( 
                    0,
                    TXT_NOMBRE_CLIENTE.Text,
                    TXT_TELEFONO_CLIENTE.Text,
                    $"{TXT_NOMBRE_CLIENTE.Text}@gmail.com"
                    );

                clientebll.Agregar_Cliente(newCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
            }
            finally
            {
                Actualizar();
            }
        }

        private void BTN_ELIMINAR_CLIENTE_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Cliente.SelectedRows.Count == 0) throw new ArgumentException(" Selecciona una fila para eliminar");

                int num = Convert.ToInt32(Grilla_Cliente.SelectedCells[0].Value);

                clientebll.Eliminar_Cliente(
                    Convert.ToInt32(Grilla_Cliente.SelectedCells[0].Value)
                    );

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Actualizar();
            }
        }

        private void BTN_AGREGAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            try
            {
                producto.Validar_Codigo(TXT_CODIGO_PRODUCTO.Text);
                producto.Validar_Nombre(TXT_NOMBRE_PROD.Text);
                producto.Validar_Precio_Venta(Convert.ToDecimal(TXT_PRECIO_PROD.Text));
                producto.Validar_Stock_Actual(Convert.ToInt32(TXT_CANTIDAD_PROD.Text));

                ProductoBE newBe = new ProductoBE(
                        TXT_CODIGO_PRODUCTO.Text,
                        TXT_NOMBRE_PROD.Text,
                        Convert.ToDecimal(TXT_PRECIO_PROD.Text),
                        Convert.ToDecimal(TXT_CANTIDAD_PROD.Text)
                        );
                productobll.Agregar_Producto(newBe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                            Grilla_Producto.DataSource = null;
            Grilla_Producto.DataSource = productobll.Obtener_Productos();
            }
        }

        private void BTN_AGREGAR_CARRITO_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Producto.SelectedRows.Count == 0 ) throw new ArgumentException( "Seleccione un producto para agregar");
                if (Grilla_Cliente.SelectedRows.Count == 0) throw new ArgumentException( "Seleccione un cliente para comprar" );

                ProductoBE newProducto = new ProductoBE(
                    Grilla_Producto.SelectedRows[0].Cells["ID_PRODUCTO"].Value.ToString(),
                    Grilla_Producto.SelectedRows[0].Cells["NOMBRE"].Value.ToString(),
                    Convert.ToDecimal(Grilla_Producto.SelectedRows[0].Cells["PRECIO"].Value),
                    Convert.ToDecimal(Grilla_Producto.SelectedRows[0].Cells["Cantidad"].Value)
                    );
                 
                ClienteBE clienteEXISTENTE = Lista_S.ListaClientesCarritos.FirstOrDefault( c => c.Id_Cliente == Convert.ToInt32(Grilla_Cliente.SelectedRows[0].Cells["Id_Cliente"].Value) );

                clienteEXISTENTE.Agregar_Productos(newProducto);

                CargarGrillaCarrito(clienteEXISTENTE);
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarGrillaCarrito(ClienteBE cliente)
        {
            List<ProductoBE> carritoLista = cliente.Retonar_Productos();

            Grilla_Carrito.Rows.Clear();
            Grilla_Carrito.Columns.Clear();

            if ( carritoLista.Count != 0 )
            {
                Grilla_Carrito.Columns.Add("Nombre","Nombre");
                Grilla_Carrito.Columns.Add("Codigo", "Codigo");
                Grilla_Carrito.Columns.Add("Precio", "Precio");

                foreach ( ProductoBE newP in carritoLista )
                {
                    Grilla_Carrito.Rows.Add( newP.Nombre,newP.Id_Producto,newP.Precio );
                }
            }
        }

        private void Grilla_Cliente_SelectionChanged(object sender, EventArgs e)
        {
            if (Grilla_Cliente.SelectedRows.Count == 0 || Grilla_Cliente.Rows.Count == 0)
            {
                Grilla_Carrito.DataSource = null;
                Grilla_Carrito.Refresh();
                return;
            }
            try
            {
                int idClienteSeleccionado = Convert.ToInt32(Grilla_Cliente.SelectedRows[0].Cells["ID_CLIENTE"].Value);

                ClienteBE cliente = Lista_S.ListaClientesCarritos
                                      .FirstOrDefault(c => c.Id_Cliente == idClienteSeleccionado);

                if (cliente != null)
                {
                    CargarGrillaCarrito(cliente);
                }
                else
                {
                    Grilla_Carrito.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                Grilla_Carrito.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool reporteYaAbierto = Application.OpenForms.OfType<REPORTE>().Any();

            if ( !reporteYaAbierto )
            {
                REPORTE rp = new REPORTE();
                rp.Show();
            }
        }
    }
}
