using System;

namespace Fabbri.Mattia._4i.LibSlotmachine
{
    public class Slotmachinef
    {
        private int saldo = 20;
        private int UltimaVin { get; set; }
        private Random segnaPosto;
        private char simbolo1;
        private char simbolo2;
        private char simbolo3;
        char[] Simboli = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int jackpot = 100;

        public Slotmachinef()
        {
            saldo = 20;
            UltimaVin = 0;
            segnaPosto = new Random();
        }

        public void Roll()
        {
            simbolo1 = Simboli[segnaPosto.Next(Simboli.Length)];

            simbolo2 = Simboli[segnaPosto.Next(Simboli.Length)];

            simbolo3 = Simboli[segnaPosto.Next(Simboli.Length)];
        }

        public int CheckVincita()
        {
            int indiceSimbolo1 = Array.IndexOf(Simboli, simbolo1);
            int indiceSimbolo2 = Array.IndexOf(Simboli, simbolo2);
            int indiceSimbolo3 = Array.IndexOf(Simboli, simbolo3);

            if (simbolo1 == 'Z' && simbolo2 == 'Z' && simbolo3 == 'Z')
            {
                saldo += jackpot;
                UltimaVin = jackpot;
                return jackpot;
            }
            else if (simbolo1 == simbolo2 && simbolo2 == simbolo3)
            {
                saldo += (indiceSimbolo1 + 1);
                UltimaVin = (indiceSimbolo1 + 1);
                return (indiceSimbolo1 + 1);
            }

            else if ((indiceSimbolo1 + 1) == indiceSimbolo2 && (indiceSimbolo2 + 1) == indiceSimbolo3)
            {
                saldo += 50;
                UltimaVin = 50;
                return 50;
            }

            else if (simbolo1 == simbolo3)
            {
                saldo += 1;
                UltimaVin = 1;
                return 1;
            }

            else if (simbolo1 == simbolo2)
            {
                saldo += 1;
                UltimaVin = 1;
                return 1;
            }

            else if (simbolo3 == simbolo2)
            {
                saldo += 1;
                UltimaVin = 1;
                return 1;
            }

            return 0;
        }
        public void DecrementaSaldo()
        {
            saldo--;
        }

        public int GetSaldo()
        {
            return saldo;
        }
        public void SetSaldo(int saldo)
        {
            this.saldo = saldo;
        }

        public char GetSimbolo1()
        {
            return simbolo1;
        }

        public char GetSimbolo2()
        {
            return simbolo2;
        }


        public char GetSimbolo3()
        {
            return simbolo3;
        }

        public int GetUltimaVin()
        {
            return UltimaVin;
        }

        public void SetUltimaVin(int UltimaVin)
        {
            this. UltimaVin= UltimaVin;
        }

    }
}
