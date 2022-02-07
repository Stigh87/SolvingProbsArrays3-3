using System;

namespace Oppgave_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            int[] arrayB = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, };
            Console.WriteLine("Hvilke array er sortert i stigende rekkeølge? A eller B?");

            string X = Console.ReadLine().ToUpper();

            CheckArrayA(arrayA, X);
            CheckArrayB(arrayB, X);

        }

        private static void CheckArrayB(int[] arrayB, string X)
        {
            if (X == "B")
            {
                int check = arrayB[0] - 1;
                for (int i = 0; i < arrayB.Length; i++)
                {

                    if (check < arrayB[i])
                    {
                        check = arrayB[i];
                        if (check == arrayB[9])
                        {
                            Console.WriteLine("Riktig");
                        };
                    }
                    else
                    {
                        Console.WriteLine("Array B er ikke sortert");
                        return;
                    }
                }
            }
        }

        private static void CheckArrayA(int[] arrayA, string X)
        {
            if (X == "A")
            {
                int check = arrayA[0] - 1;
                for (int i = 0; i < arrayA.Length; i++)
                {

                    if (check < arrayA[i])
                    {
                        check = arrayA[i];
                        if (check == arrayA[9])
                        {
                            Console.WriteLine("Arrayet er sortert stigende rekkefølge");
                        };
                    }
                    else
                    {
                        Console.WriteLine("Arrayet er IKKE sortert");
                    }
                }
            }
        }

    }
}
