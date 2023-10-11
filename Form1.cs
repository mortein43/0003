using System.Diagnostics;

namespace _0003
{
    public partial class Form1 : Form
    {
        private Process programProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string programPath = @"c:\Windows\System32\notepad.exe";
            if (programProcess == null || programProcess.HasExited)
            {
                programProcess = new Process();
                programProcess.StartInfo.FileName = programPath;
                try
                {
                    programProcess.Start();
                    programProcess.WaitForExit();
                    if (programProcess.HasExited)
                    {
                        MessageBox.Show("Програма " + "блокнот " + "завершила свою роботу.", "Info", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося відкрити програму: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}