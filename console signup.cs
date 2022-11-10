using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control= false; 
            string user_name, password;  
        do {

            Console.WriteLine("Kayıt için adınızı giriniz:");
            user_name= Console.ReadLine();
            if(user_name=="")
                control=true;
            else
            {
                control=false;
            }
        }while(control);
            
        do {
            Console.WriteLine ("Şifre Giriniz:");
            password= Console.ReadLine();
            if(password=="")
                control=true;
            else
            {
                control=false;
            }
        }while(control);
            
          Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Giriş Sayfasına yönlendiriliyorsunuz....");

            giris(user_name, password);
            
        }
static void giris(string a, string b){
  
    Console.WriteLine("Kullanıcı adı:");
    String user= Console.ReadLine();
    
    int tekrar=0;
   if(a!=user){
        Console.WriteLine("Kullanıcı yok ");
    } else {
        Console.WriteLine("Şifre:");
        String pass= Console.ReadLine();
    if( b!=pass){
            bool gec= true;
        do {
            tekrar++;
            Console.WriteLine("Kullanıcı: {0}", a);
            Console.WriteLine("Şifre yanlış Düzeltiniz...Yanlış giriş: {0}", tekrar);
            Console.WriteLine("Şifre:");
            pass= Console.ReadLine();
            if(tekrar>2)
            {
                basarisiz_giris();
                break;
            }
            if(b==pass)
            {
                gec= false;
                basarili_giris(a);
            }
        }while(gec);
    } else {
        basarili_giris(a);
    }
    }
}
static void basarili_giris(string a){
    Console.WriteLine( "----------------------------");
    for(int i=0 ; i<a.Length ; i++){
        Console.WriteLine(a[i]);
    }
    Console.WriteLine( "Giriş işlemi başarılı...");
}
static void basarisiz_giris(){
    Console.WriteLine( "----------------------------");
    string hata=" Hesabınız Bloke oldu";
    for(int i=hata.Length-1 ; i>0 ; i--){
        Console.Write(hata[i]);
    }

} 

}

}
