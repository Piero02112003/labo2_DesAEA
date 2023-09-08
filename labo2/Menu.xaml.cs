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
using static labo2.ListaConductores;

namespace labo2
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Ingresos
            Operaciones operacionesWindow = new Operaciones();
            operacionesWindow.Show();
        }

        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            // Lógica pendiente para la opción "Salidas"
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Conductores
            Conductores conductoresWindow = new Conductores();
            conductoresWindow.Show();
        }

        private void Transportistas_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Lista de Conductores
            ListaConductores listaconductoresWindow = new ListaConductores();
            listaconductoresWindow.Show();
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            // Lógica pendiente para la opción "Camiones"
        }

        private void Productos_Click(object sender, RoutedEventArgs e)
        {
            // Lógica pendiente para la opción "Productos"
        }

        private void Cargas_Click(object sender, RoutedEventArgs e)
        {
            // Lógica pendiente para la opción "Cargas"
        }

        private void IngresosReporte_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Lista de Ingresos
            ListaIngresos listaingresosWindow = new ListaIngresos();
            listaingresosWindow.Show();
        }

        private void SalidasReporte_Click(object sender, RoutedEventArgs e)
        {
            // Lógica pendiente para la opción "Reporte de Salidas"
        }
    }

}
