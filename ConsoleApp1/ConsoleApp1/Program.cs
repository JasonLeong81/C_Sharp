using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
//using Team;


class Hello
{
    static void Main(string[] args)
    {
        // Main is not required to be placed inside a class. 
        //CF_231A x = new CF_231A();
        //Console.WriteLine(x.test());


        Hello y = new Hello();
        var a = y.test(); // compiler will infer the first value type 
        Console.WriteLine(a);


    }

    int test()
    {
        int n; int k;
        int[] input = getIntArray();
        n = input[0]; k = input[1];
        int[] inputArr = getIntArray();
        int target = inputArr[k-1];
        if(target == 0)
        {
            return firstOccurance(target, inputArr,n);
        }
        else
        {
            return lastOccurance(target, inputArr,n);
        }
    }

    int lastOccurance(int target, int[] input,int n)
    {
        int left; int right;
        left = 0; right = n-1;
        int middle;
        while(left <= right)
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
                else if(middle == n -1)
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
        left = 0; right = n-1;
        int middle;
        while(left <= right )
        {
            middle = (right + left) / 2;
            if (input[middle] == target)
            {
                if(middle > 0)
                {
                    if (input[middle-1] == target)
                    {
                        right = middle - 1;
                    }
                    else if (input[middle-1] > target)
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






    void d()
    {
        Console.WriteLine("---------------------------");
    }

    int[] getIntArray()
    {
        int[] result = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        return result;
    }
    int getInt()
    {
        int result;
        bool valid = int.TryParse(Console.ReadLine(), out result);
        if (valid)
        {
            return result;
        }
        else
        {
            throw new Exception("Valid is invalid.");
        }
    }

}


