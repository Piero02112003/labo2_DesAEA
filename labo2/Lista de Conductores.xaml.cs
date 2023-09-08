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
    /// Lógica de interacción para Lista_de_Conductores.xaml
    /// </summary>
    public partial class ListaConductores : Window
    {
        public class Conductor
        {
            public string PesoMax { get; set; }
            public string Placa { get; set; }
            public string PesoVacio { get; set; }
        }

        public ListaConductores()
        {
            InitializeComponent();
            // Crear una lista de conductores (esto es solo un ejemplo)
            List<Conductor> conductores = new List<Conductor>
            {
                new Conductor { PesoMax = "Conductor 1", Placa = "Licencia 1", PesoVacio = "Transporte 1" },
                new Conductor { PesoMax = "Conductor 2", Placa = "Licencia 2", PesoVacio = "Transporte 2" },
                new Conductor { PesoMax = "Conductor 3", Placa = "Licencia 3", PesoVacio = "Transporte 3" }
            };

            // Mostrar la lista de conductores en el DataGrid
            dgConductores.ItemsSource = conductores;
        }
    }
}
