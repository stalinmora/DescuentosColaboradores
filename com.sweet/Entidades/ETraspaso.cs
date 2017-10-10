using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sweet.Entidades
{
    public class ETraspaso
    {
        public int Numero {get;set;}
        public int Linea {get;set;}
        public string CodAlmDest {get;set;}
        public string NombreAlmacen { get; set; }
        public double Descuento
        {
            get
            {
                if(this.CodAlmDest == "T1") return 100.00;
                else return 50.00;
            }
        }
        public DateTime Fecha {get;set;}
        public String FechaCorta
        {
            get
            {
                return this.Fecha.ToShortDateString();
            }
        }
        public String Hora
        {
            get
            {
                return this.Fecha.ToShortTimeString();
            }
        }
        public int CodArticulo { get; set;}
        public string Referencia {get; set; }
        public string Descripcion {get; set; }
        public Double Unidades{ get; set; }
        public Double Precio {get; set; }
        public int Usuario { get; set; }
    }
}
