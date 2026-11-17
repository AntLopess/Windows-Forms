namespace Controle_de_chamados.Formularios.Usuario
{
    partial class TelaUsuario
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
            pnlConteudo = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(800, 450);
            pnlConteudo.TabIndex = 0;
            pnlConteudo.Paint += pnlConteudo_Paint;
            // 
            // TelaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlConteudo);
            Name = "TelaUsuario";
            Text = "TelaUsuario";
            Load += TelaUsuario_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlConteudo;
    }
}