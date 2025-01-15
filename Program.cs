
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
        // Ta bort bindestreck eller mellanslag
        personnummer = personnummer.Replace("-", "").Replace(" ", "");

        // Kontrollera längden (12 tecken för YYYYMMDDXXXX eller 10 tecken för ÅÅMMDDXXXX)
        if (personnummer.Length != 12 && personnummer.Length != 10) return false;

        // Om det är 10 tecken, anta att det är ÅÅMMDDXXXX och lägg till "19" eller "20" vid behov
        if (personnummer.Length == 10)
        {
            string årHundratal = int.Parse(personnummer.Substring(0, 2)) > DateTime.Now.Year % 100 ? "19" : "20";
            personnummer = årHundratal + personnummer;
        }

        // Kontrollera att alla tecken är siffror
        if (!long.TryParse(personnummer, out _)) return false;

        // Kontrollera födelsedatumets giltighet
        string datumDel = personnummer.Substring(0, 8);
        if (!DateTime.TryParseExact(datumDel, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out _))
        {
            return false;
        }

        // Kontrollera Luhn-algoritmen för de sista 10 siffrorna
        string nummerDel = personnummer.Substring(2, 10); // Endast 10 siffror används i Luhn-algoritmen
        return KontrolleraLuhnAlgoritmen(nummerDel);
    }

    static bool KontrolleraLuhnAlgoritmen(string nummer)
    {
        int sum = 0;
        bool isDouble = false;

        // Iterera baklänges genom varje siffra
        for (int i = nummer.Length - 1; i >= 0; i--)
        {
            int siffra = int.Parse(nummer[i].ToString());
            if (isDouble)
            {
                siffra *= 2;
                if (siffra > 9)
                {
                    siffra -= 9;
                }
            }
            sum += siffra;
            isDouble = !isDouble;
        }

        return sum % 10 == 0;
    }
}
