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
        return $"Fusoliera - Materiale: {materiale}, Lunghezza: {lunghezza}\n";
    }

    public double Costo()
    {
        return lunghezza * 100;
    }
}