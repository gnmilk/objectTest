using System;
using System.Collections;

namespace objectTest
{
    class Program
    {
        static void Animal()
        {
            Animal dog = new Animal();

            dog.Mammal = "dog";

            dog.display();

            Console.WriteLine("------------------");

            Person per = new Person();

            per.display();

            Console.Read();
        }

        static void weight()
        {
            double lb = float.Parse(Console.ReadLine());

            CWeight weight = new CWeight();

            double g = weight.Convert(lb);

            Console.WriteLine("{0}lb {1}g", lb, g.ToString("#.##"));
        }

        static void passlevel()
        {
            int keyin = int.Parse(Console.ReadLine());

            CStudent stu = new CStudent();

            Console.WriteLine("分數:{0}", stu.Pass(keyin));
            Console.WriteLine("評語:{0}", stu.Pass(keyin));
            Console.ReadLine();
        }

        static void areacmp()
        {
            int d1 = 20, d2 = 10;

            DArea dv;
            Area Area = new Area();

            dv = new DArea(Area.TriA);

            Console.WriteLine("1.三角形.....");
            Area.GetArea(d1, d2, dv);

            Console.WriteLine("2.矩形");
            Area.GetArea(d1, d2, new DArea(Area.RecA));

            Console.Read();
        }
        static void Main(string[] args)
        {
            areacmp();
        }
    }
}
