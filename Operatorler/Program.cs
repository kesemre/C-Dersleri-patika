namespace Operatorler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*-*-*-*Atama Ve İşlemler");
    int x = 3;
    int y = 4;
    y = y + 2 ;
    
    Console.WriteLine(y);
    y/=2;
    Console.WriteLine(y);
   y/=1;
    Console.WriteLine(y);
    x*=2;
    Console.WriteLine(x);

    // Mantıksal Operatorler 
    //  ||(veya) , &&(ve) , !(değil) 
    Console.WriteLine("*-*-*-*Mantıksal Operatorler");
    bool isSucces = true ;
    bool isCompleted = false ;

    if(isSucces && isCompleted) // isSucces ve isCompleted true olursa yazacak ki isCompleted true değil yazmaz.
        Console.WriteLine("Perfect!");

   if(isSucces || isCompleted) // ikisinden a veya(||) b biri tru ise yazacak 
        Console.Write("Great!");

    if(isSucces && !isCompleted) // !(sonra gelen tersi olur ifade true ise true değil yani boolingde dönen false olacak) isSucces true ve !isCompleted true sonuc basarılı.
        Console.WriteLine("Fine!");
        // iliskisel operatorler related operators (ingsini ben uydurdum)
        // < , >, >= , >= , == , != 
        Console.WriteLine("*-*-*-*iliskisel operatorler");
        int a = 3 ;
        int b = 4 ;//
        bool sonuc = a<b ;
        Console.WriteLine(sonuc);
        sonuc = a>b ;  
        Console.WriteLine(sonuc);
        sonuc = a>=b ;
        Console.WriteLine(sonuc);
        sonuc = a<=b ;
        Console.WriteLine(sonuc);
        sonuc = a==b ;
        Console.WriteLine(sonuc);
        sonuc = a!=b ;
        Console.WriteLine(sonuc);
        // matematiksel operatorler 
        // / , * , - , + ,
        Console.WriteLine("*-*-*-*Matematiksel Operatorler");

        int sayi1   = 10 ; 
        int sayi2   = 5 ;
        int sonuc1  =  sayi1/sayi2 ; 
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1+=1 ;
        Console.WriteLine(sonuc1);
        
        // % mod almak icin kullanılır yani kalanı verir .
        Console.WriteLine("*-*-*-*Mod ALMA % ");
        int sonuc2 = 20%3 ;
        Console.WriteLine(sonuc2);
    }
}
