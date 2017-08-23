using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

using DotNet.Negocio;
using System.IO;

namespace DotNet.Pruebas.Controllers
{
    public class ApiSuccerController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ConsultarTorneos()
        {
            var result = (HttpResponseMessage)null;
            string path = AppDomain.CurrentDomain.BaseDirectory;

            try
            {
                XmlDocument reader = new XmlDocument();
                reader.Load($"{path}xml/soccer.xml");

                result = Request.CreateResponse(HttpStatusCode.OK, SuccerBL.ConsultarTorneos(reader));
            }
            catch (Exception exception)
            {
                result = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return result;
        }

        [HttpGet]
        public HttpResponseMessage ConsultarPartidos(int id)
        {
            var result = (HttpResponseMessage)null;
            string path = AppDomain.CurrentDomain.BaseDirectory;

            try
            {
                XmlDocument reader = new XmlDocument();
                reader.Load($"{path}xml/soccer.xml");

                result = Request.CreateResponse(HttpStatusCode.OK, SuccerBL.ConsultarPartidos(reader, id));
            }
            catch (Exception exception)
            {
                result = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return result;
        }
    }
}
