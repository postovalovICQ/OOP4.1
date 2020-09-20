using System;

namespace oop4._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Здоровье");
            Health health = new Health();
            health.Temperature = 666;
            Console.WriteLine($"Максимум: {health.Temperature} градус");
            health.Temperature = 7;
            Console.WriteLine($"Минимум: {health.Temperature} градусов");
            health.Temperature = 36.6;
            Console.WriteLine($"Ваша температура: {health.Temperature} градусов");
            Console.ReadKey();
        }
    }
    class Health
    {
        private double Temp;
        public double Temperature
        {
            get
            {
                return Temp;
            }
            set
            {
                if (value < 34)
                    Temp = 34;
                else if (value > 41)
                    Temp = 41;
                else Temp = value;
            }
        }
    }
}
