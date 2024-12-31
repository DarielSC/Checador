using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chk.Modelos;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace chk.Servicios
{
    public class DatoAsistencia
    {
        public DatoAsistencia() { }

        public static List<Asistencia> MuestraAsistencia()
        {
            List<Asistencia> listaAsistencia = new List<Asistencia>();

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=Checador;Uid=root;Pwd=root1234;SslMode=none;"))
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "MuestraAsistencia";

                        using (DbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Asistencia asis = new Asistencia
                                    {
                                        IDRegistro = dr["IDRegistro"] != DBNull.Value ? Convert.ToInt32(dr["IDRegistro"]) : 0,
                                        Matricula = dr["Matricula"]?.ToString() ?? string.Empty,
                                        Departamento = dr["Departamento"]?.ToString() ?? string.Empty,
                                        Nombre = dr["Nombre"]?.ToString() ?? string.Empty,
                                        Apellido = dr["Apellido"]?.ToString() ?? string.Empty,  
                                        Cargo = dr["Cargo"]?.ToString() ?? string.Empty,
                                        Huella = dr["Huella"] != DBNull.Value ? (byte[])dr["Huella"] : Array.Empty<byte>(),
                                        FechaHoraAsistencia = dr["FechaHoraAsistencia"] != DBNull.Value ? Convert.ToDateTime(dr["FechaHoraAsistencia"]) : default
                                    };

                                    listaAsistencia.Add(asis);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaAsistencia;
        }




        public static int RegistrarAsistencia(Asistencia asistencia)
        {
            int res = 0;

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=Checador;Uid=root;Pwd=root1234;SslMode=none;"))
                {
                    conn.Open();

                    // Verificar la cantidad de registros de la huella en el día actual
                    int cantidadRegistros = CantidadRegistrosPorDia(asistencia.Huella);
                    if (cantidadRegistros == -1) return 0; // Indica error en la consulta
                    if (cantidadRegistros >= 2)
                    {
                        return -2; // Retorna -2 si ya tiene 2 registros en el día
                    }

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "RegistrarAsistencia";

                        // Agrega los parámetros usando MySqlParameter
                        command.Parameters.Add(new MySqlParameter("pMatricula", MySqlDbType.VarChar) { Value = asistencia.Matricula });
                        command.Parameters.Add(new MySqlParameter("pNombre", MySqlDbType.VarChar) { Value = asistencia.Nombre });
                        command.Parameters.Add(new MySqlParameter("pApellido", MySqlDbType.VarChar) { Value = asistencia.Apellido });
                        command.Parameters.Add(new MySqlParameter("pCargo", MySqlDbType.VarChar) { Value = asistencia.Cargo });
                        command.Parameters.Add(new MySqlParameter("pDepartamento", MySqlDbType.VarChar) { Value = asistencia.Departamento });

                        // Asigna FechaHoraAsistencia, usa DateTime.Now si es nulo
                        command.Parameters.Add(new MySqlParameter("pFechaHoraAsistencia", MySqlDbType.Timestamp)
                        {
                            Value = asistencia.FechaHoraAsistencia ?? DateTime.Now
                        });

                        // Asigna Huella, usa DBNull.Value si es nulo
                        command.Parameters.Add(new MySqlParameter("pHuella", MySqlDbType.Blob)
                        {
                            Value = asistencia.Huella ?? (object)DBNull.Value
                        });

                        // Parámetro de salida para IdRegistro
                        MySqlParameter paramIdRegistro = new MySqlParameter("pIdRegistro", MySqlDbType.Int32)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(paramIdRegistro);

                        // Ejecutar la consulta
                        res = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la asistencia: " + ex.Message, "Error");
            }

            return res;
        }


        public static int CantidadRegistrosPorDia(byte[] huella)
        {
            int cantidad = 0;

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=Checador;Uid=root;Pwd=root1234;SslMode=none;"))
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = @"SELECT COUNT(*) 
                                                FROM Asistencia 
                                                WHERE Huella = @Huella 
                                                AND DATE(FechaHoraAsistencia) = CURDATE()";

                        command.Parameters.Add(new MySqlParameter("@Huella", MySqlDbType.Blob) { Value = huella });

                        cantidad = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar registros por día: " + ex.Message, "Error");
            }

            return cantidad;
        }
    }
}

    