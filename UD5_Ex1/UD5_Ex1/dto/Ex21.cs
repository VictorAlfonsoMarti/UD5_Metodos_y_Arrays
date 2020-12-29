using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex21
    {
        /*
         * 21) Crea un array de números de un tamaño pasado por teclado, el array contendrá
            números aleatorios entre 1 y 300 y mostrar aquellos números que acaben en un dígito que
            nosotros le indiquemos por teclado (debes controlar que se introduce un numero correcto),
            estos deben guardarse en un nuevo array.
            Por ejemplo, en un array de 10 posiciones e indicamos mostrar los números acabados en 5,
            podría salir 155, 25, etc.
            */

        public static void ExtractorValorArrayExacto()
        {
            Console.WriteLine("Indica el tamaño del Array: ");
            int[] cadena1 = new int[Convert.ToInt32(Console.ReadLine())];
            Random numRandom = new Random();


            for (int x=0; x<cadena1.Length; x++) // asignamos valor aleatorio
            {
                cadena1[x] = numRandom.Next(1, 300);
            }

            Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", cadena1)); // printamos cada una de las celdas del array en formato array.

            Console.WriteLine("Indica el dígito en que tiene que acabar un número para guardarlo: ");
            int numGuardar = Convert.ToInt32(Console.ReadLine());

            
            // creamos una lista para guardar los valores deseados 
            List<int> listaNumeros = new List<int>();

            for (int x =0; x < cadena1.Length; x++)
            {
                if ((cadena1[x] % 10) == numGuardar) // si modulo de 10 (último digito) no es igual al numero a guardar, añade el registro a la lista 
                {
                    listaNumeros.Add(cadena1[x]);
                }
            }

            int[] cadena2 = listaNumeros.ToArray();

            Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", cadena2)); // printamos cada una de las celdas del array en formato array.
        }
    }
}
