using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico : Transporte
    {
        public int CantidadDeWatts { get; set;}

        public AutoElectrico(int CantidadDeWatts, string Patente)
        {
            this.CantidadDeWatts = CantidadDeWatts;
            this.Patente = Patente;
        }

        virtual public new void Acelerar()
        {
            Console.WriteLine("El vehiculo electrico acelera");
        }

        virtual public new void Frenar()
        {
            Console.WriteLine("El vehiculo electrico frena");
        }
    }

    
}
