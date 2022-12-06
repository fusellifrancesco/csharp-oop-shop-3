using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3 {
    public class SacchettoFrutta : Prodotto {
        private int pezziFrutta;
        private int pezziFruttaMax = 5;
        private List<string> tipoFrutta;

        public SacchettoFrutta(string nome, string descrizione, double prezzo, double IVA, int pezziFrutta, List<string> tipoFrutta) : base(nome, descrizione, prezzo, IVA) {
            this.pezziFrutta = pezziFrutta;
            this.tipoFrutta = tipoFrutta;
        }

        // GETTERS

        public int GetPezziFrutta() {
            return this.pezziFrutta;
        }

        public int GetPezziFruttaMax() {
            return this.pezziFruttaMax;
        }

        public List<string> GetTipoFrutta() {
            return this.tipoFrutta;
        }

        // SETTERS

        public void SetPezziFrutta(int pezziFrutta) {
            if (pezziFrutta <= GetPezziFruttaMax()) {
                this.pezziFrutta = pezziFrutta;
            } else {
                this.pezziFrutta = GetPezziFruttaMax();
                Console.WriteLine("Ti sono cascati dei pezzi di frutta per terra!");
            }
        }

        // METODI

        public void Mangia(int pezziFrutta) {
            if (pezziFrutta <= GetPezziFrutta()) {
                int pezziRimasti = GetPezziFrutta() - pezziFrutta;
                this.pezziFrutta = pezziRimasti;
            } else {
                this.pezziFrutta = 0;
                Console.WriteLine("Hai finito la frutta!");
            }
        }

        public void AggiungiTipoFrutta(string tipoFrutta) {
            this.tipoFrutta.Add(tipoFrutta);
        }

        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.WriteLine("Pezzi di frutta all'interno: " + this.pezziFrutta);
            Console.WriteLine("MAX pezzi di frutta : " + this.pezziFruttaMax);
            Console.WriteLine("Tipo frutta presente all'interno:");
            foreach (string tipoFrutta in tipoFrutta) {
                Console.WriteLine(tipoFrutta);
            }
            Console.WriteLine();
        }
    }
}
