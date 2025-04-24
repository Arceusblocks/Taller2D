using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Ejemplos
    {
        public void Start()
        {
            Triangulo t1 = new Triangulo(3, 7);
            Triangulo t2 = new Triangulo(4, 8);

            Triangulo[] Tris = { t1, t2, new Triangulo(1, 1) };
            //Tris[3] = new Triangulo (1, 2); // <- error

            List<Triangulo> lista = Tris.ToList();

            foreach (Triangulo t in lista)
            {
                Console.WriteLine(t.CalcularArea());
            }
        }    
    }
}
