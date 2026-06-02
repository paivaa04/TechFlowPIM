using Empresa.Db;
using Empresa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Empresa.Db.LoginDb;

namespace Empresa.UI.Windows
{
    public partial class AcompanharForm : Form
    {
        private int tipoUsuario;

        // Importações nativas para permitir mover a janela personalizada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AcompanharForm(int tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            voltarButton.Visible = false;

            // Executa as configurações visuais do padrão TechFlow Solutions
            ConfigurarInterfacePremium();

            ExibirGrid();
            AjustarBotoes();
        }

        private void ConfigurarInterfacePremium()
        {
            // 1. Vincula o evento MouseDown do painel superior dinamicamente
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);

            // 2. Cores da identidade visual do app
            Color corFundoInput = Color.FromArgb(13, 22, 38);
            Color corTextoRotulo = Color.FromArgb(140, 165, 210);

            // 3. Estilização do DataGridView (Tabela em Modo Escuro)
            listaDataGridView.BackgroundColor = Color.FromArgb(20, 30, 50);
            listaDataGridView.BorderStyle = BorderStyle.None;
            listaDataGridView.GridColor = Color.FromArgb(40, 55, 80);

            // Cabeçalho da Grid
            listaDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 16, 26);
            listaDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            listaDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            listaDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(10, 16, 26);

            // Linhas da Grid
            listaDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(20, 31, 53);
            listaDataGridView.DefaultCellStyle.ForeColor = Color.White;
            listaDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            listaDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 48, 78);
            listaDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // 4. Estilização Plana dos Inputs do Painel de Detalhes
            nomeTextBox.BorderStyle = BorderStyle.FixedSingle;
            nomeTextBox.BackColor = corFundoInput;
            nomeTextBox.ForeColor = Color.White;
            nomeTextBox.Font = new Font("Segoe UI", 10F);

            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.BackColor = corFundoInput;
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Font = new Font("Segoe UI", 10F);

            setorTextBox.BorderStyle = BorderStyle.FixedSingle;
            setorTextBox.BackColor = corFundoInput;
            setorTextBox.ForeColor = Color.White;
            setorTextBox.Font = new Font("Segoe UI", 10F);

            assuntoTextBox.BorderStyle = BorderStyle.FixedSingle;
            assuntoTextBox.BackColor = corFundoInput;
            assuntoTextBox.ForeColor = Color.White;
            assuntoTextBox.Font = new Font("Segoe UI", 10F);

            statusTextBox.BorderStyle = BorderStyle.FixedSingle;
            statusTextBox.BackColor = corFundoInput;
            statusTextBox.ForeColor = Color.White;
            statusTextBox.Font = new Font("Segoe UI", 10F);

            descricaoRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            descricaoRichTextBox.BackColor = corFundoInput;
            descricaoRichTextBox.ForeColor = Color.White;
            descricaoRichTextBox.Font = new Font("Segoe UI", 10.5F);

            // 5. Ajuste de cores das Labels de texto para cinza azulado
            nomeLabel.ForeColor = corTextoRotulo;
            nomeLabel.Font = new Font("Segoe UI", 9F);
            emailLabel.ForeColor = corTextoRotulo;
            emailLabel.Font = new Font("Segoe UI", 9F);
            setorLabel.ForeColor = corTextoRotulo;
            setorLabel.Font = new Font("Segoe UI", 9F);
            assuntoLabel.ForeColor = corTextoRotulo;
            assuntoLabel.Font = new Font("Segoe UI", 9F);
            statusLabel.ForeColor = corTextoRotulo;
            statusLabel.Font = new Font("Segoe UI", 9F);
            descricaoLabel.ForeColor = corTextoRotulo;
            descricaoLabel.Font = new Font("Segoe UI", 9F);

            // 6. Configuração dos botões inferiores
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.None;

            atualizarButton.BackColor = Color.Transparent;
            atualizarButton.FlatAppearance.BorderColor = corTextoRotulo;
            atualizarButton.FlatStyle = FlatStyle.Flat;
            atualizarButton.ForeColor = Color.White;
            atualizarButton.Font = new Font("Segoe UI", 9F);

            visualizarButton.BackColor = Color.White;
            visualizarButton.FlatAppearance.BorderSize = 0;
            visualizarButton.FlatStyle = FlatStyle.Flat;
            visualizarButton.ForeColor = Color.FromArgb(10, 20, 38);
            visualizarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            voltarButton.BackColor = Color.Transparent;
            voltarButton.FlatAppearance.BorderColor = corTextoRotulo;
            voltarButton.FlatStyle = FlatStyle.Flat;
            voltarButton.ForeColor = Color.White;
            voltarButton.Font = new Font("Segoe UI", 9F);

            deletarButton.BackColor = Color.Transparent;
            deletarButton.FlatAppearance.BorderColor = Color.FromArgb(211, 47, 47); // Borda vermelha discreta para deleção
            deletarButton.FlatStyle = FlatStyle.Flat;
            deletarButton.ForeColor = Color.FromArgb(255, 128, 128);
            deletarButton.Font = new Font("Segoe UI", 9F);
        }

        private void CarregarChamados()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source = Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechFlow;Integrated Security=True;Pooling=False"))
                {
                    string sql = "SELECT Id, Nome, Email, Setor, Assunto, Descricao, DataAbertura, Prioridade, Status FROM Chamados";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    listaDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AjustarBotoes()
        {
            if (tipoUsuario == LoginDb.TipoUsuario.Colaborador)
            {
                atualizarButton.Visible = false;
                visualizarButton.Visible = true;
            }
            else if (tipoUsuario == LoginDb.TipoUsuario.Tecnico)
            {
                atualizarButton.Visible = false;
                visualizarButton.Visible = true;
            }
        }

        private void ExibirGrid()
        {
            var db = new ChamadoDb();
            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = true;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.Dock = DockStyle.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false; // Permite aplicar as cores customizadas no topo

            if (listaDataGridView.Columns["Id"] != null) listaDataGridView.Columns["Id"].Visible = false;
            if (listaDataGridView.Columns["IdUsuario"] != null) listaDataGridView.Columns["IdUsuario"].Visible = false;
            if (listaDataGridView.Columns["Nome"] != null) listaDataGridView.Columns["Nome"].Visible = true;
            if (listaDataGridView.Columns["Email"] != null) listaDataGridView.Columns["Email"].Visible = false;
            if (listaDataGridView.Columns["Descricao"] != null) listaDataGridView.Columns["Descricao"].Visible = false;

            detalhesPanel.Visible = false;
            atualizarButton.Visible = false;
        }

        // Aplica o mesmo gradiente azul escuro fluido das outras telas
        private void AcompanharForm_Paint(object sender, PaintEventArgs e)
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

        private void AcompanharForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
            listaDataGridView.AllowUserToAddRows = false;
        }

        private void visualizarButton_Click(object sender, EventArgs e)
        {
            if (listaDataGridView.CurrentRow == null)
                return;

            detalhesPanel.Visible = true;
            visualizarButton.Visible = false;
            listaDataGridView.Visible = false;
            voltarButton.Visible = true;

            Chamado chamado = (Chamado)listaDataGridView.CurrentRow.DataBoundItem;

            detalhesPanel.Dock = DockStyle.Fill;
            nomeTextBox.Text = chamado.Nome;
            emailTextBox.Text = chamado.Email;
            setorTextBox.Text = chamado.Setor;
            assuntoTextBox.Text = chamado.Assunto;
            descricaoRichTextBox.Text = chamado.Descricao;
            statusTextBox.Text = chamado.Status;

            // Bloqueia campos de texto para visualização limpa
            nomeTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            setorTextBox.ReadOnly = true;
            assuntoTextBox.ReadOnly = true;

            if (tipoUsuario == LoginDb.TipoUsuario.Tecnico)
            {
                atualizarButton.Visible = true;
                statusTextBox.ReadOnly = false;
                descricaoRichTextBox.ReadOnly = false; // Técnico pode atualizar a tratativa do chamado
            }
            else
            {
                atualizarButton.Visible = false;
                statusTextBox.ReadOnly = true;
                descricaoRichTextBox.ReadOnly = true;
            }
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            // Evento duplicado evitado mapeando o clique correto
            voltarButton_Click(sender, e);
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            detalhesPanel.Visible = false;
            voltarButton.Visible = false;
            listaDataGridView.Visible = true;

            ExibirGrid();
            AjustarBotoes();
        }

        private void deletarButton_Click(object sender, EventArgs e)
        {
            if (listaDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um chamado para deletar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idChamado = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["Id"].Value);

            DialogResult confirm = MessageBox.Show(
                "Tem certeza que deseja deletar este chamado?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var chamadoDb = new ChamadoDb();
                    chamadoDb.Excluir(idChamado);

                    MessageBox.Show("Chamado deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExibirGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            var chamado = new Chamado();
            chamado.Id = Convert.ToInt32(listaDataGridView.CurrentRow.Cells["Id"].Value);
            chamado.Descricao = descricaoRichTextBox.Text;
            chamado.Status = statusTextBox.Text;

            var db = new ChamadoDb();
            db.Alterar(chamado);

            MessageBox.Show("Chamado alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            voltarButton_Click(sender, e); // Retorna automaticamente para a tabela atualizada
        }
        private void finalizarButton_Click(object sender, EventArgs e)
        {
            if (listaDataGridView.CurrentRow == null) return;

            DialogResult confirm = MessageBox.Show(
                "Deseja encerrar e finalizar este chamado definitivamente?",
                "Finalizar Chamado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int idChamado = Convert.ToInt32(listaDataGridView.CurrentRow.Cells["Id"].Value);

                    var db = new ChamadoDb();
                    db.FinalizarChamado(idChamado); 

                    MessageBox.Show("Chamado finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    voltarButton_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}