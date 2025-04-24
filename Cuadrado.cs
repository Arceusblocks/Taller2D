using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Cuadrado
    {
        private float b;
        private float h;
        public Cuadrado(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float CalcularArea()
        {
            return b * h;
        }
    }
}
