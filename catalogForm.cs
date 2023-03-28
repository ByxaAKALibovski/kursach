using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace stationeryStore
{
    public partial class catalogForm : Form
    {
        private DataTable table = null;
        private MySqlDataAdapter adapter = null;
        private DB db = null;

        public catalogForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void catalogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }

        private void personalLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            personalForm personalForm = new personalForm();
            personalForm.Show();
        }

        private void supportLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportForm SupportForm = new SupportForm();
            SupportForm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void catalogForm_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar`", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '1'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '2'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '3'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '4'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '5'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '6'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '7'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '8'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '9'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            db = new DB();

            db.openConnection();

            table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT * FROM `tovar` WHERE `id_category` = '10'", db.getConnection());

            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
