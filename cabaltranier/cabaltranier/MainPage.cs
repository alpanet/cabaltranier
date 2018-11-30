using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace cabaltranier
{
    public partial class Main : Form
    {
        #region Tanımlamalar
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);
        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        private Process[] _processes;
        #endregion

        public Main()
        {
            InitializeComponent();
        }


        #region Event

        private void Main_Load(object sender, EventArgs e)
        {
            _processes = Process.GetProcessesByName("CabalMain");
            if (!string.IsNullOrEmpty(_processes[0].ProcessName))
            {
                groupBox1.Enabled = true;
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            IntPtr h = _processes[0].MainWindowHandle;
            SetForegroundWindow(h);

            #region Interval
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
            timerNumSpace.Interval = 2000;
            #endregion

            #region Start

            if (checkBox1.Checked)
            {
                timerNum1.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum2.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum3.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum4.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum5.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum6.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum7.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum8.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum9.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNum0.Start();
            }
            else if (checkBox1.Checked)
            {
                timerNumSpace.Start();
            }
            #endregion

        }
        #region Timerlar

        private void timerNum1_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD1);
        }

        private void timerNum2_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD2);
        }

        private void timerNum3_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD3);
        }

        private void timerNum4_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD4);
        }

        private void timerNum5_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD5);
        }

        private void timerNum6_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD6);
        }

        private void timerNum7_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD7);
        }

        private void timerNum8_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD8);
        }

        private void timerNum9_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD9);
        }

        private void timerNum0_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD0);
        }

        private void timerNumSpace_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.SPACE);
        }


        #endregion

        #endregion


    }
}
