using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
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
                if (!string.IsNullOrEmpty(_processes[0].ProcessName))
                {
                    groupBox1.Enabled = true;
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
                timerNumSpace.Interval = 2878;
                MobSelect.Interval = Convert.ToInt32(textBox11.Text);
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
            #endregion
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
            }
            catch (Exception exception)
            {
                Logger(exception);
            }

            #endregion

        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
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
                timerNumSpace.Stop();
                MobSelect.Stop();
            }
            catch (Exception exception)
            {
                Logger(exception);
            }

        }
        private void buttonOpacity_Click(object sender, EventArgs e)
        {
            if (Opacity < 0.5)
                Opacity += .05;

            Opacity -= .05;

        }
        #endregion

        #region Timerla

        private void timerNum1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("1");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }

        }

        private void timerNum2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("2");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("3");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum4_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("4");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum5_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("5");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum6_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("6");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum7_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("7");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum8_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("8");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum9_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("9");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNum0_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("0");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void timerNumSpace_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send(" ");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }

        private void MobSelect_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AutoItX.WinWaitActive(_processes[0].MainWindowTitle) != 0)
                {
                    AutoItX.Send("z");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }
        }
        #endregion

        #region Loglama

        private void Logger(Exception exception)
        {
            if (Directory.Exists(@"C:\LogTranier"))
            {
                Directory.CreateDirectory(@"C:\LogTranier");
            }
            TextWriter dosya = new StreamWriter(@"C:\LogTranier\" + DateTime.Now + ".txt");
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
                ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);

                // Using operating shell and setting the ProcessStartInfo.Verb to “runas” will let it run as admin
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";

                // Start the application as new process
                Process.Start(processStartInfo);

                // Shut down the current (old) process
                System.Windows.Forms.Application.Exit();
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
