using com.sweet.AccesoDatos;
using com.sweet.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sweet.LogicaNegocio
{
    public class ColaboradorBOL
    {

        private ColaboradoresDAL dAL = new ColaboradoresDAL();

        public EColaborador GetColaboradorID(int codigo)
        {
            return dAL.GetColaborador(codigo);
        }

        public List<ETraspaso> GetTraspasos()
        {
            return dAL.GetTraspasosAll();
        }

        public List<ETraspaso> GetTraspasoGrid()
        {
            IEnumerable<ETraspaso> eTraspaso = GetTraspasos().
                //Where(z => z.Numero < 1000).
                GroupBy(z => new { z.Numero}).
                Select(z => z.FirstOrDefault());
            return eTraspaso.ToList<ETraspaso>();
        }

        public System.Data.DataSet Articulos()
        {
            return dAL.getArticulos();
        }

        public string[] ItemsKit(int codigo)
        {
            return dAL.getItemsKit(codigo);
        }

        public string[] ItemsTraspaso(int codigo)
        {
            return dAL.getItemsTraspaso(codigo);
        }
        public double PrecioDescuento(int codigo, double descuento)
        {
            return dAL.getPrecioArticulo(codigo, descuento);
        }
    }
}
