using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex6
    {
        /*6) Crea una aplicación de consola que nos cuente el número de cifras de un número entero
            positivo (hay que controlarlo) pedido por teclado. Crea un método que realice esta acción,
            pasando el número por parámetro, devolverá el número de cifras.
        */

        // método que pregunta un número y devuelve la cantidad de cifras que lo forman.  
        public static void PrintNumeroCifras()
        {
            Console.WriteLine("Calculadora de cifras de un número entero. Indica un número: ");

            string entrada = Console.ReadLine();

            if (ControlNumeroEntero(entrada))
            {
                // llamamos al método calculador y lo printamos por pantalla
                Console.WriteLine("El número de cifras de {0} es de: {1}", entrada, CalculoNumeroCifras(entrada));
            }
            else
            {
                Console.WriteLine("ERROR: El número tiene que ser entero.");
            }
        }

        // método que retorn la cantidad de caracteres de un string
        public static int CalculoNumeroCifras(string numero)
        {
            return numero.Length;
        }

        // método que controla si un número es entero o no. 
        public static Boolean ControlNumeroEntero(string numero)
        {
            int x; // creamos una variable int x vacia para comparar luego

            if (Int32.TryParse(numero, out x)) // intentamos pasar el número que nos entra a la variable int que hemos creado. si se puede es entero, si no, no es entero. 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
