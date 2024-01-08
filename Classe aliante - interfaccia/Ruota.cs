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
    private Cerchione cerchione;
    private Gomma gomma;

    public Ruota(Cerchione cerchione, Gomma gomma)
    {
        this.cerchione = cerchione;
        this.gomma = gomma;
    }

    public string Descrizione()
    {
        return $"Ruota - {cerchione.Descrizione()}, {gomma.Descrizione()}";
    }

    public double Costo()
    {
        double costoCerchione = cerchione.Costo();
        double costoGomma = gomma.Costo();

        return costoCerchione + costoGomma;
    }
}