namespace Controle_de_chamados
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Logo = new PictureBox();
            lblAcesseconta = new Label();
            lblNomeUsuario = new Label();
            txtNomeUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
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
            tableLayoutPanel1.TabIndex = 0;
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
            tableLayoutPanel2.Controls.Add(lblAcesseconta, 1, 1);
            tableLayoutPanel2.Controls.Add(lblNomeUsuario, 1, 2);
            tableLayoutPanel2.Controls.Add(Logo, 1, 0);
            tableLayoutPanel2.Controls.Add(txtNomeUsuario, 1, 3);
            tableLayoutPanel2.Controls.Add(lblSenha, 1, 4);
            tableLayoutPanel2.Controls.Add(txtSenha, 1, 5);
            tableLayoutPanel2.Controls.Add(btnEntrar, 1, 6);
            tableLayoutPanel2.Controls.Add(btnCadastrar, 1, 7);
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
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(83, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(153, 51);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // lblAcesseconta
            // 
            lblAcesseconta.Anchor = AnchorStyles.None;
            lblAcesseconta.AutoSize = true;
            lblAcesseconta.ForeColor = SystemColors.ControlDarkDark;
            lblAcesseconta.Location = new Point(111, 61);
            lblAcesseconta.Name = "lblAcesseconta";
            lblAcesseconta.Size = new Size(97, 15);
            lblAcesseconta.TabIndex = 1;
            lblAcesseconta.Text = "Acesse sua conta";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Anchor = AnchorStyles.Left;
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.ForeColor = SystemColors.ControlDarkDark;
            lblNomeUsuario.Location = new Point(21, 85);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(108, 15);
            lblNomeUsuario.TabIndex = 2;
            lblNomeUsuario.Text = "Nome de Usuario:";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.BackColor = Color.FromArgb(224, 224, 224);
            txtNomeUsuario.Dock = DockStyle.Fill;
            txtNomeUsuario.ForeColor = SystemColors.WindowFrame;
            txtNomeUsuario.Location = new Point(21, 109);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(278, 23);
            txtNomeUsuario.TabIndex = 3;
            txtNomeUsuario.Text = "Digite seu Nome de usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = SystemColors.ControlDarkDark;
            lblSenha.Location = new Point(21, 138);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(224, 224, 224);
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.ForeColor = SystemColors.WindowFrame;
            txtSenha.Location = new Point(21, 162);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(278, 23);
            txtSenha.TabIndex = 5;
            txtSenha.Text = "Digite sua Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top;
            btnEntrar.BackColor = Color.SeaGreen;
            btnEntrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(21, 194);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(278, 41);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top;
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.BackgroundImageLayout = ImageLayout.None;
            btnCadastrar.ForeColor = SystemColors.ControlDarkDark;
            btnCadastrar.Location = new Point(21, 241);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(278, 23);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Não tem uma conta? Cadastre-se!";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "TelaLogin";
            Text = "Login";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox Logo;
        private Label lblAcesseconta;
        private Label lblNomeUsuario;
        private TextBox txtNomeUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCadastrar;
    }
}
