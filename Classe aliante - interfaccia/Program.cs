﻿using System;
using System.Collections.Generic;

//classe componente come interfaccia
public interface Componente
{
    string Descrizione();
    double Costo();
}

public class Aliante : Componente
{
    private List<Componente> componenti = new List<Componente>();

    public string Descrizione()
    {
        string descrizione = "Aliante:\n";

        foreach (Componente componente in componenti)
        {
            descrizione += componente.Descrizione() + "\n";
        }

        return descrizione;
    }

    public double Costo()
    {
        double costoTotale = 0;

        foreach (Componente componente in componenti)
        {
            costoTotale += componente.Costo();
        }

        return costoTotale;
    }

    public void Add(Componente componente)
    {
        componenti.Add(componente);
    }

    public void Remove(Componente componente)
    {
        componenti.Remove(componente);
    }

    public List<Componente> GetChild()
    {
        return componenti;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}
