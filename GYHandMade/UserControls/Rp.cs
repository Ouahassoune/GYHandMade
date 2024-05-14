using GYProject.Classes.userAll;
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
using System.IO;
using System.Net;
using System.Net.Mail;


namespace GYHandMade.UserControls
{
    public partial class Rp : UserControl
    {

        internal User user = null;


        public Rp()
        {
            InitializeComponent();
        }

        // Method to set the user for the report
        internal void SetUser(User user)
        {
            this.user = user;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                // Define your query to fetch data for the report
                string query = "SELECT * FROM transactions WHERE Id = @UserId";

                // Set up parameters for the SQL query
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@UserId", user.id);

                // Call the ExecuteQuery method of DatabaseManager to retrieve data in a DataTable
                DataTable dataTable = GYProject.Database.DatabaseManager.Instance.ExecuteQuery3(query, parameters);

                // Clear existing report data sources
                this.reportViewer1.LocalReport.DataSources.Clear();

                // Add your data source to the report
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));

                // Set the report path
                this.reportViewer1.LocalReport.ReportPath = "Report2.rdlc";

                // Refresh the report viewer
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to export the report to a PDF file
        private void ExportReportToPdf(DataTable dataTable)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            // Render the report as a PDF
            byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out extension,
                out streamids, out warnings);

            // Set the output file path (change as needed)
            string outputPath = "Report.pdf";

            // Write the PDF bytes to a file
            using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            Console.WriteLine("the user email is :"+user.email);
            Console.WriteLine("the user nom is :" + user.nom);
            // Send the generated PDF as an email attachment
            SendEmailWithAttachment(user.email, outputPath);
        }
        //youssef@ouahassoune.com
        private void SendEmailWithAttachment(string recipientEmail, string attachmentFilePath)
        {
            // Email configuration
            string senderEmail = "easy.make.home@gmail.com";
            string senderPassword = "zaacczitswiiuwlt";
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;

            // Create a MailMessage object
            MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail);

            // Set email subject and body
            mailMessage.Subject = "PDF Report";
            mailMessage.Body = "Please find the attached PDF report.";

            // Attach the PDF file
            Attachment attachment = new Attachment(attachmentFilePath);
            mailMessage.Attachments.Add(attachment);

            // Configure SMTP client
            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

            // Send the email
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Email with PDF attachment sent successfully.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                // Define your query to fetch data for the report
                string query = "SELECT * FROM transactions WHERE Id = @UserId";

                // Set up parameters for the SQL query
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@UserId", user.id);
                Console.WriteLine("the user id is :" + user.id);

                // Call the ExecuteQuery method of DatabaseManager to retrieve data in a DataTable
                DataTable dataTable = GYProject.Database.DatabaseManager.Instance.ExecuteQuery3(query, parameters);

                // Export the report to a PDF file and send it via email
                ExportReportToPdf(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Rp_Load(object sender, EventArgs e)
        {

        }
    }
}



