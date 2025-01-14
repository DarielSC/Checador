using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using chk.Modelos;
using System.IO;
using chk.Servicios;
using Enrollment;
using DPFP;
using DPFP.Verification;
using chk;
using System.Windows.Controls;

namespace chk
{
    /// <summary>
    /// Lógica de interacción para Empleados.xaml
    /// </summary>
    public partial class Empleados : Window
    {

        public Empleados()
        {
            InitializeComponent();

        }


        //Metodo para guardar los datos del empleado
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (tbNombre.Text == "" || tbDepartamento.Text == "" || tbApellido.Text == "" || tbMatricula.Text == "" || tbCargo.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser especificados.", "Error");
                return;
            }

            if (Template == null)
            {
                MessageBox.Show("Debe capturar la huella del empleado.", "Error");
                return;
            }

            // Verificar si la huella ya está registrada
            VerificationForm verificationForm = new VerificationForm();
            verificationForm.Verify(Template);

            if (verificationForm.HuellaVerificada)
            {
                
                return;
            }

            try
            {
                Empleado empleado = new Empleado
                {
                    Matricula = tbMatricula.Text,
                    Departamento = tbDepartamento.Text,
                    Nombre = tbNombre.Text,
                    Apellido = tbApellido.Text,
                    Cargo = tbCargo.Text,
                    Huella = Template.Bytes
                };

                int id = DatoEmpleado.AltaEmpleado(empleado);

                if (id > 0)
                {
                    LimpiarCampos();
                    dgEmpleados.DataContext = DatoEmpleado.MuestraEmpleado();
                }
                else if (id == -1)
                {
                    MessageBox.Show("Ya existe un empleado con la misma matrícula.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el empleado: {ex.Message}", "Error");
            }
        }

        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDepartamento.Text = "";
            tbCargo.Text = "";
            tbMatricula.Text = "";
            Template = null;
            imgVerHuella.Visibility = Visibility.Hidden;
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgEmpleados.DataContext = DatoEmpleado.MuestraEmpleado();
        }

        private void dgEmpleados_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Empleado empleado = (Empleado)dgEmpleados.SelectedItem;

            if (empleado == null)
            {
                return;
            }

            tbMatricula.Text = empleado.Matricula;
            tbDepartamento.Text = empleado.Departamento;
            tbNombre.Text = empleado.Nombre;
            tbApellido.Text = empleado.Apellido;
            tbCargo.Text = empleado.Cargo;


            if (empleado.Huella != null)
                imgVerHuella.Visibility = Visibility.Visible;
            else
                imgVerHuella.Visibility = Visibility.Hidden;


        }

        //Metodo para capturar la huella
        private void btnCaptura_Click(object sender, RoutedEventArgs e)
        {
            EnrollmentForm Enroller = new EnrollmentForm();
            Enroller.OnTemplate += this.OnTemplate;
            Enroller.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Dispatcher.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("La Huella ha sido capturada correctamente", "Capturar Huella");
                    imgVerHuella.Visibility = Visibility.Visible;
                }
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }



        private DPFP.Template Template;



        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatricula.Text))
            {
                MessageBox.Show("El campo Matricula debe ser especificado", "Error");
                return;
            }

            try
            {
                string matricula = tbMatricula.Text;
                int resultado = DatoEmpleado.EliminarEmpleado(matricula);

                if (resultado > 0)
                {
                    MessageBox.Show("Empleado eliminado correctamente");
                    tbNombre.Text = "";
                    tbApellido.Text = "";
                    tbDepartamento.Text = "";
                    tbCargo.Text = "";
                    tbMatricula.Text = "";
                    dgEmpleados.DataContext = DatoEmpleado.MuestraEmpleado();
                }
                else
                {
                    MessageBox.Show("No se encontró un empleado con la matrícula especificada", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible eliminar el empleado: " + ex.Message, "Error");
            }
        }

        private void btnListaAsis_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void btnListaFalta_Click(object sender, RoutedEventArgs e)
        {
            Faltas faltas = new Faltas();
            faltas.Show();
        }

        

    }
}
