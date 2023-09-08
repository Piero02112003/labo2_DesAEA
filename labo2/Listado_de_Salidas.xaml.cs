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
    /// Lógica de interacción para Listado_de_Salidas.xaml
    /// </summary>
    public partial class ListaSalida : Window
    {
        public class Salida
        {
            public DateTime Fecha { get; set; }
            public string Peso { get; set; }
            public string TipoAuto { get; set; }
            public string NombreTransportista { get; set; }
            public string PesoInreso { get; set; }
            public double PesoSalida { get; set; }
            public string FechayHora { get; set; }
        }

        public ListaSalida()
        {
            InitializeComponent();

            // Crear una lista de ingresos (esto es solo un ejemplo)
            List<Salida> salidas = new List<Salida>
            {
                new Salida { Fecha = DateTime.Now, Peso = "ABC123", TipoAuto = "Turno 1", NombreTransportista = "Conductor 1", PesoInreso = "Producto 1", PesoSalida = 1000.0, FechayHora = "Transporte 1" },
                new Salida { Fecha = DateTime.Now, Peso = "DEF456", TipoAuto = "Turno 2", NombreTransportista = "Conductor 2", PesoInreso = "Producto 2", PesoSalida = 1500.0, FechayHora = "Transporte 2" },
                new Salida { Fecha = DateTime.Now, Peso = "GHI789", TipoAuto = "Turno 3", NombreTransportista = "Conductor 3", PesoInreso = "Producto 3", PesoSalida = 800.0, FechayHora = "Transporte 3" }
            };

            // Mostrar la lista de ingresos en el DataGrid
            dgSalida.ItemsSource = salidas;
        }
    }
}
