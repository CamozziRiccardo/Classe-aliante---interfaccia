using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ala : Componente
{
    private double lunghezza;
    private double apertura;

    public Ala(double lunghezza, double apertura)
    {
        this.lunghezza = lunghezza;
        this.apertura = apertura;
    }

    public string Descrizione()
    {
        return $"Ala - Lunghezza: {lunghezza}, Apertura: {apertura}";
    }

    public double Costo()
    {
        return lunghezza * apertura * 0.5;
    }
}
