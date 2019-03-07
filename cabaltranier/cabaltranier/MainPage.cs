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
                    Text += _processes[0].MainWindowTitle;
                }
                else
                {
                    MessageBox.Show("Cabal Main not found. Start CabalMain.exe ");
                }
            }
            catch (Exception exception)
            {
                Logger(exception);
            }

            #region Default Set Settings

            checkboxSave.Checked = Properties.Settings.Default.checksave;
            if (checkboxSave.Checked)
            {
                #region CheckBox Save
                checkBox1.Checked = Properties.Settings.Default.checkBox1;
                checkBox2.Checked = Properties.Settings.Default.checkBox2;
                checkBox3.Checked = Properties.Settings.Default.checkBox3;
                checkBox4.Checked = Properties.Settings.Default.checkBox4;
                checkBox5.Checked = Properties.Settings.Default.checkBox5;
                checkBox6.Checked = Properties.Settings.Default.checkBox6;
                checkBox7.Checked = Properties.Settings.Default.checkBox7;
                checkBox8.Checked = Properties.Settings.Default.checkBox8;
                checkBox9.Checked = Properties.Settings.Default.checkBox9;
                checkBox10.Checked = Properties.Settings.Default.checkBox10;
                checkBoxYil.Checked = Properties.Settings.Default.checkBoxYil;
                checkBoxEs.Checked = Properties.Settings.Default.checkBoxEs;
                checkBox11.Checked = Properties.Settings.Default.checkBox11;
                checkBox12.Checked = Properties.Settings.Default.checkBox12;
                checkBoxAlt1.Checked = Properties.Settings.Default.checkBoxAlt1;
                checkBoxAlt2.Checked = Properties.Settings.Default.checkBoxAlt2;
                checkBoxAlt3.Checked = Properties.Settings.Default.checkBoxAlt3;
                checkBoxAlt4.Checked = Properties.Settings.Default.checkBoxAlt4;
                checkBoxAlt5.Checked = Properties.Settings.Default.checkBoxAlt5;
                checkBoxAlt6.Checked = Properties.Settings.Default.checkBoxAlt6;
                checkBoxAlt7.Checked = Properties.Settings.Default.checkBoxAlt7;
                checkBoxAlt8.Checked = Properties.Settings.Default.checkBoxAlt8;
                checkBoxAlt9.Checked = Properties.Settings.Default.checkBoxAlt9;
                checkBoxAlt0.Checked = Properties.Settings.Default.checkBoxAlt0;
                checkBoxAltYil.Checked = Properties.Settings.Default.checkBoxAltYil;
                checkBoxAltEs.Checked = Properties.Settings.Default.checkBoxAltEs;
                #endregion

                #region TextBox Save
                textBox1.Text = Properties.Settings.Default.textBox1;
                textBox2.Text = Properties.Settings.Default.textBox2;
                textBox3.Text = Properties.Settings.Default.textBox3;
                textBox4.Text = Properties.Settings.Default.textBox4;
                textBox5.Text = Properties.Settings.Default.textBox5;
                textBox6.Text = Properties.Settings.Default.textBox6;
                textBox7.Text = Properties.Settings.Default.textBox7;
                textBox8.Text = Properties.Settings.Default.textBox8;
                textBox9.Text = Properties.Settings.Default.textBox9;
                textBox10.Text = Properties.Settings.Default.textBox10;
                textBox25.Text = Properties.Settings.Default.textBox25;
                textBox24.Text = Properties.Settings.Default.textBox24;
                textBox26.Text = Properties.Settings.Default.textBox26;
                textBox11.Text = Properties.Settings.Default.textBox11;
                textBox12.Text = Properties.Settings.Default.textBox12;
                textBox13.Text = Properties.Settings.Default.textBox13;
                textBox14.Text = Properties.Settings.Default.textBox14;
                textBox15.Text = Properties.Settings.Default.textBox15;
                textBox16.Text = Properties.Settings.Default.textBox16;
                textBox17.Text = Properties.Settings.Default.textBox17;
                textBox18.Text = Properties.Settings.Default.textBox18;
                textBox19.Text = Properties.Settings.Default.textBox19;
                textBox20.Text = Properties.Settings.Default.textBox20;
                textBox21.Text = Properties.Settings.Default.textBox21;
                textBox22.Text = Properties.Settings.Default.textBox22;
                textBox23.Text = Properties.Settings.Default.textBox23;
                #endregion
            }

            #endregion

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
            Autoxit("!3");
        }
        private void timerAltNum4_Tick(object sender, EventArgs e)
        {
            Autoxit("!4");
        }
        private void timerAltNum5_Tick(object sender, EventArgs e)
        {
            Autoxit("!5");
        }
        private void timerAltNum6_Tick(object sender, EventArgs e)
        {
            Autoxit("!6");
        }
        private void timerAltNum7_Tick(object sender, EventArgs e)
        {
            Autoxit("!7");
        }
        private void timerAltNum8_Tick(object sender, EventArgs e)
        {
            Autoxit("!8");
        }
        private void timerAltNum9_Tick(object sender, EventArgs e)
        {
            Autoxit("!9");
        }
        private void timerNumYil_Tick(object sender, EventArgs e)
        {
            Autoxit("*");
        }
        private void timerNumEs_Tick(object sender, EventArgs e)
        {
            Autoxit("-");
        }
        private void timerAltNum0_Tick(object sender, EventArgs e)
        {
            Autoxit("!0");
        }
        private void timerAltNumYil_Tick(object sender, EventArgs e)
        {
            Autoxit("!*");
        }
        private void timerAltNumEs_Tick(object sender, EventArgs e)
        {
            Autoxit("!-");
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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkboxSave.Checked)
            {
                #region CheckBox Save
                Properties.Settings.Default.checksave = checkboxSave.Checked;
                Properties.Settings.Default.checkBox1 = checkBox1.Checked;
                Properties.Settings.Default.checkBox2 = checkBox2.Checked;
                Properties.Settings.Default.checkBox3 = checkBox3.Checked;
                Properties.Settings.Default.checkBox4 = checkBox4.Checked;
                Properties.Settings.Default.checkBox5 = checkBox5.Checked;
                Properties.Settings.Default.checkBox6 = checkBox6.Checked;
                Properties.Settings.Default.checkBox7 = checkBox7.Checked;
                Properties.Settings.Default.checkBox8 = checkBox8.Checked;
                Properties.Settings.Default.checkBox9 = checkBox9.Checked;
                Properties.Settings.Default.checkBox10 = checkBox10.Checked;
                Properties.Settings.Default.checkBoxYil = checkBoxYil.Checked;
                Properties.Settings.Default.checkBoxEs = checkBoxEs.Checked;
                Properties.Settings.Default.checkBox11 = checkBox11.Checked;
                Properties.Settings.Default.checkBox12 = checkBox12.Checked;
                Properties.Settings.Default.checkBoxAlt1 = checkBoxAlt1.Checked;
                Properties.Settings.Default.checkBoxAlt2 = checkBoxAlt2.Checked;
                Properties.Settings.Default.checkBoxAlt3 = checkBoxAlt3.Checked;
                Properties.Settings.Default.checkBoxAlt4 = checkBoxAlt4.Checked;
                Properties.Settings.Default.checkBoxAlt5 = checkBoxAlt5.Checked;
                Properties.Settings.Default.checkBoxAlt6 = checkBoxAlt6.Checked;
                Properties.Settings.Default.checkBoxAlt7 = checkBoxAlt7.Checked;
                Properties.Settings.Default.checkBoxAlt8 = checkBoxAlt8.Checked;
                Properties.Settings.Default.checkBoxAlt9 = checkBoxAlt9.Checked;
                Properties.Settings.Default.checkBoxAlt0 = checkBoxAlt0.Checked;
                Properties.Settings.Default.checkBoxAltYil = checkBoxAltYil.Checked;
                Properties.Settings.Default.checkBoxAltEs = checkBoxAltEs.Checked;
                #endregion

                #region TextBox Save

                Properties.Settings.Default.textBox1 = textBox1.Text;
                Properties.Settings.Default.textBox2 = textBox2.Text;
                Properties.Settings.Default.textBox3 = textBox3.Text;
                Properties.Settings.Default.textBox4 = textBox4.Text;
                Properties.Settings.Default.textBox5 = textBox5.Text;
                Properties.Settings.Default.textBox6 = textBox6.Text;
                Properties.Settings.Default.textBox7 = textBox7.Text;
                Properties.Settings.Default.textBox8 = textBox8.Text;
                Properties.Settings.Default.textBox9 = textBox9.Text;
                Properties.Settings.Default.textBox10 = textBox10.Text;
                Properties.Settings.Default.textBox25 = textBox25.Text;
                Properties.Settings.Default.textBox24 = textBox24.Text;
                Properties.Settings.Default.textBox26 = textBox26.Text;
                Properties.Settings.Default.textBox11 = textBox11.Text;
                Properties.Settings.Default.textBox12 = textBox12.Text;
                Properties.Settings.Default.textBox13 = textBox13.Text;
                Properties.Settings.Default.textBox14 = textBox14.Text;
                Properties.Settings.Default.textBox15 = textBox15.Text;
                Properties.Settings.Default.textBox16 = textBox16.Text;
                Properties.Settings.Default.textBox17 = textBox17.Text;
                Properties.Settings.Default.textBox18 = textBox18.Text;
                Properties.Settings.Default.textBox19 = textBox19.Text;
                Properties.Settings.Default.textBox20 = textBox20.Text;
                Properties.Settings.Default.textBox21 = textBox21.Text;
                Properties.Settings.Default.textBox22 = textBox22.Text;
                Properties.Settings.Default.textBox23 = textBox23.Text;

                #endregion
                Properties.Settings.Default.Save();
            }
        }
    }
}
