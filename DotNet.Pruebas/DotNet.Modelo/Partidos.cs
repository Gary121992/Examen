using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Modelo
{
    public class Partidos
    {
        public string Equipo_Local { get; set; }

        public string Equipo_Visitante { get; set; }

        public string Fecha { get; set; }

        public string Status { get; set; }

        public int Goles_Local { get; set; }

        public int Goles_Visitante { get; set; }
    }
}
