using System.Configuration;
using System.Data;
using System.Windows;

namespace chk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Mostrar ventana de Login
            Login loginWindow = new Login();
            bool? result = loginWindow.ShowDialog();

            if (result == true) // Login exitoso
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else // Login fallido o cancelado
            {
                Shutdown();
            }
        }

    }

}
