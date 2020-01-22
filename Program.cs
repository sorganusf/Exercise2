using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            int height;
            //Max Heart rate is equal to 220 - age
            int maxHeartRate;

            age = 25;
            height = 72;
            maxHeartRate = 220 - age;

            Console.WriteLine("I am " + age + " years old, my max heart is " +  maxHeartRate + " and I am " + height +
                " inches tall.");
            Console.ReadLine();
        }
    }
}
