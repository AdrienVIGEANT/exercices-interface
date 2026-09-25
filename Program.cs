var facture = new Facture("F001");

IImprimable imprimable = facture;
IExportable exportable = facture;

imprimable.Imprimer();

exportable.Exporter("facture.pdf");