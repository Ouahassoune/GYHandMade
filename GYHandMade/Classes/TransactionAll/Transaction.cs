using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYProject.Classes.CompteAll;
using GYProject.Classes.userAll;


namespace GYProject.Classes
{
    public class Transaction
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string category { get; set; }

        public decimal Montant { get; set; }
        public DateTime Date { get; set; }

        public Transaction(){  }
        public Transaction(string Description, decimal montant,string type)
        {
            this.Type = type;
            this.Description = Description;
            Montant = montant;
            Date = DateTime.Now; // Date actuelle
        }


  /*     public void AppliquerTransaction(Compte compte, string type)
        {
            if (type == "revenu")
            {
                compte.Solde += Montant; // Augmentation du solde pour un revenu
            }
            else if (type == "depense")
            {
                compte.Solde -= Montant; // Diminution du solde pour une dépense
            }
            else
            {
                throw new ArgumentException("Type de transaction non valide.");
            }
        }*/

      

        public void CreerPaiementPlanifie(string Frequence, int Duree)//typeCompte pour savoir est ce quon va ajouter un montant au destin ou le contrare
        {
            // Logique pour créer un paiement planifié
        }



       public void transfert(Compte sourceCompte, Compte destinCompte)
        {
            if (Montant <= 0 || Montant > sourceCompte.Solde)
            {
                throw new InvalidOperationException("Montant de transfert invalide.");
            }
            sourceCompte.Solde -= Montant;
            destinCompte.Solde += Montant;
        }

    }
}
