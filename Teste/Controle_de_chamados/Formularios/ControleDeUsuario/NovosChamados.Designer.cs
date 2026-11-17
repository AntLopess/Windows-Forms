namespace Controle_de_chamados.Formularios.ControleDeUsuario
{
    partial class MeusChamados
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitulo = new TextBox();
            panel2 = new Panel();
            cmbPrioridade = new ComboBox();
            cmbCategoria = new ComboBox();
            panel3 = new Panel();
            label5 = new Label();
            txtDescricao = new TextBox();
            btnVoltar = new Button();
            panel4 = new Panel();
            btnConfirmar = new Button();
            btnIVoltar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.27889F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.72111F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7981224F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.20188F));
            tableLayoutPanel1.Size = new Size(649, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.AntiqueWhite;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9642849F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.03571F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 49);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8205128F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.17949F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel2.Size = new Size(643, 374);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(txtTitulo, 0, 2);
            tableLayoutPanel3.Controls.Add(panel2, 0, 4);
            tableLayoutPanel3.Controls.Add(panel3, 0, 3);
            tableLayoutPanel3.Controls.Add(label4, 0, 5);
            tableLayoutPanel3.Controls.Add(txtDescricao, 0, 6);
            tableLayoutPanel3.Controls.Add(panel4, 0, 7);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(95, 43);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 54.83871F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 45.16129F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel3.Size = new Size(445, 266);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnIVoltar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 40);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(164, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 0;
            label1.Text = "Novo Chamado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(115, 16);
            label2.TabIndex = 1;
            label2.Text = "Titulo do Problema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 146);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 3;
            label4.Text = "Descrição";
            // 
            // txtTitulo
            // 
            txtTitulo.ForeColor = SystemColors.WindowFrame;
            txtTitulo.Location = new Point(3, 40);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(277, 23);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Ex:Impressora não Funciona";
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbCategoria);
            panel2.Controls.Add(cmbPrioridade);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 45);
            panel2.TabIndex = 5;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Items.AddRange(new object[] { "Baixa", "Media", "Alta" });
            cmbPrioridade.Location = new Point(256, 12);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(144, 23);
            cmbPrioridade.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Computador", "Impressora ", "Sistema ", "Rede ", "Outros" });
            cmbCategoria.Location = new Point(31, 12);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(144, 23);
            cmbCategoria.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 20);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(256, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 3;
            label5.Text = "Prioridade";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.ForeColor = SystemColors.WindowFrame;
            txtDescricao.Location = new Point(3, 173);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(439, 22);
            txtDescricao.TabIndex = 7;
            txtDescricao.Text = "Descreva o Problema Encontrado";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.SeaGreen;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(31, 7);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(130, 30);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnConfirmar);
            panel4.Controls.Add(btnVoltar);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 209);
            panel4.Name = "panel4";
            panel4.Size = new Size(439, 54);
            panel4.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SeaGreen;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(256, 7);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(130, 30);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnIVoltar
            // 
            btnIVoltar.BackColor = Color.SeaGreen;
            btnIVoltar.Dock = DockStyle.Left;
            btnIVoltar.FlatStyle = FlatStyle.Flat;
            btnIVoltar.ForeColor = Color.SeaGreen;
            btnIVoltar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnIVoltar.IconColor = Color.White;
            btnIVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIVoltar.IconSize = 35;
            btnIVoltar.Location = new Point(0, 0);
            btnIVoltar.Name = "btnIVoltar";
            btnIVoltar.Size = new Size(65, 40);
            btnIVoltar.TabIndex = 0;
            btnIVoltar.UseVisualStyleBackColor = false;
            // 
            // MeusChamados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MeusChamados";
            Size = new Size(649, 426);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtTitulo;
        private Panel panel2;
        private ComboBox cmbCategoria;
        private ComboBox cmbPrioridade;
        private Panel panel3;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtDescricao;
        private Panel panel4;
        private Button btnConfirmar;
        private Button btnVoltar;
        private FontAwesome.Sharp.IconButton btnIVoltar;
    }
}
