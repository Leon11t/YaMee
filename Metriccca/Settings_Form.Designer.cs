namespace Metriccca
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tBoxRefreshTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxCounterID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxTocen = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checBoxDateAuto = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxDate2 = new System.Windows.Forms.TextBox();
            this.tBoxDate1 = new System.Windows.Forms.TextBox();
            this.trackBarTranspatenci = new System.Windows.Forms.TrackBar();
            this.lable7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranspatenci)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxRefreshTime
            // 
            this.tBoxRefreshTime.Location = new System.Drawing.Point(6, 19);
            this.tBoxRefreshTime.Name = "tBoxRefreshTime";
            this.tBoxRefreshTime.Size = new System.Drawing.Size(45, 20);
            this.tBoxRefreshTime.TabIndex = 1;
            this.tBoxRefreshTime.TextChanged += new System.EventHandler(this.tBox_time_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "хв.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxRefreshTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(218, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інтервал оновлення";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxCounterID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tBoxTocen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Яндекс авторизація";
            // 
            // tBoxCounterID
            // 
            this.tBoxCounterID.Location = new System.Drawing.Point(6, 73);
            this.tBoxCounterID.Name = "tBoxCounterID";
            this.tBoxCounterID.Size = new System.Drawing.Size(320, 21);
            this.tBoxCounterID.TabIndex = 3;
            this.tBoxCounterID.TextChanged += new System.EventHandler(this.tBoxCounterID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = " ID лічильника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Токен";
            // 
            // tBoxTocen
            // 
            this.tBoxTocen.Location = new System.Drawing.Point(7, 34);
            this.tBoxTocen.Name = "tBoxTocen";
            this.tBoxTocen.Size = new System.Drawing.Size(319, 21);
            this.tBoxTocen.TabIndex = 0;
            this.tBoxTocen.TextChanged += new System.EventHandler(this.tBoxTocen_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checBoxDateAuto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tBoxDate2);
            this.groupBox3.Controls.Add(this.tBoxDate1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(3, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 79);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Період відтворення данних";
            // 
            // checBoxDateAuto
            // 
            this.checBoxDateAuto.AutoSize = true;
            this.checBoxDateAuto.Location = new System.Drawing.Point(149, 22);
            this.checBoxDateAuto.Name = "checBoxDateAuto";
            this.checBoxDateAuto.Size = new System.Drawing.Size(54, 19);
            this.checBoxDateAuto.TabIndex = 6;
            this.checBoxDateAuto.Text = "Авто";
            this.checBoxDateAuto.UseVisualStyleBackColor = true;
            this.checBoxDateAuto.CheckedChanged += new System.EventHandler(this.checBoxDateAuto_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "По:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Від:";
            // 
            // tBoxDate2
            // 
            this.tBoxDate2.Location = new System.Drawing.Point(43, 46);
            this.tBoxDate2.Name = "tBoxDate2";
            this.tBoxDate2.Size = new System.Drawing.Size(100, 21);
            this.tBoxDate2.TabIndex = 1;
            this.tBoxDate2.TextChanged += new System.EventHandler(this.tBoxDate2_TextChanged);
            // 
            // tBoxDate1
            // 
            this.tBoxDate1.Location = new System.Drawing.Point(43, 20);
            this.tBoxDate1.Name = "tBoxDate1";
            this.tBoxDate1.Size = new System.Drawing.Size(100, 21);
            this.tBoxDate1.TabIndex = 0;
            this.tBoxDate1.TextChanged += new System.EventHandler(this.tBoxDate1_TextChanged);
            // 
            // trackBarTranspatenci
            // 
            this.trackBarTranspatenci.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.trackBarTranspatenci.Location = new System.Drawing.Point(3, 233);
            this.trackBarTranspatenci.Minimum = 1;
            this.trackBarTranspatenci.Name = "trackBarTranspatenci";
            this.trackBarTranspatenci.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarTranspatenci.Size = new System.Drawing.Size(209, 45);
            this.trackBarTranspatenci.TabIndex = 6;
            this.trackBarTranspatenci.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTranspatenci.Value = 10;
            this.trackBarTranspatenci.ValueChanged += new System.EventHandler(this.trackBarTranspatenci_ValueChanged);
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable7.Location = new System.Drawing.Point(64, 214);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(82, 16);
            this.lable7.TabIndex = 7;
            this.lable7.Text = "Прозорість";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 281);
            this.Controls.Add(this.lable7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.trackBarTranspatenci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_Form_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranspatenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxRefreshTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxTocen;
        private System.Windows.Forms.TextBox tBoxCounterID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checBoxDateAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxDate2;
        private System.Windows.Forms.TextBox tBoxDate1;
        private System.Windows.Forms.TrackBar trackBarTranspatenci;
        private System.Windows.Forms.Label lable7;
    }
}