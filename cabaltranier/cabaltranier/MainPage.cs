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
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        // Activate an application window.
        [DllImport("USER32.DLL")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

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
            IntPtr h = _processes[0].Handle;
            SetForegroundWindow(h);

            #region Interval
            timerNum1.Interval = Convert.ToInt32(textBox1.Text) + 100;
            timerNum2.Interval = Convert.ToInt32(textBox2.Text) + 100;
            timerNum3.Interval = Convert.ToInt32(textBox3.Text) + 100;
            timerNum4.Interval = Convert.ToInt32(textBox4.Text) + 100;
            timerNum5.Interval = Convert.ToInt32(textBox5.Text) + 100;
            timerNum6.Interval = Convert.ToInt32(textBox6.Text) + 100;
            timerNum7.Interval = Convert.ToInt32(textBox7.Text) + 100;
            timerNum8.Interval = Convert.ToInt32(textBox8.Text) + 100;
            timerNum9.Interval = Convert.ToInt32(textBox9.Text) + 100;
            timerNum0.Interval = Convert.ToInt32(textBox10.Text) + 100;
            timerNumSpace.Interval = 2000;
            MobSelect.Interval = 2000;
            #endregion
            #region Start

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
            #endregion

        }
        private void buttonStop_Click(object sender, EventArgs e)
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
        }
        private void buttonOpacity_Click(object sender, EventArgs e)
        {
            if (this.Opacity < 0.5)
                this.Opacity += .05;

            this.Opacity -= .05;

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

        private void MobSelect_Tick(object sender, EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.KEY_Z);
        }




        #endregion

        #endregion


    }
}
