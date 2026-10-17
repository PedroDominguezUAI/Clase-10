using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Alquiler
    {
        private int ID_Alquiler;
        private int Tipo_Bicicleta;
        private int DNI;
        private double Importe;
        private DateTime Fecha_Registro;
        private DateTime Fecha_Vencimiento;

        public Alquiler()
        {

        }

        public int ID_Alquiler1 { get => ID_Alquiler; set => ID_Alquiler = value; }
        public int Tipo_Bicicleta1 { get => Tipo_Bicicleta; set => Tipo_Bicicleta = value; }
        public int DNI1 { get => DNI; set => DNI = value; }
        public double Importe1 { get => Importe; set => Importe = value; }
        public DateTime Fecha_Registro1 { get => Fecha_Registro; set => Fecha_Registro = value; }
        public DateTime Fecha_Vencimiento1 { get => Fecha_Vencimiento; set => Fecha_Vencimiento = value; }
    }
}
