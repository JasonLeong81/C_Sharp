using Receive_Inputs;

namespace Incinerate
{
    class CF_1763B
    {

        void test()
        {

            int tc = RI.getInt();
            while (tc-- > 0) // this means the loop will run as long as tc is greater than 0, decrementing tc every loop
            {
                int[] input = RI.getIntArray();
                int n; int k;
                n = input[0]; k = input[1];
                int[] health = RI.getIntArray();
                int[] power = RI.getIntArray();
                // KeyValuePair<string, int> person = new KeyValuePair<string, int>("John Smith", 42);

                Array.Sort(power, health); // sort in terms of power, since the condition is that we want the weakest monster 

                int totalDamage = k;
                int i = 0;
                while (i < n && k > 0)
                {
                    if (health[i] > totalDamage) // basically saying who (the next weakest mosnter) is going to survive the next attack
                    {
                        k = Math.Max(0, k - power[i]); // decrease power 
                        totalDamage += k; // increase total damage 
                    }
                    else
                    {
                        i++;
                    }
                }
                if (totalDamage >= health.Max())
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}