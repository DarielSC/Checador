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
    public class DatoFalta
    {

        public DatoFalta() { }

        public static List<Falta> MuestraFalta()
        {
            List<Falta> listaFalta = new List<Falta>();

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=Checador;Uid=root;Pwd=root1234;SslMode=none;"))
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "MuestraFaltas";

                        using (DbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Falta falt = new Falta
                                    {
                                        IDFalta = dr["IDFalta"] != DBNull.Value ? Convert.ToInt32(dr["IDFalta"]) : 0,
                                        Matricula = dr["Matricula"]?.ToString() ?? string.Empty,
                                        Departamento = dr["Departamento"]?.ToString() ?? string.Empty,
                                        Nombre = dr["Nombre"]?.ToString() ?? string.Empty,
                                        Apellido = dr["Apellido"]?.ToString() ?? string.Empty,
                                        Cargo = dr["Cargo"]?.ToString() ?? string.Empty,
                                        MotivoFalta = dr["MotivoFalta"]?.ToString() ?? string.Empty,
                                        FechaInicioFalta = dr["FechaInicioFalta"] != DBNull.Value ? Convert.ToDateTime(dr["FechaInicioFalta"]) : default,
                                        FechaFinFalta = dr["FechaFinFalta"] != DBNull.Value ? Convert.ToDateTime(dr["FechaFinFalta"]) : default
                                    };

                                    listaFalta.Add(falt);
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

            return listaFalta;
        }

        public static int InsertarFalta(Falta falta)
        {
            int res = 0;

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=Checador;Uid=root;Pwd=root1234;SslMode=none;"))
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "InsertarFaltas";

                        // Agrega los parámetros usando MySqlParameter
                        command.Parameters.Add(new MySqlParameter("pMatricula", MySqlDbType.VarChar) { Value = falta.Matricula });
                        command.Parameters.Add(new MySqlParameter("pNombre", MySqlDbType.VarChar) { Value = falta.Nombre });
                        command.Parameters.Add(new MySqlParameter("pApellido", MySqlDbType.VarChar) { Value = falta.Apellido });
                        command.Parameters.Add(new MySqlParameter("pCargo", MySqlDbType.VarChar) { Value = falta.Cargo });
                        command.Parameters.Add(new MySqlParameter("pDepartamento", MySqlDbType.VarChar) { Value = falta.Departamento });
                        command.Parameters.Add(new MySqlParameter("pFechaInicioFalta", MySqlDbType.DateTime) { Value = falta.FechaInicioFalta });
                        command.Parameters.Add(new MySqlParameter("pFechaFinFalta", MySqlDbType.DateTime) { Value = falta.FechaFinFalta });
                        command.Parameters.Add(new MySqlParameter("pMotivoFalta", MySqlDbType.VarChar) { Value = falta.MotivoFalta });

                        // Parámetro de salida para Id de la falta
                        MySqlParameter paramIdFalta = new MySqlParameter("pIdFalta", MySqlDbType.Int32)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(paramIdFalta);

                        // Ejecutar la consulta
                        res = command.ExecuteNonQuery();

                        // Opcional: Capturar el ID de la falta generado
                        if (paramIdFalta.Value != DBNull.Value)
                        {
                            int idFaltaGenerado = Convert.ToInt32(paramIdFalta.Value);
                            Console.WriteLine("ID de falta generado: " + idFaltaGenerado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la falta: " + ex.Message, "Error");
            }

            return res;
        }


    }
}
