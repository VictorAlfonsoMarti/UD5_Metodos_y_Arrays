using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex4
    {
        /*
         * 4)   Crea una aplicación de consola que nos calcule el factorial de un número pedido por
                teclado, lo realizara mediante un método al que le pasamos el número como parámetro.
                Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno. Por
                ejemplo, si introducimos un 5, realizara esta operación 5*4*3*2*1=120.
        */

        // método para preguntar qué número queremos saber el factorial y printarlo por pantalla
        public static void PrintaFactorial()
        {
            Console.WriteLine("Indica el número del cual desees saber el factorial: ");
            int numeroFactorial = Convert.ToInt32(Console.ReadLine()); // recogemos el numero en int

            // llamamos al metodo que calcula el factorial y lo imprimimos
            Console.WriteLine("El factorial de {0} es {1}", numeroFactorial, CalculoFactorial(numeroFactorial));
        }

        // método para calcular el factorial, devuelve int
        public static long CalculoFactorial(int numeroCalcular)
        {
            long resultadoTotal = 1;
            for (int i = 1; i <= numeroCalcular; i++)
            {
                resultadoTotal *= i; 
            }
            return resultadoTotal;
        }
    }
}