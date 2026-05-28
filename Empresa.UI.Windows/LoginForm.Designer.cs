namespace Empresa.UI.Windows
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.verSenhaButton = new System.Windows.Forms.Button(); // BOTÃO NOVO
            this.forgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.newAccountLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.logoPictureBox);
            this.loginPanel.Controls.Add(this.titleLabel);
            this.loginPanel.Controls.Add(this.userLabel);
            this.loginPanel.Controls.Add(this.usuarioTextBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.senhaTextBox);
            this.loginPanel.Controls.Add(this.verSenhaButton); // ADICIONADO AO PAINEL
            this.loginPanel.Controls.Add(this.forgotPasswordLabel);
            this.loginPanel.Controls.Add(this.newAccountLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(225, 45);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(350, 375);
            this.loginPanel.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Location = new System.Drawing.Point(34, 15);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(282, 65);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 8;
            this.logoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(135, 90);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(78, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Login";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(215)))));
            this.userLabel.Location = new System.Drawing.Point(31, 135);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 17);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Usuário";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.ForeColor = System.Drawing.Color.White;
            this.usuarioTextBox.Location = new System.Drawing.Point(34, 157);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(282, 27);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(215)))));
            this.passwordLabel.Location = new System.Drawing.Point(31, 197);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(43, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Senha";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.ForeColor = System.Drawing.Color.White;
            this.senhaTextBox.Location = new System.Drawing.Point(34, 219);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(242, 27); // REDUZIDO PARA CABER O BOTÃO
            this.senhaTextBox.TabIndex = 4;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // verSenhaButton
            // 
            this.verSenhaButton.BackColor = System.Drawing.Color.Transparent;
            this.verSenhaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verSenhaButton.FlatAppearance.BorderSize = 0;
            this.verSenhaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.verSenhaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.verSenhaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verSenhaButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verSenhaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(165)))), ((int)(((byte)(210))))); // COR DA FONTE ROXA/AZUL
            this.verSenhaButton.Location = new System.Drawing.Point(282, 218);
            this.verSenhaButton.Name = "verSenhaButton";
            this.verSenhaButton.Size = new System.Drawing.Size(34, 29);
            this.verSenhaButton.TabIndex = 9;
            this.verSenhaButton.Text = "👁";
            this.verSenhaButton.UseVisualStyleBackColor = false;
            this.verSenhaButton.Click += new System.EventHandler(this.verSenhaButton_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            this.forgotPasswordLabel.Location = new System.Drawing.Point(31, 256);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(121, 15);
            this.forgotPasswordLabel.TabIndex = 5;
            this.forgotPasswordLabel.TabStop = true;
            this.forgotPasswordLabel.Text = "Esqueci minha senha";
            this.forgotPasswordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLabel_LinkClicked);
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            this.newAccountLabel.Location = new System.Drawing.Point(216, 256);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(100, 15);
            this.newAccountLabel.TabIndex = 6;
            this.newAccountLabel.TabStop = true;
            this.newAccountLabel.Text = "Criar Nova Conta";
            this.newAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newAccountLabel_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.loginButton.Location = new System.Drawing.Point(34, 295);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(282, 42);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Acessar Sistema";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TechFlow Solutions";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(764, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.LinkLabel forgotPasswordLabel;
        private System.Windows.Forms.LinkLabel newAccountLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button verSenhaButton; 
    }
}