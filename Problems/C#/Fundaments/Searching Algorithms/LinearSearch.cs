namespace Interview_Prep.Fundaments.SearchingAlgorithms
{
    public class LinearSearch
    {
        private readonly int[] array;

        public LinearSearch(int[] array)
        {
            this.array = array;
        }

        public int Execute(int value) 
        {
            var position = -1;

            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i] == value)
                {
                    return i;
                }
            }

            return position;
        }
    }
}
