using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace negocio
{
    public class CategoriaNegocio
    {
        private string connectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("SELECT Id, Descripcion FROM Categorias", conexion))
            {
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Categoria categoria = new Categoria
                        {
                            Id = (int)lector["Id"],
                            Descripcion = lector["Descripcion"].ToString()
                        };

                        lista.Add(categoria);
                    }
                }
                catch
                {
                    throw;
                }
            }

            return lista;
        }
        public int agregar(Categoria categoria)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(
                "INSERT INTO Categorias (Descripcion) OUTPUT INSERTED.Id VALUES (@desc)", conexion))
            {
                comando.Parameters.AddWithValue("@desc", categoria.Descripcion);

                try
                {
                    conexion.Open();
                    int nuevoId = Convert.ToInt32(comando.ExecuteScalar());
                    return nuevoId;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
