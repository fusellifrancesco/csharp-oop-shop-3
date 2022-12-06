using csharp_oop_shop_3;
using csharp_oop_shop_3.Exceptions;
using System.Runtime.CompilerServices;

try {

    Prodotto prodotto1 = new Prodotto("Prodotto 1", "Prodotto 1", 1.50, 22);
    prodotto1.StampaProdotto();

    prodotto1.SetNome("prodotto1");
    prodotto1.StampaProdotto();

    Console.WriteLine("Cambiamo il prezzo del prodotto 1");
    prodotto1.SetPrezzo(1.90);
    prodotto1.StampaProdotto();


    Acqua acqua1 = new Acqua("Acqua Gaia", "Acqua Frizzante", 3.99, 22, "Genga (AN)", 1.5);
    acqua1.StampaProdotto();

    acqua1.SetContenutoBottiglia(1);
    acqua1.StampaProdotto();

    acqua1.Bevi(1);
    acqua1.StampaProdotto();

    acqua1.Riempi(1.5);
    acqua1.StampaProdotto();

    Acqua.ConvertitoreLitriGalloni(1.5);

} catch (NomeVuotoException e) {
    Console.WriteLine(e.Message);
} catch (PrezzoNegativoException e) {
    Console.WriteLine(e.Message);
} catch (ContenutoBottMaggioreException e) {
    Console.WriteLine(e.Message);
} catch (AcquaTerminataException e) {
    Console.WriteLine(e.Message);
} catch (LitriNegativiException e) {
    Console.WriteLine(e.Message);
}

Console.WriteLine("In totale sono stati creati: " + Prodotto.numeroProdotti + " prodotti");