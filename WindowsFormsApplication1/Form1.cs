using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorem aplikacji jest Brtk.");
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtAdres.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtAdres.Text = webBrowser1.Url.ToString();
            this.Text = webBrowser1.DocumentTitle;
            if (webBrowser1.CanGoBack)
                goWstecz.Enabled = true;
            else goWstecz.Enabled = false;
            if (webBrowser1.CanGoForward)
                goDalej.Enabled = true;
            else goDalej.Enabled = false;
        }

        private void goWstecz_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                webBrowser1.Navigate(txtAdres.Text);
            }
        }

        private void goDalej_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void goOdswiez_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void goZatrzymaj_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
