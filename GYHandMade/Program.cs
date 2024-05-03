using GYProject.Classes;
using GYProject.Classes.userAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYHandMade
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // User us = userDB.GetUserById(9);
            //us.AllTransaction();
            //List<Transaction> transactions = TransactionDB.GetAllTransactions();
            //foreach (Transaction transaction in transactions)
            //{
              //  Console.WriteLine($"ID: {transaction.ID}, type: {transaction.Type},Description: {transaction.Description}, Montant: {transaction.Montant}, Date: {transaction.Date}");
           // }
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        
            
        }
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
