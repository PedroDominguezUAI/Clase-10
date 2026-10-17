using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class TipoBicicletaDAO
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["ConexionParcial"].ConnectionString;
        public List<TipoBicicleta> GetAllTiposBicicletas()
        {

            List<TipoBicicleta> tiposBicicletas = new List<TipoBicicleta>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("select * from TIPO_BICICLETA", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TipoBicicleta tipoBicicleta = new TipoBicicleta();
                                tipoBicicleta.ID_Tipo1 = Convert.ToInt32(reader["ID_Tipo"]);
                                tipoBicicleta.Descripcion1 = Convert.ToString(reader["Descripcion"]);
                                tiposBicicletas.Add(tipoBicicleta);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {

            }
            return tiposBicicletas;

        }
    }
}
