#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
//using btl.generic;
using btl.generic;
#endregion

namespace GATest
{
    class Program
    {
        //  optimal (tối ưu) solution for this is (0.5,0.5)
        public static double theActualFunction(params double[] values)//hàm hiện tại, hàm thực tế.
        {
            if (values.Length != 2)
                throw new ArgumentOutOfRangeException("should only have 2 args");//lý lẽ luận cứ, chủ đề

            double x = values[0];
            double y = values[1];
            double n = 9;  //  should be an int, but I don't want to waste time casting.

            double f1 = Math.Pow(15 * x * y * (1 - x) * (1 - y) * Math.Sin(n * Math.PI * x) * Math.Sin(n * Math.PI * y), 2);
            //double f2 = -x * ( Math.Log(x) * Math.Log(x) + y * y);
            //double f3 = (x * x * x + y * y * y + 3 * x * y);

            return f1;
        }

        public static void Main()
        {
            //  Crossover		= 80%
            //  Mutation		=  5%
            //  Population size = 100
            //  Generations		= 2000
            //  Genome size		= 2
            GA ga = new GA(0.8, 0.05, 100, 2000, 2);

            ga.FitnessFunction = new GAFunction(theActualFunction);
           
            //ga.FitnessFile = @"H:\fitness.csv";
            ga.Elitism = true;
            ga.Go();

            double[] values;
            double fitness;
            ga.GetBest(out values, out fitness);
            //System.Console.WriteLine("cá thể tốt nhất:");
            System.Console.WriteLine("best({0}):", fitness);
             foreach (double valeur in values)
                System.Console.WriteLine("values {0}:",valeur);

            ga.GetWorst(out values, out fitness);
           // System.Console.WriteLine("cá thể xấu nhất:");
            System.Console.WriteLine("\n worst ({0}):", fitness);
            foreach (double valeur in values)
                System.Console.WriteLine("values {0} ", valeur);

            System.Console.ReadLine();

        }
    }
}
