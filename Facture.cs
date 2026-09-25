public class Facture : IImprimable, IExportable
{
    public string Numero { get; set; }

    public Facture(string numero)
    {
        Numero = numero;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Impression de la facture {Numero}");
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"Facture {Numero} exportée vers {fichier}");
    }
}