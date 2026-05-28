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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class AberturaForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Painel invisível que criaremos via código para servir de fundo para os campos
        private Panel cardFundo;

        public AberturaForm()
        {
            InitializeComponent();
            dataAberturaLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);

            // Executa a reestruturação moderna
            ConfigurarLayoutPremium();
        }

        private void ConfigurarLayoutPremium()
        {
            // 1. Configuração do Card Centralizado de Fundo (Dá estrutura para a tela)
            cardFundo = new Panel();
            cardFundo.Size = new Size(540, 320);
            cardFundo.Location = new Point((this.ClientSize.Width - cardFundo.Width) / 2, 55);
            cardFundo.BackColor = Color.FromArgb(20, 25, 35, 45); // Um cinza/azul semi-transparente de verdade
            cardFundo.Paint += CardFundo_Paint;
            this.Controls.Add(cardFundo);

            // Mover os controles originais para dentro do Card ou trazê-los para frente
            cardFundo.SendToBack();

            int larguraCampos = 460;
            int margemEsquerda = (this.ClientSize.Width - larguraCampos) / 2;

            // Cores premium para dar o contraste ideal no modo escuro
            Color corFundoInput = Color.FromArgb(20, 28, 46); // Um pouco mais claro que o fundo geral
            Color corBordaFina = Color.FromArgb(50, 65, 95);  // Cinza azulado para destacar a borda

            // 2. Alinhamento do Setor
            label4.Location = new Point(margemEsquerda, 70);
            setorComboBox.Location = new Point(margemEsquerda, 92);
            setorComboBox.Width = 220;
            setorComboBox.BackColor = corFundoInput;
            setorComboBox.ForeColor = Color.White;

            // 3. Alinhamento do Assunto
            label5.Location = new Point(margemEsquerda, 135);
            assuntoTextBox.Location = new Point(margemEsquerda, 157);
            assuntoTextBox.Width = larguraCampos;
            assuntoTextBox.BackColor = corFundoInput;

            // 4. Alinhamento da Descrição
            label3.Location = new Point(margemEsquerda, 200);
            descricaoRichTextBox.Location = new Point(margemEsquerda, 222);
            descricaoRichTextBox.Width = larguraCampos;
            descricaoRichTextBox.Height = 85;
            descricaoRichTextBox.BackColor = corFundoInput;

            // Força a remoção de bordas tridimensionais
            assuntoTextBox.BorderStyle = BorderStyle.FixedSingle;
            descricaoRichTextBox.BorderStyle = BorderStyle.FixedSingle;

            // 5. Alinhamento da Prioridade e Botões
            prioridadeCheckBox.Location = new Point(margemEsquerda, 322);

            panel2.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(margemEsquerda, 5);

            // Pequeno truque visual para o ComboBox parar de piscar em branco puro
            setorComboBox.FlatStyle = FlatStyle.Popup;
        }

        // Desenha uma borda sutil e cantos levemente definidos ao redor do grupo de inputs
        private void CardFundo_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(40, 60, 90), 1))
            {
                // Desenha um retângulo suave ao redor dos campos, centralizando a atenção do usuário
                e.Graphics.DrawRectangle(pen, 0, 0, cardFundo.Width - 1, cardFundo.Height - 1);
            }
        }

        private void AberturaForm_Load(object sender, EventArgs e)
        {
            voltarButton.Visible = true;
        }

        private void AberturaForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(12, 19, 34),   // Azul marinho premium profundo
                Color.FromArgb(28, 48, 82),   // Azul petróleo corporativo bem dosado
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

        private void dataAberturaLabel_Click(object sender, EventArgs e)
        {
            dataAberturaLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void relogioTimer_Tick(object sender, EventArgs e)
        {
            dataAberturaLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Sessao.UsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário logado. Faça login antes de abrir um chamado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (setorComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(assuntoTextBox.Text) || string.IsNullOrWhiteSpace(descricaoRichTextBox.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de gravar o chamado.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var chamado = new Chamado();
            chamado.IdUsuario = Sessao.UsuarioLogado.Id;
            chamado.Nome = Sessao.UsuarioLogado.Nome;
            chamado.Email = Sessao.UsuarioLogado.Email;

            chamado.Setor = setorComboBox.SelectedItem.ToString();
            chamado.Assunto = assuntoTextBox.Text.Trim();
            chamado.Descricao = descricaoRichTextBox.Text.Trim();
            chamado.DataAbertura = DateTime.Now;
            chamado.Prioridade = prioridadeCheckBox.Checked;

            var db = new Db.ChamadoDb();
            db.Create(chamado);

            MessageBox.Show("Chamado cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void prioridadeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}