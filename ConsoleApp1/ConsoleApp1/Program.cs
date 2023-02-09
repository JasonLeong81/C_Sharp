using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.XPath;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Security.AccessControl;

using Learn; // for learning purposes

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

        Learning x = new Learning();
        x.test();

        //y.test();

    }

    void test() {
        int a = 0;
    }


    /*
     * 
     */







    public static void print(string str, bool dash=false)
    {
        if (dash)
        {
            Console.WriteLine($"##############333{str}");
        }
        else
        {

        }
        {
            Console.WriteLine(str);
        }
    }

    public static void printArr(int[] arr)
    {
        Console.WriteLine("Start");
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Done");
    }
    public static void print(double? x = null, bool dash = true)
    {
        if (dash)
        {
            Console.Write($"#####################{x}");
        }
        else
        {
            Console.Write($"{x} ");
        }
    }

    public static void d(int? x=null)
    {
        Console.WriteLine($"{x}---------------------------");
    }

    public static int[] getIntArray()
    {
        int[] result = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        return result;
    }
    public static int getInt()
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

    public static long getLong()
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

    public static long[] getLongArr()
    {
        long[] result = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        return result;

    }

}


