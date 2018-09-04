/*using System;

namespace objectTest
{
    class CFruit
    {
        public double Price { get; set; }

        public virtual double spend()
        {
            return 0;
        }
    }

    class CNumber : CFruit
    {
        public double Number { get; set; }

        public CNumber(int number, double price)
        {
            Number = number;
        }

        public override double spend()
        {
            return Number * Price;
        }
    }

    class CWeight : CFruit
    {
        public double Weight { get; set; }

        public CWeight(double weight, double price)
        {
            Weight = weight;
            Price = price;
        }

        public override double spend()
        {
            return Weight * Price;
        }
    }

    class CSum
    {
        private static double tot;

        public CSum(CFruit f)
        {
            tot += f.spend();
            Console.WriteLine(f.spend() + "" + tot);
        }
    }
}*/