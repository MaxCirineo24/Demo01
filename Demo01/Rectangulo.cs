using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Rectangulo
    {

        public int Altura { get; set; }

        public int Base { get; set; }

        public int CalcularArea()
        {
            return Altura + Base;
        }

        public int CalcularPerimetro()
        {
            return 2 * CalcularArea();
        }
    }
}
