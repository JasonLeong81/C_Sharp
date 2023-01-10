using Receive_Inputs;

namespace elephant
{
    class CF_617A
    {
        int test()
        {
            int dst = RI.getInt();
            int r = 0;
            while (dst > 0)
            {
                for (int i = 5; i > 0; i--)
                {
                    if (dst >= i)
                    {
                        r += dst / i;
                        dst %= i; // dst takes the remainder 
                    }
                }
            }
            return r;
        }
    }
}