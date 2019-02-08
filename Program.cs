using System;

namespace CsharpBascis
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2;
            
            sample2 = 58;

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal");

            }
            else { Console.WriteLine("The samples are not equal"); }



            int heartRate;

            heartRate = 85;

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal");

            }
            else
            {
                Console.WriteLine("Heart rate is not normal");
            }


            double deposits;

            deposits = 135002796;

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor");
            }

            const float acceleration = 9.800f;
            float mass;


            mass = 14.6f;

            float force;
            force = acceleration * mass;


            Console.WriteLine("force = {0}", force);

            double distance = 129.763001;

            Console.WriteLine("{0} is the distance", distance);


            bool lost;
            lost = true;
            bool expensive;
            expensive = true;

            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off");
            }

            int choice;
            choice = 2;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1 ");
                    break;
                case 2:

                    Console.WriteLine("You chose 2 ");
                    break;
                case 3:
                    Console.WriteLine("You chose 3 ");

                    break;
            }

            const char integral ='\u222B';
                    
                    Console.WriteLine(" {0} is an integral.", integral);


            int i;
            for (i = 5; i <= 10; i = i + 1)
            {
                Console.WriteLine("i = {0}", i);
            }

            int age;
            age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = {0}", age);
                age++;
            }

            const string greeting = "Hello";
            string name;
            name = "Karen";
            Console.WriteLine("{0} {1}", name, greeting);
        }
    }
}