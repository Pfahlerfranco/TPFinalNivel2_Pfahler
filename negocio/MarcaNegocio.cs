using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection("server=.\\FRANZIER; database=CATALOGO_DB; integrated security=true");
            SqlCommand comando = new SqlCommand("SELECT Id, Descripcion FROM Marcas", conexion);

            try
            {
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)lector["Id"];
                    marca.Descripcion = lector["Descripcion"].ToString();

                    lista.Add(marca);
                }

                return lista;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
