using Receive_Inputs;

namespace addPlusMinusSign
{
    class CF_1774A
    {
        string test()
        {
            // Explicity casting -> large to small
            // Implicit casting -> small data type size to large

            /*
             If the number of 1s is even then the minimum is 0, we will give half the ones with + and the other with -.
             If the number of 1s is odd, then the minimum is 1 so we can give the last 1 either a + or - since the answer will be absolute anyway.

             If a result is > 0, then we + else we -. Since its always just 0 or 1.
             */

            int result = 0;
            string result_r = "";

            int start = 0;
            int rows = RI.getInt();
            while (start < rows)
            {
                int data_length = RI.getInt();
                string input = Console.ReadLine();
                result += (int)(char.GetNumericValue(input[0]));
                for (int i = 1; i < data_length; i++)
                {
                    int c = (int)(char.GetNumericValue(input[i]));
                    // int c = (int)input[i]; // implicit casting, gives us the unicode for a numeric character
                    if (result > 0)
                    {
                        result -= c;
                        result_r += "-";
                    }
                    else
                    {
                        result += c;
                        result_r += "+";
                    }
                }
                start++;
                if (start < rows)
                {
                    result_r += "\n";
                }
                result = 0;
            }
            return result_r;
        }
    }
}