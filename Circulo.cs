using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Circulo
    {
        private float radio;

        public Circulo(float r)
        {
            this.radio = r;
        }

        public float CalcularArea()
        {
            return (float)(Math.PI * radio * radio);
        }
    }
}
