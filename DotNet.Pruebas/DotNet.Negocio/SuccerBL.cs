using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DotNet.Modelo;
using System.Xml;

namespace DotNet.Negocio
{
    public static class SuccerBL
    {
        public static  List<Torneos> ConsultarTorneos(XmlDocument xDoc)
        {
            var torneos = new List<Torneos>();
            
            XmlNodeList Scores = xDoc.GetElementsByTagName("scores");
            XmlNodeList Categoria = ((XmlElement)Scores[0]).GetElementsByTagName("category");

            int i = 0;
            foreach (XmlElement nodo in Categoria)
            {
                
                Torneos oTorneo = new Torneos();
                oTorneo.Name = nodo.GetAttribute("name");
                oTorneo.Id = Convert.ToInt32(nodo.GetAttribute("id"));
                torneos.Add(oTorneo);
            }
            
            return torneos;
        }

        public static List<Partidos> ConsultarPartidos(XmlDocument xDoc, int id)
        {
            var partidos = new List<Partidos>();

            XmlNodeList Scores = xDoc.GetElementsByTagName("scores");
            XmlNodeList Categoria = ((XmlElement)Scores[0]).GetElementsByTagName("category");
            
            foreach (XmlElement nodo in Categoria)
            {
                Torneos oTorneo = new Torneos();
                oTorneo.Id = Convert.ToInt32(nodo.GetAttribute("id"));

                if (oTorneo.Id == id)
                {
                    XmlNodeList Matches = ((XmlElement)nodo).GetElementsByTagName("matches");
                    XmlNodeList Match = ((XmlElement)Matches[0]).GetElementsByTagName("match");

                    foreach (XmlElement n in Match)
                    {
                        Partidos oPartido = new Partidos();
                        XmlNodeList Localteam = ((XmlElement)n).GetElementsByTagName("localteam");
                        XmlNode localteam = Localteam[0];
                        oPartido.Equipo_Local = localteam.Attributes["name"].Value;
                        oPartido.Goles_Local = Convert.ToInt32(localteam.Attributes["goals"].Value);

                        XmlNodeList Visitorteam = ((XmlElement)n).GetElementsByTagName("visitorteam");
                        XmlNode visitorteam = Visitorteam[0];
                        oPartido.Equipo_Visitante = visitorteam.Attributes["name"].Value;
                        oPartido.Goles_Visitante = Convert.ToInt32(visitorteam.Attributes["goals"].Value);

                        oPartido.Fecha = n.Attributes["formatted_date"].Value;
                        oPartido.Status = n.Attributes["status"].Value;

                        partidos.Add(oPartido);
                    }
                }
            }

            return partidos;
        }
    }
}
