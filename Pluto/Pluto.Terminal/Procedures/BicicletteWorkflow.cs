using Pluto.Core.Entities;
using Pluto.Core.Managers.Interfaces;
using Pluto.Storage;
using Pluto.Storage.Automobili;
using Pluto.Terminal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonBicicletteManager = Pluto.Storage.JsonBicicletteManager;

namespace Pluto.Terminal.Procedures
{
    public static class BicicletteWorkflow
    {
          /*
        -Dovrà essere possibile inserire una bicicletta(o un’automobile) 
        e salvarla su un “database” realizzato con un file di json
        -Dovrà essere possibile visualizzare il contenuto intero del 
        database dell’oggetto di riferimento
        -Dovrà essere possibile visualizzare solo gli elementi che corrispondono 
        al criterio di ricerca sul campo “Modello”. */

        //Visualizzo menu e richiedo selezione


        public static void Summary()
        {
            //Menu
            Console.WriteLine("******************************");
            Console.WriteLine("**********MENU'***************");
            Console.WriteLine("******************************");
            Console.WriteLine("* 1 - Salva nuova bicicletta in catalogo");
            Console.WriteLine("* 2 - Visualizza intero catalogo");
            Console.WriteLine("* 3 - Cerca Modello");


            //Recupero della selezione
            var selezione = ConsoleUtils.LeggiNumeroInteroDaConsole(1, 3);



            //Avvio della procedura
            switch (selezione)
            {
                //********************************************************
                case 1:
                    CreaSalva();
                    break;

                //********************************************************
                case 2:
                    VisualizzaContenutoCatalogo();
                    break;

                //********************************************************
                case 3:
                    CercaModello();
                    break;



                //********************************************************
                default:
                    Console.WriteLine("Selezione non valida");
                    break;
            }
        }

        public static void CreaSalva()
        {


            Console.WriteLine("Inserisci la marca : ");
            string marca = Console.ReadLine();
            Console.WriteLine("Inserisci il modello : ");
            string modello = Console.ReadLine();


            //Istanzio il manager 
            Console.WriteLine();
            Console.WriteLine("ESECUZIONE DEL WORKFLOW Biciclette...");
            Console.WriteLine();

            IManager<Bicicletta> manager = new JsonBicicletteManager();

            //Visualizzazione contenuto database
            /*Console.WriteLine("Lettura del database...");
            var BicicletteInArchivio = manager.Carica();
            Console.WriteLine($"Trovate {BicicletteInArchivio.Count} Automobili in archivio");
            foreach (var currentBici in BicicletteInArchivio)
                Console.WriteLine($"Lettura: {currentBici.Modello} (ID:{currentBici.Id})");
            Console.WriteLine("");*/




            //1) Validazione degli input
            if (string.IsNullOrEmpty(marca))
                throw new ArgumentNullException(nameof(marca));
            if (string.IsNullOrEmpty(modello))
                throw new ArgumentNullException(nameof(modello));


            //7) Creo l'oggetto con tutti i dati
            Bicicletta nuovoBici = new Bicicletta
            {
                Marca = marca,
                Modello = modello,

            };

            //Aggiungo il libro
            manager.Crea(nuovoBici);





            Console.WriteLine("la bici dovrebbe essere stato creato su disco!");
            Console.WriteLine();

        }
        public static void VisualizzaContenutoCatalogo()
        {
            //Istanzio il manager 
            Console.WriteLine();
            Console.WriteLine("ESECUZIONE DEL WORKFLOW bici...");
            Console.WriteLine();

            IManager<Bicicletta> manager = new JsonBicicletteManager();
            //Leggiamo le auto dal database
            Console.WriteLine("Lettura del catalogo...");
            var biciInArchivio = manager.Carica();
            Console.WriteLine($"Trovati {biciInArchivio.Count} bici in archivio");
            foreach (var currentbici in biciInArchivio)
                Console.WriteLine($"Lettura: {currentbici.Modello} (ID:{currentbici.Id})");
            Console.WriteLine("");
        }

        public static Bicicletta CercaModello()
        {
            Console.WriteLine("Inserisci il modello da cercare: ");
            string modello = Console.ReadLine();

            //Istanzio il manager 
            Console.WriteLine();
            Console.WriteLine("ESECUZIONE DEL WORKFLOW BICI...");
            Console.WriteLine();

            IManager<Bicicletta> manager = new JsonBicicletteManager();


            //4-2) Carico tutti le automobili

            IList<Bicicletta> bici = manager.Carica();

            //4-3) Verifico che esista un automobile con modello specificato
            Bicicletta biciConStessoModello = bici
                .SingleOrDefault(l => l.Modello == modello);
            return biciConStessoModello;
        }

    }
}
