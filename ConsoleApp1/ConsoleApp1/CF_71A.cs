namespace wayTooLongWords
{
    class CF_71A
    {
        public string test(string word)
        {
            if (word.Length > 10)
            {
                string temp = "";
                temp += word[0] + (word.Length - 2).ToString() + word[word.Length - 1];
                return temp;
            }
            return word;
        }
    }
}

/*
        string aa;
        //Console.WriteLine(aa.GetType()); 
        int start = 0;
        int num_words;
        string result;
        bool temp = int.TryParse(Console.ReadLine(), out num_words); // out is must, int is cannot, and ref is maybe

        while (start < num_words)
        {
            aa = Console.ReadLine();
            result = y.test(aa);
            Console.WriteLine(result);
            start++;

        }
 */
