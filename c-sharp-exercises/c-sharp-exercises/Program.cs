using System;

namespace c_sharp_exercises
{
    class Program
    {
        //sum of two numbers
        public int SumOf(int a, int b)
        {
            return a + b;
        }

        public int QuotOf(int a, int b)
        {
            return a / b;
        }

        public double ProdOf(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Program e = new Program();

            int sum = e.SumOf(2, 3);
            int quotient = e.QuotOf(18, 3);
            double product = Math.Round(e.ProdOf(14.0, 2.2),1);


            Console.WriteLine(sum);
            Console.WriteLine(quotient);
            Console.WriteLine(product);


        }
     
    }
}
