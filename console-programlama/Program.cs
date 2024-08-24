using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(String[] args)
        {
           //1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        //    Console.Write("Diziye kaç eleman gireceksiniz: ");
        //    int n=int.Parse(Console.ReadLine());
        //    int[] dizi=new int[n];
        //    for(int i=0; i<n; i++){
        //     Console.Write($"{i+1}. elemanı giriniz: ");
        //     int sayi=int.Parse(Console.ReadLine());
        //     dizi[i]=sayi;
        //    }
        //    Console.WriteLine("------------Çift sayılar------------");
        //    foreach(int eleman in dizi){
        //     if(eleman%2==0){
        //         Console.WriteLine(eleman);
        //     }
        //    }



        //2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        // Console.Write("Bir sayı giriniz: ");
        // int n=int.Parse(Console.ReadLine());
        // Console.Write("Bir sayı giriniz: ");
        // int m=int.Parse(Console.ReadLine());
        // int[] dizi=new int[n];
        // for(int i=0; i<n; i++){
        //      Console.Write($"{i+1}. elemanı giriniz: ");
        //      int sayi=int.Parse(Console.ReadLine());
        //      dizi[i]=sayi;
        // }
        // Console.WriteLine("--------------------");
        // foreach(int eleman in dizi){
        //     if(m%eleman==0){
        //         Console.WriteLine(eleman);
        //     }
        // }



        //3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        // Console.Write("Diziye kaç eleman gireceksiniz: ");
        // int n=int.Parse(Console.ReadLine());
        // int[] dizi=new int[n];
        // for(int i=0; i<n; i++){
        //     Console.Write($"{i+1}. elemanı giriniz: ");
        //       int sayi=int.Parse(Console.ReadLine());
        //       dizi[i]=sayi;
        // }
        // Console.WriteLine("--------Sıralama----------");
        // for(int i=dizi.Length-1; i>=0; i--){
        //     Console.WriteLine(dizi[i]);
        // }




        //4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        // Console.Write("Bir cümle giriniz: ");
        // String metin=Console.ReadLine();
        // String[] kelime=metin.Split(' ');
        // int kelimeSayisi=metin.Trim().Split(' ').Length;
        // Console.WriteLine(kelimeSayisi);
        // int harfSayisi=0;
        // for(int i=0; i<metin.Length; i++){
        //     if(metin[i]==' '){
        //         continue;
        //     }else{
        //         harfSayisi++;
        //     }
        // }
        // Console.WriteLine(harfSayisi);

        //5.Console Girilen Cümlede En Fazla Kullanılan Harfi ve Sayısını Bulma
        int mak = 0;
            int son=0;
            Console.WriteLine("Cümleyi Girin :");
            Console.WriteLine("==========================================");
            String metin = Console.ReadLine();
            metin = metin.ToLower();
            String karakterler = "0123456789abcdefghijklmnopqrstuvwxyz.?,;";
            int[] count = new int[karakterler.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakterler[i] + " " + count[i]);
                }
            }
 
            //En fazla bulunan harf sayısı
            for (int i = 1; i < count.Length; i++)
            {
                if (mak < count[i])
                { 
                    mak = count[i];
                    son = i; //Harf sayısı en fazla olan index numarası
                }
                    
            }   
            Console.WriteLine("En fazla olan karakter : " + karakterler[son] + ", sayısı " + mak);
            Console.ReadKey();
        }  
    }
}