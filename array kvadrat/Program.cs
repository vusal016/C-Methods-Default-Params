namespace array_kvadrat
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Tapsiriq 2
            int[] ededler = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 76 };

            Kvadrat(ededler);


        }


        public static void Kvadrat(int[] ededler)
        {
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] *= ededler[i];
            }
            foreach (int eded in ededler)
            {
                Console.WriteLine(eded);
            }

        }
    }
}
