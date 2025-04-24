using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Rectangulo
    {
        private float baseRect;
        private float altura;

        public Rectangulo(float b, float h)
        {
            this.baseRect = b;
            this.altura = h;
        }

        public float CalcularArea()
        {
            return baseRect * altura;
        }
    }
}
