using Empresa.Db;
using Empresa.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class LoginForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();

            try
            {
                this.logoPictureBox.Image = Properties.Resources.Logotipo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a logo: " + ex.Message, "Aviso");
            }

            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
        }

        // Desenha o gradiente liso de fundo
        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(10, 18, 32),
                Color.FromArgb(24, 43, 73),
                LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void forgotPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ResetarSenhaForm resetarSenhaForm = new ResetarSenhaForm();
            resetarSenhaForm.FormClosed += (s, args) => this.Show();
            resetarSenhaForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTextBox.Text.Trim();
            string senha = senhaTextBox.Text.Trim();
            var db = new LoginDb();

            var usuarioLogado = db.Autenticar(usuario, senha);

            if (usuarioLogado == null)
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sessao.UsuarioLogado = usuarioLogado;
            this.Hide();
            TelaInicialForm telaInicialForm = new TelaInicialForm(usuarioLogado.TipoUsuario);
            telaInicialForm.FormClosed += (s, args) => this.Show();
            telaInicialForm.Show();
        }

        private void newAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.FormClosed += (s, args) => this.Show();
            cadastroForm.Show();
        }

        // EVENTO NOVO: Botão de mostrar/ocultar senha
        private void verSenhaButton_Click(object sender, EventArgs e)
        {
            senhaTextBox.UseSystemPasswordChar = !senhaTextBox.UseSystemPasswordChar;
        }
    }
}