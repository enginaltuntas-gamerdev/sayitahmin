
namespace sayitahmin;
class sifir_50arasindasayitahmin
{
   
    public static void Main(String[] args)
    {
       Random random=new Random();
       int sayi=random.Next(0,50);
       //Console.WriteLine(sayi);
       int sayac=5;

       for(int i = 1; i <= sayac; i++)
        {
            Console.Write($"{i}. tahmin..: ");
            int tahmin=Convert.ToInt32(Console.ReadLine());
            if(tahmin<sayi){
                Console.WriteLine($"Tahminini Büyüt !! {sayac-i} hakkın kaldı");
                continue;
            }
            else if(sayac==i){
                Console.WriteLine("Tahmin hakkın bitti");
                break;
            }
            else if(tahmin>sayi){
                Console.WriteLine($"Tahminini Küçült !! {sayac-i} hakkın kaldı");
                continue;
            }
            else{
                Console.WriteLine($"Tebrikler {i}. denemede doğru tahmin ettiniz :)"); 
                break;
            }
        }
    }
}
