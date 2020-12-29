using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    /* 1) Crea una aplicación de consola que nos calcule el área de un circulo, cuadrado o
    triangulo. Pediremos que figura queremos calcular su área y según lo introducido pedirá los
    valores necesarios para calcular el área. Crea un método por cada figura para calcular cada
    área, este devolverá un número real. Muestra el resultado por pantalla.
    Aquí te mostramos que necesita cada figura:
        • Circulo: (radio^2)*PI
        • Triangulo: (base * altura) / 2
        • Cuadrado: lado * lado
 */
    public class Ex1
    {
        public static void CalcularAreas() // método para calcular areas, pregunta por pantalla, lee entrada y llama al método requerido.
        {
            Console.WriteLine("¿Qué área quieres calcular? circulo || cuadrado || triangulo");
            string entrada = Console.ReadLine();

            switch (entrada)
            {
                case "circulo":

                    Console.WriteLine("Introduce el radio del círculo:");

                    // llamamos al método areaCirculo pasandole por valor una conversion a double de lo que recogemos por cmd
                    double resultadoCirculo = AreaCirculo(Convert.ToDouble(Console.ReadLine()));

                    Console.WriteLine("El área del círculo es: {0}", resultadoCirculo);
                    break;

                case "cuadrado":
                    Console.WriteLine("Introduce el lado de una cara del cuadrado:");

                    // llamamos al método con lo que obtenemos por pantalla convertido a double
                    double resultadoCuadrado = AreaCuadrado(Convert.ToDouble(Console.ReadLine()));

                    Console.WriteLine("El área del cuadrado es: {0}", resultadoCuadrado);
                    break;

                case "triangulo":
                    Console.WriteLine("Introduce la base del triangulo:");

                    // guardamos la base del triangulo en double
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Introduce la altura del triangulo:");

                    // guardamos la altura del triangulo en double
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                    // enviamos la base y la altura al metodo y guardamos el resultado en variable
                    double resultadoTriangulo = AreaTriangulo(baseTriangulo, alturaTriangulo);

                    Console.WriteLine("El área del triangulo es: {0}", resultadoTriangulo);
                    break;

                default:
                    Console.WriteLine("ERROR: instrucción no reconocida");
                    break;
            }
        }

        // método que calcula el area de un circulo
        public static double AreaCirculo(double radioCirculo) // entra variable double, retorna variable double
        {
            return Math.Pow(radioCirculo, 2) * Math.PI;
        }

        // método que calcula el area de un cuadrado
        public static double AreaCuadrado(double ladoCuadrado)  // entra variable double, retorna variable double
        {
            return ladoCuadrado * ladoCuadrado;
        }

        // método que calcula el area de un triangulo
        public static double AreaTriangulo(double baseTriangulo, double alturaTriangulo)  // entra variable double, retorna variable double
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
