using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a= {1,5,8,3,7,10,2,0};
            bool hareket;
            int say=0;
        
           do {
            hareket= false;
    say++;
            for(int i= 1; i<8 ; i++){
               
                if(a[i]<a[i-1]){
                    int z= a[i-1];
                   a[i-1]=a[i];
                   a[i]=z;
                 hareket= true;

                }
           } 
          
           }while (hareket); 
            for(int f=0 ; f<8; f++){
                Console.Write(a[f]);
            }

        Console.WriteLine();
        Console.WriteLine(say);
        }
    }
}
