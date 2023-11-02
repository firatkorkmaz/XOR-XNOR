/* Implementing XOR and XNOR by Using (^) and (^!) Operators */

using System;

namespace XOR_XNOR
{
    class XOR_XNOR
    {
        static void Main(string[] args)
        {

            int[][] code = new int[][] {new int[] { 0, 0 },
                                        new int[] { 0, 1 },
                                        new int[] { 1, 0 },
                                        new int[] { 1, 1 } };

            Console.WriteLine();
            Console.WriteLine("# XOR LOGIC GATE #");
            Console.WriteLine("X ^ Y = X'.Y + X.Y'\n");
            Console.WriteLine("X  Y  |  Result");
            Console.WriteLine("------|---------");

            for (int i = 0; i < 4; i++)
            {
                Console.Write(code[i][0] + "  " + code[i][1]);
                Console.Write("  |  ");

                if ((code[i][0] == 1) ^ (code[i][1] == 1))          // (^) is Applied to Boolean Values
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }

            Console.WriteLine("\n===================\n");


            Console.WriteLine("# XNOR LOGIC GATE #");
            Console.WriteLine("X ^! Y = X.Y + X'.Y'\n");
            Console.WriteLine("X  Y  |  Result");
            Console.WriteLine("------|---------");

            for (int i = 0; i < 4; i++)
            {
                Console.Write(code[i][0] + "  " + code[i][1]);
                Console.Write("  |  ");

                if ((code[i][0] == 1) ^! (code[i][1] == 1))         // (^!) is Applied to Boolean Values
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }


            Console.Write("\n\n-------------");
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
