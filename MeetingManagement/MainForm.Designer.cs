namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.btnCreateMeet = new System.Windows.Forms.Button();
            this.btnJoinMeet = new System.Windows.Forms.Button();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminSecretKey = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateMeet
            // 
            this.btnCreateMeet.Location = new System.Drawing.Point(108, 43);
            this.btnCreateMeet.Name = "btnCreateMeet";
            this.btnCreateMeet.Size = new System.Drawing.Size(563, 97);
            this.btnCreateMeet.TabIndex = 0;
            this.btnCreateMeet.Text = "Toplantı Oluştur";
            this.btnCreateMeet.UseVisualStyleBackColor = true;
            this.btnCreateMeet.Click += new System.EventHandler(this.btnCreateMeet_Click);
            // 
            // btnJoinMeet
            // 
            this.btnJoinMeet.Location = new System.Drawing.Point(108, 243);
            this.btnJoinMeet.Name = "btnJoinMeet";
            this.btnJoinMeet.Size = new System.Drawing.Size(563, 97);
            this.btnJoinMeet.TabIndex = 1;
            this.btnJoinMeet.Text = "Katılımcı Takvim Uygunluğu Kontrol Et";
            this.btnJoinMeet.UseVisualStyleBackColor = true;
            this.btnJoinMeet.Click += new System.EventHandler(this.btnJoinMeet_Click);
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecretKey.Location = new System.Drawing.Point(108, 196);
            this.txtSecretKey.Multiline = true;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(563, 41);
            this.txtSecretKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplantı Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin Girişi";
            // 
            // txtAdminSecretKey
            // 
            this.txtAdminSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSecretKey.Location = new System.Drawing.Point(108, 387);
            this.txtAdminSecretKey.Multiline = true;
            this.txtAdminSecretKey.Name = "txtAdminSecretKey";
            this.txtAdminSecretKey.Size = new System.Drawing.Size(563, 41);
            this.txtAdminSecretKey.TabIndex = 6;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(108, 434);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(563, 97);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "Admin Olarak Giriş Yap";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminSecretKey);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.btnJoinMeet);
            this.Controls.Add(this.btnCreateMeet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMeet;
        private System.Windows.Forms.Button btnJoinMeet;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminSecretKey;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}

