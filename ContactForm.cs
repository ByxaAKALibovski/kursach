using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stationeryStore
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }

        private void supportLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportForm SupportForm = new SupportForm();
            SupportForm.Show();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void personalLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            personalForm personalForm = new personalForm();
            personalForm.Show();
        }

        private void catalogLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            catalogForm catalogForm = new catalogForm();
            catalogForm.Show();
        }

        private void contactLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm ContactForm = new ContactForm();
            ContactForm.Show();
        }

        private void basketLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasketForm BasketForm = new BasketForm();
            BasketForm.Show();
        }
    }
}
