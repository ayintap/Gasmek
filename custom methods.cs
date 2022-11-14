using System;

namespace project
{
    class Program
    {
        static void Main(string[] args){
            int a,b,c;
            string s;
            Console.WriteLine("Mutlak değer için değer giriniz:");
            a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mutlak değer sonuç: {0}", mutlak(a));

            Console.WriteLine("Kuvveti alınacak sayı için değer giriniz:");
            b= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Üssü için değer giriniz(Zorunlu değil) varsayılan 2:");
            
            s= Console.ReadLine();
            if (s==""){
                c = 2;
            }else {
                c= Convert.ToInt32(s);
            }
            Console.WriteLine("Kuvveti: {0}", kuvvet(s:b,k:c));

        }
        public static int mutlak(int a){

            if (a<=0)
            {
                return a*-1;
                
            }else {
                return a;
            }
        }
        public static int kuvvet(int s, int k=2){
            int sayi=1;
            for(int a =0; a<k; a++){
                sayi *=s;
            }
            return sayi;
        }
        
    }




}
