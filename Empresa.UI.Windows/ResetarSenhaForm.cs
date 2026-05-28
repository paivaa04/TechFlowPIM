using Empresa.Db;
using Empresa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions; // Adicionado para as validações
using System.Threading.Tasks;
using System.Windows.Forms;
using static Empresa.Db.LoginDb;

namespace Empresa.UI.Windows
{
    public partial class ResetarSenhaForm : Form
    {
        // Importações nativas para permitir mover a janela customizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public ResetarSenhaForm()
        {
            InitializeComponent();

            // Vincula o evento MouseDown do painel superior dinamicamente
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
        }

        // Desenha o gradiente contínuo de fundo do padrão TechFlow Solutions
        private void ResetarSenhaForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(10, 18, 32),   // Azul marinho muito escuro
                Color.FromArgb(24, 43, 73),   // Azul petróleo corporativo
                LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            string usuario = usuarioResetTextBox.Text.Trim();
            string email = emailResetTextBox.Text.Trim();
            string novaSenha = novaSenhaTextBox.Text;

            // 1. Validações básicas
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validação Rigorosa de E-mail
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validação de Complexidade da Nova Senha
            string senhaPattern = @"^(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).{6,}$";
            if (!Regex.IsMatch(novaSenha, senhaPattern))
            {
                MessageBox.Show("A nova senha deve ter:\n- No mínimo 6 caracteres\n- Pelo menos 1 letra maiúscula\n- Pelo menos 1 símbolo especial", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Chamada ao Banco com Try/Catch
            try
            {
                var db = new LoginDb();
                bool sucesso = db.ResetarSenha(usuario, email, novaSenha);

                if (sucesso)
                {
                    MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // Retorna falso se ele não encontrar ninguém com aquele usuário + email
                    MessageBox.Show("Usuário ou e-mail não encontrados no sistema.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Captura qualquer barreira de segurança imposta pelo Backend
                MessageBox.Show(ex.Message, "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}