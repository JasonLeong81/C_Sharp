using Receive_Inputs;

namespace bitPlusPlus
{
    class CF_282A
    {
        int test()
        {
            int rows = RI.getInt();
            int start = 0;
            string instruction;
            int temp = 0;
            while (start < rows)
            {
                instruction = Console.ReadLine();
                if (instruction[1] == '+')
                {
                    temp++;
                }
                else
                {
                    temp--;
                }
                start++;
            }
            return temp;
        }
    }
}