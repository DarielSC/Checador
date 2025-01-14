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
    }
}