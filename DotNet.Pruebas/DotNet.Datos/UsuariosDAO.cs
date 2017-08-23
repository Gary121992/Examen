using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DotNet.Modelo;
using System.Data.SqlClient;
using System.Configuration;

namespace DotNet.Datos
{
    public class UsuariosDAO
    {
        public int CrearUsuarios(Usuarios modelo)
        {
            var resultado = 0;

            using (var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["dbPruebas"].ConnectionString))
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = $@"INSERT INTO Usuarios VALUES ('{modelo.Nombre}', '{modelo.ApellidoPaterno}',
                                        '{modelo.ApellidoMaterno}', '{modelo.Direccion}', '{modelo.Telefono}')";
                conexion.Open();
                comando.ExecuteNonQuery();

                return resultado;
            }
        }

        public List<Usuarios> ConsultarUsuarios()
        {
            var resultado = new List<Usuarios>();

            using (var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["dbPruebas"].ConnectionString))
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = @"SELECT TOP 1000 [UsuarioID]
                                        ,[Nombre]
                                        ,[ApellidoPaterno]
                                        ,[ApellidoMaterno]
                                        ,[Direccion]
                                        ,[Telefono]
                                        FROM [Usuarios]";

                conexion.Open();

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                    {
                        Usuarios oUsuario = new Usuarios()
                        {
                            UsuarioID = string.IsNullOrEmpty(lector["UsuarioID"].ToString()) ? 0 : Convert.ToInt16(lector["UsuarioID"]),
                            Nombre = string.IsNullOrEmpty(lector["Nombre"].ToString()) ? "" : lector["Nombre"].ToString(),
                            ApellidoPaterno = string.IsNullOrEmpty(lector["ApellidoPaterno"].ToString()) ? "" : lector["ApellidoPaterno"].ToString(),
                            ApellidoMaterno = string.IsNullOrEmpty(lector["ApellidoMaterno"].ToString()) ? "" : lector["ApellidoMaterno"].ToString(),
                            Direccion = string.IsNullOrEmpty(lector["Direccion"].ToString()) ? "" : lector["Direccion"].ToString(),
                            Telefono = string.IsNullOrEmpty(lector["Telefono"].ToString()) ? "" : lector["Telefono"].ToString()
                        };
                        resultado.Add(oUsuario);
                    }

                return resultado;
            }
        }
    }
}
