
namespace elave_tapsiriq_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapsiriq 3
            araliqteksayi(7,18);
        }

        public static void araliqteksayi(int n, int m)
        {
            int tekcem = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    tekcem += i;
                }
            }
               Console.WriteLine(tekcem);

        }




    }
    }
