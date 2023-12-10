namespace WindowsFormsApp1
{
    partial class ChooseAvaliableDate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateMeetingIdInformation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtParticipantName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSelectedDates = new System.Windows.Forms.ListBox();
            this.txtSelectedDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecretKey.Location = new System.Drawing.Point(41, 108);
            this.txtSecretKey.Multiline = true;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.ReadOnly = true;
            this.txtSecretKey.Size = new System.Drawing.Size(471, 41);
            this.txtSecretKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplantı Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplantıyı Oluşturan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCreateMeetingIdInformation
            // 
            this.txtCreateMeetingIdInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCreateMeetingIdInformation.Location = new System.Drawing.Point(41, 187);
            this.txtCreateMeetingIdInformation.Multiline = true;
            this.txtCreateMeetingIdInformation.Name = "txtCreateMeetingIdInformation";
            this.txtCreateMeetingIdInformation.ReadOnly = true;
            this.txtCreateMeetingIdInformation.Size = new System.Drawing.Size(471, 41);
            this.txtCreateMeetingIdInformation.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "İçerik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Konu";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtContent.Location = new System.Drawing.Point(41, 332);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(471, 151);
            this.txtContent.TabIndex = 11;
            // 
            // txtTopic
            // 
            this.txtTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTopic.Location = new System.Drawing.Point(41, 258);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.ReadOnly = true;
            this.txtTopic.Size = new System.Drawing.Size(471, 41);
            this.txtTopic.TabIndex = 10;
            // 
            // txtParticipantName
            // 
            this.txtParticipantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParticipantName.Location = new System.Drawing.Point(546, 104);
            this.txtParticipantName.Multiline = true;
            this.txtParticipantName.Name = "txtParticipantName";
            this.txtParticipantName.Size = new System.Drawing.Size(262, 41);
            this.txtParticipantName.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Katılımcı Ad Soyad";
            // 
            // lbSelectedDates
            // 
            this.lbSelectedDates.FormattingEnabled = true;
            this.lbSelectedDates.ItemHeight = 16;
            this.lbSelectedDates.Location = new System.Drawing.Point(549, 170);
            this.lbSelectedDates.Name = "lbSelectedDates";
            this.lbSelectedDates.Size = new System.Drawing.Size(259, 244);
            this.lbSelectedDates.TabIndex = 30;
            this.lbSelectedDates.SelectedIndexChanged += new System.EventHandler(this.lbSelectedDates_SelectedIndexChanged);
            // 
            // txtSelectedDate
            // 
            this.txtSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSelectedDate.Location = new System.Drawing.Point(546, 442);
            this.txtSelectedDate.Multiline = true;
            this.txtSelectedDate.Name = "txtSelectedDate";
            this.txtSelectedDate.ReadOnly = true;
            this.txtSelectedDate.Size = new System.Drawing.Size(259, 41);
            this.txtSelectedDate.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Seçilen Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tarih Seç";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(41, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(767, 34);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(43, 21);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(44, 16);
            this.lbMessage.TabIndex = 35;
            this.lbMessage.Text = "label1";
            // 
            // ChooseAvaliableDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 583);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSelectedDate);
            this.Controls.Add(this.lbSelectedDates);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtParticipantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreateMeetingIdInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecretKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseAvaliableDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplantı Tarihi Belirle";
            this.Load += new System.EventHandler(this.ChooseAvaliableDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreateMeetingIdInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtParticipantName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbSelectedDates;
        private System.Windows.Forms.TextBox txtSelectedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbMessage;
    }
}