
namespace stationeryStore
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLogin = new System.Windows.Forms.Label();
            this.linkReg = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passInput = new System.Windows.Forms.TextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelErLog = new System.Windows.Forms.Label();
            this.labelErPass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelErPass);
            this.panel1.Controls.Add(this.labelErLog);
            this.panel1.Controls.Add(this.errorLogin);
            this.panel1.Controls.Add(this.linkReg);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.passInput);
            this.panel1.Controls.Add(this.loginInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 407);
            this.panel1.TabIndex = 0;
            // 
            // errorLogin
            // 
            this.errorLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.errorLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLogin.Location = new System.Drawing.Point(110, 77);
            this.errorLogin.Name = "errorLogin";
            this.errorLogin.Size = new System.Drawing.Size(179, 44);
            this.errorLogin.TabIndex = 7;
            this.errorLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkReg
            // 
            this.linkReg.AutoSize = true;
            this.linkReg.Location = new System.Drawing.Point(143, 313);
            this.linkReg.Name = "linkReg";
            this.linkReg.Size = new System.Drawing.Size(113, 13);
            this.linkReg.TabIndex = 6;
            this.linkReg.TabStop = true;
            this.linkReg.Text = "Зарегистрироваться";
            this.linkReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReg_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(146, 277);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 33);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passInput
            // 
            this.passInput.AccessibleDescription = "";
            this.passInput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passInput.ForeColor = System.Drawing.Color.Gray;
            this.passInput.Location = new System.Drawing.Point(93, 210);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(217, 33);
            this.passInput.TabIndex = 3;
            this.passInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passInput.Enter += new System.EventHandler(this.passInput_Enter);
            this.passInput.Leave += new System.EventHandler(this.passInput_Leave);
            // 
            // loginInput
            // 
            this.loginInput.CausesValidation = false;
            this.loginInput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInput.ForeColor = System.Drawing.Color.Gray;
            this.loginInput.Location = new System.Drawing.Point(93, 146);
            this.loginInput.Multiline = true;
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(217, 39);
            this.loginInput.TabIndex = 1;
            this.loginInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginInput.Enter += new System.EventHandler(this.loginInput_Enter);
            this.loginInput.Leave += new System.EventHandler(this.loginInput_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelErLog
            // 
            this.labelErLog.AutoSize = true;
            this.labelErLog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErLog.ForeColor = System.Drawing.Color.Red;
            this.labelErLog.Location = new System.Drawing.Point(142, 121);
            this.labelErLog.Name = "labelErLog";
            this.labelErLog.Size = new System.Drawing.Size(114, 20);
            this.labelErLog.TabIndex = 8;
            this.labelErLog.Text = "Введите логин";
            // 
            // labelErPass
            // 
            this.labelErPass.AutoSize = true;
            this.labelErPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErPass.ForeColor = System.Drawing.Color.Red;
            this.labelErPass.Location = new System.Drawing.Point(133, 188);
            this.labelErPass.Name = "labelErPass";
            this.labelErPass.Size = new System.Drawing.Size(127, 20);
            this.labelErPass.TabIndex = 9;
            this.labelErPass.Text = "Введите пароль";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 407);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(422, 446);
            this.MinimumSize = new System.Drawing.Size(422, 446);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanstovarShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.LinkLabel linkReg;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label errorLogin;
        private System.Windows.Forms.Label labelErPass;
        private System.Windows.Forms.Label labelErLog;
    }
}