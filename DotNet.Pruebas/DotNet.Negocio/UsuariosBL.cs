using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DotNet.Modelo;
using DotNet.Datos;

namespace DotNet.Negocio
{
    public static class UsuariosBL
    {
        public static int CrearUsuario(Usuarios modelo)
        {
            UsuariosDAO oUsuario = new UsuariosDAO();
            return oUsuario.CrearUsuarios(modelo);
        }

        public static List<Usuarios> ConsultarUsuarios()
        {
            UsuariosDAO oUsuario = new UsuariosDAO();
            return oUsuario.ConsultarUsuarios();
        }
    }
}
