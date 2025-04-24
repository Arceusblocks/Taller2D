using System;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            while (repetir)
            {
                //Calculadora
                Console.WriteLine("Introduce el primer número:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el segundo número:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce la operación [+, -, *, /, %]:");
                string operacion = Console.ReadLine();

                double resultado = 0;
                bool operacionValida = true;

                switch (operacion)
                {
                    case "+": resultado = num1 + num2; break;
                    case "-": resultado = num1 - num2; break;
                    case "*": resultado = num1 * num2; break;
                    case "/": if (num2 != 0) resultado = num1 / num2; else { Console.WriteLine("Error: No se puede dividir por cero"); operacionValida = false; } break;
                    case "%": resultado = num1 % num2; break;
                    default:
                        Console.WriteLine("Operador no válido"); operacionValida = false;
                        break;
                }

                if (operacionValida)
                {
                    Console.WriteLine($"El resultado es: {resultado}");
                }

                Console.WriteLine("¿Desea realizar otra operación? (Si/No)");
                string respuesta = Console.ReadLine();

                if (respuesta == "No" || respuesta == "no")
                {
                    repetir = false;
                }
            }

            Console.WriteLine();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione la figura:");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la base del rectángulo:");
                        float baseR = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del rectángulo:");
                        float alturaR = float.Parse(Console.ReadLine());

                        Rectangulo rect = new Rectangulo(baseR, alturaR);
                        Console.WriteLine($"Área del rectángulo: {rect.CalcularArea()}");break;

                    case 2:
                        Console.WriteLine("Ingrese el radio del círculo:");
                        float radio = float.Parse(Console.ReadLine());

                        Circulo circ = new Circulo(radio);
                        Console.WriteLine($"Área del círculo: {circ.CalcularArea()}");break;

                    case 3:
                        Console.WriteLine("Ingrese la base del triángulo:");
                        float baseT = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del triángulo:");
                        float alturaT = float.Parse(Console.ReadLine());

                        Triangulo tri = new Triangulo(baseT, alturaT);
                        Console.WriteLine($"Área del triángulo: {tri.CalcularArea()}");break;

                    case 4: continuar = false;break;

                    default:Console.WriteLine("Opción no válida");break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("¿Desea calcular otra figura? (Si/No)");
                    string respuesta = Console.ReadLine();
                    if (respuesta == "No" || respuesta == "no")
                    {
                        continuar = false;
                    }
                }
            }

            
        }
    }
}
