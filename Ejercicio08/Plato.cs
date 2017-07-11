using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Plato 
    {
        public Alimento Alimento1 { get; set; }
        public Alimento Alimento2 { get; set; }

        public Plato(Alimento Alimento1, Alimento Alimento2)
        {
            this.Alimento1 = Alimento1;
            this.Alimento2 = Alimento2;
        }

        public void Emplatar()
        {
            Console.Write("Plato colocado");
        }
    }
}
