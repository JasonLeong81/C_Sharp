// Learn 1 uses some topics (in dataStructures) and Program.cs will use Learn 1 
using dataStructures;

namespace Learn
{
    public class Learning
    {
        public void test()
        {
            DS x = new DS();

            x.DICTIONARY();
            x.LIST();
            x.HASH_SET();
            x.t();
        }
    }
}

/*
1) Appending to an array -> initialize it with n (where n is what you want) zero elements (new int[]) then change the values 

2) 
2 5 1 3 4 7 -- #elements is "upper bound" but index is "lower bound" - as long as we round down  -> if we round up then index gives us the upper bound and #elements doesn't change
1 2 3 -- #elements and index is the same, gives us the middle - as long as we round down -> if we round up then #elements give us one index higher
than the middle but index gives us the middle

3) <string>.Length, <string>.substring(startIndex, Length_inclusiveOfStart) -> similar to range in python (start,length_exclusiveOfEnd), 

4) Lists, Dictionary, Hash Sets -> Common data structures 

5) 
*/