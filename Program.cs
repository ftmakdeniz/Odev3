//for (int i = 1; i <= 7; i++)
//{
//    for (int j = 1; j <= 7 - i; j++)
//    {
//Console.Write(" ");
//    }
//    for (int k = 1; k <= 2 * i - 1; k++)
//{
//Console.Write("*");
//}
//Console.WriteLine();
//}

//for (int i = 13; i >= 1; i--)
//{
//for (int j = 1; j <= i; j++)
//{
//Console.Write("*");
//}
//Console.WriteLine();

//}

//string name = "FATMA";

//for (int i = 0; i < name.Length; i++)
//{
//Console.WriteLine(name[i]);
//}


//for (int i = 1; i <= 13; i++)
//{
//for (int j = 1; j <= i; j++)
//{
//Console.Write("*");
//}
//Console.WriteLine();
//}


using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç adet ürün gireceksiniz? ");
        int urunSayisi = int.Parse(Console.ReadLine());

        string[] urunIsimleri = new string[urunSayisi];
        decimal[] urunFiyatlari = new decimal[urunSayisi];

        for (int i = 0; i < urunSayisi; i++)
        {
            Console.Write($"Ürün {i + 1} adı: ");
            urunIsimleri[i] = Console.ReadLine();

            Console.Write($"Ürün {i + 1} fiyatı: ");
            urunFiyatlari[i] = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Ürünlerin Listesi ve Fiyatları:");
        
        decimal toplamFiyat = 0;
        for (int i = 0; i < urunSayisi; i++)
        {
            toplamFiyat += urunFiyatlari[i];
        }

        Console.WriteLine($"Toplam Fiyat: {toplamFiyat:C}");
    }
}
