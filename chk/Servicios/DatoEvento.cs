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
    public class DatoEvento
    {
        public DatoEvento() { }

        public static List<Evento> MuestraEvento()
        {
            List<Evento> listaEvento = new List<Evento>();
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "MuestraEvento";
                        using (DbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Evento evento = new Evento
                                    {
                                        IDEvento = dr["IDEvento"] != DBNull.Value ? Convert.ToInt32(dr["IDEvento"]) : 0,
                                        Accion = dr["Accion"]?.ToString() ?? string.Empty,
                                        Detalle = dr["Detalle"]?.ToString() ?? string.Empty,
                                        FechaHora = dr["FechaHora"] != DBNull.Value ? Convert.ToDateTime(dr["FechaHora"]) : default,   
                                    };
                                    listaEvento.Add(evento);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los eventos: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return listaEvento;
        }

    }
}
