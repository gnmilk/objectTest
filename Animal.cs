using System;

namespace objectTest
{
    class Animal
    {
        protected string kind = "animal";

        public string Mammal { set; get; }

        public virtual void display()
        {
            Console.WriteLine(Mammal + " is " + kind);
        }
    }
}