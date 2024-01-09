using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Iphone iphone = new Iphone("933421567", "iPhone x", "35-299941-676128-1", 228);
        iphone.InstalarAplicativo("Instagram");

        Nokia nokia = new Nokia("987654321", "Nokia 3310", "35-209900-176148-2", 16);
        nokia.InstalarAplicativo("WhatsApp");
    }
}