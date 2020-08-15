namespace Interview_Prep.Fundaments.SearchingAlgorithms
{
    public class BinarySearch
    {
        private readonly int[] array;
        public BinarySearch(int[] array)
        {
            this.array = array;
        }

        public int Execute(int value)
        {
            var start = 0;
            var end = this.array.Length;

            while (start < end)
            {
                var middle = (start + end) / 2;

                if (this.array[middle] < value)
                {
                    start = middle + 1;
                }
                else if (this.array[middle] > value)
                {
                    end = middle - 1;
                }
                else
                {
                    return start;
                }
            }

            return -1;
        }
    }
}
