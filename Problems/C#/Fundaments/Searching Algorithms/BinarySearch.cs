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
            var position = this.array.Length % 2 == 0 ? (this.array.Length / 2) - 1 : (this.array.Length - 1) / 2;
            var middle = this.array[position];

            if (middle < value)
            {
                for (int i = position; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        return i;
                    }
                }
            }
            else if (middle > value)
            {
                for (int i = position; i > 0; i--)
                {
                    if (array[i] == value)
                    {
                        return i;
                    }
                }
            }
            else if (middle == value)
            {
                return position;
            }

            return -1;
        }
    }
}
