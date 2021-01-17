/*
*Toplama işlemi öğrenmeye çalışan bir oyun programı yazılacaktır.

*Oyun başladığı zaman rastgele 2 tane 1-100 arasında sayı tutulacak, tutulan sayılar ekranda gösterilecek ve kullanıcıya bu sayıların bu sayıların toplamı nedir diye sorulacak

*Eğer kullanıcı doğru cevap verirse "Tebrikler Bildiniz" değil ise "Üzgünüm Bilemediniz" diye mesaj verilecektir.

*Her cevaptan sonra "Tekrar oynamak istiyor musunuz(e/E)?" şeklinde soru sorulacak ve eğer kullanıcı "e" veya "E" ile karşılık verirse oyun tekrar başlayacaktır.

*Kullanıcının puanı her doğru cevap için 5 puan artacak, her yanlış cevap için ise 2 puan azalacaktır.

*Oyun sonlandığında kullanıcının verdiği doğru cevap sayısı, yanlış cevap sayısı ve puanı ekranda listelenmektedir.

*Bu işlemleri yapan programın kodlarını yazınız.
*/

using System;

namespace AdditionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int kullaniciToplami, toplam, kullaniciPuani = 0, dogruCevapSayisi = 0, yanlisCevapSayisi = 0;
            char tercih;

            do
            {
                int sayi1 = random.Next(1, 101);
                int sayi2 = random.Next(1, 101);

                Console.WriteLine("Sayıların toplamını bulunuz: {0} + {1} = ?", sayi1, sayi2);

                kullaniciToplami = int.Parse(Console.ReadLine());
                toplam = sayi1 + sayi2;

                if (toplam == kullaniciToplami)
                {
                    Console.WriteLine("Tebrikler Bildiniz");

                    kullaniciPuani += 5;

                    dogruCevapSayisi++;
                }

                else
                {
                    Console.WriteLine("Üzgünüm Bilemediniz");

                    kullaniciPuani -= 2;

                    yanlisCevapSayisi++;
                }

                Console.WriteLine("Tekrar oynamak istiyor musunuz? Evet ise (e/E) yazınız, hayır ise (h/H) yazınız");
                tercih = char.Parse(Console.ReadLine());
            } while (tercih == 'e' || tercih == 'E');

            if (tercih == 'h' || tercih == 'H')
            {
                Console.WriteLine("Doğru cevap sayınız : {0} , Yanlış cevap sayınız : {1} , Oyun sonu puanınız : {2}", dogruCevapSayisi, yanlisCevapSayisi, kullaniciPuani);
            }

            else
            {
                Console.WriteLine("Varsayılmayan Durum");
            }
        }
    }
}
