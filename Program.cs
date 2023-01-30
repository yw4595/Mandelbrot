using System;

namespace Mandelbrot
{
    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: This class generates Mandelbrot sets in the console window!
    /// Restrictions: None known
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>
    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            double realMin, realMax, imagMin, imagMax;
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            Console.WriteLine("Enter the minimum value for the real axis: ");
            realMin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the maximum value for the real axis: ");
            realMax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the minimum value for the imaginary axis: ");
            imagMin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the maximum value for the imaginary axis: ");
            imagMax = Convert.ToDouble(Console.ReadLine());

            for (imagCoord = imagMax; imagCoord >= imagMin; imagCoord -= (imagMax - imagMin) / 20)
            {
                for (realCoord = realMin; realCoord <= realMax; realCoord += (realMax - realMin) / 60)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
