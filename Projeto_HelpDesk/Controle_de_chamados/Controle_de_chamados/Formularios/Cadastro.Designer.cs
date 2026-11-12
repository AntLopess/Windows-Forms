namespace Controle_de_chamados.Formularios
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblCadastreconta = new Label();
            lblNomeUsuario2 = new Label();
            Logo2 = new PictureBox();
            txtNomeUsuario2 = new TextBox();
            lblSenha2 = new Label();
            txtSenha2 = new TextBox();
            btnEntrar2 = new Button();
            btnVoltar = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.AntiqueWhite;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 245F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 326F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 245F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 309F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(248, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 303);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.22406626F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.77593F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17F));
            tableLayoutPanel2.Controls.Add(lblCadastreconta, 1, 1);
            tableLayoutPanel2.Controls.Add(Logo2, 1, 0);
            tableLayoutPanel2.Controls.Add(txtNomeUsuario2, 1, 3);
            tableLayoutPanel2.Controls.Add(lblSenha2, 1, 4);
            tableLayoutPanel2.Controls.Add(txtSenha2, 1, 5);
            tableLayoutPanel2.Controls.Add(btnEntrar2, 1, 6);
            tableLayoutPanel2.Controls.Add(btnVoltar, 1, 7);
            tableLayoutPanel2.Controls.Add(lblNomeUsuario2, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.Size = new Size(320, 303);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblCadastreconta
            // 
            lblCadastreconta.Anchor = AnchorStyles.None;
            lblCadastreconta.AutoSize = true;
            lblCadastreconta.ForeColor = SystemColors.ControlDarkDark;
            lblCadastreconta.Location = new Point(106, 61);
            lblCadastreconta.Name = "lblCadastreconta";
            lblCadastreconta.Size = new Size(107, 15);
            lblCadastreconta.TabIndex = 1;
            lblCadastreconta.Text = "Cadastre sua conta";
            // 
            // lblNomeUsuario2
            // 
            lblNomeUsuario2.Anchor = AnchorStyles.Left;
            lblNomeUsuario2.AutoSize = true;
            lblNomeUsuario2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario2.ForeColor = SystemColors.ControlDarkDark;
            lblNomeUsuario2.Location = new Point(21, 85);
            lblNomeUsuario2.Name = "lblNomeUsuario2";
            lblNomeUsuario2.Size = new Size(108, 15);
            lblNomeUsuario2.TabIndex = 2;
            lblNomeUsuario2.Text = "Nome de Usuario:";
            // 
            // Logo2
            // 
            Logo2.Anchor = AnchorStyles.None;
            Logo2.Image = (Image)resources.GetObject("Logo2.Image");
            Logo2.Location = new Point(83, 3);
            Logo2.Name = "Logo2";
            Logo2.Size = new Size(153, 51);
            Logo2.TabIndex = 0;
            Logo2.TabStop = false;
            // 
            // txtNomeUsuario2
            // 
            txtNomeUsuario2.BackColor = Color.FromArgb(224, 224, 224);
            txtNomeUsuario2.Dock = DockStyle.Fill;
            txtNomeUsuario2.ForeColor = SystemColors.WindowFrame;
            txtNomeUsuario2.Location = new Point(21, 109);
            txtNomeUsuario2.Name = "txtNomeUsuario2";
            txtNomeUsuario2.Size = new Size(278, 23);
            txtNomeUsuario2.TabIndex = 3;
            txtNomeUsuario2.Text = "Digite seu Nome de usuario";
            // 
            // lblSenha2
            // 
            lblSenha2.AutoSize = true;
            lblSenha2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha2.ForeColor = SystemColors.ControlDarkDark;
            lblSenha2.Location = new Point(21, 138);
            lblSenha2.Name = "lblSenha2";
            lblSenha2.Size = new Size(46, 15);
            lblSenha2.TabIndex = 4;
            lblSenha2.Text = "Senha:";
            // 
            // txtSenha2
            // 
            txtSenha2.BackColor = Color.FromArgb(224, 224, 224);
            txtSenha2.Dock = DockStyle.Fill;
            txtSenha2.ForeColor = SystemColors.WindowFrame;
            txtSenha2.Location = new Point(21, 162);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Size = new Size(278, 23);
            txtSenha2.TabIndex = 5;
            txtSenha2.Text = "Digite sua Senha";
            // 
            // btnEntrar2
            // 
            btnEntrar2.Anchor = AnchorStyles.Top;
            btnEntrar2.BackColor = Color.SeaGreen;
            btnEntrar2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar2.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar2.Location = new Point(21, 194);
            btnEntrar2.Name = "btnEntrar2";
            btnEntrar2.Size = new Size(278, 41);
            btnEntrar2.TabIndex = 6;
            btnEntrar2.Text = "Entrar";
            btnEntrar2.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BackgroundImageLayout = ImageLayout.None;
            btnVoltar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.SeaGreen;
            btnVoltar.Location = new Point(98, 241);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(123, 26);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar\r\n";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Cadastro";
            Text = "Cadastro";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblCadastreconta;
        private Label lblNomeUsuario2;
        private PictureBox Logo2;
        private TextBox txtNomeUsuario2;
        private Label lblSenha2;
        private TextBox txtSenha2;
        private Button btnEntrar2;
        private Button btnVoltar;
    }
}