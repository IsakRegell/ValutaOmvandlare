using System.Globalization;

namespace ValutaOmvandlare
{
//Skapa en konsolapplikation som konverterar en summa pengar från en valuta till en annan.Inkludera typkonverteringar, operatörer och kontrollflöde.

//Instruktioner:
//Be användaren att ange en summa pengar i SEK.
//Ange en lista över tillgängliga valutor (t.ex.EUR, GBP, JPY, USD).
//Använd en switch-sats för att hantera valutaomvandlingen.
//Utför omvandlingen med multiplikationsoperatorer och skriv gjutning vid behov.
//Visa det konverterade beloppet.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en summa pengare i SEK : ");

            int userInputSek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vilken valuta vill du omvandla till?");
            Console.WriteLine("(1) EUR");
            Console.WriteLine("(2) GBP");
            Console.WriteLine("(3) JPY");
            Console.WriteLine("(4) USD");

            string selectedValuta = Console.ReadLine()!;
            double convertedAmaount = 0;

            switch (selectedValuta)
            {
                case "1":
                    double convertedAmount = userInputSek * 1.06;
                    Console.WriteLine($"Din summa du angav i SEK är --- {convertedAmount} i EUR");
                    break;

                case "2":
                    convertedAmount = userInputSek * 1.07;
                    Console.WriteLine($"Din summa du angav i SEK är --- {convertedAmount} i EUR");
                    break;

                case "3":
                    convertedAmount = userInputSek * 1.08;
                    Console.WriteLine($"Din summa du angav i SEK är --- {convertedAmount} i EUR");
                    break;

                case "4":
                    convertedAmount = userInputSek * 1.09;
                    Console.WriteLine($"Din summa du angav i SEK är --- {convertedAmount} i EUR");
                    break;
            }
        }
    }
}
