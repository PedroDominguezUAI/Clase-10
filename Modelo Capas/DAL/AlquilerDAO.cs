using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class AlquilerDAO
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["ConexionParcial"].ConnectionString;

        public List<Alquiler> GetAllAlquileres()
        {
            List<Alquiler> aluqileres = new List<Alquiler>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("select * from ALQUILER",conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Alquiler alquiler = new Alquiler();
                                alquiler.ID_Alquiler1 = Convert.ToInt32(reader["ID_Alquiler"]);
                                alquiler.Tipo_Bicicleta1 = Convert.ToInt32(reader["ID_Tipo"]);
                                alquiler.DNI1 = Convert.ToInt32(reader["DNI"]);
                                alquiler.Importe1 = Convert.ToDouble(reader["importe"]);
                                alquiler.Fecha_Registro1 = Convert.ToDateTime(reader["Fecha_Registro"]);
                                alquiler.Fecha_Vencimiento1 = Convert.ToDateTime(reader["Fecha_Alquiler"]);
                                aluqileres.Add(alquiler);
                            }
                        }
                    }

                }

            }
            catch (Exception ex) { 
            
            }
            return aluqileres;
        
        
        }
        public void InsertarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("insert into ALQUILER (ID_Tipo,DNI,importe,Fecha_Registro,Fecha_Alquiler) values (@ID_Tipo,@DNI,@Importe,@FechaRegistro,@FechaVencimiento)", conn))
                    {
                        //ID_Alquiler,ID_Tipo,DNI,importe,Fecha_Registro,Fecha_Alquiler
                        command.Parameters.AddWithValue("@ID_Tipo",alquiler.Tipo_Bicicleta1);
                        command.Parameters.AddWithValue("@DNI",alquiler.DNI1);
                        command.Parameters.AddWithValue("@Importe",alquiler.Importe1);
                        command.Parameters.AddWithValue("@FechaRegistro",alquiler.Fecha_Registro1);
                        command.Parameters.AddWithValue("@FechaVencimiento", alquiler.Fecha_Vencimiento1);
                        command.ExecuteNonQuery();



                    }

                }
            }
            catch { Exception e; }

        }
    
       public void ModificarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE ALQUILER SET importe = @Importe, Fecha_Alquiler = @Fecha WHERE ID_Alquiler = @ID", conn))
                    {
                        //ID_Alquiler,ID_Tipo,DNI,importe,Fecha_Registro,Fecha_Alquiler
                        command.Parameters.AddWithValue("@ID", alquiler.ID_Alquiler1);
                        command.Parameters.AddWithValue("@Importe", alquiler.Importe1);
                        command.Parameters.AddWithValue("@Fecha", alquiler.Fecha_Vencimiento1);
                        command.ExecuteNonQuery();



                    }

                }
            }
            catch { Exception e; }

        }//delete ALQUILER where ID_Alquiler = 9
        public void EliminarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("delete ALQUILER where ID_Alquiler = @ID", conn))
                    {

                        command.Parameters.AddWithValue("@ID", alquiler.ID_Alquiler1);
                        command.ExecuteNonQuery();



                    }

                }
            }
            catch { Exception e; }

        }
        public bool GetAlquilerByID(Alquiler alquiler)
        {

            try
            {
                int contador = 0;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("select * from ALQUILER Where ID_Alquiler = @ID", conn))
                    {
                        command.Parameters.AddWithValue("@ID", alquiler.ID_Alquiler1);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return true;
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {

            }
            return false;


        }
    }
}
