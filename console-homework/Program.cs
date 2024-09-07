using System.Collections;

namespace console_homework{
    class Program{
        public static void Main(string[] args){
           
            /*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            Negatif ve numeric olmayan girişleri engelleyin.

            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.

            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */

            ArrayList asalList=new ArrayList();
            ArrayList asalOlmayanList=new ArrayList();
            for(int i =0; i<20; i++){
                try
                {
                    Console.Write($"{i+1}. sayıyı giriniz : ");
                    int sayi=int.Parse(Console.ReadLine());
                    if(sayi<0){
                        Console.WriteLine("Girdiğiniz sayı negatif olamaz!!!");
                    }
                    if(sayi%2==1){
                        asalList.Add(sayi);
                    }else{
                        asalOlmayanList.Add(sayi);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata : " + e.Message.ToString());
                }
            }
            asalList.Sort();
            asalList.Reverse();
            asalOlmayanList.Sort();
            asalOlmayanList.Reverse();

            Console.WriteLine("-----Asal sayılar-----");
            foreach(var eleman in asalList){
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----Asal olmayan sayılar-----");
            foreach(var eleman in asalOlmayanList){
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
            int toplam=0;
            foreach(var i in asalList){
                toplam+= (int)i;
            }
            Console.WriteLine("----Asal sayıların ortalaması-------");
            int elemanSayi=asalList.Count;
            Console.WriteLine("Dizinin eleman sayısı : " + elemanSayi);
            Console.WriteLine("Dizinin ortalaması : " + toplam/elemanSayi);

            toplam=0;
            foreach (var item in asalOlmayanList)
            {
                toplam+=(int)item;
            }
            Console.WriteLine("----Asal olmayan sayıların ortalaması-------");
            elemanSayi=asalOlmayanList.Count;
            Console.WriteLine("Dizinin eleman sayısı : " + elemanSayi);
            Console.WriteLine("Dizinin ortalaması : " + toplam/elemanSayi);

            /*Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.) */

            int[] maxList=new int[3];
            int[] minList=new int[3];
            int[] list=new int[20];
            for(int i=0; i<20; i++){
                Console.Write($"{i+1}. sayıyı giriniz : ");
                int sayi=int.Parse(Console.ReadLine());
                list[i]=sayi;
            }
            int temp;
            for(int i=0; i<3; i++){
                for(int j=i+1; j<list.Length; j++){
                    if(list[i]<list[j]){
                        temp=list[i];
                        list[i]=list[j];
                        list[j]=temp;
                    }  
                }
                maxList[i]=list[i];
            }
            
            for(int i=0; i<3; i++){
                for(int j=i+1; j<list.Length; j++){
                    if(list[i]>list[j]){
                        temp=list[i];
                        list[i]=list[j];
                        list[j]=temp;
                    }  
                }
                minList[i]=list[i];
            }

            Console.WriteLine("-----en büyük 3 sayı ve ortalaması------");
            double top=0;
            foreach(int eleman in maxList){
                Console.WriteLine(eleman);
                top+=eleman;
            }
            Console.WriteLine(top/maxList.Length);
            Console.WriteLine("-----en küçük 3 sayı ve ortalaması------");
            toplam=0;
            foreach(int eleman in minList){
                Console.WriteLine(eleman);
                top+=eleman;
            }
            Console.WriteLine(top/minList.Length);


            /*Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/

            Console.Write("Bir metin giriniz : ");
            string metin=Console.ReadLine();
            string sesliHarf="aeıioöuü";
            List<char> sesli=new List<char>();
            for(int i=0; i<metin.Length; i++){
                if(sesliHarf.Contains(metin[i])){
                    sesli.Add(metin[i]);
                }
            }
            sesli.Sort();
            foreach(char eleman in sesli){
                Console.Write(eleman + " ");
            }
        }
    }
}
