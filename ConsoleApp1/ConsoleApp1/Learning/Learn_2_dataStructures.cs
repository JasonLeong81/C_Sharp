using System.Collections.Generic;
using Receive_Inputs;

namespace dataStructures
{
    public class DS
    {
        public void DICTIONARY()
        {
            Dictionary<string, int> x = new Dictionary<string, int>() { { "Yean",10} };
            x.Add("Jason",19);
            x.Add("Leong", 20);
            x.Remove("Leong");
            x.Clear();
            foreach(KeyValuePair<string,int> kvp in x)
            {
                RI.print(kvp.Key);
                RI.print(kvp.Value);
            }

            // RI.print(x.Count); // Count is an attribute 
            
            
        }

        public void LIST() 
        { 
            List<string> x = new List<string>();
            x.Add("Jason");
            x.Add("Leong");
            x.Add("Chor");

            x.Remove("Jason"); // removes value 
            x.RemoveAt(0); // removes on index

            x.Clear();
            foreach (string s in x) {
                RI.print(s);
            }
        }

        public void HASH_SET()
        {
            HashSet<string> x = new HashSet<string>();

            x.Add("Jason");
            x.Add("Leong");
            x.Add("Jason"); // No errors but will not be included 
            x.Add("Yew");

            x.Remove("Jason"); 

            x.Clear();
            foreach(string s in x)
            {
                RI.print(s);
            }
        }


        public void t()
        {

        }









    }
}

/*
1) Hash Sets: 

2) List: 

3) Dictioanry: 


 */