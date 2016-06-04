using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLHelper
{
    public partial class SQLHelper : Form
    {
        public SQLHelper()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputListTextBox.Text))
            {
                var list = InputListTextBox.Text.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string output = string.Empty;

                foreach (var sting in list)
                {
                    if (!string.IsNullOrEmpty(sting))
                    {
                        output += BeforeTextBox.Text + sting.Trim() + AfterTextBox.Text + Environment.NewLine;
                    }
                }

                OutputTextBox.Text = output;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void SQLHelper_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void InputListTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                InputListTextBox.SelectAll();
            }
        }

        private void OutputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                OutputTextBox.SelectAll();
            }
        }
    }
}
