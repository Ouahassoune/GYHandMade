using GYProject.Database;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYHandMade.UserControls
{
    public partial class Rp : UserControl
    {
        public Rp()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Créez une instance de DatabaseManager
            DatabaseManager databaseManager = DatabaseManager.Instance;

            // Définissez votre requête SQL
            string query = "SELECT * FROM transactions";

            // Appelez la méthode ExecuteQuery de DatabaseManager pour récupérer les données dans un DataTable
            DataTable dataTable = databaseManager.ExecuteQuery(query);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            //reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
