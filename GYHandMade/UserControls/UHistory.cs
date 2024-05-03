using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYProject.Classes;

namespace GYHandMade.UserControls
{
    public partial class UHistory : UserControl

    {
        public int Id { get; set; }
        public string Typep { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }


        public UHistory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UHistory_Load(object sender, EventArgs e)
        {

        }
        public void SetHistoryData( Transaction historyItem)
        {

            // Set properties of the UHistory control based on the provided history item

            Typep = historyItem.Type;
            Description = historyItem.Description;
            Date = historyItem.Date;
            Montant = historyItem.Montant;

            // Update UI elements to display the data
            labelType.Text = Typep;
            labelD.Text = Description;
            labelM.Text = Montant.ToString();
            labelDate.Text = Date.ToString();

        }
    }
}
