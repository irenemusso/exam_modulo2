using Pluto.Terminal.Procedures;
using Pluto.Terminal.Utils;
using System;

namespace Pluto.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Visualizzo menu e richiedo selezione
            Console.WriteLine("*******************************");
            Console.WriteLine("* MENU                        *");
            Console.WriteLine("*******************************");
            Console.WriteLine("* A - Apri Catalogo delle Biciclette");
            Console.WriteLine("* B - Apri Catalogo delle Automobili");


            var selezione = ConsoleUtils.LeggiLetteraDaConsole();

            //Selezione dell'opzione
            switch (selezione)
            {
                case "A":
                    BicicletteWorkflow.Summary();
                    break;
                case "B":
                    AutomobiliWorkflow.Summary();
                    break;
                
                default:
                    Console.WriteLine("Opzione non valida!");
                    break;
            }

            //Richiedo conferma di uscita
            ConsoleUtils.ConfermaUscita();
        }
    }
}

