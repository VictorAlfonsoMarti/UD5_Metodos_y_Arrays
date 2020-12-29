using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex2
    {
        /*
         * 2) Crea una aplicación de consola que nos genere una cantidad de números enteros
            aleatorios que nosotros le pasaremos por teclado. Crea un método donde pasamos como
            parámetros entre que números queremos que los genere, podemos pedirlas por teclado
            antes de generar los números. Este método devolverá un número entero aleatorio. Muestra
            estos números por pantalla.
         */

        public static void GeneradorNumeros()
        {
            // pedimos cantidad, minimo y maximo y guardamos en variables.
            Console.WriteLine("Bienvenido al generador de dúmeros aleatórios. \n ¿Quántos numeros quieres generar?");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indica el valor MÍNIMO que puede tener el número.");
            int valorMinimo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indica el valor MÁXIMO que puede tener el número.");
            int valorMaximo = Convert.ToInt32(Console.ReadLine());

            //llamamos al metodo que genera los numeros aleatorios y lo devolvemos, printamos por cada posicion en el array.
            int[] numeros = NumeroRandom(cantidadNumeros, valorMinimo, valorMaximo);
            foreach (int posicion in numeros)
            {
                Console.WriteLine("Número {0}: {1}", posicion, numeros[posicion]);
            }     
        }

        // metodo para generar x cantidad de numeros aleatorios entre intervalo minimo y maximo. 
        public static int[] NumeroRandom(int cantidadNumeros, int valorMinimo, int valorMaximo)
        {
            int[] array = new int[cantidadNumeros]; //creamos un array con las celdas indicadas
            Random numeroRandom = new Random(); //llamamos al metodo random propia de c#

            for (int x = 1; x < cantidadNumeros; x++)
            {
                array[x] = numeroRandom.Next(valorMinimo, valorMaximo); //colocamos en la posicion x un numero random entre valorMinimo y valorMaximo  
            }

            return array;
        }
    }
}
