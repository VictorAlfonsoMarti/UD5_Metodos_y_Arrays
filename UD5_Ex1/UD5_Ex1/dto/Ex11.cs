using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex11
    {
        // 11) Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y sacar la suma total.
        public static int SumaPosicionesArray(string[] cadena)
        {
            int sumaTotal = 0;

            for (int x = 0; x < cadena.Length; x++)// recorremos las posiciones del array
            {
                sumaTotal += Convert.ToInt32(cadena[x]); //sumamos recursivamente los valores del array.
            } 
            return sumaTotal;
        }
    }
}
