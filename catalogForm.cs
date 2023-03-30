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
            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar`";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar`";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

            

            /*table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;*/
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '1'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '2'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '3'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '4'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '5'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '6'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '7'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '8'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '9'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `id_category` = '10'";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            string min = minPrice.Text;
            string max = maxPrice.Text;

            dataGridView1.Rows.Clear();

            db = new DB();

            db.openConnection();

            table = new DataTable();

            string query = "SELECT `title`, `description`, `price`, `id` FROM `tovar` WHERE `price` BETWEEN "+min+" AND "+max+"";

            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                MessageBox.Show(e.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                string id_tovar = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string id_user = DataBank.ID;

                db = new DB();

                db.openConnection();

                table = new DataTable();

                string query = "INSERT INTO `basket` (`id`, `id_user`, `id_tovar`) VALUES (NULL, "+ id_user + ", "+ id_tovar + ")";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Товар " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " был добавлен в вашу корзину");

                }

                db.closeConnection();
            }
        }
    }
}
