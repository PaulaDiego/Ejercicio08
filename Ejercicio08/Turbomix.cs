using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Turbomix
    {
        public IBascula Bascula { get; set; }
        public ICocina Cocina
        {
            get;
            set;
        }
        public Turbomix(ICocina _Cocina, IBascula _Bascula)
        {
            this.Bascula = _Bascula;
            this.Cocina = _Cocina;
        }
        public void HacerPlato (Alimento Alimento1, Alimento Alimento2)
        {

            Bascula.Pesar(Alimento1);
            Bascula.Pesar(Alimento2);
            Cocina.Calentar(Alimento1, Alimento2);
            Plato Plato1 = new Plato(Alimento1,Alimento2);
            Plato1.Emplatar();
        }
    }
}
