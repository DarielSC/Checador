using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows;
using chk.Modelos;
using System.Data.Common;

namespace chk.Servicios
{
    public class DatoUsuario
    {
        public DatoUsuario() { }

        public static List<Usuario> MuestraUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "MuestraUsuarios";

                        using (DbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Usuario usuario = new Usuario
                                    {
                                        Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : 0,
                                        Matricula = dr["Matricula"]?.ToString() ?? string.Empty,
                                        Contrasena = dr["Contrasena"]?.ToString() ?? string.Empty,
                                        Rol = dr["Rol"]?.ToString() ?? string.Empty,
                                        FechaRegistro = dr["FechaRegistro"] != DBNull.Value ? Convert.ToDateTime(dr["FechaRegistro"]) : (DateTime?)null
                                    };
                                    listaUsuarios.Add(usuario);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los usuarios: " + ex.Message);
            }
            return listaUsuarios;
        }



        public static int AltaUsuario(Usuario usuario)
        {
            int res = 0;

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Verificar si ya existe un usuario con la misma matrícula
                    using (var checkCommand = connection.CreateCommand())
                    {
                        checkCommand.CommandType = CommandType.Text;
                        checkCommand.CommandText = "SELECT COUNT(*) FROM administradores WHERE Usuario = @Usuario";
                        checkCommand.Parameters.Add(new MySqlParameter("@Usuario", MySqlDbType.VarChar) { Value = usuario.Matricula });

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            return -1; // Indica que ya existe un usuario con la misma matrícula
                        }
                    }

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "AltaUsuario";

                        command.Parameters.Add(new MySqlParameter("pUsuario", MySqlDbType.VarChar) { Value = usuario.Matricula});   
                        command.Parameters.Add(new MySqlParameter("pContrasena", MySqlDbType.VarChar) {Value = usuario.Contrasena});
                        command.Parameters.Add(new MySqlParameter("pRol", MySqlDbType.VarChar) { Value = usuario.Rol });
                        // Parámetro de salida para Id
                        MySqlParameter paramId = new MySqlParameter("pId", MySqlDbType.Int32)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(paramId);

                        // Ejecutar la consulta
                        res = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al dar de alta el usuario: " + ex.Message);
            }
            return res;
        }

        public static void RegistrarInicioSesion(string usuario, string rol)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "RegistrarInicioSesion";

                        command.Parameters.AddWithValue("pUsuario", usuario);
                        command.Parameters.AddWithValue("pRol", rol);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el inicio de sesión: " + ex.Message);
            }
        }

        public static void RegistrarCierreSesion(string usuario, string rol)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "RegistrarCierreSesion";

                        command.Parameters.AddWithValue("pUsuario", usuario);
                        command.Parameters.AddWithValue("pRol", rol);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el cierre de sesión: " + ex.Message);
            }
        }

    }
}
