using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Extensions;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace WindowsFormsApp1
{
    public partial class CreateMeeting : Form
    {
        public CreateMeeting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var firstNameValidation = txtFirstName.Text.IsValid();
            var lastNameValidation = txtLastName.Text.IsValid();
            var topicValidation = txtTopic.Text.IsValid();
            var contentValidation = txtContent.Text.IsValid();
            var secretKeyValidation = txtSecretKey.Text.IsValid();
            var dateValidation = lbSelectedDates.Items.Count > 0;
            if (!firstNameValidation || !lastNameValidation || !contentValidation || !topicValidation || !secretKeyValidation || !dateValidation)
            {
                MessageBox.Show("Lütfen bütün alanları eksiksiz bir şekilde doldurunuz");
                return;
            }
            var newMeet = new MeetingModel
            {
                CreateMeetingIdInformation = $"{txtFirstName.Text} {txtLastName.Text}",
                Topic = txtTopic.Text,
                Content = txtContent.Text,
                Dates = lbSelectedDates.Items.Cast<string>().ToList(),
                SecretKey = txtSecretKey.Text,
                AdminSecretKey = txtAdminSecretKey.Text
            };

            var fileName = $"{newMeet.SecretKey}.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Sınıfı XML olarak serileştir
                XmlSerializer serializer = new XmlSerializer(typeof(MeetingModel));
                serializer.Serialize(writer, newMeet);
            }
            MessageBox.Show($"Toplantı Kaydı Başarıyla oluşturulmuştur. {newMeet.SecretKey} kodu ile katılabilirsiniz");
            this.Close();
        }

        private void btnCreateSecretKey_Click(object sender, EventArgs e)
        {
            var key = Guid.NewGuid();
            txtSecretKey.Text = key.ToString();
        }

        private void btnAddDate_Click(object sender, EventArgs e)
        {
            var selectedDate = mcDates.SelectionRange.Start.ToShortDateString();
            lbSelectedDates.Items.Add(selectedDate);
        }

        private void btnDeleteSelectedDate_Click(object sender, EventArgs e)
        {
            if (lbSelectedDates.SelectedIndex != -1)
            {
                lbSelectedDates.Items.RemoveAt(lbSelectedDates.SelectedIndex);
            }
        }

        private void CreateMeeting_Load(object sender, EventArgs e)
        {
            var key = Guid.NewGuid();
            txtAdminSecretKey.Text = key.ToString();
        }
    }
}
