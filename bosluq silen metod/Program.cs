namespace bosluq_silen_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deleter("salam necesiz");
           
        }
        public static string Deleter(string verilenmetn)
        {
            string boslugsuz = "";
            foreach ( char bosluq in verilenmetn)
            {
                if (bosluq != ' ')
                {
                    boslugsuz += bosluq;
                }
            }
            Console.WriteLine(boslugsuz);

            return boslugsuz;
        }
    }
}

