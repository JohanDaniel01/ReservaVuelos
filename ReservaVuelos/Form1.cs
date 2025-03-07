using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaVuelos
{
    public partial class Form1 : Form
    {
        //Lista de vuelos
        public List<clsVuelo> listaVuelos = new List<clsVuelo>();
        public Form1()
        {
            InitializeComponent();
        }

        public void validacionesRegistroVuelo()
        {
            if (txtCodigoVuelo.Text == "" || txtOrigen.Text == "" || txtDestino.Text == "" || txtAsientosDisponibles.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtCodigoVuelo.Text, out int codigo) == false)
            {
                MessageBox.Show("El código de vuelo debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtCodigoVuelo.Text) <= 0)
            {
                MessageBox.Show("El código de vuelo debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtAsientosDisponibles.Text, out int asientos) == false)
            {
                MessageBox.Show("La cantidad de asientos disponibles debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtAsientosDisponibles.Text) <= 0)
            {
                MessageBox.Show("La cantidad de asientos disponibles debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void validacionesReservaVuelo()
        {
            if (int.TryParse(txtCodigoReserva.Text, out int codigo) == false)
            {
                MessageBox.Show("El código de la reseva debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtCodigoReserva.Text) <= 0)
            {
                MessageBox.Show("El código de la reseva debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtCantidadReservas.Text, out int cantidad) == false)
            {
                MessageBox.Show("La cantidad de reservas debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtCantidadReservas.Text) <= 0)
            {
                MessageBox.Show("La cantidad de reservas debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listaVuelos.Count == 0)
            {
                MessageBox.Show("No hay vuelos registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                validacionesRegistroVuelo();


                clsVuelo vuelo = new clsVuelo(int.Parse(txtCodigoVuelo.Text), txtOrigen.Text, txtDestino.Text, dtpFechaSalida.Value, int.Parse(txtAsientosDisponibles.Text));
                listaVuelos.Add(vuelo);
                MessageBox.Show("Vuelo agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Añadir a list view el vuelo
                listViewVuelos.Items.Add(new ListViewItem(new string[] { vuelo.Codigo.ToString(), vuelo.FechaSalida.ToString(), vuelo.CantidadAsientos.ToString(), vuelo.Origen, vuelo.Destino,  }));

                //Resetear los campos
                txtCodigoVuelo.Text = "";
                txtOrigen.Text = "";
                txtDestino.Text = "";
                txtAsientosDisponibles.Text = "";
                dtpFechaSalida.Value = DateTime.Now;

            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReservarVuelo_Click(object sender, EventArgs e)
        {
            validacionesReservaVuelo();

            foreach (clsVuelo vuelo in listaVuelos)
            {
                if (vuelo.Codigo == int.Parse(txtCodigoReserva.Text))
                {
                    if (vuelo.CantidadAsientos < int.Parse(txtCantidadReservas.Text))
                    {
                        MessageBox.Show("No hay suficientes asientos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    vuelo.ReservarAsiento(int.Parse(txtCantidadReservas.Text));
                    MessageBox.Show("Reserva realizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la cantidad de asientos disponibles en el list view
                    foreach (ListViewItem item in listViewVuelos.Items)
                    {
                       if (item.SubItems[0].Text == vuelo.Codigo.ToString())
                        {
                            item.SubItems[2].Text = vuelo.CantidadAsientos.ToString();
                           break;
                       }
                    }

                    return;
                }

                MessageBox.Show("Vuelo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Resetear los campos
            txtCodigoReserva.Text = "";
            txtCantidadReservas.Text = "";
        }
    }
}
