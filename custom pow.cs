using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Küçük sayıyı giriniz: ");
            int k_sayi= Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Büyük sayıyı giriniz: ");
            int b_sayi= Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Kaç Katı giriniz: ");
            int kere= Convert.ToInt32(Console.ReadLine());

        if(k_sayi>=b_sayi){
            Console.WriteLine("Sayıları dogru giriniz!!");
        } else {
       
               int [] donen_dizi=   My_method(kucuk_sayi:k_sayi, buyuk_sayi:b_sayi, kat:kere);

               for(int a= 0; a<donen_dizi.Length; a++){
                Console.WriteLine(donen_dizi[a]);
             }
        }
   
        }

        static int[] My_method(int kucuk_sayi, int buyuk_sayi, int kat=2){
        int value = buyuk_sayi- kucuk_sayi;
        int [] dizi = new int[value];

   
        for(int i= 0 ; i<dizi.Length; i++){
            dizi[i]=(kucuk_sayi+i);
       }
       for (int b=0; b<dizi.Length; b++){
           int sonuc=dizi[b];
       for(int a= 1 ; a< kat; a++){
           sonuc*=dizi[b];
       }
       dizi[b]=sonuc;
       }
    return dizi;
       
        }

    }
}
