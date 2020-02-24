using System;

namespace SwapIntegers
{
    public class IntSwap
    {
        public static void Swap( ref int x, ref int y)
        {
            y = x + y;
            x = y - x;
            y = y - x;
        }
    }
}
