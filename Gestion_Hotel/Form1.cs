using Microsoft.VisualBasic;
using BE;
using BLL;

namespace Gestion_Hotel
{
    public partial class Form1 : Form
    {

        private readonly HabitacionBLL HBLL = new();

        public Form1()
        {
            InitializeComponent();
        }
        public void ActualizarGrilla()
        {
            Grilla_Habitaciones.DataSource = null;
            Grilla_Habitaciones.DataSource = HBLL.ObtenerHabitaciones();

            Grilla_Habitaciones.Columns["Numero"].HeaderText = "Numero";
            Grilla_Habitaciones.Columns["PrecioBase"].HeaderText = "Precio Base";
            Grilla_Habitaciones.Columns["Capacidad"].HeaderText = "Capacidad";
            Grilla_Habitaciones.Columns["Disponibilidad"].HeaderText = "Disponible";

        }
        private void BTN_ADD_HABITACION_Click(object sender, EventArgs e)
        {
            if (!PedirInt("Ingrese numero de habitacion", out var numero )) return;
            if (!PedirDouble("Ingrese precio base", out var precioBase )) return;
            if (!PedirInt("Ingrese capacidad de la habitacion", out var capacidad)) return;
            if (!PedirBool("Ingrese Disponibilidad", out var disponibilidad)) return;

            HabitacionBE Habitacion = new HabitacionBE
            {
                Numero = numero,
                PrecioBase = precioBase,
                Capacidad = capacidad,
                Disponibilidad = disponibilidad
            };

            HBLL.AgregarHabitacion(Habitacion);

        }

        private void BTN_REMOVE_HABITACION_Click(object sender, EventArgs e)
        {
            if (Grilla_Habitaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var numeroHabitacion = Grilla_Habitaciones.SelectedRows[0].Cells["Numero"].Value;

            if (numeroHabitacion == null)
            {
                MessageBox.Show("Seleccione una habitación para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            HBLL.EliminarHabitacion(new HabitacionBE { Numero = Convert.ToInt16(numeroHabitacion) });
        }

        private void BTN_MOD_HABITACION_Click(object sender, EventArgs e)
        {
            if (Grilla_Habitaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var numeroHabitacion = Convert.ToInt16(Grilla_Habitaciones.SelectedRows[0].Cells["Numero"].Value);

            if (numeroHabitacion <= 0)
            {
                MessageBox.Show("Seleccione una habitación para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!PedirDouble("Ingrese precio base", out var precioBase)) return;
            if (!PedirInt("Ingrese capacidad de la habitacion", out var capacidad)) return;
            if (!PedirBool("Ingrese Disponibilidad", out var disponibilidad)) return;

            HabitacionBE Habitacion = new HabitacionBE
            {
                Numero = numeroHabitacion,
                PrecioBase = precioBase,
                Capacidad = capacidad,
                Disponibilidad = disponibilidad
            };



            HBLL.ModificarHabitacion(Habitacion);

        }

        private static bool PedirInt(string mensaje, out int valor)
        {
            while (true)
            {
                var input = Interaction.InputBox(mensaje, "Dato Requerido");
                if (string.IsNullOrEmpty(input))
                {
                    valor = default;
                    return false;
                }

                if (int.TryParse(input, out valor) && valor > 0)
                    return true;

                MessageBox.Show("Por favor, ingrese un número entero válido mayor a 0.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private static bool PedirDouble(string mensaje, out double valor)
        {
            while (true)
            {
                var input = Interaction.InputBox(mensaje, "Dato Requerido");
                if (string.IsNullOrEmpty(input))
                {
                    valor = default;
                    return false;
                }

                if (double.TryParse(input, out valor) && valor > 0)
                    return true;

                MessageBox.Show("Por favor, ingrese un número válido mayor a 0.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private static bool PedirBool(string mensaje, out bool valor)
        {
            while(true)
            {
                var input = Interaction.InputBox(mensaje + " (S/N)", "Dato Requerido");
                if (string.IsNullOrEmpty(input))
                {
                    valor = default;
                    return false;
                }

                var normalizado = input.Trim().ToUpperInvariant();

                if (normalizado is "S" or "SI")
                {
                    valor = true;
                    return true;
                }
                else if (normalizado is "N" or "NO")
                {
                    valor = false;
                    return true;
                }

                MessageBox.Show("Por favor, ingrese 'S' o 'N'.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
    }
}
