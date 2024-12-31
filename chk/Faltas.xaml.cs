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
    /// Lógica de interacción para Faltas.xaml
    /// </summary>
    public partial class Faltas : Window
    {
        public Faltas()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgFaltas.DataContext = DatoFalta.MuestraFalta();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(tbMatricula.Text == "")
            {
                MessageBox.Show("El numero de matricula debe ser definido,", "Error");
                return;
            }
            if(tbNombre.Text == "")
            {
                MessageBox.Show("El nombre del empleado debe ser definido,", "Error");
                return;
            }
            if(tbApellido.Text == "")
            {
                MessageBox.Show("El apellido del empleado debe ser definido,", "Error");
                return;
            }
            if(tbDepartamento.Text == "")
            {
                MessageBox.Show("El departamento del empleado debe ser definido,", "Error");
                return;
            }
            if(tbCargo.Text == "")
            {
                MessageBox.Show("El cargo del empleado debe ser definido,", "Error");
                return;
            }
            if(cbMotivoFalta.SelectedIndex == -1)
            {
                MessageBox.Show("El motivo de la falta debe ser definido,", "Error");
                return;
            }
            if(dpFechaInicioFalta.SelectedDate == null)
            {
                MessageBox.Show("La fecha de inicio de la falta debe ser definida,", "Error");
                return;
            }
            if(dpFechaFinFalta.SelectedDate == null)
            {
                MessageBox.Show("La fecha de fin de la falta debe ser definida,", "Error");
                return;
            }

            try {
                Falta falta = new Falta();
                falta.Matricula = tbMatricula.Text;
                falta.Nombre = tbNombre.Text;
                falta.Apellido = tbApellido.Text;
                falta.Departamento = tbDepartamento.Text;
                falta.Cargo = tbCargo.Text;
                falta.MotivoFalta = ((ComboBoxItem)cbMotivoFalta.SelectedItem).Content.ToString();
                falta.FechaInicioFalta = dpFechaInicioFalta.SelectedDate.Value;
                falta.FechaFinFalta = dpFechaFinFalta.SelectedDate.Value;


                int id = DatoFalta.InsertarFalta(falta);

                if(id > 0)
                {
                    MessageBox.Show("Falta guardada correctamente", "Falta Guardada");
                    tbMatricula.Text = "";
                    tbNombre.Text = "";
                    tbApellido.Text = "";
                    tbDepartamento.Text = "";
                    tbCargo.Text = "";
                    cbMotivoFalta.SelectedIndex = -1;
                    dpFechaInicioFalta.SelectedDate = null;
                    dpFechaFinFalta.SelectedDate = null;

                    
                }

            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la falta" + ex.Message, "Error");
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem falta = (ComboBoxItem)cbMotivoFalta.SelectedItem;
            MessageBox.Show(falta.Content.ToString(), "Motivo Seleccionado");
        }

        private void dgFaltas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
