using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class AlquilerMapper
    {
        public static Alquiler Map(SqlDataReader reader ) {

            Alquiler alquiler = new Alquiler();
            alquiler.ID_Alquiler1 = Convert.ToInt32(reader["ID_Alquiler"]);
           
            alquiler.DNI1 = Convert.ToInt32(reader["DNI"]);
            alquiler.Importe1 = Convert.ToDouble(reader["importe"]);
            alquiler.Fecha_Registro1 = Convert.ToDateTime(reader["Fecha_Registro"]);
            alquiler.Fecha_Vencimiento1 = Convert.ToDateTime(reader["Fecha_Alquiler"]);
            return alquiler;
        }
    }
}
