namespace arraya_elave_veriable_elave_etmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapsiriq 4


        }
        public static int[] Elave(int[] elave, int a)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < elave.Length; i++)
            {
                sum1 += elave[i];
            }
            for (int y = 0; y < elave.Length; y++)
            {
                sum2 += elave[y];

                sum1 = sum2 - a;
            }
            Console.WriteLine(sum2);
            return elave;



        }
    }