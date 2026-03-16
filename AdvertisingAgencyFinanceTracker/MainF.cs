using AdvertisingAgencyFinanceTracker.TableObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdvertisingAgencyFinanceTracker
{
    public partial class MainF : Form
    {
        static AdvertisingAgencyRepository rep = new AdvertisingAgencyRepository(AdvertisingAgencyDb.connectionString);
        public MainF()
        {
            InitializeComponent();
        }

        private void MainF_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(600, 380);
            statusCB.Items.Add("Все");
            statusCB.Items.Add("Оплачен");
            statusCB.Items.Add("Не оплачен");

            var proposals = rep.GetProposals();

            foreach (var proposal in proposals)
            {
                proposalsWithClientsDGV.Rows.Add(proposal.ClientProposal.Company_name,
                    proposal.ClientProposal.Contact_person,
                    proposal.ClientProposal.Phone_number,
                    proposal.DateDisplay,
                    proposal.Amount);
            }

            amountInInvoice.Text = Convert.ToString(rep.GetAmountInInvoice());

            var payments = rep.GetPayments();

            foreach (var payment in payments)
            {
                paymentsDGV.Rows.Add(payment.DateDisplay, payment.Amount);
            }

            var expenses = rep.GetExpenses();

            foreach (var expense in expenses)
            {
                expensesDGV.Rows.Add(expense.DateDisplay, expense.Amount);
            }

            InputInvoice();
        }

        private void paymentsB_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1140, 380);
            paymentsB.Visible = false;
            rollUpB.Visible = true;
        }

        private void rollUpB_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(600, 380);
            rollUpB.Visible = false;
            paymentsB.Visible = true;
        }

        private void InputInvoice()
        {
            var clientsInvoices = rep.GetInvoices();

            foreach (var clientInvoice in clientsInvoices)
            {
                invoicesWithClentsDGV.Rows.Add(clientInvoice.Client.Company_name,
                    clientInvoice.Client.Contact_person,
                    clientInvoice.Invoice.DateDisplay,
                    clientInvoice.Invoice.Amount,
                    clientInvoice.Invoice.Status);
            }
        }

        private void InputInvoiceByStatus(string status)
        {
            var clientsInvoices = rep.GetInvoicesByStatus(status);

            foreach (var clientInvoice in clientsInvoices)
            {
                invoicesWithClentsDGV.Rows.Add(clientInvoice.Client.Company_name,
                    clientInvoice.Client.Contact_person,
                    clientInvoice.Invoice.DateDisplay,
                    clientInvoice.Invoice.Amount,
                    clientInvoice.Invoice.Status);
            }
        }

        private void invoicesDisplayB_Click(object sender, EventArgs e)
        {
            invoicesWithClentsDGV.Rows.Clear();
            string status = statusCB.Text;

            switch (status)
            {
                case "Все":
                    InputInvoice();
                    break;
                case "Оплачен":
                    InputInvoiceByStatus("Оплачен");
                    break;
                case "Не оплачен":
                    InputInvoiceByStatus("Не оплачен");
                    break;
                default:
                    InputInvoice();
                    break;
            }
        }
    }
}
