using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace Metriccca
{
   
    public partial class Form1 : Form
    {
        const int DISTANCE = 7; //Задає відстань прилипання у пікселях 

        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false; //Відкриття фортми налаштувань
            notifyIcon1.Visible = false; //Згортає програму в трей
        }

        public void LableDataUpdate()
        {
            label1.Text = Yandex.page_views_var;
            label2.Text = Yandex.visits_var;
            label3.Text = Yandex.visitors_var;

            notifyIcon1.Text = "Переглядів: " + Yandex.page_views_var
                               + "\nВізитів: " + Yandex.visits_var
                               + "\nВідвідувачів: " + Yandex.visitors_var;
        }

        //Ефект прилипання форми до країв екрана
        protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x0046 /* WM_WINDOWPOSCHANGING */)
                {
                    Rectangle workArea = SystemInformation.WorkingArea;
                    Rectangle rect =
                        (Rectangle)
                            Marshal.PtrToStructure((IntPtr) (IntPtr.Size*2 + m.LParam.ToInt64()), typeof (Rectangle));

                    if (rect.X <= workArea.Left + DISTANCE)
                        Marshal.WriteInt32(m.LParam, IntPtr.Size*2, workArea.Left);

                    if (rect.X + rect.Width >= workArea.Width - DISTANCE)
                        Marshal.WriteInt32(m.LParam, IntPtr.Size*2, workArea.Right - rect.Width);

                    if (rect.Y <= workArea.Top + DISTANCE)
                        Marshal.WriteInt32(m.LParam, IntPtr.Size*2 + 4, workArea.Top);

                    if (rect.Y + rect.Height >= workArea.Height - DISTANCE)
                        Marshal.WriteInt32(m.LParam, IntPtr.Size*2 + 4, workArea.Bottom - rect.Height);
                }

                base.WndProc(ref m);
            }
        


        private void Form1_Load(object sender, EventArgs e)
        {   
            Properties.Settings ps = Properties.Settings.Default; //Запамятовуе положення форми при відкритті
            Top = ps.Top;
            Left = ps.Left;

            Opacity = ps.Transparenci_var; //Задає прозорість форми
            

            timer1.Interval = (60000*ps.Timer1_var);//Задає час оновлення данних
            timer1.Start();
            Yandex.Request();//Читає данні із сервера при завантаженні форми
        }

        private void btn_sett_Click(object sender, EventArgs e)
        {
            var sett = new SettingsForm(this); //Відкриття фортми налаштувань
            sett.ShowDialog();
            //sett.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) //Згортає програму в трей
        {
            notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Yandex.Request();
            LableDataUpdate();
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
                Yandex.Request();
                LableDataUpdate();

            }
            catch (Exception)
            {

                MessageBox.Show("Перевірте з'єднання з мережею", "Сталась помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)//Відсилання запиту по кнопці
        {
            try
            {
                 Yandex.Request();
                 LableDataUpdate();
                 
            }
            catch (Exception)
            {

                MessageBox.Show("Перевірте з'єднання з мережею", "Сталась помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }

        }

        private void btn_Attach_Click(object sender, EventArgs e)//Закріплює форму поверх всіх вікон
        {
            TopMost ^= true; //Інвертує значення при кожному натисненні на кнопку
        }


        //public double Opas_var;
        //private void Form1_MouseEnter(object sender, EventArgs e)//Плавне просвітлення форми !!!!!!!!!!!!!!!!!!!!!!!!!!
        //{

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Thread.Sleep(60);
        //        Opacity = Opacity + 0.1;
                 
        //    }

        //}

        //private void Form1_MouseLeave(object sender, EventArgs e)
        //{
        //    Properties.Settings ps = Properties.Settings.Default;
        //    for (int i = 0; i < 6; i++)
        //    {
        //        Thread.Sleep(60);  
        //       ps.Transparenci_var = Opacity-0.1;
        //    }
        //}




    }

}