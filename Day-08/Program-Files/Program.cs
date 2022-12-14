using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program2.method3();

            int a = 23, b = 0;
            try
            {
                if (a == b)
                {
                    throw new Exception("\na & b shouldn't be equal!");
                }
                else
                {
                    try
                    {
                        if (b == 0)
                        {
                            throw new Exception("\n b shouldn't be zero");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }

            }
            catch (Exception e) { 
                Console.WriteLine(e.ToString());
                try {
                    if (true) {
                        throw new Exception("\n\nExpression shouldn't be true!");
                    }
                } catch (Exception e1) {
                    Console.WriteLine(e1.ToString());
                }
            }
        }
    }
}