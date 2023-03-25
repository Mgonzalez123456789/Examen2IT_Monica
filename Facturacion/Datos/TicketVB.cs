using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace Datos
{
    internal class TicketVB
    {
        string cadena = "server=localhost; user=root; database=Tickect; password=Seguridad23;";
        private object ticket;

        public bool Guardar(Tickect tickect)
        {
            bool inserto = false;
            int idTicket = 0;
            try
            {
                StringBuilder sqlTicket = new StringBuilder();
                sqlTicket.Append(" INSERT INTO ticket (Fecha, Usuario, Cliente, TipoSoporte, DescripcionSolicitud, DescripcionRespuesta, Precio, ISV, Descuento, Total) VALUES (@Fecha, @Usuario, @Cliente, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @ISV, @Descuento, @Total); ");
                sqlTicket.Append(" SELECT LAST_INSERT_ID(); ");


                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    con.Open();

                    MySqlTransaction tran = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        using (MySqlCommand cmd1 = new MySqlCommand(sqlTikect.ToString(), con, tran))
                        {
                            cmd1.CommandType = System.Data.CommandType.Text;
                            cmd1.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;
                            cmd1.Parameters.Add("@Usuario", MySqlDbType.VarChar, 45).Value = ticket.Usuario;
                            cmd1.Parameters.Add("@Cliente", MySqlDbType.VarChar, 45).Value = ticket.Cliente;
                            cmd1.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 45).Value = ticket.; TipoSoporte
                            cmd1.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 80).Value = ticket.DescripcionSolicitud;
                            cmd1.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 80).Value = Ticket.DescripcionRespuesta;
                            cmd1.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.Precio;
                            cmd1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = ticket.ISV;
                            cmd1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                            cmd1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                            idTicket = Convert.ToInt32(cmd1.ExecuteScalar());
                        }
                    }
                }
 catch (System.Exception)
            {
            }
            return inserto;
        }

    }

    public class Tickect
    {
    }
