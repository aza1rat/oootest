namespace OOO_Test
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelAuthUp = new System.Windows.Forms.TableLayoutPanel();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.buttonAuthExit = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelAuthUnder = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAuthMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonAuthGuest = new System.Windows.Forms.Button();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.tableLayoutPanelAuthUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelAuthMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAuthUp
            // 
            this.tableLayoutPanelAuthUp.ColumnCount = 3;
            this.tableLayoutPanelAuthUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelAuthUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelAuthUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAuthUp.Controls.Add(this.labelAuthorization, 1, 0);
            this.tableLayoutPanelAuthUp.Controls.Add(this.buttonAuthExit, 2, 0);
            this.tableLayoutPanelAuthUp.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanelAuthUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelAuthUp.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAuthUp.Name = "tableLayoutPanelAuthUp";
            this.tableLayoutPanelAuthUp.RowCount = 1;
            this.tableLayoutPanelAuthUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAuthUp.Size = new System.Drawing.Size(662, 65);
            this.tableLayoutPanelAuthUp.TabIndex = 1;
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.Location = new System.Drawing.Point(69, 0);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(457, 65);
            this.labelAuthorization.TabIndex = 0;
            this.labelAuthorization.Text = "Авторизация";
            this.labelAuthorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAuthExit
            // 
            this.buttonAuthExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAuthExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthExit.Location = new System.Drawing.Point(532, 3);
            this.buttonAuthExit.Name = "buttonAuthExit";
            this.buttonAuthExit.Size = new System.Drawing.Size(127, 59);
            this.buttonAuthExit.TabIndex = 1;
            this.buttonAuthExit.Text = "Выйти";
            this.buttonAuthExit.UseVisualStyleBackColor = true;
            this.buttonAuthExit.Click += new System.EventHandler(this.buttonAuthExit_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 59);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanelAuthUnder
            // 
            this.tableLayoutPanelAuthUnder.ColumnCount = 1;
            this.tableLayoutPanelAuthUnder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanelAuthUnder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelAuthUnder.Location = new System.Drawing.Point(0, 348);
            this.tableLayoutPanelAuthUnder.Name = "tableLayoutPanelAuthUnder";
            this.tableLayoutPanelAuthUnder.RowCount = 1;
            this.tableLayoutPanelAuthUnder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAuthUnder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelAuthUnder.Size = new System.Drawing.Size(662, 65);
            this.tableLayoutPanelAuthUnder.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanelAuthMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 283);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanelAuthMain
            // 
            this.tableLayoutPanelAuthMain.ColumnCount = 2;
            this.tableLayoutPanelAuthMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAuthMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAuthMain.Controls.Add(this.textBoxPassword, 1, 1);
            this.tableLayoutPanelAuthMain.Controls.Add(this.labelLogin, 0, 0);
            this.tableLayoutPanelAuthMain.Controls.Add(this.labelPassword, 0, 1);
            this.tableLayoutPanelAuthMain.Controls.Add(this.textBoxLogin, 1, 0);
            this.tableLayoutPanelAuthMain.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanelAuthMain.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanelAuthMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAuthMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAuthMain.Name = "tableLayoutPanelAuthMain";
            this.tableLayoutPanelAuthMain.RowCount = 3;
            this.tableLayoutPanelAuthMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAuthMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAuthMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAuthMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAuthMain.Size = new System.Drawing.Size(662, 283);
            this.tableLayoutPanelAuthMain.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(334, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(325, 22);
            this.textBoxPassword.TabIndex = 6;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(248, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 94);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(235, 94);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 94);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogin.Location = new System.Drawing.Point(334, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(325, 22);
            this.textBoxLogin.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 89);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxCaptcha);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 59);
            this.panel4.TabIndex = 9;
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(325, 59);
            this.pictureBoxCaptcha.TabIndex = 7;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxCaptcha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 30);
            this.panel3.TabIndex = 8;
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCaptcha.Location = new System.Drawing.Point(0, 0);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(325, 22);
            this.textBoxCaptcha.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonAuthGuest);
            this.panel5.Controls.Add(this.buttonAuth);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(334, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 89);
            this.panel5.TabIndex = 8;
            // 
            // buttonAuthGuest
            // 
            this.buttonAuthGuest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAuthGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthGuest.Location = new System.Drawing.Point(0, 47);
            this.buttonAuthGuest.Name = "buttonAuthGuest";
            this.buttonAuthGuest.Size = new System.Drawing.Size(325, 42);
            this.buttonAuthGuest.TabIndex = 5;
            this.buttonAuthGuest.Text = "Войти как гость";
            this.buttonAuthGuest.UseVisualStyleBackColor = true;
            this.buttonAuthGuest.Click += new System.EventHandler(this.buttonAuthGuest_Click);
            // 
            // buttonAuth
            // 
            this.buttonAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuth.Location = new System.Drawing.Point(0, 0);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(325, 42);
            this.buttonAuth.TabIndex = 4;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanelAuthUnder);
            this.Controls.Add(this.tableLayoutPanelAuthUp);
            this.MaximumSize = new System.Drawing.Size(900, 800);
            this.MinimumSize = new System.Drawing.Size(680, 460);
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.tableLayoutPanelAuthUp.ResumeLayout(false);
            this.tableLayoutPanelAuthUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelAuthMain.ResumeLayout(false);
            this.tableLayoutPanelAuthMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAuthUp;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Button buttonAuthExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAuthUnder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAuthMain;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonAuthGuest;
    }
}

