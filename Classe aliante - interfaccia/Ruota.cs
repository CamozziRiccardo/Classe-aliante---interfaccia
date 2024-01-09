public class Cerchione : Componente
{
    private double diametro;
    private string materiale;

    public Cerchione(double diametro, string materiale)
    {
        this.diametro = diametro;
        this.materiale = materiale;
    }

    public string Descrizione()
    {
        return $"Cerchione - Diametro: {diametro}, Materiale: {materiale}";
    }

    public double Costo()
    {
        return diametro * 20;
    }
}

public class Gomma : Componente
{
    private double altezza;
    private double larghezza;
    private double raggio;

    public Gomma(double altezza, double larghezza, double raggio)
    {
        this.altezza = altezza;
        this.larghezza = larghezza;
        this.raggio = raggio;
    }

    public string Descrizione()
    {
        return $"Gomma - Altezza: {altezza}, Larghezza: {larghezza}, Raggio: {raggio}";
    }

    public double Costo()
    {
        return altezza * larghezza * raggio * 10;
    }
}

public class Ruota : Componente
{
    private List<Componente> CompRuota = new List<Componente>();

    public double Costo()
    {
        double costoTotale = 0;

        foreach (Componente componente in CompRuota)
        {
            costoTotale += componente.Costo();
        }

        return costoTotale;
    }

    public string Descrizione()
    {
        string descrizione = "Aliante:\n";

        foreach (Componente componente in CompRuota)
        {
            descrizione += componente.Descrizione() + "\n";
        }

        return descrizione;
    }
    public void Add(Componente componente)
    {
        CompRuota.Add(componente);
    }

    public void Remove(Componente componente)
    {
        CompRuota.Remove(componente);
    }

    public List<Componente> GetChild()
    {
        return CompRuota;
    }
}