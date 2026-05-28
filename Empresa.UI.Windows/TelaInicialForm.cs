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
using System.Threading.Tasks;
using System.Windows.Forms;
using static Empresa.Db.LoginDb;

namespace Empresa.UI.Windows
{
    public partial class TelaInicialForm : Form
    {
        private int tipoUsuario;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public TelaInicialForm(int tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;

            // Carrega a logo a partir dos recursos embutidos salvos
            try
            {
                this.logoPictureBox.Image = Properties.Resources.Logotipo;
            }
            catch { }

            // Vincula o evento MouseDown do painel superior dinamicamente
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);

            AjustarBotoes();
        }

        private void AjustarBotoes()
        {
            if (tipoUsuario == LoginDb.TipoUsuario.Colaborador)
            {
                abrirChamadoButton.Visible = true;
                acompanharChamadoButton.Visible = true;
            }
            else if (tipoUsuario == LoginDb.TipoUsuario.Tecnico)
            {
                abrirChamadoButton.Visible = false;
                acompanharChamadoButton.Visible = true;

                // AJUSTE UX: Centraliza verticalmente o card de acompanhar se for a única opção visível
                acompanharChamadoButton.Location = new Point(20, 55);
            }
        }

        // Aplica o gradiente contínuo de alta fidelidade
        private void TelaInicialForm_Paint(object sender, PaintEventArgs e)
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

        private void abrirChamadoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AberturaForm aberturaForm = new AberturaForm();
            aberturaForm.FormClosed += (s, args) => this.Show();
            aberturaForm.Show();
        }

        private void acompanharChamadoButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Fallback de segurança se testar pulando o login
            int tipoUsuarioLogado = (Sessao.UsuarioLogado != null) ? Sessao.UsuarioLogado.TipoUsuario : this.tipoUsuario;

            AcompanharForm acompanharForm = new AcompanharForm(tipoUsuarioLogado);
            acompanharForm.FormClosed += (s, args) => this.Show();
            acompanharForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaInicialForm_Load(object sender, EventArgs e)
        {
        }
    }
}