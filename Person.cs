using System;

namespace objectTest
{
    class Person : Animal
    {
        public new string Mammal
        {
            get { return "person"; }
        }

        public string special
        {
            get { return "smart"; }
        }

        public override void display()
        {
            Console.WriteLine(Mammal + " is " + kind);

            Console.WriteLine(Mammal + " is a " + special + " " + kind);
        }
    }
}