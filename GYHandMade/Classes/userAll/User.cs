using GYProject.Classes.userAll;
using GYProject.Classes.CompteAll;

using GYProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic.ApplicationServices;

namespace GYProject.Classes.userAll
{
    internal class User
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string password { get; set; }
        public string email { get; set; }
       public byte[] img { get; set; }

        public User()   {  }
        public User(string nom, string prenom, string email, string password, byte[] image)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.password = password;

            this.img = image;
        }

        /**********************les methodes de user ***********/
        //ajouter user
        public void TransferAmount(String sourceAccount, String destinationAccount, decimal amount) {
            userDB.TransferAmoun(this.id, sourceAccount, destinationAccount, amount);

        }



        public decimal GetSolde(String nameofcompte)
        {
            return userDB.GetSold(this.id,nameofcompte);

        }
        public void AddUser()
        {
            Compte cm11 = new Compte("Espece", 0);
            Compte cm12 = new Compte("Banc", 0);
            int id=userDB.AddUserWithComptes(this, cm11, cm12);
            this.id = id;
           
        }


        /**********************les methodes pour les transactionn ***********/

        //afficher tout les  transaction de cet user
        public List<Transaction> AllTransaction()
        {
            return userDB.ShowAllTransaction(this.id);
        }


        //afficher juste 3 derniere transaction: 
        public List<Transaction> GetLastThreeTransactions()
        {
            return userDB.getLast(this.id );
        }
        

        //afficher le total du montant des  transaction de type expense (depense)
        public decimal TotalExpenses()
        {
            return userDB.GetTotalExpenses(this.id);
        }
        public decimal getTotalIncomes()
        {
            return userDB.getTotalIncomes(this.id);
        }

        public int GetTotalTransactionsCount()
        {
            // Récupérer toutes les transactions de l'utilisateur
            List<Transaction> transactions = AllTransaction();

            // Retourner le nombre total de transactions
            return transactions.Count;
        }
        public decimal GetAccountBalance()
        {
            // Calculer le solde du compte (total des revenus - total des dépenses)
            if(getTotalIncomes() - TotalExpenses() < 0)
            {
                MessageBox.Show("Add to your incomes to continue this transaction", "Erreur de transfert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return getTotalIncomes() - TotalExpenses();
        }


       //retourner la situation finnanciere de user
        public string AnalyzeFinancialState()
        {
            // Appeler la méthode de la classe UserDB pour analyser l'état financier
            return userDB.AnalyzeFinancialState(this.id);
        }
        // retourner les futur trans
        public List<Transaction> FuturTransactions()
        {
            return userDB.GetRecentTransactions(this.id);
        }



        //ajouter transaction a ce user
        public void AjouterTransaction(Transaction transaction)
        {
            TransactionDB.AddTransaction(transaction, this.id);
        }
        public  void EffectuerTransaction(Transaction transaction, Compte compte)
        {
            TransactionDB.AddTransaction(transaction, this.id);            // Appeler la méthode correspondante dans userDB
            userDB.EffectuerTransaction(transaction, compte);
        }



        /***************************les methodes pour le Compte***********/

        //afficher tout les compte du user  courant
        public List<Compte> AllCompte()
        {
            return userDB.ShowAllComptes(this.id);
        }
        
        // Méthode pour ajouter un compte à l'utilisateur
        public void AjouterCompte(Compte compte)
        {
            userDB.AddUserCompte(this.id, compte);
        }

        public void AddToCompte(String nameOfCompte, decimal amount)
        {
            Console.WriteLine("id= dans meth " + this.id);

            CompteDB.AddAmountToAccount(this.id, nameOfCompte, amount);
        }

        public void RemoveFromCompte(String nameOfCompte, decimal amount)
        {
            CompteDB.RemoveAmountFromAccount(this.id, nameOfCompte, amount);
        }











    }
}
