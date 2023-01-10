namespace Receive_Inputs
{
    public class RI
    {
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
                throw new Exception("Valid is invalid.");
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
    }
}