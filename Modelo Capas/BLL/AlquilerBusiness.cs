using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAL;
namespace BLL
{
    public class AlquilerBusiness
    {
        AlquilerDAO aDao = new AlquilerDAO();
        public List<Alquiler> GetAllAlquileres()
        {
            return aDao.GetAllAlquileres();
        }
        public void InsertarAlquiler(Alquiler alquiler)
        {
            if (alquiler.DNI1.ToString() =="")
            {
                throw new Exception("No puede estar vacio el DNI");
            }
            if (alquiler.DNI1 <= 9999)
            {
                throw new Exception("El Dni debe de poseer mas de 5 digitos");
            }
            if (alquiler.Fecha_Vencimiento1 <= DateTime.Now)
            {
                throw new Exception("La fecha de vencimiento debe de ser mayor a la actual");
            }
            if (alquiler.Importe1 <= 0)
            {
                throw new Exception("No puede estar vacio el importe ni ser 0");
            }
            if (alquiler.Tipo_Bicicleta1.ID_Tipo1 == 0)
            {
                throw new Exception("No puede estar vacio el Tipo de Bicicleta");
            }

            aDao.InsertarAlquiler(alquiler);
        }
            
        public void ModificarAlquiler (Alquiler alquiler)
        {
            if(alquiler.ID_Alquiler1 <= 0)
            {
                throw new Exception("El Id del Alquiler no puede ser mnor o igual a 0");
            }
            if (!aDao.GetAlquilerByID(alquiler))
            {
                throw new Exception("El Id del Alquiler no existe");
            }
            if (alquiler.Importe1 <= 0)
            {
                throw new Exception("No puede estar vacio el importe ni ser 0");
            }
            if (alquiler.Fecha_Vencimiento1 <= DateTime.Now)
            {
                throw new Exception("La fecha de vencimiento debe de ser mayor a la actual");
            }
            aDao.ModificarAlquiler(alquiler);
        }
        public void EliminarAlquiler(Alquiler alquiler)
        {
            if (alquiler.ID_Alquiler1 <= 0)
            {
                throw new Exception("El Id del Alquiler no puede ser mnor o igual a 0");
            }
            if (!aDao.GetAlquilerByID(alquiler))
            {
                throw new Exception("El Id del Alquiler no ya existe");
            }
            aDao.EliminarAlquiler(alquiler);

        }
        public bool GetAlquilerByDNI(Alquiler alquiler)
        {
            return aDao.GetAlquilerByID(alquiler);
            
        }
    }
}
