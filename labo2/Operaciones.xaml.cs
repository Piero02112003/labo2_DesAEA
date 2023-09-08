using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace labo2
{
    /// <summary>
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void RegistrarIngreso_Click(object sender, RoutedEventArgs e)
        {
            // Capturar los valores de los campos
            string tipoDocumento = cmbTipoDocumento.Text;
            string numeroDocumento = txtNumeroDocumento.Text;
            string placa = txtPlaca.Text;
            string turno = cmbTurno.Text;
            string nombreConductor = txtNombreConductor.Text;
            string nombreCliente = txtNombreCliente.Text;
            DateTime fecha = dpFecha.SelectedDate ?? DateTime.Now; // Obtener la fecha seleccionada
            string hora = txtHora.Text;
            double pesoIngreso;

            if (double.TryParse(txtPesoIngreso.Text, out pesoIngreso))
            {
                // Aquí puedes realizar la lógica para guardar la información o realizar la acción deseada
                // Por ejemplo, guardar los datos en una base de datos
                // o mostrar un mensaje de éxito.
                MessageBox.Show("Ingreso registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el Peso de Ingreso.");
            }
        }
    }
}
