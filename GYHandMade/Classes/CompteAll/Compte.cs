
using GYProject.Classes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GYProject.Classes.CompteAll
{
    public class Compte
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public decimal Solde { get; set; }
        //public string Type { get; set; }
        public List<Transaction> transactions { get; set; }
        public Compte()
        {  }
        public Compte(string nom, decimal solde)
        {
            this.Nom = nom;
            this.Solde = solde;
            transactions = new List<Transaction>();
        }

        // Méthode pour ajouter une transaction au compte
        public void AddCompte()
        {
            CompteDB.AddCompte(this);
        }

      /*  public void CreerPaiementPlanifie(PaiementPlanifie paiement)
        {
            // Logique pour créer un paiement planifié
        }*/
        public void Transfert(Compte compteDestination, decimal montant)
        {
            // Logique de transfert de fonds entre comptes
        }


    }
}
