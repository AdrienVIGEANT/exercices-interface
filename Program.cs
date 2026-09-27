void AfficherTotal(
    decimal montantCommande,
    ICalculLivraison calculLivraison)
{
    decimal frais = calculLivraison.Calculer(montantCommande);

    decimal total = montantCommande + frais;

    Console.WriteLine($"Montant commande : {montantCommande} €");
    Console.WriteLine($"Frais livraison : {frais} €");
    Console.WriteLine($"Total : {total} €");
    Console.WriteLine();
}

AfficherTotal(
    40m,
    new LivraisonStandard());

AfficherTotal(
    40m,
    new LivraisonExpress());

AfficherTotal(
    40m,
    new RetraitMagasin());

Console.WriteLine("----------");

AfficherTotal(
    100m,
    new LivraisonStandard());

AfficherTotal(
    100m,
    new LivraisonExpress());

AfficherTotal(
    100m,
    new RetraitMagasin());