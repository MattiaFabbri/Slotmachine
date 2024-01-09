using Fabbri.Mattia._4i.LibSlotmachine;
using System;

namespace Fabbri.Mattia._4i.CliSlotmachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            string risposta;
            Slotmachine slotmachine = new Slotmachine();
            do
            {
                GiocaPartite(slotmachine);
                do
                {
                    // richiesta di giocare ancora
                    Console.WriteLine("Vuoi giocare ancora? (si/no)");
                    risposta = Console.ReadLine();
                } while (!(risposta.ToLower() == "si" || risposta.ToLower() == "no"));

            } while (risposta.ToLower() == "si");

            Console.WriteLine("\nGrazie per aver giocato!");
        }
        static void GiocaPartite(Slotmachine slotmachine)
        {
            string risposta;

            Console.WriteLine("Benvenuto nella slot machine, queste sono le regole:\n" +
                              "  - Se c'è una coppia, viene restituita una moneta.\n" +
                              "  - Se c'è un tris di lettere uguali, vengono restituite un numero di monete pari alla posizione in ordine alfabetico della lettera del tris (es. tre C corrispondono a 3 monete).\n" +
                              "  - Se ci sono tre lettere consecutive (es. ABC oppure EFG), vengono restituite 50 monete.\n" +
                              "  - Se ci sono tre Z, allora è JACKPOT e vengono restituite 100 monetine.\n" +
                              "  - Altrimenti non viene restituito nulla e si passa alla partita successiva inserendo una nuova monetina.");

            int numeroPartite = 0;
            int numeroMassimoPartite = 3;
            slotmachine.DecrementaSaldo();
            while (numeroPartite < numeroMassimoPartite && slotmachine.GetSaldo() > 0)
            {
                // Info sulla partita
                Console.WriteLine($"\nPartita {numeroPartite + 1} - Saldo attuale: {slotmachine.GetSaldo()} - Ultima Vittoria: {slotmachine.GetUltimaVin()}");
                // Giro delle rotelle e output del risultato
                slotmachine.Roll();
                Console.WriteLine($"Rotelle: {slotmachine.GetSimbolo1()} - {slotmachine.GetSimbolo2()} - {slotmachine.GetSimbolo3()}");
                //controllo della vincita
                int vincita = slotmachine.CheckVincita();
                Console.WriteLine($"Hai vinto {vincita} monete!");

                numeroPartite++;

            }
        }
    }
}
