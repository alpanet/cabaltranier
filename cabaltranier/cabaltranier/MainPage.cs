using System;
using System.Diagnostics;
using System.Linq;
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
        private Process[] processes = null;

        [System.ComponentModel.TypeConverter(typeof(System.Windows.Forms.KeysConverter))]
        [System.Flags]
        [System.Runtime.InteropServices.ComVisible(true)]
        public enum Keys
        {
            numPad0 = 96,
            numPad1 = 97,
            numPad2 = 98,
            numPad3 = 99,
            numPad4 = 100,
            numPad5 = 101,
            numPad6 = 102,
            numPad7 = 103,
            numPad8 = 104,
            numPad9 = 105,

        }

        #endregion

        public Main()
        {
            InitializeComponent();
        }


        #region Event

        private void Main_Load(object sender, System.EventArgs e)
        {
            processes = Process.GetProcessesByName("notepad++");
            if (!string.IsNullOrEmpty(processes[0].ProcessName))
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
            IntPtr h = processes[0].MainWindowHandle;
            SetForegroundWindow(h);
            timerNum1.Interval = Convert.ToInt32(textBox1.Text);
            timerNum1.Start();
        }
        #region Timerlar

        private void timerNum1_Tick(object sender, System.EventArgs e)
        {
            Keyboard.Send(Keyboard.ScanCodeShort.NUMPAD1);
        }

        private void timerNum2_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum3_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum4_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum5_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum6_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum7_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum8_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum9_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNum0_Tick(object sender, System.EventArgs e)
        {

        }

        private void timerNumSpace_Tick(object sender, System.EventArgs e)
        {

        }


        #endregion

        #endregion


    }
}
