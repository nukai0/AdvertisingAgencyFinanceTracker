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

namespace AdvertisingAgencyFinanceTracker
{
    public partial class AuthorizationF : Form
    {
        string conn = AdvertisingAgencyDb.connectionString;
        public AuthorizationF()
        {
            InitializeComponent();
        }

        private async void enterB_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string passwordTB = passTB.Text;

            if (!string.IsNullOrEmpty(login) && int.TryParse(passwordTB, out int password))
            {
                var rep = new AdvertisingAgencyRepository(conn);
                Account account = await rep.GetAccountAsync(login, password);

                if (account != null)
                {
                    var mainF = new MainF();
                    this.Hide();
                    mainF.Show();
                }
                else MessageBox.Show("Ошибка");
            }
            else MessageBox.Show("Данные введены не коректно");
        }

        private void passChangeL_Click(object sender, EventArgs e)
        {
            var changePassF = new ChangePasswordF();
            this.Hide();
            changePassF.Show();
        }
    }
}
