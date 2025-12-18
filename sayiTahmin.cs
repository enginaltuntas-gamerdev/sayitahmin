// Bu projenin kısa hali sayiTahminKisa.cs
namespace sayitahmin;
class sayiTahmin
{
    static int RandomSayi()
    {
        Random rsayi=new Random();
        int sayi=rsayi.Next(100,999);
        return sayi;
    }

    public static void Main(string[] args)
    {
        int tutulan=RandomSayi();
        string tutulanmetin=tutulan.ToString();
        Console.WriteLine(tutulan);
        int s=5;
        for (int a=1;a<=s;a++)
        {
            Console.Write($"\n{a}. Tahmin..:");
            string tsayi=Convert.ToString(Console.ReadLine()??"");
            
            if(tutulanmetin==tsayi){Console.WriteLine("Doğru Tahmin :)"); break;}
            else if(a==s){Console.WriteLine("Tahmin hakkın kalmadı !!");}
            else{
                if (tutulanmetin[0] == tsayi[0])
                {
                    Console.Write("1.Sayının yeri doğru"+"  ");
                    if (tutulanmetin[1] == tsayi[1])
                    {
                        Console.Write("2.Sayının yeri doğru"+"  ");
                    }
                    if (tutulanmetin[2] == tsayi[2])
                    {
                        Console.Write("3.Sayının yeri doğru"+"  ");
                    }
                    continue;
               }
               if (tutulanmetin[1] == tsayi[1])
                {
                    Console.Write("2.Sayının yeri doğru"+"  ");
                    if (tutulanmetin[0] == tsayi[0])
                    {
                        Console.Write("1.Sayının yeri doğru"+"  ");
                    }
                    if (tutulanmetin[2] == tsayi[2])
                    {
                        Console.Write("3.Sayının yeri doğru"+"  ");
                    }
                    continue;
               }
               if (tutulanmetin[2] == tsayi[2])
                {
                    Console.Write("3.Sayının yeri doğru"+"  ");
                    if (tutulanmetin[1] == tsayi[1])
                    {
                        Console.Write("1.Sayının yeri doğru"+"  ");
                    }
                    if (tutulanmetin[0] == tsayi[0])
                    {
                        Console.Write("0.Sayının yeri doğru"+"  ");
                    }
                    continue;
               }
            }
        }
    }
}
