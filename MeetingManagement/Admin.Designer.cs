namespace WindowsFormsApp1
{
    partial class Admin
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSelectedDates = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Konu";
            // 
            // txtTopic
            // 
            this.txtTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTopic.Location = new System.Drawing.Point(43, 32);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.ReadOnly = true;
            this.txtTopic.Size = new System.Drawing.Size(471, 41);
            this.txtTopic.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(471, 81);
            this.button1.TabIndex = 19;
            this.button1.Text = "Seçilen Tarih\'i Toplantı Tarihi olarak belirle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSelectedDates
            // 
            this.lbSelectedDates.FormattingEnabled = true;
            this.lbSelectedDates.ItemHeight = 16;
            this.lbSelectedDates.Location = new System.Drawing.Point(43, 98);
            this.lbSelectedDates.Name = "lbSelectedDates";
            this.lbSelectedDates.Size = new System.Drawing.Size(471, 116);
            this.lbSelectedDates.TabIndex = 18;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSelectedDates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbSelectedDates;
    }
}