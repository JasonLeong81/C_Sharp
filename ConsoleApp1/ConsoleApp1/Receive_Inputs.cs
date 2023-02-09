namespace Receive_Inputs
{
    public class RI
    {
        /// <summary>
        /// This method is for integer printing 
        /// </summary>
        /// <param name="integer"></param>
        /// <param name="dash"></param>
        public static void print(int? integer, bool dash = false)
        {
            if (dash)
            {
                Console.WriteLine($"Integer print: {integer}");
            }
            else
            {
                Console.WriteLine(integer);
            }
        }


        /// <summary>
        /// This method is for string printing 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="dash"></param>
        public static void print(string str, bool dash = false)
        {
            if (dash)
            {
                Console.WriteLine($"String print: {str}");
            }
            else
            {
                Console.WriteLine(str);
            }
        }
        /// <summary>
        /// This method is for integer array printing 
        /// </summary>
        /// <param name="arr"></param>
        public static void printArr(int[] arr)
        {
            Console.WriteLine("Start Int Array Print");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Done Int Array Print");
        }
        /// <summary>
        /// This method is for nullable double printing  
        /// </summary>
        /// <param name="x"></param>
        /// <param name="dash"></param>
        public static void print(double? x = null, bool dash = false)
        {
            if (dash)
            {
                Console.Write($"Double print: {x}");
            }
            else
            {
                Console.Write($"{x}");
            }
        }

        /// <summary>
        /// This method is to get integer array input via space seperator 
        /// </summary>
        /// <returns></returns>
        public static int[] getIntArray()
        {
            int[] result = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            return result;
        }
        /// <summary>
        /// This method is to get integer input 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// This method is to get long input 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// This method is to get long array input via empty space 
        /// </summary>
        /// <returns></returns>
        public static long[] getLongArr()
        {
            long[] result = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            return result;

        }
    }
}