using Receive_Inputs;

namespace divisibilityBy2N
{
    class CF_1744D
    {
        void test()
        {
            int t = RI.getInt();

            while (t-- > 0)
            {
                int n = RI.getInt();
                int[] input = RI.getIntArray();
                int result = 0; // how many 2 do i have so far 
                for (int i = 0; i < n; i++)
                // get the number of 2s we have 
                {
                    int temp = input[i];
                    while (temp % 2 == 0)
                    {
                        temp = temp / 2;
                        result++;
                    }

                }
                int missing = n - result; // how many more 2s do we need

                int count = 0; // how many operations we need, minimum 
                List<int> twoGenerator = new List<int>();

                for (int i = 1; i < n + 1; i++)
                // how many two's are each index going to add and then sort them in descending order
                {
                    if (i % 2 == 0)
                    {
                        int temp = i;
                        int temp_ = 0;
                        while (temp % 2 == 0)
                        {
                            temp = temp / 2;
                            temp_++;
                        }
                        twoGenerator.Add(temp_);
                    }
                    else
                    {
                        twoGenerator.Add(0);
                    }
                }
                twoGenerator.Sort();
                twoGenerator.Reverse();
                foreach (int i in twoGenerator)
                {
                    if (missing > 0)
                    {
                        int temp_ = missing;
                        missing -= i;
                        count = missing < temp_ ? count + 1 : count; // for EC len(arr) = 1 
                    }
                }

                if (missing <= 0) // it could be negative, other 2s are just scalars
                {
                    RI.print(count);
                }
                else
                {
                    RI.print(-1);
                }

            }
        }
    }
}