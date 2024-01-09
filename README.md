# Slotmachine

## Consegna

- Realizzare una libreria di classi C# con le classi relative alla SlotMachine
- Realizzare un programma WPF che usa la libreria di classi
- Realizzare un programma Console che usa la stessa libreria di classi

# SlotMachine Library

La libreria SlotMachine fornisce un'implementazione di una slot machine in C# con alcune caratteristiche chiave.

## Funzionalità Principali

- **Saldo Iniziale:** La slot machine inizia con un saldo di 20 crediti.
- **Simboli:** Utilizza i simboli dell'alfabeto da 'A' a 'Z'.
- **Jackpot:** Può essere vinto ottenendo tre simboli 'Z' in una singola giocata.

## Metodi Principali

- `Roll()`: Genera casualmente tre simboli per ogni giocata.
- `CheckVincita()`: Verifica la combinazione di simboli e restituisce il numero di crediti vinti.
- `DecrementaSaldo()`: Decrementa il saldo della slot machine di un credito.
- `GetSaldo()`: Restituisce il saldo attuale della slot machine.

# Console SlotMachine 

Applicazione console che utilizza la libreria SlotMachine per simulare il gioco di una slot machine.

## Utilizzo

1. Avviare l'applicazione console `CliSlotmachine`.
2. Seguire le istruzioni visualizzate per giocare alla slot machine.
3. Ogni partita richiederà una monetina e mostrerà il saldo attuale.
4. La slot machine restituirà le vincite in base alle regole del gioco.

## Regole del Gioco

  - Una coppia restituisce una moneta.
  - Un tris di lettere uguali restituisce un numero di monete pari alla posizione in ordine alfabetico della lettera del tris.
  - Tre lettere consecutive restituiscono 50 monete.
  - Tre Z corrispondono al JACKPOT e restituiscono 100 monete.
  - Altrimenti, non viene restituita alcuna vincita, e si passa alla partita successiva inserendo una nuova monetina.

# WPF SlotMachine App

Applicazione WPF che utilizza la libreria SlotMachine per creare una simulazione di una slot machine con interfaccia grafica.

## Utilizzo

1. Avviare l'applicazione WPF `Slotmachine`.
2. Premere il pulsante "Gioca" per avviare una nuova partita.
3. Dopo ogni partita, è possibile premere nuovamente il pulsante "Gioca" per avviare una nuova giocata.
4. Il saldo verrà decrementato di una moneta ad ogni giocata.
5. Visualizza il saldo, il numero della partita corrente e l'ultima vincita.

## Interfaccia Utente

- **Rotelle:** Tre rotelle mostrano i simboli risultanti dalla giocata.
- **Pulsante "Gioca":** Avvia una nuova partita e visualizza il risultato.
- **Pulsante "Reset":** Ripristina il saldo, il numero delle partite e l'ultima vincita.

