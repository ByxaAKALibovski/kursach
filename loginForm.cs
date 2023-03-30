using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stationeryStore
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();

            this.ActiveControl = label1;

            this.passInput.AutoSize = false;
            this.passInput.Size = new Size(this.passInput.Size.Width, 39);

            loginInput.Text = "Логин";
            passInput.Text = "Пароль";

            labelErLog.Hide();
            labelErPass.Hide();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if(loginInput.Text == "Логин" || passInput.Text == "Пароль")
            {
                errorLogin.Hide();
                flag = false;
                if(loginInput.Text == "Логин")
                    labelErLog.Show();
                else
                    labelErLog.Hide();
                if (passInput.Text == "Пароль")
                    labelErPass.Show();
                else
                    labelErPass.Hide();
            }

            if (flag)
            {
                labelErLog.Hide();
                labelErPass.Hide();

                string loginUser = loginInput.Text;
                string passUser = passInput.Text;

                var md5 = MD5.Create();
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(passUser));

                DB db = new DB();

                db.openConnection();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Convert.ToBase64String(hash);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                MySqlDataReader reader = command.ExecuteReader();

                if (table.Rows.Count > 0)
                {
                    DataBank.Login = loginUser;
                    this.Hide();
                    mainForm mainForm = new mainForm();
                    mainForm.Show();

                    while (reader.Read())
                    {
                        DataBank.ID = reader[0].ToString();
                        DataBank.Name = reader[3].ToString();
                        DataBank.Phone = reader[5].ToString();
                        DataBank.Email = reader[4].ToString();
                        DataBank.Admin = reader[6].ToString();
                    }

                    db.closeConnection();
                }
                else
                {
                    errorLogin.Show();
                    errorLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    errorLogin.Location = new System.Drawing.Point(110, 77);
                    errorLogin.Size = new System.Drawing.Size(179, 44);
                    errorLogin.Text = "Логин или пароль были введенны неверно";
                    errorLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                }
            }
        }

        private void loginInput_Enter(object sender, EventArgs e)
        {
            if(loginInput.Text == "Логин")
            {
                loginInput.Text = "";
                loginInput.ForeColor = Color.Black;
            }
        }
        private void loginInput_Leave(object sender, EventArgs e)
        {
            if (loginInput.Text == "")
            {
                loginInput.Text = "Логин";
                loginInput.ForeColor = Color.Gray;
            }
        }
        private void passInput_Enter(object sender, EventArgs e)
        {
            if (passInput.Text == "Пароль")
            {
                passInput.Text = "";
                passInput.ForeColor = Color.Black;
                passInput.UseSystemPasswordChar = true;
                passInput.PasswordChar = '*';
            }
        }
        private void passInput_Leave(object sender, EventArgs e)
        {
            if (passInput.Text == "")
            {
                passInput.Text = "Пароль";
                passInput.ForeColor = Color.Gray;
                passInput.UseSystemPasswordChar = false;
                passInput.PasswordChar = '\0';
            }
        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.Show();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
