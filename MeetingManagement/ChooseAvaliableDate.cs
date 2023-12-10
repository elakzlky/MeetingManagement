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
using WindowsFormsApp1.Extensions;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ChooseAvaliableDate : Form
    {
        private readonly string _secretKey;
        private MeetingModel _meetingModel;
        public ChooseAvaliableDate(string secretKey)
        {
            InitializeComponent();
            _secretKey = secretKey;
            txtSecretKey.Text = _secretKey;
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

        private void ChooseAvaliableDate_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uploadMeeting()
        {
            var filePath = $"{_secretKey}.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(MeetingModel));
                _meetingModel = (MeetingModel)serializer.Deserialize(reader);

                txtCreateMeetingIdInformation.Text = _meetingModel.CreateMeetingIdInformation;
                txtContent.Text = _meetingModel.Content;
                txtTopic.Text = _meetingModel.Topic;
                lbSelectedDates.Items.AddRange(_meetingModel.Dates.ToArray());
            }
        }

        private void lbSelectedDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedDate.Text = lbSelectedDates.Items[lbSelectedDates.SelectedIndex].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var nameIsValid = txtParticipantName.Text.IsValid();
            var selectedDateIsValid = txtSelectedDate.Text.IsValid();
            if(!nameIsValid || !selectedDateIsValid) 
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
                return;
            }
            if(!_meetingModel.MeetingParticipants.Any())
            {
                _meetingModel.MeetingParticipants = new List<MeetingParticipant>();
            }
            _meetingModel.MeetingParticipants.Add(new MeetingParticipant
            {
                FullName = txtParticipantName.Text,
                Date = txtSelectedDate.Text
            });
            var fileName = $"{_meetingModel.SecretKey}.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Sınıfı XML olarak serileştir
                XmlSerializer serializer = new XmlSerializer(typeof(MeetingModel));
                serializer.Serialize(writer, _meetingModel);
            }
            MessageBox.Show("Başarıyla Kaydedilmiştir.");
            this.Close();
        }
    }
}
