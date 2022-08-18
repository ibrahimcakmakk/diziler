using System;

class Program
{
    static void Main(string[] args)
    {
        //Dizi tanımı
        string[] renkler = new String[5];

        string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

        int[] dizi;
        dizi = new int[5];

        renkler[0] = "mavi";
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //döngülerle dizi kullanımı

        Console.Write("lütfen dizinin eleman sayısını giriniz");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayıDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("lütfen {0}. sayısı giriniz" ,i+1);
            sayıDizisi[i] = int.Parse(Console.ReadLine());

        }
        int toplam = 0;
        foreach (var sayi in sayıDizisi)
        {
            toplam += sayi; 
        }
        Console.WriteLine("ortalama : " + toplam/diziUzunlugu);
    }
}
