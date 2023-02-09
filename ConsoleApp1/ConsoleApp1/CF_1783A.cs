using Receive_Inputs;


namespace makeItBeautiful
{
    class CF_1783A
    {
        void test()
        {
            // put the largest number in front, so any other number will not have the prefix sum requirement satisfied. 
            // Only case where this wont work is if the max and min of the array is the same, like 1 1 1 1 1, in this case we're going to return NO
            int tc = RI.getInt();
            while (tc-- > 0)
            {
                int n = RI.getInt();
                int[] input = RI.getIntArray();
                if (input[0] == input[input.Length - 1])
                {
                    RI.print("NO");
                }
                else
                {
                    RI.print("YES");
                    Console.Write(input[input.Length - 1]);
                    Console.Write(' ');
                    for (int i = 0; i < input.Length - 1; i++)
                    {
                        Console.Write(input[i]);
                        Console.Write(' ');
                    }
                }





            }

        }
    }
}