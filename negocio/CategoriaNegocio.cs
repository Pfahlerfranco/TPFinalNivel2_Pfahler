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
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection conexion = new SqlConnection("server=.\\FRANZIER; database=CATALOGO_DB; integrated security=true");
            SqlCommand comando = new SqlCommand("SELECT Id, Descripcion FROM Categorias", conexion);

            try
            {
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)lector["Id"];
                    categoria.Descripcion = lector["Descripcion"].ToString();

                    lista.Add(categoria);
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
