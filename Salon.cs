using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Salon
    {
        private List <Alumno> alumnoList = new List<Alumno>();

        public void Start()
        {
            bool salir = false;

            while (!salir)
            {
                Mostrarmenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": RegistrarAlumno; break;
                    case "2": RemoverAlumno; break;
                    case "3": MostrarAprobados; break;


                }
            }

        }

        private void Mostrarmenu()
        {

        }

        private void RegistrarAlumno()
        {

        }

        private void RemoverAlumno()
        {

        }

        private void MostrarAprobados()
        {

        }
    }
}
