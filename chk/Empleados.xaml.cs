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

        private void btnFoto_Click(object sender, RoutedEventArgs e)
        {
            if(tbMatricula.Text == "")
            {
                MessageBox.Show("El numero de matricula debe ser definido,", "Error");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (.jpg)|*.jpg|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

           if (ofd.ShowDialog() == true) 
              {
                    tbUrlFoto.Text = "";

                try
                {
                    BitmapImage foto = new BitmapImage();
                    foto.BeginInit();
                    foto.UriSource = new Uri(ofd.FileName);
                    foto.EndInit();
                    foto.Freeze();

                    imgFoto.Source = foto;
                    tbUrlFoto.Text = "foto_" + tbMatricula.Text + ".jpg";
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error al cargar la imagen" + ex.Message, "Error");
                }
              }
        }

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
                empleado.Foto = tbUrlFoto.Text;
                empleado.Huella = Template.Bytes;

                string destino = @"C:\Chk";
                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }
                string recurso = imgFoto.Source.ToString().Replace("file:///", "");
                File.Copy(recurso, Path.Combine(destino, tbUrlFoto.Text), true);

                int id = DatoEmpleado.AltaEmpleado(empleado);

                if (id > 0) 
                {
                    MessageBox.Show("Empleado guardado correctamente");
                    tbNombre.Text = "";
                    tbApellido.Text = "";
                    tbDepartamento.Text = "";
                    tbCargo.Text = "";
                    tbMatricula.Text = "";
                    tbUrlFoto.Text = "";
                    imgFoto.Source = null;
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
            tbUrlFoto.Text = empleado.Foto;

            if (empleado.Huella != null)
                imgVerHuella.Visibility = Visibility.Visible;
            else
                imgVerHuella.Visibility = Visibility.Hidden;

            if (!string.IsNullOrEmpty(empleado.Foto))
            {
                BitmapImage foto = new BitmapImage();
                foto.BeginInit();
                foto.UriSource = new Uri(@"C:\Chk\" + empleado.Foto);
                foto.EndInit();
                imgFoto.Source = foto;
            }
            else
            {
                imgFoto.Source = null;
                tbUrlFoto.Text = "";
            }
        }

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
