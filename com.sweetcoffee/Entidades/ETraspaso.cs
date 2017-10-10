using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sweetcoffee.Entidades
{
    public class ETraspaso
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int Usuario { get; set; }
        public string Almacen { get; set; }
        public double Porcentaje
        {
            get
            {
                if (this.Almacen == "T5") return 50;
                else return 100;
            }
        }
        public IList<EItem> items = new List<EItem>();
    }
}
