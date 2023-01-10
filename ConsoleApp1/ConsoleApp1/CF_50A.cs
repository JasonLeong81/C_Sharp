using Receive_Inputs;

namespace dominoPiling
{
    class CF_50A
    {
        int test()
        {
            int[] dimension = RI.getIntArray();
            int m; int n;
            m = dimension[0]; n = dimension[1];
            int result = (m * n) % (2 * 1);
            int R = result == 0 ? (m * n) / (2 * 1) : ((m * n) - result) / (2 * 1);
            return R;
        }
    }
}