namespace elave_tapsiriq_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cuteded(new int[] {1,2,3,4,5,6,7,8,9,10,34,56,});
            
        }
        public static void cuteded(int[] array)
        {
            int cuteded = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    cuteded += i;
                }
            }
                 Console.WriteLine(cuteded);
        }
    }   
}
