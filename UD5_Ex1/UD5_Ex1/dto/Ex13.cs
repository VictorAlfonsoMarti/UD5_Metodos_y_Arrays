using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex13
    {
       // 13) Rellenar un array de longitud pedida por el usuario con números aleatorios entre 1 y 10.

       public static string[] ArrayAleatorio()
        {
            Console.WriteLine("Creadora de Arrays Aleatorios: ¿Cuántas celdas quieres tener?");
            int nCeldas = Convert.ToInt32(Console.ReadLine()); // recogemos la cantidad de celdas que tiene que tener el array

            string[] arrayCreado = new string[nCeldas]; // creamos un array vacio con las celdas que nos han indicado
            Random numRandom = new Random(); // llamamos al metodo random

            for (int x = 0; x < nCeldas; x++) // recorremos todas las celdas del array
            {
                arrayCreado[x] = Convert.ToString(numRandom.Next(1,10)); // insertamos en cada posicion un numero random entre 1 y 10
            }

            return arrayCreado;
        }

    }
}
