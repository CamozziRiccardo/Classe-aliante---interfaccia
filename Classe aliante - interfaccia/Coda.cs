using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Coda : Componente
{
    private double lunghezza;

    public Coda(double lunghezza)
    {
        this.lunghezza = lunghezza;
    }

    public string Descrizione()
    {
        return $"Coda - Lunghezza: {lunghezza}";
    }

    public double Costo()
    {
        // Calcolo del costo della coda basato sulla lunghezza
        // Questo è un valore fittizio, sostituiscilo con un calcolo reale
        return lunghezza * 50;
    }
}