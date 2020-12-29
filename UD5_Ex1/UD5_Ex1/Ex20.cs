using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex20
    {
        /*20) Crea dos arrays de números con una posición pasado por teclado.
            Uno de ellos estará rellenado con números aleatorios y el otro apuntara al array anterior,
            después crea un nuevo array con el primer array (usa de nuevo new con el primer array) con
            el mismo tamaño que se ha pasado por teclado, rellenalo de nuevo con números aleatorios.
            Después, crea un método que tenga como parámetros, los dos arrays y devuelva uno nuevo
            con la multiplicación de la posición 0 del array1 con el del array2 y así sucesivamente. Por
            último, muestra el contenido de cada array.*/

        public static int[] ArrayAleatorioInt(int nCeldas)
        {

            int[] arrayCreado = new int[nCeldas]; // creamos un array vacio con las celdas que nos han indicado
            Random numRandom = new Random(); // llamamos al metodo random

            for (int x = 0; x < nCeldas; x++) // recorremos todas las celdas del array
            {
                arrayCreado[x] = numRandom.Next(0, 100); // insertamos en cada posicion un numero random entre 1 y 100
            }

            return arrayCreado;
        }

        public static int[] MultiplicadorArray(int[] cadena1, int[] cadena2)
        {
            int[] cadenaMultiplicada = new int[cadena1.Length];
            if (cadena1.Length != cadena2.Length)
            {
                Console.WriteLine("ERROR: Las cadenas tienen que tener la misma longitud.");
                return cadenaMultiplicada;
            }
            else
            {
                for (int x=0; x<cadena1.Length; x++)
                {
                    cadenaMultiplicada[x] = cadena1[x] * cadena2[x];
                }
            }

            return cadenaMultiplicada;
        }
    }
}
