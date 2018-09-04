using System;

namespace objectTest
{
    interface IPass
    {
        int Score { get; set; }

        String Pass(int grade);
    }

    interface ILevel
    {
        int High { get; set; }

        int Low { get; set; }

        String Level(int grade);
    }
}