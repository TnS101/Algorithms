using System.Collections.Generic;

namespace Interview_Prep.Problems
{
    public class CountrTripplets
    {
        public long Exe(List<long> arr)
        {
            if (arr.Count < 3)
            {
                return 0;
            }

            var set = new HashSet<long>(arr);
            var right = 2 * (arr.Count - set.Count);

            return arr.Count - 2 * right + arr.Count - right;
        }
    }
}
