using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex5
    {
        /*
         * 5) Crea una aplicación de consola que nos convierta un número en base decimal a binario.
            Esto lo realizara un método al que le pasaremos el numero como parámetro, devolverá un
            String con el numero convertido a binario. Para convertir un numero decimal a binario,
            debemos dividir entre 2 el numero y el resultado de esa división se divide entre 2 de nuevo
            hasta que no se pueda dividir mas, el resto que obtengamos de cada división formara el
            numero binario, de abajo a arriba.
        */

        // método para preguntar un número y printarlo en binario 
        public static void PrintBinario()
        {
            Console.WriteLine("Impresora de número en binario. ¿Qué número quieres imprimir? ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El número {0} convertido en binario es: {1}", numero, PasarBinario(numero)); 

        }

        public static string PasarBinario(int numero)
        {
            string numeroBinario = ""; //creamos la cadena vacia para añadirle posteriormente los 0s y 1s.

            if (numero > 0) // revisamos que el número sea positivo y mayor que 0.
            {
                while (numero > 0)
                {
                    if ((numero % 2) == 0) // si el resto es 0
                    {
                        numeroBinario = "0" + numeroBinario; // añadimos 0 + el string que ya estubierta
                    }
                    else // si el resto no es 0
                    {
                        numeroBinario = "1" + numeroBinario; // añadimos 1 + el string que ya tubieramos 
                    }
                    numero = numero / 2; // dividimos el número entre 2
                }
                return numeroBinario;
            }
            else if (numero == 0) // si el número es 0, devuelve 0
            {
                return "0";
            }
            else // si no se reconoce el número. 
            {
                return "ERROR: El número debe ser positivo || No se reconoce el número";
            }
        }
    }
}
