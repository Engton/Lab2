using System;

namespace Lab2_2
{
    public delegate int Number();
    public delegate int MediumCalc(Number[] arrayX);
    class Program
    {
        public static int Randomizer()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }

        public static readonly Number n1 = delegate ()
        {
            return Randomizer();
        };
        public static readonly Number n2 = delegate ()
        {
            return Randomizer();
        };
        public static readonly Number n3 = delegate ()
        {
            return Randomizer();
        };
        public static  readonly Number n4 = delegate ()
        {
            return Randomizer();
        };
        public static  readonly Number n5 = delegate ()
        {
            return Randomizer();
        };
        static void Main(string[] args)
        {
            Number[] temp = new Number[5];

            MediumCalc mediumCalc = delegate (Number[] arrayX)
            {
                
                
                arrayX[0] = n1;
                arrayX[1] = n2;
                arrayX[2] = n3;
                arrayX[3] = n4;
                arrayX[4] = n5;
                Console.WriteLine($"{n1.Invoke()} {n2.Invoke()} {n3.Invoke()} {n4.Invoke()} {n5.Invoke()} ");
                int sum = 0;
                int av = (n1.Invoke() + n2.Invoke() + n3.Invoke() + n4.Invoke() + n5.Invoke()) / 5;
                Console.WriteLine(av);
                return av;
            };

            Console.WriteLine(mediumCalc(temp));

            Console.ReadKey();
        }
    }
}
