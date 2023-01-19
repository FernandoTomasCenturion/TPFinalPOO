using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Transporte

    {
        public int Kilometros { get; set; }
        public string Patente { get; set; }

        public Transporte()
        {
        }

        public void Acelerar()
        {
            Console.WriteLine("El Transporte acelera");
        }

        public void Frenar()
        {
            Console.WriteLine("El Transporte Frena");
        }
    }

}
