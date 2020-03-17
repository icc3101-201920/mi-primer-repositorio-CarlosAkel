using System;

namespace Test.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Rotonda angulo = new Rotonda(0,0);
            angulo.giro = 70;
            angulo.Fries = 1;
            angulo.Hamburger = 2;
            angulo.Fries = 2;
            Console.WriteLine(angulo.Get());
            angulo.Angulo();



        }
    }
}
