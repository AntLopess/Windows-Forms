namespace Controle_de_chamados.Formularios.ControleDeUsuario
{
    partial class MenuSuporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSuporte));
            tlpMenuUsuario = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnNV = new Button();
            lblSuporteAtendimento = new Label();
            btnMC = new Button();
            btnCC = new Button();
            btnCA = new Button();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            tlpMenuUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpMenuUsuario
            // 
            tlpMenuUsuario.BackColor = Color.White;
            tlpMenuUsuario.ColumnCount = 1;
            tlpMenuUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuUsuario.Controls.Add(label4, 0, 6);
            tlpMenuUsuario.Controls.Add(pictureBox1, 0, 0);
            tlpMenuUsuario.Controls.Add(btnNV, 0, 5);
            tlpMenuUsuario.Controls.Add(lblSuporteAtendimento, 0, 1);
            tlpMenuUsuario.Controls.Add(btnMC, 0, 2);
            tlpMenuUsuario.Controls.Add(btnCC, 0, 4);
            tlpMenuUsuario.Controls.Add(btnCA, 0, 3);
            tlpMenuUsuario.Controls.Add(panel1, 0, 7);
            tlpMenuUsuario.Dock = DockStyle.Fill;
            tlpMenuUsuario.Location = new Point(0, 0);
            tlpMenuUsuario.Name = "tlpMenuUsuario";
            tlpMenuUsuario.RowCount = 8;
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tlpMenuUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMenuUsuario.Size = new Size(201, 444);
            tlpMenuUsuario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNV
            // 
            btnNV.BackColor = Color.White;
            btnNV.Dock = DockStyle.Fill;
            btnNV.FlatStyle = FlatStyle.Flat;
            btnNV.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNV.ForeColor = Color.SeaGreen;
            btnNV.Location = new Point(3, 212);
            btnNV.Name = "btnNV";
            btnNV.Size = new Size(195, 44);
            btnNV.TabIndex = 3;
            btnNV.Text = "Novo chamado";
            btnNV.UseVisualStyleBackColor = false;
            // 
            // lblSuporteAtendimento
            // 
            lblSuporteAtendimento.Anchor = AnchorStyles.Top;
            lblSuporteAtendimento.AutoSize = true;
            lblSuporteAtendimento.ForeColor = SystemColors.ControlDarkDark;
            lblSuporteAtendimento.Location = new Point(35, 43);
            lblSuporteAtendimento.Name = "lblSuporteAtendimento";
            lblSuporteAtendimento.Size = new Size(130, 14);
            lblSuporteAtendimento.TabIndex = 1;
            lblSuporteAtendimento.Text = "Suporte e Atendimento";
            // 
            // btnMC
            // 
            btnMC.BackColor = Color.SeaGreen;
            btnMC.Dock = DockStyle.Fill;
            btnMC.FlatStyle = FlatStyle.Flat;
            btnMC.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMC.ForeColor = Color.White;
            btnMC.Location = new Point(3, 60);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(195, 46);
            btnMC.TabIndex = 2;
            btnMC.Text = "Meus Chamados";
            btnMC.UseVisualStyleBackColor = false;
            // 
            // btnCC
            // 
            btnCC.Dock = DockStyle.Fill;
            btnCC.FlatStyle = FlatStyle.Flat;
            btnCC.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCC.ForeColor = Color.SeaGreen;
            btnCC.Location = new Point(3, 162);
            btnCC.Name = "btnCC";
            btnCC.Size = new Size(195, 44);
            btnCC.TabIndex = 6;
            btnCC.Text = "Chamados Concluidos";
            btnCC.UseVisualStyleBackColor = true;
            // 
            // btnCA
            // 
            btnCA.Dock = DockStyle.Fill;
            btnCA.FlatStyle = FlatStyle.Flat;
            btnCA.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCA.ForeColor = Color.SeaGreen;
            btnCA.Location = new Point(3, 112);
            btnCA.Name = "btnCA";
            btnCA.Size = new Size(195, 44);
            btnCA.TabIndex = 5;
            btnCA.Text = "Chamados em Andamento";
            btnCA.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 31);
            panel1.TabIndex = 9;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(6, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(34, 32);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(43, -36);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 4;
            label1.Text = "         Olá\r\n(Nome Usuario)";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(40, -71);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 4;
            label3.Text = "         Olá\r\n(Nome Usuario)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(46, -1);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 8;
            label2.Text = "         Olá\r\n(Nome Usuario)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(71, 392);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "(Suporte)";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMenuUsuario);
            Name = "Menu";
            Size = new Size(201, 444);
            tlpMenuUsuario.ResumeLayout(false);
            tlpMenuUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenuUsuario;
        private PictureBox pictureBox1;
        private Button btnNV;
        private Label lblSuporteAtendimento;
        private Button btnMC;
        private Button btnCC;
        private Button btnCA;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
