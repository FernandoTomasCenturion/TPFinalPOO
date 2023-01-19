using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Transporte
    { 
        public Remolque Remolque;

        public Camion(int Kilometros, string Patente)
        {
            this.Kilometros = Kilometros;
            this.Patente = Patente;
        }
   
        public void QuitarRemolque()
        {
            this.Remolque = null;
        } 

        virtual public new void Acelerar()
        {
            Console.WriteLine("El Camion Acelera");
        }

        virtual public new void Frenar()
        {
            Console.WriteLine("El Camion Frena");
        }

    }



}
