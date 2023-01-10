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

    string test()
    {
        return "hi";
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


