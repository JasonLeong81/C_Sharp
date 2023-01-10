using Receive_Inputs;

namespace nextRound
{
    class CF_158A
    {
        public int test()
        {
            int n; int k;
            int[] input = RI.getIntArray();
            n = input[0]; k = input[1];
            int[] inputArr = RI.getIntArray();
            int target = inputArr[k - 1];
            if (target == 0)
            {
                return firstOccurance(target, inputArr, n);
            }
            else
            {
                return lastOccurance(target, inputArr, n);
            }
        }

        int lastOccurance(int target, int[] input, int n)
        {
            int left; int right;
            left = 0; right = n - 1;
            int middle;
            while (left <= right)
            {
                middle = (right + left) / 2;
                if (input[middle] == target)
                {
                    if (middle < n - 1)
                    {
                        if (input[middle + 1] == target)
                        {
                            left = middle + 1;
                        }
                        else if (input[middle + 1] < target)
                        {
                            return middle + 1;
                        }
                    }
                    else if (middle == n - 1)
                    {
                        return n;
                    }
                }

                if (target > input[middle])
                {
                    right = middle - 1;
                }
                if (target < input[middle])
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
        int firstOccurance(int target, int[] input, int n)
        {
            int left; int right;
            left = 0; right = n - 1;
            int middle;
            while (left <= right)
            {
                middle = (right + left) / 2;
                if (input[middle] == target)
                {
                    if (middle > 0) // can't less than left here since left moves. (Test case: 5 5, 5 4 3 0 0)
                    {
                        if (input[middle - 1] == target)
                        {
                            right = middle - 1;
                        }
                        else if (input[middle - 1] > target)
                        {
                            return middle;
                        }
                    }

                    if (middle == 0)
                    {
                        if (input[middle] == target)
                        {
                            return 0;
                        }
                        else if (input[middle] > target)
                        {
                            left = middle + 1;
                        }
                    }
                }


                if (target > input[middle])
                {
                    right = middle - 1;
                }
                if (target < input[middle])
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}