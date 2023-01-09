using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
//using Team;


class Hello
{
    static void Main(string[] args)
    {
        // Main is not required to be placed inside a class. 
        //CF_231A x = new CF_231A();
        //Console.WriteLine(x.test());


        Hello y = new Hello();
        string a = y.test();
        Console.WriteLine(a);


    }

    string test()
    {
        return "0";
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


