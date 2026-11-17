
using System;
using System.Drawing;
using System.Windows.Forms;
using Controle_de_chamados.Formularios.ControleDeUsuario;

namespace Controle_de_chamados.Formularios.Usuario
{
    public partial class TelaUsuario : Form
    {
        private Panel pnlConteudo;
        private MenuUsuario menu;

        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            // Configura o formulário
            this.BackColor = Color.FromArgb(245, 240, 230);

            // Cria o menu lateral
            menu = new MenuUsuario();
            menu.Width = 200;
            menu.Dock = DockStyle.Left;

            // Cria a área de conteúdo
            pnlConteudo = new Panel();
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.BackColor =
                Color.FromArgb(245, 240, 230);

            // Adiciona primeiro o menu e depois o conteúdo
            this.Controls.Add(menu);
            this.Controls.Add(pnlConteudo);

            // Ajusta a ordem dos controles
            menu.BringToFront();

            // Abre a tela inicial
            AbrirConteudo(new NovosChamados());
        }

        private void AbrirConteudo(UserControl controle)
        {
            // Limpa o conteúdo anterior
            pnlConteudo.Controls.Clear();

            // Centraliza o UserControl
            controle.Dock = DockStyle.None;
            controle.Anchor = AnchorStyles.None;

            // Adiciona o controle
            pnlConteudo.Controls.Add(controle);

            // Centraliza inicialmente
            CentralizarControle(controle);

            // Recentraliza quando a janela mudar de tamanho
            pnlConteudo.Resize += (s, e) =>
            {
                if (!controle.IsDisposed &&
                    pnlConteudo.Controls.Contains(controle))
                {
                    CentralizarControle(controle);
                }
            };
        }

        private void CentralizarControle(Control controle)
        {
            controle.Left =
                Math.Max(0,
                (pnlConteudo.ClientSize.Width - controle.Width) / 2);

            controle.Top =
                Math.Max(0,
                (pnlConteudo.ClientSize.Height - controle.Height) / 2);
        }
        private void pnlConteudo_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
