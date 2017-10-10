using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sweetcoffee.Entidades
{
    public class EItem
    {
        public int Id { get; set; }
        public int Linea { get; set; }
        public int CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public float Unidades { get; set; }
        public float Precio { get; set; }
    }
}
