using System;

namespace objectTest
{
    public class CWeight : IConvert
    {
        private double mult = 453.39;

        public double Mult
        {
            get { return mult; }
            set { mult = value; }
        }

        public double Convert(double lb)
        {
            return lb * Mult;
        }
    }
}