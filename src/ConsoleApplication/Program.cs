//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train();
            train.StartEngines();
            Console.WriteLine("Hello World!");


            for (i = 0 ; i<=100; i ++){

                var newTrain = new Train(ToString(i));
            }
            Console.Write(ToString(GetTrainCount()));


            for (f=0 ; f<=10000000; f ++){

                var newTrain = new Train(ToString(f));
            } 
            Console.Write(ToString(GetTrainCount()));
        
            var t1 = new Train("Last Train to London");
            var t2 = new Train("Last Train to London");
            var t3 = new Train("Runaway Train");

        
        }


    }
}