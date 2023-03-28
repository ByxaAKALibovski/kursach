
namespace stationeryStore
{
    partial class BasketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.supportLink = new System.Windows.Forms.Label();
            this.contactLink = new System.Windows.Forms.Label();
            this.catalogLink = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            this.basketLink = new System.Windows.Forms.PictureBox();
            this.personalLink = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 534);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.supportLink);
            this.panel2.Controls.Add(this.contactLink);
            this.panel2.Controls.Add(this.catalogLink);
            this.panel2.Controls.Add(this.basketLink);
            this.panel2.Controls.Add(this.personalLink);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 534);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "©KanstovarShop 2022-2023. Все права защищены";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supportLink
            // 
            this.supportLink.AutoSize = true;
            this.supportLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supportLink.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supportLink.ForeColor = System.Drawing.Color.White;
            this.supportLink.Location = new System.Drawing.Point(31, 231);
            this.supportLink.Name = "supportLink";
            this.supportLink.Size = new System.Drawing.Size(139, 25);
            this.supportLink.TabIndex = 6;
            this.supportLink.Text = "Поддержка";
            this.supportLink.Click += new System.EventHandler(this.supportLink_Click);
            // 
            // contactLink
            // 
            this.contactLink.AutoSize = true;
            this.contactLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactLink.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactLink.ForeColor = System.Drawing.Color.White;
            this.contactLink.Location = new System.Drawing.Point(43, 193);
            this.contactLink.Name = "contactLink";
            this.contactLink.Size = new System.Drawing.Size(109, 25);
            this.contactLink.TabIndex = 5;
            this.contactLink.Text = "Контакты";
            this.contactLink.Click += new System.EventHandler(this.contactLink_Click);
            // 
            // catalogLink
            // 
            this.catalogLink.AutoSize = true;
            this.catalogLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogLink.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogLink.ForeColor = System.Drawing.Color.White;
            this.catalogLink.Location = new System.Drawing.Point(49, 157);
            this.catalogLink.Name = "catalogLink";
            this.catalogLink.Size = new System.Drawing.Size(97, 25);
            this.catalogLink.TabIndex = 4;
            this.catalogLink.Text = "Каталог";
            this.catalogLink.Click += new System.EventHandler(this.catalogLink_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::stationeryStore.Properties.Resources.logout;
            this.exit.Location = new System.Drawing.Point(76, 377);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(5);
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 7;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // basketLink
            // 
            this.basketLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.basketLink.Image = global::stationeryStore.Properties.Resources.cart;
            this.basketLink.Location = new System.Drawing.Point(107, 79);
            this.basketLink.Name = "basketLink";
            this.basketLink.Size = new System.Drawing.Size(55, 55);
            this.basketLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basketLink.TabIndex = 3;
            this.basketLink.TabStop = false;
            // 
            // personalLink
            // 
            this.personalLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personalLink.Image = global::stationeryStore.Properties.Resources.user;
            this.personalLink.Location = new System.Drawing.Point(23, 84);
            this.personalLink.Name = "personalLink";
            this.personalLink.Padding = new System.Windows.Forms.Padding(5);
            this.personalLink.Size = new System.Drawing.Size(50, 50);
            this.personalLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personalLink.TabIndex = 2;
            this.personalLink.TabStop = false;
            this.personalLink.Click += new System.EventHandler(this.personalLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::stationeryStore.Properties.Resources.stationery_pen_pencil_art_design_512;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 534);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1013, 573);
            this.MinimumSize = new System.Drawing.Size(1013, 573);
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanstovarShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BasketForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label supportLink;
        private System.Windows.Forms.Label contactLink;
        private System.Windows.Forms.Label catalogLink;
        private System.Windows.Forms.PictureBox basketLink;
        private System.Windows.Forms.PictureBox personalLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}