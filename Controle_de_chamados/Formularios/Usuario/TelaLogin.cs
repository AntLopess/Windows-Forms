
using System;
using System.Drawing;
using System.Windows.Forms;
using Controle_de_chamados.Formularios.Usuario;

namespace Controle_de_chamados
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaUsuario menu = new TelaUsuario();

            menu.Show();

            this.Hide();
        }

        private void tableLayoutPanel2_Paint(
            object sender, PaintEventArgs e)
        {

        }
    }
}
