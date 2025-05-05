namespace elave_tapsiriq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ededaraliqi(3, 5);
        }
    
         public static void ededaraliqi(int n, int m)
        {
            int cemtek = 0;
            for (int i= n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    cemtek++;
                }
            }
            Console.WriteLine(cemtek);
        }
    }
}
