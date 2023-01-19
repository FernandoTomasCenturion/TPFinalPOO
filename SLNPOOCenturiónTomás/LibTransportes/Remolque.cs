using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Remolque
    {
        public string Patente { get; set; }
        public int CantRuedas { get; set; }
        public Remolque(string Patente, int CantRuedas)
        {
            {
                this.Patente = Patente;
                this.CantRuedas = CantRuedas;
            }

        }
    }
}
