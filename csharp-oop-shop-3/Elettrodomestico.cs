using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3 {
    public class Elettrodomestico : Prodotto {
        private string tipoElettrodomestico;
        private string condizione;
        private bool statoAccensione;
        private bool guasto;

        public Elettrodomestico(string nome, string descrizione, double prezzo, double IVA, string tipoElettrodomestico, string condizione) : base(nome, descrizione, prezzo, IVA) {
            this.tipoElettrodomestico = tipoElettrodomestico;
            this.condizione = condizione;
        }

        // GETTERS

        public string GetTipoElettrodomestico() {
            return this.tipoElettrodomestico;
        }

        public string GetCondizione() {
            return this.condizione;
        }

        public bool GetStatoAccenzione() {
            return this.statoAccensione;
        }

        public bool GetGuasto() {
            return this.guasto;
        }

        // SETTERS

        public void SetCondizione(string condizione) {
            this.condizione = condizione;
        }

        public void SetGuasto(string guasto) {
            string guastoMinuscolo = guasto.ToLower();
            if (guastoMinuscolo == "si") {
                this.guasto = true;
                Console.WriteLine("Il guasto è stato Registrato");
            } else if (guastoMinuscolo == "no") {
                this.guasto = false;
                Console.WriteLine("L'Elettrodomestico non è guasto");
            } else {
                Console.WriteLine("inserisci SI o NO per aggiornare lo stato del guasto");
            }
        }

        // METODI

        public void Accendi(string accendi) {
            string accendiMinuscolo = accendi.ToLower();
            if (accendiMinuscolo == "on") {
                this.statoAccensione = true;
                Console.WriteLine("avvio in corso...");
            } else {
                this.statoAccensione = false;
                Console.WriteLine("avvio non riuscito\nscrivere ON per accendere");
            }
        }

        public void Spegni(string spegni) {
            string spegniMinuscolo = spegni.ToLower();
            if (spegniMinuscolo == "off") {
                this.statoAccensione = false;
                Console.WriteLine("spegnimento in corso...");
            } else {
                this.statoAccensione = false;
                Console.WriteLine("spegnimento non riuscito\nscrivere OFF per spegnere");
            }
        }


        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.WriteLine("Tipologia Elettrodomestico: " + this.tipoElettrodomestico);
            Console.WriteLine("Condizione: " + this.condizione);
            Console.WriteLine("Stato di Accensione: " + this.statoAccensione);
            Console.WriteLine("guasto: " + this.guasto);
            Console.WriteLine();
        }
    }


}
