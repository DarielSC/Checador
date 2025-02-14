using chk.Modelos;
using chk.Servicios;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace chk
{
    delegate void Function();
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConfigurarUI();
        }

        private void ConfigurarUI()
        {
            MostrarSaludoUsuario(); // Llamar al método para mostrar el saludo

            if (SesionUsuario.Rol == "mod")
            {
                btnEmpleados.IsEnabled = false; // Moderador no puede gestionar empleados
                btnUsuarios.IsEnabled = false; // Moderador no puede gestionar usuarios
            }
            else if (SesionUsuario.Rol == "admin")
            {
                // Administrador tiene acceso completo
            }
        }

        private void btnEmpleados_Click(object sender, RoutedEventArgs e)
        {
            Empleados emp = new Empleados();
            emp.Show();
        }

        private void btnChecador_Click(object sender, RoutedEventArgs e)
        {
            Check check = new Check();
            check.Show();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRespaldo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Definir la ubicación del archivo de respaldo
                string backupDirectory = @"C:\Respaldos";
                string backupFile = System.IO.Path.Combine(backupDirectory, $"Respaldo_{DateTime.Now:yyyyMMdd_HHmmss}.sql");

                // Crear el directorio si no existe
                if (!Directory.Exists(backupDirectory))
                {
                    Directory.CreateDirectory(backupDirectory);
                }

                // Realizar el respaldo
                bool resultado = DatabaseHelper.RespaldarBaseDeDatos(backupFile);

                if (resultado)
                {
                    MessageBox.Show($"Respaldo realizado correctamente en:\n{backupFile}", "Éxito");
                }
                else
                {
                    MessageBox.Show("No fue posible realizar el respaldo", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el respaldo: " + ex.Message, "Error");
            }
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana actual (MainWindow)
            this.Close();
            SesionUsuario.CerrarSesion();

        }

        private void btnRegistroEventos_Click(object sender, RoutedEventArgs e)
        {
            Eventos eventos = new Eventos();
            eventos.Show();
        }

        private void btnListaAsistencia_Click(object sender, RoutedEventArgs e)
        {
           Window1 Asistencia = new Window1();
            Asistencia.Show();
        }

        private void btnListaFaltas_Click(object sender, RoutedEventArgs e)
        {
            Faltas faltas = new Faltas();
            faltas.Show();
        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void btnComparar_Click(object sender, RoutedEventArgs e)
        {
            Comparativa comparativa = new Comparativa();
            comparativa.Show();
        }

        private void MostrarSaludoUsuario()
        {
            string saludo = ObtenerSaludo();
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            lblSaludo.Content = $"{saludo}, {SesionUsuario.Nombre}! Hoy es {fechaActual}.";
        }

        private string ObtenerSaludo()
        {
            int hora = DateTime.Now.Hour;

            if (hora >= 5 && hora < 12)
                return "Buenos días";
            else if (hora >= 12 && hora < 18)
                return "Buenas tardes";
            else
                return "Buenas noches";
        }

    }
}