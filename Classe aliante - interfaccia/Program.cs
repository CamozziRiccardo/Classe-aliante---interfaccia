using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Inserimento dei dati dell'ala dall'utente
        Console.WriteLine("Inserisci la lunghezza dell'ala:");
        double lunghezzaAla = Convert.ToDouble(Console.ReadLine());

        // Inserimento dei dati della fusoliera dall'utente
        Console.WriteLine("Inserisci il materiale della fusoliera:");
        string materialeFusoliera = Console.ReadLine();
        Console.WriteLine("Inserisci la lunghezza della fusoliera:");
        double lunghezzaFusoliera = Convert.ToDouble(Console.ReadLine());

        // Inserimento dei dati della coda dall'utente
        Console.WriteLine("Inserisci la lunghezza della coda:");
        double lunghezzaCoda = Convert.ToDouble(Console.ReadLine());

        // Inserimento dei dati della ruota dall'utente
        Console.WriteLine("Inserisci il diametro del cerchione della ruota:");
        double diametroCerchione = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il materiale del cerchione:");
        string materialeCerchione = Console.ReadLine();
        Console.WriteLine("Inserisci l'altezza della gomma:");
        double altezzaGomma = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci la larghezza della gomma:");
        double larghezzaGomma = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il raggio della gomma:");
        double raggioGomma = Convert.ToDouble(Console.ReadLine());

        //Creazione dell'aliante
        Aliante aliante = new Aliante();
        Ruota ruota = new Ruota();
        Ala ala = new Ala(lunghezzaAla);
        Fusoliera fusoliera = new Fusoliera(materialeFusoliera, lunghezzaFusoliera);
        Gomma gomma = new Gomma(altezzaGomma, larghezzaGomma, raggioGomma);
        Cerchione cerchione = new Cerchione(diametroCerchione, materialeCerchione);
        Coda coda = new Coda(lunghezzaCoda);

        //Inserimento dei dati nella lista Ruota
        ruota.Add(gomma);
        ruota.Add(cerchione);

        //inserimento di tutti i componenti nella lista della classe aliante
        aliante.Add(ala);
        aliante.Add(fusoliera);
        aliante.Add(ruota);
        aliante.Add(coda);

        // Visualizzazione della descrizione dell'aliante
        Console.WriteLine("\nDescrizione dell'aliante:");
        Console.WriteLine(aliante.Descrizione());

        // Calcolo del costo totale dell'aliante
        Console.WriteLine($"\nCosto totale dell'aliante: {aliante.Costo()}");
    }
}
