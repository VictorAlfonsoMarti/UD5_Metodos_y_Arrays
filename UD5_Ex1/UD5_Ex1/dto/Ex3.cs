using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex3
    {
        /*
         * 3)   Crea una aplicación de consola que nos pida un número por teclado y con un método se
                lo pasamos por parámetro para que nos indique si es o no un número primo, debe devolver
                true si es primo sino false.
                Un número primo es aquel solo puede dividirse entre 1 y si mismo. Por ejemplo: 25 no es
                primo, ya que 25 es divisible entre 5, sin embargo, 17 si es primo.
        */

        // método para preguntar si un numero es primo y llamar al metodo que lo calcula
        public static void EsPrimo()
        {
            Console.WriteLine("¿Es un número primo? Indica el número que desees: ");
            int numeroPrimo = Convert.ToInt32(Console.ReadLine()); // recogemos el numero en int

            // llamamos al metodo que calcula e imprimimos lo que nos devuelve.
            Console.WriteLine(CalculoPrimo(numeroPrimo));
        }

        // método para calcular si un número es primo, devuelve true o false.
        public static Boolean CalculoPrimo(int numeroPrimo)
        {
            for (int x = 2; x < numeroPrimo; x++) // recorremos los numeros hasta el que entreamos para poder operarlos (empezamos en 2 ya que siempre sera divisible un numero entre 1)
            {
                if ((numeroPrimo % x) == 0) // comprobamos si el numero actual es divisible y el residuo es 0 (indicaria que no es primo)
                {
                    return false;
                }
            }
            // si no hemos encontrado numero con el que haciendo el residuo sea 0 quiere decir que es primo. 
            return true;
        }

    }
}
