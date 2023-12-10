namespace WindowsFormsApp1
{
    partial class CreateMeeting
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mcDates = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateSecretKey = new System.Windows.Forms.Button();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.lbSelectedDates = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedDate = new System.Windows.Forms.Button();
            this.txtAdminSecretKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Location = new System.Drawing.Point(26, 97);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(230, 41);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.Location = new System.Drawing.Point(262, 97);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(235, 41);
            this.txtLastName.TabIndex = 1;
            // 
            // txtTopic
            // 
            this.txtTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTopic.Location = new System.Drawing.Point(26, 171);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(471, 41);
            this.txtTopic.TabIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtContent.Location = new System.Drawing.Point(26, 245);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(471, 249);
            this.txtContent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oluşturan Ad";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 614);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(758, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oluşturan Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Konu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "İçerik";
            // 
            // mcDates
            // 
            this.mcDates.AllowDrop = true;
            this.mcDates.Location = new System.Drawing.Point(522, 115);
            this.mcDates.Name = "mcDates";
            this.mcDates.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tarih";
            // 
            // btnCreateSecretKey
            // 
            this.btnCreateSecretKey.Location = new System.Drawing.Point(29, 536);
            this.btnCreateSecretKey.Name = "btnCreateSecretKey";
            this.btnCreateSecretKey.Size = new System.Drawing.Size(471, 55);
            this.btnCreateSecretKey.TabIndex = 13;
            this.btnCreateSecretKey.Text = "Toplantı Kodu Oluştur";
            this.btnCreateSecretKey.UseVisualStyleBackColor = true;
            this.btnCreateSecretKey.Click += new System.EventHandler(this.btnCreateSecretKey_Click);
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecretKey.Location = new System.Drawing.Point(525, 536);
            this.txtSecretKey.Multiline = true;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.ReadOnly = true;
            this.txtSecretKey.Size = new System.Drawing.Size(262, 55);
            this.txtSecretKey.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toplantı Kodu";
            // 
            // btnAddDate
            // 
            this.btnAddDate.Location = new System.Drawing.Point(522, 335);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(262, 23);
            this.btnAddDate.TabIndex = 16;
            this.btnAddDate.Text = "Tarih Ekle";
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // lbSelectedDates
            // 
            this.lbSelectedDates.FormattingEnabled = true;
            this.lbSelectedDates.ItemHeight = 16;
            this.lbSelectedDates.Location = new System.Drawing.Point(525, 365);
            this.lbSelectedDates.Name = "lbSelectedDates";
            this.lbSelectedDates.Size = new System.Drawing.Size(259, 100);
            this.lbSelectedDates.TabIndex = 17;
            // 
            // btnDeleteSelectedDate
            // 
            this.btnDeleteSelectedDate.Location = new System.Drawing.Point(522, 471);
            this.btnDeleteSelectedDate.Name = "btnDeleteSelectedDate";
            this.btnDeleteSelectedDate.Size = new System.Drawing.Size(262, 23);
            this.btnDeleteSelectedDate.TabIndex = 18;
            this.btnDeleteSelectedDate.Text = "Seçileni Sil";
            this.btnDeleteSelectedDate.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedDate.Click += new System.EventHandler(this.btnDeleteSelectedDate_Click);
            // 
            // txtAdminSecretKey
            // 
            this.txtAdminSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSecretKey.Location = new System.Drawing.Point(328, 22);
            this.txtAdminSecretKey.Multiline = true;
            this.txtAdminSecretKey.Name = "txtAdminSecretKey";
            this.txtAdminSecretKey.ReadOnly = true;
            this.txtAdminSecretKey.Size = new System.Drawing.Size(471, 41);
            this.txtAdminSecretKey.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(42, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 48);
            this.label7.TabIndex = 20;
            this.label7.Text = "Buradaki Kodu lütfen kaybetmeyiniz. \r\nToplantı Tarihini Admin olarak belirleyebil" +
    "mek\r\n için bu kodu kullanınız.";
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 669);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdminSecretKey);
            this.Controls.Add(this.btnDeleteSelectedDate);
            this.Controls.Add(this.lbSelectedDates);
            this.Controls.Add(this.btnAddDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.btnCreateSecretKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mcDates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplantı Oluştur";
            this.Load += new System.EventHandler(this.CreateMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar mcDates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateSecretKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.ListBox lbSelectedDates;
        private System.Windows.Forms.Button btnDeleteSelectedDate;
        private System.Windows.Forms.TextBox txtAdminSecretKey;
        private System.Windows.Forms.Label label7;
    }
}