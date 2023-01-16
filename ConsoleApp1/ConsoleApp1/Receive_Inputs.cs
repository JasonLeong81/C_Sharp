namespace Receive_Inputs
{
    public class RI
    {

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

        public static void d(int? x = null)
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
}