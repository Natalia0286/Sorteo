using System;
using System.Collections;
using System.Collections.Generic;

namespace Concurso
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] concursantes = new string[5];
           //List<string> concusantes = new List<string>();
           
           
           for(int x=0; x<concursantes.Length; x++){
            Console.WriteLine("Ingrese nombre del concursante:");
            concursantes[x]= Console.ReadLine();
            Console.WriteLine();
            }     


            Console.WriteLine();

            Random rnd = new Random();
            int aleatorio=  rnd.Next(0, concursantes.Length);
            Console.Write("El conscursante aleatorio es: " + concursantes[aleatorio]);
            

           
        }
    }
}
