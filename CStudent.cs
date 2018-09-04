using System;

namespace objectTest
{
    class CStudent : IPass, ILevel
    {
        private String passOK;

        private int score = 60;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public String Pass(int grade)
        {
            if (grade >= score)
                passOK = "及格";
            else passOK = "不及格";

            return passOK;
        }

        private String levelN;

        private int high = 80;

        public int High
        {
            get { return high; }
            set { high = value; }
        }

        private int low = 50;

        public int Low
        {
            get { return low; }
            set { low = value; }
        }

        public String Level(int grade)
        {
            if (grade >= high) levelN = "表現優異";
            if ((grade >= low) && (grade < high)) levelN = "差強人意";
            if (grade < low) levelN = "有待加強";

            return levelN;
        }
    }
}