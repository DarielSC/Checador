﻿using System;
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
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using chk.Servicios;

namespace chk
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Password;

            if (ValidarCredenciales(usuario, contrasena))
            {
                // Indica éxito al cerrar la ventana
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error");
            }
        }


        private bool ValidarCredenciales(string usuario, string contrasena)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT Contrasena FROM Administradores WHERE Usuario = @Usuario";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string contrasenaHasheada = HashPassword(contrasena);

                            // Comparar el hash ingresado con el hash almacenado
                            return contrasenaHasheada == result.ToString();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error");
            }

            return false;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}