using System;
using System.Windows.Forms;

namespace Metriccca
{
    

    public partial class SettingsForm : Form
    {
        Properties.Settings ps = Properties.Settings.Default;
        private readonly Form1 parentForm; //Ініціалізація фортми налаштувань
        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void tBox_time_TextChanged(object sender, EventArgs e)
        {
            ps.Timer1_var = Convert.ToInt32(tBoxRefreshTime.Text);
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {
            tBoxRefreshTime.Text = Convert.ToString(ps.Timer1_var);
            tBoxTocen.Text = ps.YaTocen;
            tBoxCounterID.Text = ps.CounterID;
            tBoxDate1.Text = ps.Date1;
            tBoxDate2.Text = ps.Date2;

            checBoxDateAuto.Checked = ps.DateAuto;
            trackBarTranspatenci.Value = ps.trackBar_var;

        }

        private void checBoxDateAuto_CheckedChanged(object sender, EventArgs e)//Вмикає щитування дати із системи, або введення в ручну
        {
            ps.Date1 = DateTime.Now.ToString("yyyyMMdd");//Дістає за маскою дату із системи
            ps.Date2 = DateTime.Now.ToString("yyyyMMdd");
            ps.DateAuto = checBoxDateAuto.Checked;

            if (checBoxDateAuto.Checked)//Робить не активними поля вводу тексту
            {
               tBoxDate1.Enabled = false;
               tBoxDate2.Enabled = false;
            }
            else
            {
                tBoxDate1.Enabled = true;
                tBoxDate2.Enabled = true;
            }     
        }

        private void Settings_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            ps.Save();
        }

        private void trackBarTranspatenci_ValueChanged(object sender, EventArgs e)//Задає прозорість головної форми
        {
            double formOPacity = Convert.ToDouble(((trackBarTranspatenci.Value) / 10.0));
            parentForm.Opacity = formOPacity;
            ps.Transparenci_var = formOPacity;
            ps.trackBar_var = trackBarTranspatenci.Value;
        }

        private void tBoxTocen_TextChanged(object sender, EventArgs e)
        {
            ps.YaTocen = tBoxTocen.Text;
        }

        private void tBoxCounterID_TextChanged(object sender, EventArgs e)
        {
            ps.CounterID = tBoxCounterID.Text;
        }

        private void tBoxDate1_TextChanged(object sender, EventArgs e)
        {
            ps.Date1 = tBoxDate1.Text;
        }

        private void tBoxDate2_TextChanged(object sender, EventArgs e)
        {
            ps.Date2 = tBoxDate2.Text;
        }

    }
}
