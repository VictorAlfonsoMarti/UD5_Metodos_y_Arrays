using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex19
    {
        /* 19) Crea un array de números de un tamaño pasado por teclado, el array contendrá
            números aleatorios primos entre los números deseados, por último nos indicar cual es el
            mayor de todos.
            Haz un método para comprobar que el número aleatorio es primo, puedes hacer todos lo
            métodos que necesites.*/

        public static int[] NumeroRandomPrimo(int cantidadNumeros, int valorMinimo, int valorMaximo)
        {
            int[] array = new int[cantidadNumeros]; //creamos un array con las celdas indicadas
            Random numeroRandom = new Random(); //llamamos al metodo random propia de c#
            int numeroRandomPrimo;
            Boolean esPrimo;

            for (int x = 1; x < array.Length; x++)
            {
                esPrimo = false;
                while (esPrimo == false)
                {
                    numeroRandomPrimo = numeroRandom.Next(valorMinimo, valorMaximo); //seleccionamos un numero aleatorio entre valores
                    if (Ex3.CalculoPrimo(numeroRandomPrimo)) // si el numero es primo añadimos
                    {
                        array[x] = numeroRandomPrimo; //colocamos en la posicion x un numero PRIMO random entre valorMinimo y valorMaximo
                        esPrimo = true;
                    }
                }
            }

            return array;
        }

        // indica el número de mayor valor en un array.
        public static int NumeroMayorArray(int[] cadena)
        {
            int numeroMayor = 0;

            for (int x = 0; x<cadena.Length; x++)
            {
                if (numeroMayor < cadena[x]) numeroMayor = cadena[x]; //si el valor de la posicion es mayor que el de la variable le asigna ese valor a la variable.
            }
            return numeroMayor;
        } 
    }
}
