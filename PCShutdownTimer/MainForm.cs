using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PCShutdownTimer
{
    public partial class MainForm : Form
    {

        bool isEditedComboBox = false; // флаг первого изменения ComboBox
        /// <summary>
        /// Фоновая задача обновления времени
        /// </summary>
        BackgroundWorker timeBW = new BackgroundWorker();
        /// <summary>
        /// Фоновая задача будильника
        /// </summary>
        BackgroundWorker alarmBW;
        // Будильник
        int alarmHour;
        int alarmMinute;
        bool isAlarm = false;
        public MainForm()
        {
            InitializeComponent();
            Location = new Point(300, 300);
            // Заполнение ComboBox
            String str;
            for (int i=0; i<24; i++)
            {
                str = i<10 ? "0"+i.ToString() : i.ToString();
                hourComboBox.Items.Add(str);
            }
            for(int i=0; i<60; i++)
            {
                str = i < 10 ? "0"+i.ToString() : i.ToString();
                minuteComboBox.Items.Add(str);
            }
            // Фоновые задачи
            timeBW.DoWork += showTime;
            timeBW.RunWorkerAsync();
            alarmBW = new BackgroundWorker();
            alarmBW.DoWork += checkAlarmWork;
            alarmBW.WorkerSupportsCancellation = true;
        }

        //  Функция показа времени
        private void showTime(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                timeLabel.Invoke(new Action(() => { timeLabel.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"); }));
                // Обновляет комбобоксы при первом запуске
                if (!isEditedComboBox)
                {
                    String h = DateTime.Now.ToString("HH");
                    String m = DateTime.Now.ToString("mm");
                    hourComboBox.Invoke(new Action(() => { hourComboBox.SelectedIndex = hourComboBox.FindString(h); }));
                    minuteComboBox.Invoke(new Action(() => { minuteComboBox.SelectedIndex = minuteComboBox.FindString(m); }));
                }
                Thread.Sleep(990);
            }
        }

        private void minuteComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            isEditedComboBox = true;
        }

        private void hourComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            isEditedComboBox = true;
        }
        // Активация будильника
        private void alarmCheckBox_Click(object sender, EventArgs e)
        {
            if (alarmCheckBox.Checked)
            {
                alarmHour = hourComboBox.SelectedIndex;
                alarmMinute = minuteComboBox.SelectedIndex;
                hourComboBox.Enabled = false;
                minuteComboBox.Enabled = false;
                isAlarm = true;
                alarmBW.RunWorkerAsync();
            }
            else
            {
                hourComboBox.Enabled = true;
                minuteComboBox.Enabled = true;
                isAlarm=false;
                alarmBW.CancelAsync();
            }
        }
        // Фоновая задача проверки срабатывания будильника
        private void checkAlarmWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            while (true)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(5);
                if (DateTime.Now.Hour == alarmHour && DateTime.Now.Minute == alarmMinute && DateTime.Now.Second == 0)
                {
                    string command = "shutdown /s /t 10";
                    System.Diagnostics.Process.Start("cmd.exe", "/C " + command);
                    Application.Exit();
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        // Функции сворачивания в трей
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                if (isAlarm)
                {
                    notifyIcon.Text = "Компьютер будет в выключен в " + alarmHour  + ":" + alarmMinute;
                }
            }
        }
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
