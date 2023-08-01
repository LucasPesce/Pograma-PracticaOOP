using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___ESTRUCTURA_DE_DATOS___EJERCICIO_1
{
    internal class Auto
    {
        // ATRIBUTOS
        private string Color;
        private int Velocidad;

        // INICIALIZAMOS LOS ATRIBUTOS
        public Auto(string color)
        {
            this.Color = color;             // El ATRIBUTO Color se le asigna, el STRING color que recive
            this.Velocidad = 0;
        }
        //METODOS
        public void Acelerar()
        {
            if(Velocidad == 195)
            {
                Velocidad += 5;
            }
            if (Velocidad < 200)         // Controla que no supere los 200 Km
            {
                Velocidad += 10;
            }
        }
        public void Frenar()
        {
            if (Velocidad > 0)          // Controla que no baje de los 0 Km
            {
                Velocidad -= 5;
            }
        }
        public string DevolverVelocidad()       // Devuelve y muestra la velocidad
        {
            return Velocidad.ToString("000");   // Convertimos los enteros en STRING
        }
        public string DevolverColor()           // Devuelve y muestra el color
        {
            return Color;
        }

    }
}
