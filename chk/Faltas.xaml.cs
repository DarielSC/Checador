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
            if (tbMatricula.Text == "")
            {
                MessageBox.Show("El numero de matricula debe ser definido,", "Error");
                return;
            }
            if (tbNombre.Text == "")
            {
                MessageBox.Show("El nombre del empleado debe ser definido,", "Error");
                return;
            }
            if (tbApellido.Text == "")
            {
                MessageBox.Show("El apellido del empleado debe ser definido,", "Error");
                return;
            }
            if (tbDepartamento.Text == "")
            {
                MessageBox.Show("El departamento del empleado debe ser definido,", "Error");
                return;
            }
            if (tbCargo.Text == "")
            {
                MessageBox.Show("El cargo del empleado debe ser definido,", "Error");
                return;
            }
            if (cbMotivoFalta.SelectedIndex == -1)
            {
                MessageBox.Show("El motivo de la falta debe ser definido,", "Error");
                return;
            }
            if (dpFechaInicioFalta.SelectedDate == null)
            {
                MessageBox.Show("La fecha de inicio de la falta debe ser definida,", "Error");
                return;
            }

            string motivo = ((ComboBoxItem)cbMotivoFalta.SelectedItem).Content.ToString();

            // Validar para los motivos que solo requieren fecha de inicio
            if (motivo == "Cita medica foranea" || motivo == "Acompañante de cita medica")
            {
                // No se requiere fecha de fin
                dpFechaFinFalta.SelectedDate = null;
            }
            else
            {
                // Si no es un motivo especial, se requiere tanto fecha de inicio como de fin
                if (dpFechaFinFalta.SelectedDate == null)
                {
                    MessageBox.Show("La fecha de fin de la falta debe ser definida,", "Error");
                    return;
                }
            }

            try
            {
                Falta falta = new Falta
                {
                    Matricula = tbMatricula.Text,
                    Nombre = tbNombre.Text,
                    Apellido = tbApellido.Text,
                    Departamento = tbDepartamento.Text,
                    Cargo = tbCargo.Text,
                    MotivoFalta = motivo,
                    FechaInicioFalta = dpFechaInicioFalta.SelectedDate.Value
                };

                // Si el motivo es uno de los especiales, la fecha de fin será nula
                if (motivo == "Cita medica foranea" || motivo == "Acompañante de cita medica")
                {
                    falta.FechaFinFalta = null; // O puedes asignar null si usas un Nullable<DateTime> en la base de datos
                }
                else
                {
                    falta.FechaFinFalta = dpFechaFinFalta.SelectedDate.Value;
                }

                int id = DatoFalta.InsertarFalta(falta);

                if (id > 0)
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
                MessageBox.Show("Error al guardar la falta: " + ex.Message, "Error");
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
            Falta falta = (Falta)dgFaltas.SelectedItem;
            if (falta == null)
            {
                return;
            }
            tbMatricula.Text = falta.Matricula;
            tbNombre.Text = falta.Nombre;
            tbApellido.Text = falta.Apellido;
            tbDepartamento.Text = falta.Departamento;
            tbCargo.Text = falta.Cargo;
        }

        private void btnActualizarFalta_Click(object sender, RoutedEventArgs e)
        {
                
        }
    }
}
