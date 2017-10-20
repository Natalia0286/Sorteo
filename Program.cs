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
           
           
           for(int x=0;x<concursantes.Length; x++){
            Console.WriteLine("Ingrese nombre del concursante:");
            concursantes[x]= Console.ReadLine();
            Console.WriteLine();
            }     


            Console.WriteLine();
          
            Console.WriteLine("Las personas registradas son: ");
            for(int x=0;x<concursantes.Length; x++){
                       
            Console.WriteLine(concursantes[x]);
            } 
        
            Console.WriteLine();
            

            Random rnd = new Random();
            int aleatorio=  rnd.Next(0, concursantes.Length);
            Console.Write("El concursante aleatorio es: " + concursantes[aleatorio]);
            

           
        }
    }
}
