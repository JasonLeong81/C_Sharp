using Receive_Inputs;

namespace helpfulMaths
{
    class CF_339A
    {
        string test_manual()
        {
            int[] s = Array.ConvertAll(Console.ReadLine().Split('+'), int.Parse);
            string ss = "";
            s = quickSort(s, 0, s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    ss += s[i];
                    break;
                }
                ss += $"{s[i]}+";
            }
            return ss;
        }

        int partition(int[] s, int low, int high)
        {
            int ii = low - 1;
            int pivot = high - 1; // choosing the last element as pivot 
            for (int j = low; j < high - 1; j++)
            {
                if (s[j] < s[pivot])
                {
                    ii++;
                    int temp = s[ii]; // swap i and j here
                    s[ii] = s[j];
                    s[j] = temp;
                }
            }
            int temp_ = s[ii + 1]; // swap pivot and ii+1 here 
            s[ii + 1] = s[pivot];
            s[pivot] = temp_;

            return ii + 1; // index of pivot 
        }

        int[] quickSort(int[] s, int low, int high)
        {
            if (low < high - 1)
            {
                int pivot = partition(s, low, high);
                s = quickSort(s, low, pivot); // left // here is not pivot-1 because our high is not last index but rather len of list
                s = quickSort(s, pivot + 1, high); // right
                return s;
            }
            else
            {
                return s;
            }
        }





        string test()
        {
            int[] s = Array.ConvertAll(Console.ReadLine().Split('+'), int.Parse);
            Array.Sort(s);
            string ss = "";
            //foreach(char c in s){
            //    ss += "c+";
            //}
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    ss += $"{s[i]}";
                    break;
                }
                ss += $"{s[i]}+";
            }
            return ss;
        }
    }
}