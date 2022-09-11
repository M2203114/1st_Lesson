using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void Main(string[] args)
        {
            Task3();
        }
        public static void Task1()
        {
            Console.WriteLine("Height in santimeters: ");
            double height = Convert.ToDouble(Console.ReadLine())/100;//182
            Console.WriteLine("Weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());//78
            var bmi = weight / (height * height);
            Console.Write($"BMI = {bmi} ");
            if (bmi <= 18.5)
                Console.WriteLine("Bellow the norm");
            if (bmi < 25)
                Console.Write("Normal");
            else if (bmi <= 29)
                Console.Write("Overweight");
            else
                Console.Write("Obese");
        }

        public static void Task2() 
        {
            double a = 100 % 21;
            double b = 17 - (a / 21);
            double grad = 10 * 6;
            double res = (4 * (Math.PI * a * b + Math.Pow((a - b), 2) / (a + b))) / 360 * grad;
            Console.WriteLine(Math.Round(res,3));
        }
        public static void Task3() 
        {
            int a_0 = 21;
            int S = 10812;
            Console.Write("Enter the amount of members of the arithmetic progression: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double a_n = (S * 2 / n) - a_0;
            double d = (a_n - a_0) / n;
            Console.WriteLine($"The step of the arithmetic progression: {d}");
        }

            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */
        }
    }
}
