//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {

        private static int trainCount = 0;
        private String trainName = "";
        

         /// <summary>
        /// Constructor clase Train
        /// </summary>
        public Train(name){

            this.trainName = name;
            trainCount ++;
            Console.Write("New train created")
        }

         /// <summary>
        /// Destructor clase Train
        /// </summary>
        ~Train(){

            trainCount --;
            Console.Write("Deleted train from count")
        }

         /// <summary>
        /// Getters y Setters
        /// </summary>

        public static Int GetTrainCount(){

            return this.trainCount;
        }

        public String GetTrainName(){

            return this.trainName;
        }

        public static void SetTrainCount(Int newCount){

            Train.trainCount = newCount;
        }     

        public void SetTrainName(String newName){

            this.trainName = newName;
        }

        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
    }
}