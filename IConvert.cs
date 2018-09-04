using System;

namespace objectTest
{
    interface IConvert
    {
        double Mult { get; set; }

        double Convert(double w);
    }   
}