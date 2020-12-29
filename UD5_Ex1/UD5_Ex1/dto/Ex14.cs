using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{ 
    class Ex14
    {
       // 14) Dado el anterior array, pedir al usuario un numero e indicarle si existe en el array.
       public static Boolean ExisteEnArray(string[] cadena)
        {
            Console.WriteLine("¿Existe en mi array? ¿Qué número quieres comprobar?");
            string numero = Convert.ToString(Console.ReadLine());
            Boolean existe = false;

            for (int x=0; x<cadena.Length; x++)
            {
                if (cadena[x].Equals(numero)) //si el numero esta en el array
                {
                    existe = true;
                    break; // salimos del loop
                }
            }

            return existe;

        }
    }
}
