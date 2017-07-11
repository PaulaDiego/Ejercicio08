using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Turbomix : ITurbomix
    {
        public int Pesar (Alimento Alimento1)
        {
            return Alimento1.Peso;
        }

        public void Calentar(Alimento Alimento1, Alimento Alimento2)
        {
            Console.Write("He calentado los alimentos");
        }

        public void HacerPlato (Alimento Alimento1, Alimento Alimento2)
        {
            Plato Plato1 = new Plato(Alimento1,Alimento2);
            Plato1.Emplatar();
        }
    }
}
