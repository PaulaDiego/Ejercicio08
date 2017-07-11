using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class BasculaService : IBascula
    {
        public int Pesar(Alimento Alimento1)
        {
            return Alimento1.Peso;
        }
    }
}
