using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MediaAnt
{
    public partial class Form1 : Form
    {
     int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
          i++;
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            if(toolStripTextBox1.Text != null)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
            else
            {

            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count>1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i--;
            }
            else
            {
                Application.Exit();
            }
           
        }

        private void ToolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
        }

       

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            web.Navigate("www.google.ru");
            i++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            web.Navigate("www.google.ru");
            i++;
        }

        private void ToolStripButton8_Click(object sender, EventArgs e)
        {
            Process.Start("MediaAnt.exe");
        }
    }
}
