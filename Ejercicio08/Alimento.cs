using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Alimento
    { 
        public int Peso { get; set; }
        public bool Calentado { get; set; }

        public Alimento()
        {
            Peso = 0;
            Calentado = false;
        }
        public Alimento(int Peso, bool Calentado)
        {
            this.Calentado = Calentado;
            this.Peso = Peso;
        }
    }
}
