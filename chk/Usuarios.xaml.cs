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
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Window
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, RoutedEventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(tbUsuario.Text) ||
                string.IsNullOrWhiteSpace(tbContrasena.Password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (cbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un rol.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                Usuario usuario = new Usuario
                {
                    Matricula = tbUsuario.Text,
                    Contrasena = tbContrasena.Password,
                    Rol = ((ComboBoxItem)cbRol.SelectedItem).Content.ToString()
                };

                int id = DatoUsuario.AltaUsuario(usuario);

                if (id > 0)
                {
                    MessageBox.Show("Usuario registrado correctamente.", "Registro Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbUsuario.Clear();
                    tbContrasena.Clear();
                    cbRol.SelectedIndex = -1;
                    dgUsuarios.DataContext = DatoUsuario.MuestraUsuarios();
                }

                else if (id == -1)
                {
                    MessageBox.Show("Ya existe un Usuario con la misma matrícula.", "Error");
                }

                else
                {
                    MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgUsuarios.ItemsSource = DatoUsuario.MuestraUsuarios();
        }

        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem rol = (ComboBoxItem)cbRol.SelectedItem;
            MessageBox.Show(rol.Content.ToString(), "Rol Seleccionado");
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
