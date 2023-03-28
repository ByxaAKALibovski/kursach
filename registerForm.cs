using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace stationeryStore
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();

            this.ActiveControl = label1;

            this.passInput.AutoSize = false;
            this.passInput.Size = new Size(this.passInput.Size.Width, 39);
            this.repeatPassInput.AutoSize = false;
            this.repeatPassInput.Size = new Size(this.repeatPassInput.Size.Width, 39);

            loginInput.Text = "Логин";
            nameInput.Text = "Имя";
            phoneInput.Text = "Телефон";
            passInput.Text = "Пароль";
            repeatPassInput.Text = "Повторите пароль";
            emailInput.Text = "E-mail";

            labelErLog.Hide();
            labelErPhone.Hide();
            labelErName.Hide();
            labelErMail.Hide();
            labelErPass.Hide();
            labelErRepPass.Hide();
        }

        private void loginInput_Enter(object sender, EventArgs e)
        {
            if (loginInput.Text == "Логин")
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
        private void nameInput_Enter(object sender, EventArgs e)
        {
            if (nameInput.Text == "Имя")
            {
                nameInput.Text = "";
                nameInput.ForeColor = Color.Black;
            }
        }
        private void nameInput_Leave(object sender, EventArgs e)
        {
            if (nameInput.Text == "")
            {
                nameInput.Text = "Имя";
                nameInput.ForeColor = Color.Gray;
            }
        }
        private void phoneInput_Enter(object sender, EventArgs e)
        {
            if (phoneInput.Text == "Телефон")
            {
                phoneInput.Text = "";
                phoneInput.ForeColor = Color.Black;
            }
        }
        private void phoneInput_Leave(object sender, EventArgs e)
        {
            if (phoneInput.Text == "")
            {
                phoneInput.Text = "Телефон";
                phoneInput.ForeColor = Color.Gray;
            }
        }
        private void emailInput_Enter(object sender, EventArgs e)
        {
            if (emailInput.Text == "E-mail")
            {
                emailInput.Text = "";
                emailInput.ForeColor = Color.Black;
            }
        }
        private void emailInput_Leave(object sender, EventArgs e)
        {
            if (emailInput.Text == "")
            {
                emailInput.Text = "E-mail";
                emailInput.ForeColor = Color.Gray;
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
        private void repeatPassInput_Enter(object sender, EventArgs e)
        {
            if (repeatPassInput.Text == "Повторите пароль")
            {
                repeatPassInput.Text = "";
                repeatPassInput.ForeColor = Color.Black;
                repeatPassInput.UseSystemPasswordChar = true;
                repeatPassInput.PasswordChar = '*';
            }
        }
        private void repeatPassInput_Leave(object sender, EventArgs e)
        {
            if (repeatPassInput.Text == "")
            {
                repeatPassInput.Text = "Повторите пароль";
                repeatPassInput.ForeColor = Color.Gray;
                repeatPassInput.UseSystemPasswordChar = false;
                repeatPassInput.PasswordChar = '\0';
            }
        }

        private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool flag = true;

            labelErLog.Text = "Введите логин";
            labelErPhone.Text = "Введите телефон";
            labelErName.Text = "Введите имя";
            labelErMail.Text = "Введите E-mail";
            labelErPass.Text = "Введите пароль";
            labelErRepPass.Text = "Повторите пароль";

            if (loginInput.Text == "Логин" || phoneInput.Text == "Телефон" || nameInput.Text == "Имя" || emailInput.Text == "E-mail" || passInput.Text == "Пароль" || repeatPassInput.Text == "Повторите пароль")
            {
                /*errorLogin.Hide();*/
                flag = false;
                if (loginInput.Text == "Логин")
                    labelErLog.Show();
                else
                    labelErLog.Hide();
                if (phoneInput.Text == "Телефон")
                    labelErPhone.Show();
                else
                    labelErPhone.Hide();
                if (nameInput.Text == "Имя")
                    labelErName.Show();
                else
                    labelErName.Hide();
                if (emailInput.Text == "E-mail")
                    labelErMail.Show();
                else
                    labelErMail.Hide();
                if (passInput.Text == "Пароль")
                    labelErPass.Show();
                else
                    labelErPass.Hide();
                if (repeatPassInput.Text == "Повторите пароль")
                    labelErRepPass.Show();
                else
                    labelErRepPass.Hide();
            }

            if (flag)
            {
                labelErLog.Hide();
                labelErPhone.Hide();
                labelErName.Hide();
                labelErMail.Hide();
                labelErPass.Hide();
                labelErRepPass.Hide();

                DB db = new DB();

                string loginUser = loginInput.Text;
                string nameUser = nameInput.Text;
                string phoneUser = phoneInput.Text;
                string emailUser = emailInput.Text;
                string passUser = passInput.Text;
                string repPassUser = repeatPassInput.Text;
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                string patternPass = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{6,16}$";

                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM `users` WHERE `e-mail` = @uE", db.getConnection());
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM `users` WHERE `phone` = @uPhone", db.getConnection());

                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command1.Parameters.Add("@uE", MySqlDbType.VarChar).Value = emailUser;
                command2.Parameters.Add("@uPhone", MySqlDbType.VarChar).Value = phoneUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                adapter.SelectCommand = command1;
                adapter.Fill(table1);
                adapter.SelectCommand = command2;
                adapter.Fill(table2);

                if (phoneInput.Text.Length != 11)
                {
                    flag = false;
                    labelErPhone.Show();
                    labelErPhone.Text = "Номер должен состоять из 11 символов";
                }
                if (loginInput.Text.Length < 3)
                {
                    flag = false;
                    labelErLog.Show();
                    labelErLog.Text = "Минимальная длина 3 символа";
                }
                if (!Regex.IsMatch(emailInput.Text, pattern))
                {
                    flag = false;
                    labelErMail.Show();
                    labelErMail.Text = "Неверный формат почты";
                }
                if (!Regex.IsMatch(passInput.Text, patternPass))
                {
                    flag = false;
                    labelErPass.Show();
                    labelErPass.Text = "Используйте только буквы (a–z, A–Z), цифры и символы";
                }
                if (passInput.Text != repeatPassInput.Text)
                {
                    flag = false;
                    labelErRepPass.Show();
                    labelErRepPass.Text = "Пароли не совпадают";
                }
                if (table.Rows.Count > 0)
                {
                    flag = false;
                    labelErLog.Show();
                    labelErLog.Text = "Такой пользователь сущестувует";
                }
                if (table1.Rows.Count > 0)
                {
                    flag = false;
                    labelErMail.Show();
                    labelErMail.Text = "Такой пользователь сущестувует";
                }
                if (table2.Rows.Count > 0)
                {
                    flag = false;
                    labelErPhone.Show();
                    labelErPhone.Text = "Такой пользователь сущестувует";
                }
                if (flag)
                {
                    var md5 = MD5.Create();
                    var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(passUser));
                    MySqlCommand commandCreate = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `password`, `name`, `e-mail`, `phone`) VALUES (NULL, @uL, @uP, @uN, @uE, @uPhone);", db.getConnection());

                    commandCreate.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                    commandCreate.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Convert.ToBase64String(hash);
                    commandCreate.Parameters.Add("@uN", MySqlDbType.VarChar).Value = nameUser;
                    commandCreate.Parameters.Add("@uE", MySqlDbType.VarChar).Value = emailUser;
                    commandCreate.Parameters.Add("@uPhone", MySqlDbType.VarChar).Value = phoneUser;

                    db.openConnection();

                    if (commandCreate.ExecuteNonQuery() == 1)
                    {
                        this.Hide();
                        mainForm mainForm = new mainForm();
                        mainForm.Show();

                    }

                    db.closeConnection();
                }
            }
        }

        private void phoneInput_KeyPress(object sender, KeyPressEventArgs e)
        {   
            char number = e.KeyChar;
            
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
