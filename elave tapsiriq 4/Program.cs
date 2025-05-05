namespace elave_tapsiriq_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapsiriq 4
            sadeeded(9);
        }

        public static void sadeeded(int n)
        {
            bool isMurekkeb = false;
           for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    isMurekkeb = true;
            }
            if (isMurekkeb)
            {
                Console.WriteLine("Murekkeb");
            }
            else
            {
                Console.WriteLine("Sade");
            }
        }
    }
}