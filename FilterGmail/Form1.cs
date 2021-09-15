using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FilterGmail
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);
        private Filter filter;
        private Thread clipboardThread;

        public Form1()
        {
            InitializeComponent();
            filter = new Filter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();                       
        }

        private void addFrom_Click(object sender, EventArgs e)
        {
            addEmailFrom(txtFrom.Text);
            txtFrom.Clear();
        }    

        private void generate_Click(object sender, EventArgs e)
        {

            string filterStr = filter.generateFrom() + " " + filter.generateIs() + " " + filter.generateSubject();
            if(clipboardThread != null && clipboardThread.IsAlive) StopThread();
            checkBox1.Checked = false;
            System.Windows.Forms.Clipboard.SetText(filterStr);
            MessageBox.Show("Copied filter to clipboard", "Generated");
        }

        private void ThreadTask()
        {
            while(true)
            {
                string clip = System.Windows.Forms.Clipboard.GetText().Trim();           
                
                if (!(clip == "") && !filter.fromList.Contains(clip)) addEmailFrom(clip);
                Thread.Sleep(1000);
            }            
        }

        private void addEmailFrom(string email)
        {
            filter.fromList.Add(email);
            RefreshCount();
        }

        private void emailCounterSetText(string v)
        {
            if (emailCounter.InvokeRequired)
            {
                var d = new SafeCallDelegate(emailCounterSetText);
                emailCounter.Invoke(d, new object[] { v });
            }
            else
            {
                emailCounter.Text = v;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            checkedListBox1.SetItemChecked(index, !checkedListBox1.GetItemChecked(index));
            if (checkedListBox1.GetItemChecked(index)) filter.isList.Add(checkedListBox1.Items[index].ToString());
            if (!checkedListBox1.GetItemChecked(index)) filter.isList.Remove(checkedListBox1.Items[index].ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CreateThread();
            } else
            {
                StopThread();
            }
        }

        private void CreateThread()
        {
            clipboardThread = new Thread(new ThreadStart(this.ThreadTask));
            clipboardThread.SetApartmentState(ApartmentState.STA);
            clipboardThread.IsBackground = true;
            System.Windows.Forms.Clipboard.Clear();
            clipboardThread.Start();
        }

        private void StopThread()
        {
            clipboardThread.Abort();
            clipboardThread.Join();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
            filter.Clear();
            RefreshCount();  
        }

        private void RefreshCount()
        {
            emailCounter.Text = filter.fromList.Count.ToString();
            subjectcounter.Text = filter.fromList.Count.ToString();
        }

        private void subjectbtn_Click(object sender, EventArgs e)
        {
            AddSubject(subjecttxt.Text);
            subjecttxt.Clear();
        }

        private void AddSubject(string subject)
        {
            filter.subjects.Add(subject);
            RefreshCount();
        }
    }
}
