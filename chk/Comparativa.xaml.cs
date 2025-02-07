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
            dgComparar.ItemsSource = DatoAsistencia.ObtenerComparativaAsistencia();
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string matricula = tbBuscar.Text.Trim();

            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Por favor, ingrese una matrícula.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Asistencia asistencia = DatoAsistencia.ObtenerUltimaAsistenciaPorMatricula(matricula);

            if (asistencia != null)
            {
                lblMatricula.Content = asistencia.Matricula;
                lblNombre.Content = asistencia.Nombre;
                lblApellido.Content = asistencia.Apellido;
                lblDepartamento.Content = asistencia.Departamento;
                lblGrado.Content = asistencia.Grado;
                lblFechaHoraAsistencia.Content = asistencia.FechaHoraAsistencia;
            }

        }
    }
}
