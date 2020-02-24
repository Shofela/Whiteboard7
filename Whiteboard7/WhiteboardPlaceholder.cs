using System;

// this is the default startup project
namespace Whiteboard7
{
    class WhiteboardPlaceholder
    {
        public static void CheckPrime()
        {
            int i = 100;
            Console.WriteLine("checking.");

            while (true)
            {
                if ( PrimeNumbers.Prime.IsPrime(++i) )
                {
                    Console.WriteLine(i + ", ");
                }
            }
        }
        static void Main()
        {
            Console.WriteLine(
                "\n\n\n\tHa! there's nothing here\n" +
                "\tDid you mean to run this?" +
                "\n\tMaybe set a different startup project?" +
                "\n\n\n\n"
            );
            // CheckPrime();
        }
    }
}
