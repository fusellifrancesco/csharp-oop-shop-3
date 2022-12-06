using csharp_oop_shop_3;
using csharp_oop_shop_3.Exceptions;

try {
    Prodotto prodotto1 = new Prodotto("Prodotto 1", "Prodotto 1", 1.50, 22);
    prodotto1.StampaProdotto();

    prodotto1.SetNome("");
    prodotto1.StampaProdotto();

    Console.WriteLine("Cambiamo il prezzo del prodotto 1");
    prodotto1.SetPrezzo(-1.50);
    prodotto1.StampaProdotto();

} catch (NomeVuotoException e) {
    Console.WriteLine(e.Message);
} catch (PrezzoNegativoException e) {
    Console.WriteLine(e.Message);
}

Console.WriteLine(Prodotto.numeroProdotti);