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
    /// Lógica de interacción para Mantenimiento.xaml
    /// </summary>
    public partial class Mantenimiento : Window
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }
        private void RegistrarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            string presomaximo = txtPesoMaximo.Text;
            string placa = txtPlaca.Text;
            string pesovacio = txtPesoVacio.Text;

            // Aquí puedes realizar la lógica para guardar la información o realizar la acción deseada
            // Por ejemplo, guardar los datos en una base de datos
            // o mostrar un mensaje de éxito.
            MessageBox.Show("Camión registrado correctamente.");
        }
    }
}
