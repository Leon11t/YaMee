using System;
using System.Xml;
using System.Windows.Forms;
using System.Threading;


namespace Metriccca
{
    public partial class Form1 : Form
    {
        private class MyClass
        {
            public static string visits_var, page_views_var, visitors_var;

            public static void Yandex_Request()
            {
                Properties.Settings ps = Properties.Settings.Default;
                String xmlUrl = "http://api-metrika.yandex.ru/stat/traffic/summary?id=" + ps.CounterID + "&date1=" +
                                ps.Date1 + "&date2=" + ps.Date2 + "&oauth_token=" + ps.YaTocen;

                XmlReader xmlReader = XmlReader.Create(xmlUrl);
                XmlDocument xml = new XmlDocument();

                xml.Load(xmlReader);
                xmlWorker(xml);
            }

            public static void xmlWorker(XmlDocument xml)
            {
                
                Properties.Settings ps = Properties.Settings.Default;
                XmlNode xmlNode = xml.GetElementsByTagName("totals").Item(0);

                if (xmlNode != null)
                    foreach (XmlNode node in xmlNode.ChildNodes)
                    {

                        switch (node.Name)
                        {
                            case "visits":
                                visits_var = node.InnerText;
                                break;
                            case "page_views":
                                page_views_var = node.InnerText;
                                break;
                            case "visitors":
                                visitors_var = node.InnerText;
                                break;
                        }

                    }
            }

        }


public Form1()
        {
            InitializeComponent();
            
            CheckForIllegalCrossThreadCalls = false; //Відкриття фортми налаштувань
            notifyIcon1.Visible = false; //Згортає програму в трей

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {   
            Properties.Settings ps = Properties.Settings.Default; //Запамятовуе положення форми при відкритті
            Top = ps.Top;
            Left = ps.Left;

            Opacity = ps.Transparenci_var; //Задає прозорість форми

            timer1.Interval = (60000*ps.Timer1_var);//Задає час оновлення данних
            timer1.Start();
            
            

        }

        private void btn_sett_Click(object sender, EventArgs e)
        {
            var sett = new SettingsForm(this); //Відкриття фортми налаштувань
            sett.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) //Згортає програму в трей
        {
            notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;

        }

        private void Form1_Resize(object sender, EventArgs e) //Згортає програму в трей
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;
            }
        }

        private void btn_Minimice_Click(object sender, EventArgs e)//Згортає програму в трей
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)//Завершує програму з діалоговим вікном
        {
            DialogResult dialogResult = MessageBox.Show(@"Справді закрити?", "Програма буде закрита!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)//Можливість перетягувати форму за любий край
        {
             
             Capture = false;
             Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
             WndProc(ref m);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//Запамятовуе положення форми при відкритті
        {
            Properties.Settings ps = Properties.Settings.Default; 
            ps.Top = Top;
            ps.Left = Left;
            ps.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)//Відсилання запиту по системному таймері
        {
            try
            {
                MyClass.Yandex_Request();
            }
            catch (Exception)
            {

                MessageBox.Show("Перевірте з'єднання з мережею", "Сталась помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }
            label1.Text = MyClass.page_views_var;
            label2.Text = MyClass.visits_var;
            label3.Text = MyClass.visitors_var;

            notifyIcon1.Text = "Яндекс Метрика" + "\nПереглядів: " + MyClass.page_views_var
                                                + "\nВізитів: " + MyClass.visits_var
                                                + "\nВідвідувачів: " + MyClass.visitors_var;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)//Відсилання запиту по кнопці
        {
            try
            {
                 MyClass.Yandex_Request();
            }
            catch (Exception)
            {

                MessageBox.Show("Перевірте з'єднання з мережею", "Сталась помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }
           
            label1.Text = MyClass.page_views_var;
            label2.Text = MyClass.visits_var;
            label3.Text = MyClass.visitors_var;
        }

        private void btn_Attach_Click(object sender, EventArgs e)//Закріплює форму поверх всіх вікон
        {
            TopMost ^= true; //Інвертує значення при кожному натисненні на кнопку
        }

        private void Form1_MouseEnter(object sender, EventArgs e)//Плавне просвітлення форми !!!!!!!!!!!!!!!!!!!!!!!!!!
        {

            //for (int i=0; i < 10; i++)
            //{
            //    Thread.Sleep(60);
            //    Opacity = Opacity+0.1;
            //}
            
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //for (int i = 0; i < 6; i++)
            //{
            //    Thread.Sleep(60);
            //    Opacity = Opacity - 0.1;
            //}
        }

    }

}