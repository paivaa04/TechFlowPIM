namespace Empresa.UI.Windows
{
    partial class TelaInicialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialForm));
            this.abrirChamadoButton = new System.Windows.Forms.Button();
            this.acompanharChamadoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abrirChamadoButton
            // 
            this.abrirChamadoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.abrirChamadoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abrirChamadoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.abrirChamadoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.abrirChamadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrirChamadoButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirChamadoButton.ForeColor = System.Drawing.Color.White;
            this.abrirChamadoButton.Location = new System.Drawing.Point(20, 15);
            this.abrirChamadoButton.Name = "abrirChamadoButton";
            this.abrirChamadoButton.Size = new System.Drawing.Size(460, 65);
            this.abrirChamadoButton.TabIndex = 1;
            this.abrirChamadoButton.Text = "➕  Abrir Novo Chamado";
            this.abrirChamadoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrirChamadoButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.abrirChamadoButton.UseVisualStyleBackColor = false;
            this.abrirChamadoButton.Click += new System.EventHandler(this.abrirChamadoButton_Click);
            // 
            // acompanharChamadoButton
            // 
            this.acompanharChamadoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.acompanharChamadoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acompanharChamadoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.acompanharChamadoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.acompanharChamadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acompanharChamadoButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acompanharChamadoButton.ForeColor = System.Drawing.Color.White;
            this.acompanharChamadoButton.Location = new System.Drawing.Point(20, 95);
            this.acompanharChamadoButton.Name = "acompanharChamadoButton";
            this.acompanharChamadoButton.Size = new System.Drawing.Size(460, 65);
            this.acompanharChamadoButton.TabIndex = 2;
            this.acompanharChamadoButton.Text = "🔍  Acompanhar Painel de Tickets";
            this.acompanharChamadoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acompanharChamadoButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.acompanharChamadoButton.UseVisualStyleBackColor = false;
            this.acompanharChamadoButton.Click += new System.EventHandler(this.acompanharChamadoButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.logoPictureBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 75);
            this.panel2.TabIndex = 7;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Location = new System.Drawing.Point(150, 10);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(120, 55);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Painel de Controle";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.abrirChamadoButton);
            this.panel3.Controls.Add(this.acompanharChamadoButton);
            this.panel3.Location = new System.Drawing.Point(150, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 240);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TechFlow Solutions - Principal";
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
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicialForm";
            this.Load += new System.EventHandler(this.TelaInicialForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaInicialForm_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button abrirChamadoButton;
        private System.Windows.Forms.Button acompanharChamadoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}