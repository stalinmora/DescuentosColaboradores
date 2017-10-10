using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using sweetcoffee.Entidades;

namespace sweetcoffee.AccesoDatos
{
    public class DescuentoDAL
    {
        public static IQueryable getDescuentos()
        {
            List<EDescuento> descuento = new List<EDescuento>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connLocal"].ToString()))
            {

            }
            return descuento.AsQueryable();
        }
    }
}
