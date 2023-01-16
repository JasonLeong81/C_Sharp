using Receive_Inputs;

namespace Scuza
{
    class CF_1742E
    {
        void test()
        {
            int test_cases = RI.getInt();
            while (test_cases-- > 0)
            {
                long num_stairs; long num_questions;
                long[] input = RI.getLongArr();
                long[] stairs = RI.getLongArr();
                long[] questions = RI.getLongArr();
                num_stairs = input[0]; num_questions = input[1];


                long[] precom = Enumerable.Repeat(0L, (int)num_stairs).ToArray();
                precom[0] = stairs[0];

                for (int i = 0; i < num_stairs; i++)
                {
                    if (i > 0)
                    {
                        precom[i] = precom[i - 1] + stairs[i];
                    }
                }

                for (int i = 0; i < num_stairs; i++)
                {
                    if (i > 0)
                    {
                        stairs[i] = Math.Max(stairs[i], stairs[i - 1]);
                    }
                }

                foreach (long i in questions)
                {
                    int result = binarySearch_LastOccurance(stairs, i);
                    if (result >= 0)
                    {
                        RI.print(precom[result], false);
                    }
                    else
                    {
                        RI.print(0, false);
                    }
                }
                Console.WriteLine(' ');

            }



        }
        /// <summary>
        /// Returns the index of the last occurance of k 
        /// </summary>
        /// <param name="stairs"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int binarySearch_LastOccurance(long[] stairs, long k)
        {
            int left; int right;
            left = 0; right = stairs.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (stairs[middle] <= k)
                {
                    if (middle < stairs.Length - 1)
                    {
                        if (stairs[middle + 1] <= k)
                        {
                            left = middle + 1;
                        }
                        else
                        {
                            return middle;
                        }
                    }
                    else
                    {
                        return middle;
                    }
                }
                else if (stairs[middle] > k)
                {
                    right = middle - 1;
                }

            }

            return -1; // -1 out here means not found 
        }
    }
}