using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3 {
    public class Prodotto {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double IVA;

        public Prodotto(string nome, string descrizione, double prezzo, double IVA) {
            this.codice = GeneraCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = Math.Round(prezzo, 2);
            this.IVA = IVA;
        }

        // GETTERS

        public int GetCodice() {
            return this.codice;
        }

        public string GetNome() {
            return this.nome;
        }

        public string GetDescrizione() {
            return this.descrizione;
        }

        public double GetPrezzo() {
            return this.prezzo;
        }

        public double GetIVA() {
            return this.IVA;
        }

        public double GetPrezzoIVA() {
            double prezzoIVA = (this.prezzo + (this.prezzo * this.IVA) / 100);
            prezzoIVA = Math.Round(prezzoIVA, 2);
            return prezzoIVA;
        }



        public string GetNomeEsteso() {
            string codiceStringa = this.codice.ToString();
            codiceStringa = codiceStringa.PadLeft(8, '0');
            return codiceStringa + this.nome;
        }

        // SETTERS

        public void SetNome(string nome) {
            this.nome = nome;
        }

        public void SetDescrizione(string descrizione) {
            this.descrizione = descrizione;
        }

        public void SetPrezzo(double prezzo) {
            this.prezzo = prezzo;
        }

        public void SetIVA(double IVA) {
            this.IVA = IVA;
        }

        // METODI PUBBLICI

        public void StampaPrezzoBase() {
            string prezzoBase = this.prezzo.ToString();
            Console.WriteLine("Il prezzo base è: " + prezzoBase + " euro");
        }

        public void StampaPrezzoIva() {
            double prezzoIVA = (this.prezzo + (this.prezzo * this.IVA) / 100);
            prezzoIVA = Math.Round(prezzoIVA, 2);
            string prezzo = (prezzoIVA.ToString());
            Console.WriteLine("Il prezzo con IVA è: " + prezzo + " euro");
        }

        public virtual void StampaProdotto() {
            Console.WriteLine("------ " + this.nome + " ------");
            Console.WriteLine();
            Console.WriteLine(this.descrizione);
            Console.WriteLine("Il codice del prodotto è: " + this.codice);
            Console.WriteLine("Il prezzo del prodotto è: " + this.GetPrezzoIVA() + " euro");
            Console.WriteLine("L'IVA inclusa è al: " + this.IVA + " %");
            Console.WriteLine();
            Console.WriteLine("Il NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine();
        }

        private int GeneraCodice() {
            Random generatoreRandom = new Random();
            int numeroCodice = generatoreRandom.Next(999999);
            return numeroCodice;
        }
    }
}
