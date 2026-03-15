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
    public partial class ChangePasswordF : Form
    {
        public ChangePasswordF()
        {
            InitializeComponent();
        }

        private async void changePassB_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string oldPassText = oldPassTB.Text;
            string newPassText = newPassTB.Text;

            if (!string.IsNullOrEmpty(login) && int.TryParse(oldPassText, out int oldPass) && int.TryParse(newPassText, out int newPass))
            {
                var rep = new AdvertisingAgencyRepository(AdvertisingAgencyDb.connectionString);
                bool isUpdated = await rep.UpdatePasswordAsync(login, oldPass, newPass);

                if (isUpdated)
                {
                    var authorizationF = new AuthorizationF();
                    this.Hide();
                    authorizationF.Show();
                }
                else MessageBox.Show("Данные введены некорректно");
            }
            else MessageBox.Show("Данные в полях имеют неверный формат");
        }
    }
}
