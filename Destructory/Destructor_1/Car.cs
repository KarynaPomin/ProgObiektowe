using System;

namespace Destructory_1.Classes
{
    internal class Car
    {
        private string name;
        private double speed;

        public Car(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }

        ~Car() 
        {
            Console.WriteLine($"Samochód {name} został zniszczony.");
        }

        public void StartRace()
        {
            Console.WriteLine($"Samochód {name} rozpoczął wyścig.");
        }
    }
}
