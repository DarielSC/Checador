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
    public class DatoEmpleado
    {
        public DatoEmpleado() { }   

        public static List<Empleado> MuestraEmpleado()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=Checador;Uid=root;Pwd=root1234;SslMode=none;"))
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "MuestraEmpleados";

                        using (DbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Empleado emp = new Empleado
                                    {
                                        Id = dr["Id"] != DBNull.Value ? Convert.ToInt32(dr["Id"]) : 0,
                                        Matricula = dr["Matricula"]?.ToString() ?? string.Empty,
                                        Departamento = dr["Departamento"]?.ToString() ?? string.Empty,
                                        Nombre = dr["Nombre"]?.ToString() ?? string.Empty,
                                        Apellido = dr["Apellido"]?.ToString() ?? string.Empty,
                                        Cargo = dr["Cargo"]?.ToString() ?? string.Empty,
                                        Foto = dr["Foto"]?.ToString() ?? string.Empty,
                                        Huella = dr["Huella"] != DBNull.Value ? (byte[])dr["Huella"] : Array.Empty<byte>(),
                                        FechaHoraAlta = dr["FechaHoraAlta"] != DBNull.Value ? Convert.ToDateTime(dr["FechaHoraAlta"]) : default
                                    };

                                    listaEmpleados.Add(emp);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrió un error al consultar Empleados" + ex.Message, "Error");
            }

            return listaEmpleados;  
        }   

        public static int AltaEmpleado(Empleado empleado)
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
                        command.CommandText = "AltaEmpleados";

                        // Agrega los parámetros usando MySqlParameter
                        command.Parameters.Add(new MySqlParameter("pMatricula", MySqlDbType.VarChar) { Value = empleado.Matricula });
                        command.Parameters.Add(new MySqlParameter("pCargo", MySqlDbType.VarChar) { Value = empleado.Cargo });
                        command.Parameters.Add(new MySqlParameter("pNombre", MySqlDbType.VarChar) { Value = empleado.Nombre });
                        command.Parameters.Add(new MySqlParameter("pApellido", MySqlDbType.VarChar) { Value = empleado.Apellido });
                        command.Parameters.Add(new MySqlParameter("pDepartamento", MySqlDbType.VarChar) { Value=empleado.Departamento});

                        // Asignar la foto como string (ruta) o como byte[] según sea el caso
                        command.Parameters.Add(new MySqlParameter("pFoto", MySqlDbType.VarChar) { Value = empleado.Foto });

                        // Asignar la huella como byte[]
                        command.Parameters.Add(new MySqlParameter("pHuella", MySqlDbType.Blob) { Value = empleado.Huella });

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
                MessageBox.Show("Error al dar de alta al elemento" + ex.Message, "Error");
            }

            return res;

        }


    }


}
