using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Turbomix
    { 
        
        public void HacerPlato (Alimento Alimento1, Alimento Alimento2)
        {
            IBascula Bascula = new BasculaService();
            ICocina ser = new CocinaService();
            Bascula.Pesar(Alimento1);
            Bascula.Pesar(Alimento2);
            ser.Calentar(Alimento1, Alimento2);
            Plato Plato1 = new Plato(Alimento1,Alimento2);
            Plato1.Emplatar();
        }
    }
}
