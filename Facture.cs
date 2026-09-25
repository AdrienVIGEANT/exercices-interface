public class Facture : Document, IImprimable
{
    public decimal Montant { get; set; }

    public Facture(string titre, decimal montant)
        : base(titre)
    {
        Montant = montant;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Facture : {Titre} - {Montant} €");
    }
}