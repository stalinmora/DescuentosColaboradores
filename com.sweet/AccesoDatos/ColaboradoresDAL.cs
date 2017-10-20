using com.sweet.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.sweet.AccesoDatos
{
    public class ColaboradoresDAL
    {
    
        public EColaborador GetColaborador(int codigo)
        {
            string sql = "select CODVENDEDOR , NOMBREVENDEDOR, NOMBRECORTO  from dbo.vendedores where CODVENDEDOR = " + codigo;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDescuentoLocal"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        EColaborador colaborador = new EColaborador
                        {
                            id = Convert.ToInt32(data["CODVENDEDOR"]),
                            NombreLargo = Convert.ToString(data["NOMBREVENDEDOR"]),
                            NombreCorto = Convert.ToString(data["NOMBRECORTO"])
                        };
                        return colaborador;
                    }
                }                   
            }
            return null;
        }

        /// <summary>
        /// Procedimiento Retorna un array string
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public string[] getItemsKit(int codigo)
        {
            List<string> resultado = new List<string>();
            string sql = "SELECT DESCRIPCIOKIT FROM dbo.KITS WHERE CODARTICULO = " + codigo;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDescuentoLocal"].ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader data = cmd.ExecuteReader();
                        while(data.Read())
                        {
                            resultado.Add(Convert.ToString(data["DESCRIPCIOKIT"]));
                        };
                    }
                    return resultado.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public double getPrecioArticulo(int codigo, double descuento )
        {
            double precio = 0.00;
            double porcentaje;
            string sql = "SELECT VALOR FROM dbo.PRECIOSVENTA WHERE CODARTICULO = " + codigo;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDescuentoLocal"].ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if(descuento == 50)
                        {
                            porcentaje = 0.5;
                        }else
                        {
                            porcentaje = 1.0;
                        }
                        precio = Convert.ToDouble(cmd.ExecuteScalar());
                        return precio * porcentaje;
                        /*
                        SqlDataReader data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            precio = Convert.ToDouble(data["VALOR"]);
                        };
                        */
                    }
                }
            }
            catch (Exception)
            {
                return 0.00;
            }
        }
    

        public string[] getItemsTraspaso(int codigo)
        {
            List<string> resultado = new List<string>();
            string sql = "SELECT DESCRIPCION FROM dbo.TRASPALMACEN WHERE numero = " + codigo;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDescuentoLocal"].ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            resultado.Add(Convert.ToString(data["DESCRIPCION"]));
                        };
                    }
                    return resultado.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataSet getArticulos()
        {
            DataSet ds = new DataSet();
            string sql = "select " +
                        "CODARTICULO, " +
                            "REFERENCIA, " +
                            "DESCRIPCION " +
                        " from dbo.articulos " +
                        " where sevende = 'T' and descatalogado = 'F' ORDER BY 3 ";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDescuentoLocal"].ToString()))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(ds, "articulos");
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al conectar con la nase de datos.");

            }
            return null;
        }

        public List<ETraspaso> GetTraspasosAll()
        {
            List<ETraspaso> traspasos = new List<ETraspaso>();

            #region SQL OBTIENE TRASPASOS
            string sql =  "SELECT "+ 
                            "NUMERO, "+
                            "LINEA, "+
                            "CODALMDEST, "+
                            "B.NOMBREALMACEN AS NOMBREALMACEN, "+
                            "FECHA, " +
                            "CODARTICULO, "+
                            "REFERENCIA, "+
                            "DESCRIPCION, "+
                            "UNIDADES, "+
                            "PRECIO ,"+
                            "USUARIO "+
                            "FROM [dbo].[TRASPALMACEN] A INNER JOIN [dbo].[ALMACEN] B  ON A.CODALMDEST = B.CODALMACEN collate Latin1_General_CS_AS " +
                            "WHERE CODALMDEST IN ('T1','T5') ";
            #endregion

            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDescuentoLocal"].ToString()))
            {
               conn.Open();
               using(SqlCommand cmd = new SqlCommand(sql, conn))
               {
                   SqlDataReader data = cmd.ExecuteReader();
                   while(data.Read())
                   {
                       ETraspaso traspaso = new ETraspaso
                       {
                           Numero = Convert.ToInt32(data["NUMERO"]),
                           Linea = Convert.ToInt32(data["LINEA"]),
                           CodAlmDest = Convert.ToString(data["CODALMDEST"]),
                           NombreAlmacen = Convert.ToString(data["NOMBREALMACEN"]),
                           Fecha = Convert.ToDateTime(data["FECHA"]),
                           CodArticulo = Convert.ToInt32(data["CODARTICULO"]),
                           Referencia = Convert.ToString(data["REFERENCIA"]),
                           Descripcion = Convert.ToString(data["DESCRIPCION"]),
                           Unidades = Convert.ToDouble(data["UNIDADES"]),
                           Precio = Convert.ToDouble(data["PRECIO"]),
                           Usuario = Convert.ToInt32(data["USUARIO"])
                       };
                       traspasos.Add(traspaso);
                   }
               }
            }
            return traspasos;
        }
    }
}
