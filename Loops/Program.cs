namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ust giriniz: ");
            int ust = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi;

            // 2 * 2 * 2
            // for'un 3 bölümü vardır,
            // ilk bölümü değişkenin tanımlandığı bölüm
            // ikinci bölümde koşul gelir
            // üçüncü bölümü, döngü sonunda değişken üzerinde gerçekleşek işlem
            // for (int i = 0; i < 2; i++)
            for (int i = 0; i < ust - 1; i++)
            {
                sonuc *= sayi;
            }

            Console.WriteLine($"Sonuc : {sonuc}");
            */

            /*
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geri sayım başladı...");
            for (int i = sayi; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Bir isim giriniz");
            string isim = Console.ReadLine();

            for (string i = isim; i != string.Empty; i = i.Substring(0, i.Length - 1))
            {
                Console.WriteLine(i);
            }
            

            for (string i = string.Empty; i.Length < isim.Length; i = isim.Substring(0,  i.Length + 1))
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // while döngüsünde koşul doğru olduğu sürece devam eder
            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                sayi--;
            }
            */

            Console.WriteLine("Bir sayi giriniz: ");

            bool parseEdildiMi = false;
            do
            {
                string sayiDegeri = Console.ReadLine();
                int sayi = 0;

                parseEdildiMi = int.TryParse(sayiDegeri, out sayi);

                if (parseEdildiMi)
                {
                    Console.WriteLine($"Girilen sayi: {sayi}");
                }
                else
                {
                    Console.WriteLine("Yanlış girdiniz, lütfen tekrar giriniz:");
                }
            } while (!parseEdildiMi);
        }
    }
}
