using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Triangulo
    {
        private float baseTri;
        private float altura;

        public Triangulo(float b, float h)
        {
            this.baseTri = b;
            this.altura = h;
        }

        public float CalcularArea()
        {
            return baseTri * altura / 2;
        }
    }
}
