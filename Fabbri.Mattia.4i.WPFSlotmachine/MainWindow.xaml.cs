using Fabbri.Mattia._4i.LibSlotmachine;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Fabbri.Mattia._4i.Slotmachine
{
    public partial class MainWindow : Window
    {
        private Slotmachinef slotmachine;
        int partite;
        public MainWindow()
        {
            InitializeComponent();
            slotmachine = new Slotmachinef();
            partite = 0;
            AggiornaStato(Partite, Saldo, UltimaVincita);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (!(slotmachine.GetSaldo() == 0))
            {
                partite++;
                slotmachine.Roll();
                slotmachine.CheckVincita();
                AggiornaRotelle(Rotella1, Rotella2, Rotella3);
            }
            else
            {
                RestartStat();
            }
            if (slotmachine.GetSaldo() != 0)
            {
                slotmachine.DecrementaSaldo();
            }
            AggiornaStato(Partite, Saldo, UltimaVincita);
        }

        private void AggiornaStato(TextBlock Partite, TextBlock Saldo, TextBlock UltimaVincita)
        {
            Partite.Text = "Partita n: " + Convert.ToString(partite);
            Saldo.Text = "Saldo: " + Convert.ToString(slotmachine.GetSaldo());
            UltimaVincita.Text = "Ultima Vincita: " + Convert.ToString(slotmachine.GetUltimaVin());
        }

        private void AggiornaRotelle(TextBlock Rotella1, TextBlock Rotella2, TextBlock Rotella3)
        {
            Rotella1.Text = Convert.ToString(slotmachine.GetSimbolo1());
            Rotella2.Text = Convert.ToString(slotmachine.GetSimbolo2());
            Rotella3.Text = Convert.ToString(slotmachine.GetSimbolo3());
        }

        private void RestartStat()
        {
            slotmachine.SetSaldo(20);
            partite = 0;
            slotmachine.SetUltimaVin(0);
            AggiornaStato(Partite, Saldo, UltimaVincita);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RestartStat();
        }
    }
}
