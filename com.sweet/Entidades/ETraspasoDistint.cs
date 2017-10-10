using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sweet.Entidades
{
    public class ETraspasoDistint
    {
        public int Numero { get; set; }
        public string CodAlmDest { get; set; }
        public double Descuento
        {
            get
            {
                if (this.CodAlmDest == "T1") return 100.00;
                else return 50.00;
            }
        }
        public DateTime Fecha { get; set; }
    }
}
