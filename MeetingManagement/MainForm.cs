using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extensions;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateMeet_Click(object sender, EventArgs e)
        {
            CreateMeeting createMeeting = new CreateMeeting();
            createMeeting.ShowDialog();
        }

        private void btnJoinMeet_Click(object sender, EventArgs e)
        {
            try
            {
                var validateSecretKey = txtSecretKey.Text.IsValid();
                if (!validateSecretKey)
                {
                    MessageBox.Show("Lütfen Toplantı Kodunu Giriniz");
                    return;
                }
                var chooseAvaliableDate = new ChooseAvaliableDate(txtSecretKey.Text);
                chooseAvaliableDate.ShowDialog();
            }
            catch
            {

            }

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var validateSecretKey = txtSecretKey.Text.IsValid();
                var validateAdminSecretKEy = txtAdminSecretKey.Text.IsValid();
                if (!validateSecretKey || !validateAdminSecretKEy)
                {
                    MessageBox.Show("Lütfen Toplantı Kodunu Giriniz");
                    return;
                }
                var admin = new Admin(txtAdminSecretKey.Text, txtSecretKey.Text);
                admin.ShowDialog();
            }
            catch
            {

            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
