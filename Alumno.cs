using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Alumno
    {
        private string Nombre;
        private float Nota1;
        private float Nota2;
        private float Nota3;

        public Alumno(string nombre, float nota1, float nota2, float nota3)
        {
            Nombre = nombre;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public float PromedioTLS()
        {
            return (Nota1 + Nota2 + Nota3) / 4;
        }
    }
}
