using System;
using System.Xml.XPath;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Security.AccessControl;


class Hello
{
    static void Main(string[] args)
    {
        // Main is not required to be placed inside a class. 
        //CF_158A x = new CF_158A();
        //Console.WriteLine(x.test());


        Hello y = new Hello();
        //var a = y.test(); // compiler will infer the first value type 
        //Console.WriteLine(a);

        y.test();


    }

    void test()
    {
        int t = getInt();

        while(t --> 0){
            int n = getInt();
            int[] input = getIntArray();
            int result = 1;
            foreach(int i in input)
            {
                result *= i;
            }
        }
    }




    void print(double? x = null)
    {
        Console.WriteLine($"{x}---");
    }

    void d(int? x=null)
    {
        Console.WriteLine($"{x}---------------------------");
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
            throw new Exception("getInt is invalid.");
        }
    }

    long getLong()
    {
        long result;
        bool valid = long.TryParse(Console.ReadLine(), out result);
        if (valid)
        {
            return result;
        }
        else
        {
            throw new Exception("getUlong is invalid.");
        }
    }

}


