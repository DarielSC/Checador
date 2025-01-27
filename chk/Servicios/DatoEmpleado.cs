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
        //Método para mostrar los empleados
        public static List<Empleado> MuestraEmpleado()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            try
            {
                // Usa el método GetConnection de la clase DatabaseHelper
                using (var conn = DatabaseHelper.GetConnection())
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
                                        Grado = dr["Grado"]?.ToString() ?? string.Empty,
                                        Huella = dr["Huella"] != DBNull.Value ? (byte[])dr["Huella"] : Array.Empty<byte>(),
                                        FechaHoraAlta = dr["FechaHoraAlta"] != DBNull.Value ? Convert.ToDateTime(dr["FechaHoraAlta"]) : default,
                                        Condicion = dr["Condicion"]?.ToString() ?? string.Empty
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
                MessageBox.Show("Ocurrió un error al consultar Empleados: " + ex.Message, "Error");
            }

            return listaEmpleados;
        }



        //Método para dar de alta a un empleados
        public static int AltaEmpleado(Empleado empleado)
        {
            int res = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Verificar si ya existe un empleado con la misma matrícula
                    using (var checkCommand = conn.CreateCommand())
                    {
                        checkCommand.CommandType = CommandType.Text;
                        checkCommand.CommandText = "SELECT COUNT(*) FROM Empleados WHERE Matricula = @Matricula";
                        checkCommand.Parameters.Add(new MySqlParameter("@Matricula", MySqlDbType.VarChar) { Value = empleado.Matricula });

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            return -1; // Indica que ya existe un empleado con la misma matrícula
                        }
                    }

                    // Insertar el nuevo empleado
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "AltaEmpleados";

                        // Agrega los parámetros usando MySqlParameter
                        command.Parameters.Add(new MySqlParameter("pMatricula", MySqlDbType.VarChar) { Value = empleado.Matricula });
                        command.Parameters.Add(new MySqlParameter("pGrado", MySqlDbType.VarChar) { Value = empleado.Grado });
                        command.Parameters.Add(new MySqlParameter("pNombre", MySqlDbType.VarChar) { Value = empleado.Nombre });
                        command.Parameters.Add(new MySqlParameter("pApellido", MySqlDbType.VarChar) { Value = empleado.Apellido });
                        command.Parameters.Add(new MySqlParameter("pDepartamento", MySqlDbType.VarChar) { Value = empleado.Departamento });
                        command.Parameters.Add(new MySqlParameter("pCondicion", MySqlDbType.VarChar) { Value = empleado.Condicion });

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
                MessageBox.Show("Error al dar de alta al empleado: " + ex.Message, "Error");
            }

            return res;
        }


        public static int EliminarEmpleado(string matricula)
        {
            int res = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "EliminarEmpleado";

                        command.Parameters.Add(new MySqlParameter("pMatricula", MySqlDbType.VarChar) { Value = matricula });

                        res = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message, "Error");
            }

            return res;
        }

        public static bool ActualizarEmpleado(Empleado empleado)
        {
            bool actualizado = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection()) // Asegúrate de tener un método para obtener la conexión
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "ActualizarEmpleado"; // Nombre del procedimiento almacenado

                        // Agrega los parámetros usando MySqlParameter
                        command.Parameters.Add(new MySqlParameter("pId", MySqlDbType.Int32) { Value = empleado.Id });
                        command.Parameters.Add(new MySqlParameter("pMatricula", MySqlDbType.VarChar) { Value = empleado.Matricula });
                        command.Parameters.Add(new MySqlParameter("pNombre", MySqlDbType.VarChar) { Value = empleado.Nombre });
                        command.Parameters.Add(new MySqlParameter("pApellido", MySqlDbType.VarChar) { Value = empleado.Apellido });
                        command.Parameters.Add(new MySqlParameter("pDepartamento", MySqlDbType.VarChar) { Value = empleado.Departamento });
                        command.Parameters.Add(new MySqlParameter("pGrado", MySqlDbType.VarChar) { Value = empleado.Grado });
                        command.Parameters.Add(new MySqlParameter("pHuella", MySqlDbType.Blob) { Value = empleado.Huella });
                        command.Parameters.Add(new MySqlParameter("pCondicion", MySqlDbType.VarChar) { Value = empleado.Condicion });

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();
                        actualizado = rowsAffected > 0; // Retorna true si se actualizó al menos un registro
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message, "Error");
            }

            return actualizado;
        }

        public static int ObtenerCantidadEmpleados()
        {
            int cantidad = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "ObtenerCantidadEmpleados"; // Nombre del procedimiento almacenado

                        // Ejecutar la consulta y obtener el resultado
                        cantidad = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la cantidad de empleados: " + ex.Message, "Error");
            }

            return cantidad;
        }


    }
}
