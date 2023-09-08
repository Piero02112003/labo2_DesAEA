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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Password;

            // Verificar las credenciales (esto es solo un ejemplo)
            if (usuario == "Will" && contraseña == "Bocchi")
            {
                // Credenciales correctas, redirige a la ventana del menú
                Menu menuWindow = new Menu();
                menuWindow.Show();
                Close(); // Cierra la ventana de inicio de sesión
            }
            else
            {
                lblMensaje.Text = "Credenciales incorrectas. Intente nuevamente.";
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }
    }
}
