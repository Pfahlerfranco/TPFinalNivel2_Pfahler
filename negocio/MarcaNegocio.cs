using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace negocio
{
    public class MarcaNegocio
    {
        private string connectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("SELECT Id, Descripcion FROM Marcas", conexion))
            {
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Marca marca = new Marca
                        {
                            Id = (int)lector["Id"],
                            Descripcion = lector["Descripcion"].ToString()
                        };

                        lista.Add(marca);
                    }
                }
                catch
                {
                    throw;
                }
            }

            return lista;
        }

        public int agregar(Marca marca)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(
                "INSERT INTO Marcas (Descripcion) OUTPUT INSERTED.Id VALUES (@desc)", conexion))
            {
                comando.Parameters.AddWithValue("@desc", marca.Descripcion);

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
