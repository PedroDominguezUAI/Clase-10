using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entity;

namespace BLL
{
   
    public class TipoBicicletaBusiness
    {
        TipoBicicletaDAO tBDAO = new TipoBicicletaDAO();
        public List<TipoBicicleta> GetAllTipoBicicletas()
        {
            return tBDAO.GetAllTiposBicicletas();
        }
    }
}
