using System.Collections;
namespace sayitahmin;
class sayiTahminKisa
{
    static int RandomSayi()
    {
        Random rsayi=new Random();
        int sayi=rsayi.Next(100,999);
        return sayi;
    }
    public static void Main(String[] args)
    {
        int t=RandomSayi();
        string tsayi1=t.ToString();
        Console.WriteLine(tsayi1);
        int s=5;
        for(int b = 1; b <= s; b++)
        {
            Console.Write($"\n{b}.tahmin..:");
            string girilensayi=Console.ReadLine()??" ";
            if (girilensayi==tsayi1){Console.WriteLine("Doğru tahmin");break;}
            else if(s==b){Console.WriteLine("Tahmin hakkı bitti");}
            else{
                for(int i = 0; i < tsayi1.Length; i++)
                {
                    if (tsayi1[i] == girilensayi[i])
                    {
                        Console.Write($"{i+1}. sayının yeri doğru / ");
                    }
                }
            }
        }
        
    }
}
