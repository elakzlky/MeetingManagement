using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        private string _secretKey;
        private string _adminSecretKey;
        private MeetingModel _meetingModel;
        public Admin(string adminSecretKey, string secretKey)
        {
            InitializeComponent();
            _secretKey = secretKey;
            _adminSecretKey = adminSecretKey;
            try
            {
                uploadMeeting();
            }
            catch
            {
                MessageBox.Show("Böyle bir toplantı kaydı bulunmaktadır");
                this.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void uploadMeeting()
        {
            var filePath = $"{_secretKey}.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(MeetingModel));
                _meetingModel = (MeetingModel)serializer.Deserialize(reader);
                if(_meetingModel.AdminSecretKey != _adminSecretKey)
                {
                    MessageBox.Show("Eşleşen bir toplantı bulunamadı!");
                    this.Close();
                }
                txtTopic.Text = _meetingModel.Topic;
                lbMessage.Text = String.IsNullOrEmpty(_meetingModel.DecidedDate) ? "Toplantı tarihi belirlenmemiştir." : $"Toplantı tarihi belirlenmiştir --> {_meetingModel.DecidedDate} ";
                lbSelectedDates.Items.AddRange(_meetingModel.MeetingParticipants.Select(x=> x.FullName + " - " + x.Date).ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _meetingModel.DecidedDate = lbSelectedDates.Items[lbSelectedDates.SelectedIndex].ToString().Split('-')[1];
            var fileName = $"{_meetingModel.SecretKey}.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Sınıfı XML olarak serileştir
                XmlSerializer serializer = new XmlSerializer(typeof(MeetingModel));
                serializer.Serialize(writer, _meetingModel);
            }
            MessageBox.Show("Başarıyla Kaydedilmiştir.");
        }
    }
}
