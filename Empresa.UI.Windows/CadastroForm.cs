using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa.Models;
using Empresa.Db;

namespace Empresa.UI.Windows
{
    public partial class CadastroForm : Form
    {
        // Importações nativas para permitir mover a janela customizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public CadastroForm()
        {
            InitializeComponent();
            // Vincula o evento MouseDown do painel superior dinamicamente
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
        }

        // Desenha o gradiente contínuo de fundo do padrão TechFlow Solutions
        private void CadastroForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(10, 18, 32),   // Azul marinho muito escuro
                Color.FromArgb(24, 43, 73),   // Azul petróleo corporativo
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string senha = senhaTextBox.Text;
            string confirmarSenha = confirmarSenhaTextBox.Text;

            // 1. Validações básicas de preenchimento
            if (string.IsNullOrWhiteSpace(nomeTextBox.Text) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(usuarioTextBox.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validação Rigorosa de E-mail
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Por favor, insira um e-mail válido (ex: seu_nome@dominio.com).", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validação de Complexidade da Senha
            string senhaPattern = @"^(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).{6,}$";
            if (!Regex.IsMatch(senha, senhaPattern))
            {
                MessageBox.Show("A senha deve ter:\n- No mínimo 6 caracteres\n- Pelo menos 1 letra maiúscula\n- Pelo menos 1 símbolo especial", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipoUsuarioComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var login = new Login();
            login.Nome = nomeTextBox.Text.Trim();
            login.Email = email;
            login.Usuario = usuarioTextBox.Text.Trim();
            login.Senha = senha;
            login.TipoUsuario = tipoUsuarioComboBox.SelectedIndex;

            // 4. Envio para o Banco com tratamento de erros (Try/Catch)
            try
            {
                var db = new Db.LoginDb();
                db.Create(login);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Aqui o Forms captura e mostra o aviso se o banco rejeitar o cadastro (ex: usuário duplicado)
                MessageBox.Show(ex.Message, "Aviso de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tipoUsuarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // EVENTOS NOVOS: Botões de mostrar/ocultar senha
        private void verSenhaButton_Click(object sender, EventArgs e)
        {
            senhaTextBox.UseSystemPasswordChar = !senhaTextBox.UseSystemPasswordChar;
        }

        private void verConfirmarSenhaButton_Click(object sender, EventArgs e)
        {
            confirmarSenhaTextBox.UseSystemPasswordChar = !confirmarSenhaTextBox.UseSystemPasswordChar;
        }
    }
}