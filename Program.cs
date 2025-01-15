
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv ett svenskt personnummer (YYYYMMDD-XXXX):");
        string personnummer = Console.ReadLine();
        
        if (ValideraPersonnummer(personnummer))
        {
            Console.WriteLine("Personnumret är giltigt.");
        }
        else
        {
            Console.WriteLine("Personnumret är ogiltigt.");
        }
    }

    static bool ValideraPersonnummer(string personnummer)
    {
        // Här implementeras själva valideringen av personnummer enligt svensk standard.
        // Du kan använda Luhn-algoritmen eller annan validering.
        
        // Detta är ett grundläggande exempel. Du kan förbättra det senare.
        if (personnummer.Length != 13) return false;
        
        // Luhn-algoritm eller annan kontroll kan implementeras här.
        return true;
    }
}
