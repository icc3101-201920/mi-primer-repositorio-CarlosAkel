using System;
using System.Collections.Generic;
using System.Text;

namespace Test.exe
{
    class Rotonda
    {
        public int giro { get; set; }
        public int Hamburger { get; set; }
        public int Fries { get; set; }


        public void Angulo()
        {
            Console.WriteLine("El Angulo de la rotonda es de " + giro + " grados");


        }

        public Rotonda( int Hambuger, int Fries)
        {
            this.Hamburger = Hamburger;
            this.Fries = Fries;
           
        }

        public string Get()
        {
            return $"{Hamburger} and {Fries}";

        }
    }
}
