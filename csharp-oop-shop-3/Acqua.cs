using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3 {
    public class Acqua : Prodotto {

        private double contenutoBottiglia;
        private string sorgente;
        private double contenutoMaxBottiglia = 1.5;

        public Acqua(string nome, string descrizione, double prezzo, double IVA, string sorgente, double contenutoBottiglia, double contenutoMaxBottiglia) : base(nome, descrizione, prezzo, IVA) {
            this.sorgente = sorgente;
            this.contenutoBottiglia = contenutoBottiglia;
            this.contenutoMaxBottiglia = contenutoMaxBottiglia;
        }

        // GETTERS

        public string GetSorgente() {
            return this.sorgente;
        }

        public double GetContenutoBottiglia() {
            return this.contenutoBottiglia;
        }

        public double GetContenutoMaxBottiglia() {
            return this.contenutoMaxBottiglia;
        }

        // SETTERS

        public void SetContenutoBottiglia(double contenutoBottiglia) {
            if (contenutoBottiglia <= GetContenutoMaxBottiglia()) {
                this.contenutoBottiglia = contenutoBottiglia;
            } else {
                this.contenutoBottiglia = GetContenutoMaxBottiglia();
                Console.WriteLine("Ti si è rovesciata l'acqua per terra!");
            }
        }

        // METODI

        public void Bevi(double acquaDaBere) {
            if (acquaDaBere <= GetContenutoBottiglia() && acquaDaBere > 0) {
                double acquaRimasta = GetContenutoBottiglia() - acquaDaBere;
                this.contenutoBottiglia = acquaRimasta;
            } else {
                this.contenutoBottiglia = 0;
                Console.WriteLine("Hai finito l'acqua!");
            }
        }

        public void Riempi(double litri) {
            if (litri <= GetContenutoMaxBottiglia()) {
                this.contenutoBottiglia = litri;
            } else {
                this.contenutoBottiglia = GetContenutoMaxBottiglia();
                Console.WriteLine("Ti si è rovesciata l'acqua per terra!");
            }
        }

        public void Svuota() {
            this.contenutoBottiglia = 0;
        }

        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.WriteLine("La sorgente di provenienza è: " + this.sorgente);
            Console.WriteLine("Il contenuto della bottiglia è: " + this.contenutoBottiglia + " l");
            Console.WriteLine("Il contenuto MAX della bottiglia è: " + this.contenutoMaxBottiglia + " l");
            Console.WriteLine();
        }


    }
}
