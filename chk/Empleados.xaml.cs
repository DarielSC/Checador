using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using chk.Modelos;
using System.IO;
using chk.Servicios;
using Enrollment;

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
            if(tbNombre.Text =="")
            {
                MessageBox.Show("El campo Nombre debe ser especificado", "Error");
                return;
            }

            if (tbDepartamento.Text == "")
            {
                MessageBox.Show("El campo Departamento debe ser especificado", "Error");
                return;
            }

            if (tbApellido.Text == "")
            {
                MessageBox.Show("El campo Apellido debe ser especificado", "Error");
                return;
            }

            if (tbMatricula.Text == "") 
            {
                MessageBox.Show("El campo Matricula debe ser especificado", "Error");
                return;
            }

            if (tbCargo.Text =="")
            {
                MessageBox.Show("El campo Cargo debe ser especificado", "Error");
                return;
            }

            if (Template == null)
            {
                MessageBox.Show("La Huella del empleado debe ser especificado", "Error");
                return;
            }

            try
            {
                Empleado empleado = new Empleado();
                empleado.Matricula = tbMatricula.Text;
                empleado.Departamento = tbDepartamento.Text;
                empleado.Nombre = tbNombre.Text;
                empleado.Apellido = tbApellido.Text;
                empleado.Cargo = tbCargo.Text;
                empleado.Huella = Template.Bytes;



                int id = DatoEmpleado.AltaEmpleado(empleado);

                if (id > 0) 
                {
                    MessageBox.Show("Empleado guardado correctamente");
                    tbNombre.Text = "";
                    tbApellido.Text = "";
                    tbDepartamento.Text = "";
                    tbCargo.Text = "";
                    tbMatricula.Text = "";
                    dgEmpleados.DataContext = DatoEmpleado.MuestraEmpleado();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("No fue posible guardar el empleado" + ex.Message, "Error en guardar");
            }
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
    }
}
