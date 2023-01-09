using Receive_Inputs;

namespace Team
{
    class CF_231A
    {
        public int test()
        {
            // decimal m > float f
            int start = 0;
            int rows = RI.getInt(); // get the number of test cases 
            int solve = 0;
            while (start < rows)
            {
                int[] input = RI.getIntArray();
                int temp = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    temp += input[i];
                }

                if (temp / 3f > 0.5f) // if more than half of them know the solution then we increment "solve"
                {
                    solve++;
                }
                start++;
            }
            return solve;
        }
    }
}