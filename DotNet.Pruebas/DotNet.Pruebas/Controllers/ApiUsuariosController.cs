using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using DotNet.Modelo;
using DotNet.Negocio;

namespace DotNet.Pruebas.Controllers
{
    public class ApiUsuariosController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CrearUsuario(Usuarios modelo)
        {
            var result = (HttpResponseMessage)null;

            try
            {
                result = Request.CreateResponse(HttpStatusCode.OK, UsuariosBL.CrearUsuario(modelo));
            }
            catch (Exception exception)
            {
                result = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return result;
        }

        [HttpGet]
        public HttpResponseMessage ConsultarUsuarios(Usuarios modelo)
        {
            var result = (HttpResponseMessage)null;

            try
            {
                result = Request.CreateResponse(HttpStatusCode.OK, UsuariosBL.ConsultarUsuarios());
            }
            catch (Exception exception)
            {
                result = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return result;
        }
    }
}
