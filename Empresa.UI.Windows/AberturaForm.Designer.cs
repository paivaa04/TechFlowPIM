namespace Empresa.UI.Windows
{
    partial class AberturaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AberturaForm));
            this.prioridadeCheckBox = new System.Windows.Forms.CheckBox();
            this.descricaoRichTextBox = new System.Windows.Forms.TextBox(); // Modificado para TextBox Multiline para evitar bordas brancas 3D
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.setorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataAberturaLabel = new System.Windows.Forms.Label();
            this.relogioTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gravarChamadoButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prioridadeCheckBox
            // 
            this.prioridadeCheckBox.AutoSize = true;
            this.prioridadeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.prioridadeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioridadeCheckBox.ForeColor = System.Drawing.Color.White;
            this.prioridadeCheckBox.Location = new System.Drawing.Point(160, 315);
            this.prioridadeCheckBox.Name = "prioridadeCheckBox";
            this.prioridadeCheckBox.Size = new System.Drawing.Size(130, 21);
            this.prioridadeCheckBox.TabIndex = 4;
            this.prioridadeCheckBox.Text = "Marcar Prioridade";
            this.prioridadeCheckBox.UseVisualStyleBackColor = false;
            this.prioridadeCheckBox.CheckedChanged += new System.EventHandler(this.prioridadeCheckBox_CheckedChanged);
            // 
            // descricaoRichTextBox
            // 
            this.descricaoRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.descricaoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoRichTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoRichTextBox.ForeColor = System.Drawing.Color.White;
            this.descricaoRichTextBox.Location = new System.Drawing.Point(160, 212);
            this.descricaoRichTextBox.Multiline = true;
            this.descricaoRichTextBox.Name = "descricaoRichTextBox";
            this.descricaoRichTextBox.Size = new System.Drawing.Size(480, 90);
            this.descricaoRichTextBox.TabIndex = 3;
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.assuntoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assuntoTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assuntoTextBox.ForeColor = System.Drawing.Color.White;
            this.assuntoTextBox.Location = new System.Drawing.Point(160, 148);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(480, 27);
            this.assuntoTextBox.TabIndex = 2;
            // 
            // setorComboBox
            // 
            this.setorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.setorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setorComboBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setorComboBox.ForeColor = System.Drawing.Color.White;
            this.setorComboBox.FormattingEnabled = true;
            this.setorComboBox.Items.AddRange(new object[] {
            "Vendas",
            "RH",
            "Conferencia",
            "Secretaria"});
            this.setorComboBox.Location = new System.Drawing.Point(160, 85);
            this.setorComboBox.Name = "setorComboBox";
            this.setorComboBox.Size = new System.Drawing.Size(220, 27);
            this.setorComboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            this.label5.Location = new System.Drawing.Point(157, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Assunto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(157, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            this.label3.Location = new System.Drawing.Point(157, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descrição";
            // 
            // dataAberturaLabel
            // 
            this.dataAberturaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataAberturaLabel.AutoSize = true;
            this.dataAberturaLabel.BackColor = System.Drawing.Color.Transparent;
            this.dataAberturaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAberturaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
            this.dataAberturaLabel.Location = new System.Drawing.Point(645, 12);
            this.dataAberturaLabel.Name = "dataAberturaLabel";
            this.dataAberturaLabel.Size = new System.Drawing.Size(110, 15);
            this.dataAberturaLabel.TabIndex = 25;
            this.dataAberturaLabel.Text = "00/00/0000 00:00:00";
            this.dataAberturaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataAberturaLabel.Click += new System.EventHandler(this.dataAberturaLabel_Click);
            // 
            // relogioTimer
            // 
            this.relogioTimer.Enabled = true;
            this.relogioTimer.Interval = 1000;
            this.relogioTimer.Tick += new System.EventHandler(this.relogioTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "TechFlow - Novo Chamado";
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gravarChamadoButton
            // 
            this.gravarChamadoButton.BackColor = System.Drawing.Color.White;
            this.gravarChamadoButton.FlatAppearance.BorderSize = 0;
            this.gravarChamadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gravarChamadoButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarChamadoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.gravarChamadoButton.Location = new System.Drawing.Point(3, 3);
            this.gravarChamadoButton.Name = "gravarChamadoButton";
            this.gravarChamadoButton.Size = new System.Drawing.Size(140, 32);
            this.gravarChamadoButton.TabIndex = 5;
            this.gravarChamadoButton.Text = "Gravar Chamado";
            this.gravarChamadoButton.UseVisualStyleBackColor = false;
            this.gravarChamadoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.BackColor = System.Drawing.Color.Transparent;
            this.voltarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
            this.voltarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.ForeColor = System.Drawing.Color.White;
            this.voltarButton.Location = new System.Drawing.Point(149, 3);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(90, 32);
            this.voltarButton.TabIndex = 6;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = false;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.dataAberturaLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 58);
            this.panel2.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.gravarChamadoButton);
            this.flowLayoutPanel1.Controls.Add(this.voltarButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(160, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AberturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prioridadeCheckBox);
            this.Controls.Add(this.descricaoRichTextBox);
            this.Controls.Add(this.assuntoTextBox);
            this.Controls.Add(this.setorComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AberturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AberturaForm";
            this.Load += new System.EventHandler(this.AberturaForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AberturaForm_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox prioridadeCheckBox;
        private System.Windows.Forms.TextBox descricaoRichTextBox; // Alterado para TextBox plano
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.ComboBox setorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dataAberturaLabel;
        private System.Windows.Forms.Timer relogioTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gravarChamadoButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}