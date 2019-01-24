using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using AutoIt;

namespace cabaltranier
{
    public partial class Main : Form
    {
        #region Tanımlamalar
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        private Process[] _processes;
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        private void Main_Load(object sender, EventArgs e)
        {
            runadmin();
            try
            {
                _processes = Process.GetProcessesByName("CabalMain");
                if (_processes.Length > 0)
                {
                    panel1.Enabled = true;
                    this.Text += _processes[0].MainWindowTitle;
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }

        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            TimerSetInterval();
            TimerSetStart();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            TimerSetStop();
        }
        private void buttonOpacity_Click(object sender, EventArgs e)
        {
            if (Opacity < 0.5)
                Opacity += .05;

            Opacity -= .05;

        }
        private void Autoxit(string key)
        {
            try
            {
                if (AutoItX.WinActive(_processes[0].MainWindowTitle) != 0)
                {
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        AutoItX.Send(key);
                    }).Start();
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }
        #endregion

        #region Timer's

        private void TimerSetInterval()
        {
            #region Interval

            try
            {
                timerNum1.Interval = Convert.ToInt32(textBox1.Text);
                timerNum2.Interval = Convert.ToInt32(textBox2.Text);
                timerNum3.Interval = Convert.ToInt32(textBox3.Text);
                timerNum4.Interval = Convert.ToInt32(textBox4.Text);
                timerNum5.Interval = Convert.ToInt32(textBox5.Text);
                timerNum6.Interval = Convert.ToInt32(textBox6.Text);
                timerNum7.Interval = Convert.ToInt32(textBox7.Text);
                timerNum8.Interval = Convert.ToInt32(textBox8.Text);
                timerNum9.Interval = Convert.ToInt32(textBox9.Text);
                timerNum0.Interval = Convert.ToInt32(textBox10.Text);
                MobSelect.Interval = Convert.ToInt32(textBox11.Text);
                timerNumSpace.Interval = Convert.ToInt32(textBox26.Text);
                timerNumYil.Interval = Convert.ToInt32(textBox25.Text);
                timerNumEs.Interval = Convert.ToInt32(textBox24.Text);
                timerAltNum1.Interval = Convert.ToInt32(textBox22.Text);
                timerAltNum2.Interval = Convert.ToInt32(textBox21.Text);
                timerAltNum3.Interval = Convert.ToInt32(textBox20.Text);
                timerAltNum4.Interval = Convert.ToInt32(textBox19.Text);
                timerAltNum5.Interval = Convert.ToInt32(textBox18.Text);
                timerAltNum6.Interval = Convert.ToInt32(textBox17.Text);
                timerAltNum7.Interval = Convert.ToInt32(textBox16.Text);
                timerAltNum8.Interval = Convert.ToInt32(textBox15.Text);
                timerAltNum9.Interval = Convert.ToInt32(textBox14.Text);
                timerAltNum0.Interval = Convert.ToInt32(textBox13.Text);
                timerAltNumYil.Interval = Convert.ToInt32(textBox12.Text);
                timerAltNumEs.Interval = Convert.ToInt32(textBox23.Text);
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
            #endregion

        }
        private void TimerSetStart()
        {
            #region Start

            try
            {
                if (checkBox1.Checked)
                {
                    timerNum1.Start();
                }
                if (checkBox2.Checked)
                {
                    timerNum2.Start();
                }
                if (checkBox3.Checked)
                {
                    timerNum3.Start();
                }
                if (checkBox4.Checked)
                {
                    timerNum4.Start();
                }
                if (checkBox5.Checked)
                {
                    timerNum5.Start();
                }
                if (checkBox6.Checked)
                {
                    timerNum6.Start();
                }
                if (checkBox7.Checked)
                {
                    timerNum7.Start();
                }
                if (checkBox8.Checked)
                {
                    timerNum8.Start();
                }
                if (checkBox9.Checked)
                {
                    timerNum9.Start();
                }
                if (checkBox10.Checked)
                {
                    timerNum0.Start();
                }
                if (checkBox11.Checked)
                {
                    timerNumSpace.Start();
                }
                if (checkBox12.Checked)
                {
                    MobSelect.Start();
                }
                if (checkBoxYil.Checked)
                {
                    timerNumYil.Start();
                }
                if (checkBoxEs.Checked)
                {
                    timerNumEs.Start();
                }
                if (checkBoxAlt1.Checked)
                {
                    timerAltNum1.Start();
                }
                if (checkBoxAlt2.Checked)
                {
                    timerAltNum2.Start();
                }
                if (checkBoxAlt2.Checked)
                {
                    timerAltNum2.Start();
                }
                if (checkBoxAlt3.Checked)
                {
                    timerAltNum3.Start();
                }
                if (checkBoxAlt4.Checked)
                {
                    timerAltNum4.Start();
                }
                if (checkBoxAlt5.Checked)
                {
                    timerAltNum5.Start();
                }
                if (checkBoxAlt6.Checked)
                {
                    timerAltNum6.Start();
                }
                if (checkBoxAlt7.Checked)
                {
                    timerAltNum7.Start();
                }
                if (checkBoxAlt8.Checked)
                {
                    timerAltNum8.Start();
                }
                if (checkBoxAlt9.Checked)
                {
                    timerAltNum9.Start();
                }
                if (checkBoxAlt0.Checked)
                {
                    timerAltNum0.Start();
                }
                if (checkBoxAltYil.Checked)
                {
                    timerAltNumYil.Start();
                }
                if (checkBoxAltEs.Checked)
                {
                    timerAltNumEs.Start();
                }

            }
            catch (Exception exception)
            {
                Logger(exception);
            }

            #endregion
        }
        private void TimerSetStop()
        {
            #region Stop
            try
            {
                timerNum1.Stop();
                timerNum2.Stop();
                timerNum3.Stop();
                timerNum4.Stop();
                timerNum5.Stop();
                timerNum6.Stop();
                timerNum7.Stop();
                timerNum8.Stop();
                timerNum9.Stop();
                timerNum0.Stop();
                timerNumYil.Stop();
                timerNumEs.Stop();
                timerNumSpace.Stop();
                MobSelect.Stop();
                timerAltNum1.Stop();
                timerAltNum2.Stop();
                timerAltNum3.Stop();
                timerAltNum4.Stop();
                timerAltNum5.Stop();
                timerAltNum6.Stop();
                timerAltNum7.Stop();
                timerAltNum8.Stop();
                timerAltNum9.Stop();
                timerAltNum0.Stop();
                timerAltNumEs.Stop();
                timerAltNumYil.Stop();
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
            #endregion
        }
        #region Timer Tick
        private void timerNum1_Tick(object sender, EventArgs e)
        {
            Autoxit("1");
        }
        private void timerNum2_Tick(object sender, EventArgs e)
        {
            Autoxit("2");
        }
        private void timerNum3_Tick(object sender, EventArgs e)
        {
            Autoxit("3");
        }
        private void timerNum4_Tick(object sender, EventArgs e)
        {
            Autoxit("4");
        }
        private void timerNum5_Tick(object sender, EventArgs e)
        {
            Autoxit("5");
        }
        private void timerNum6_Tick(object sender, EventArgs e)
        {
            Autoxit("6");
        }
        private void timerNum7_Tick(object sender, EventArgs e)
        {
            Autoxit("7");
        }
        private void timerNum8_Tick(object sender, EventArgs e)
        {
            Autoxit("8");
        }
        private void timerNum9_Tick(object sender, EventArgs e)
        {
            Autoxit("9");
        }
        private void timerNum0_Tick(object sender, EventArgs e)
        {
            Autoxit("0");
        }
        private void timerNumSpace_Tick(object sender, EventArgs e)
        {
            Autoxit(" ");
        }
        private void MobSelect_Tick(object sender, EventArgs e)
        {
            Autoxit("z");
        }
        private void timerAltNum1_Tick(object sender, EventArgs e)
        {
            Autoxit("!1");
        }

        private void timerAltNum2_Tick(object sender, EventArgs e)
        {
            Autoxit("!2");
        }

        private void timerAltNum3_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNum4_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNum5_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNum6_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNum7_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNum8_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNum9_Tick(object sender, EventArgs e)
        {

        }

        private void timerNumYil_Tick(object sender, EventArgs e)
        {

        }

        private void timerNumEs_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNum0_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNumYil_Tick(object sender, EventArgs e)
        {

        }

        private void timerAltNumEs_Tick(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region Loglama
        private void Logger(Exception exception)
        {
            Guid g = Guid.NewGuid();
            string guidString = Convert.ToBase64String(g.ToByteArray());
            guidString = guidString.Replace("=", "");
            guidString = guidString.Replace("+", "");
            if (!Directory.Exists(@"C:\LogTranier"))
            {
                Directory.CreateDirectory(@"C:\LogTranier");
            }
            TextWriter dosya = new StreamWriter(@"C:\LogTranier\" + guidString + DateTime.Now.ToString("yyyymmdd") + ".txt");
            dosya.WriteLine(exception);
            dosya.Flush();
            dosya.Close();
        }
        #endregion

        #region administrator
        private void runadmin()
        {
            #region Runadministrator
            if (!IsRunningAsAdministrator())
            {
                // Setting up start info of the new process of the same application
                ProcessStartInfo processStartInfo =
                    new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase)
                    {
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                // Using operating shell and setting the ProcessStartInfo.Verb to “runas” will let it run as admin

                // Start the application as new process
                Process.Start(processStartInfo);

                // Shut down the current (old) process
                Application.Exit();
            }


            #endregion
        }
        public static bool IsRunningAsAdministrator()
        {
            // Get current Windows user
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();

            // Get current Windows user principal
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);

            // Return TRUE if user is in role "Administrator"
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        #endregion

       
    }
}
