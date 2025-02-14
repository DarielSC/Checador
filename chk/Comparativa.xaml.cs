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
using chk.Servicios;
using chk.Modelos;
using System.IO;

namespace chk
{
    /// <summary>
    /// Lógica de interacción para Comparativa.xaml
    /// </summary>
    public partial class Comparativa : Window
    {
        public Comparativa()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblFechaActual.Content = DateTime.Now.ToString("dd/MM/yyyy");
            dgMotivosFaltas.DataContext = DatoFalta.MuestraFalta();
            dgAsistencia.DataContext = DatoAsistencia.ObtenerEmpleadosConAsistencia();
            dgFaltas.DataContext = DatoAsistencia.ObtenerEmpleadosSinAsistencia();
        }


        private void dgFaltas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
