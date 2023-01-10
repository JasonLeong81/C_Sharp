using Receive_Inputs;

namespace calculatingFunction
{
    class CF_486A
    {
        long test()
        {
            /*
             var d  = 1.0d;  // double
            var d0 = 1.0;   // double
            var d1 = 1e+3;  // double
            var d2 = 1e-3;  // double
            var f  = 1.0f;  // float
            var m  = 1.0m;  // decimal
            var i  = 1;     // int
            var ui = 1U;    // uint
            var ul = 1UL;   // ulong
            var l  = 1L;    // long
             */
            long input = RI.getLong();
            if (input % 2 == 0)
            {
                return input / 2L;
            }
            else
            {
                return ((input - 1L) / 2L) - input;
            }
        }
    }
}