using Receive_Inputs;

namespace soldierAndBananas
{
    class CF_546A
    {
        int test()
        {
            int[] inputs = RI.getIntArray();
            int cost_first = inputs[0]; int initial_capital = inputs[1]; int num_wants = inputs[2];
            int total_cost_neeeded = ((num_wants * (num_wants + 1)) / 2) * cost_first;
            return total_cost_neeeded > initial_capital ? total_cost_neeeded - initial_capital : 0;
        }
    }
}