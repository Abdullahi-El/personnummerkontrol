
using System;

namespace PersonnummerKontroll
{
    class Program
    {
        public static bool VerifieraPersonnummer(string personnummer)
        {
            // Ta bort bindestreck om det finns
            personnummer = personnummer.Replace("-", "");

            // Kontrollera om personnumret har exakt 10 siffror
            if (personnummer.Length != 10)
                return false;

            // Luhn-algoritmen
            int sum = 0;
            bool alternate = false;

            for (int i = personnummer.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(personnummer[i].ToString());

                if (alternate)
                {
                    n *= 2;
                    if (n > 9)
                        n -= 9;
                }

                sum += n;
                alternate = !alternate;
            }

            return sum % 10 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett svenskt personnummer (YYMMDDXXXX):");
            string personnummer = Console.ReadLine();
            bool ärKorrekt = VerifieraPersonnummer(personnummer);

            if (ärKorrekt)
                Console.WriteLine("Personnumret är korrekt.");
            else
                Console.WriteLine("Personnumret är inte korrekt.");
        }
    }
}
