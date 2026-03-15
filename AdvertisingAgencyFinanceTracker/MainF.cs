using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvertisingAgencyFinanceTracker.TableObjects;

namespace AdvertisingAgencyFinanceTracker
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void MainF_Load(object sender, EventArgs e)
        {
            var rep = new AdvertisingAgencyRepository(AdvertisingAgencyDb.connectionString);
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
        }
    }
}
