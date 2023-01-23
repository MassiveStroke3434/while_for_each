using System;

namespace while_for_each;
class Program
{
    static void Main(string[] args)
    {
        // 1 den başlayarak console'da girilen sayıya kadar ortalama hesaplama hesaplayıp consola yazdıran program
        Console.WriteLine("Please enter a number");
        int sayi = int.Parse(Console.ReadLine());
        int sayac =1;
        int overall = 0;
        while (sayac<=sayi)
        {
            overall+= sayac;
            sayac++;
        }
        Console.WriteLine(overall/sayi);
        char character = 'a';
        while (character<'z')
        {
            Console.WriteLine(character);
            character++;
        }
        Console.WriteLine("***Foreach***");
        string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
