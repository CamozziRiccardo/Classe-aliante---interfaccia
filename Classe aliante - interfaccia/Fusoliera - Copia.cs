using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fusoliera : Componente
{
    private string materiale;
    private double lunghezza;

    public Fusoliera(string materiale, double lunghezza)
    {
        this.materiale = materiale;
        this.lunghezza = lunghezza;
    }

    public string Descrizione()
    {
        return $"Fusoliera - Materiale: {materiale}, Lunghezza: {lunghezza}";
    }

    public double Costo()
    {
        // Calcolo del costo della fusoliera basato sulla lunghezza
        // Questo è un valore fittizio, sostituiscilo con un calcolo reale
        return lunghezza * 100;
    }
}