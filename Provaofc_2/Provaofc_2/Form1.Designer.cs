namespace Provaofc_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Quantidade = new TextBox();
            Preço = new TextBox();
            Codigo_barras = new TextBox();
            label5 = new Label();
            Lista_Cadastrados = new ListBox();
            Nome = new TextBox();
            Btn_Voltar = new Button();
            Btn_Deletar = new Button();
            Btn_Salvar = new Button();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Quantidade
            // 
            Quantidade.Font = new Font("Perpetua Titling MT", 9.75F);
            Quantidade.ForeColor = Color.FromArgb(140, 91, 35);
            Quantidade.Location = new Point(35, 210);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(169, 23);
            Quantidade.TabIndex = 3;
            // 
            // Preço
            // 
            Preço.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Preço.ForeColor = Color.FromArgb(140, 91, 35);
            Preço.Location = new Point(35, 290);
            Preço.Name = "Preço";
            Preço.Size = new Size(86, 23);
            Preço.TabIndex = 5;
            // 
            // Codigo_barras
            // 
            Codigo_barras.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Codigo_barras.ForeColor = Color.FromArgb(140, 91, 35);
            Codigo_barras.Location = new Point(35, 128);
            Codigo_barras.Name = "Codigo_barras";
            Codigo_barras.Size = new Size(242, 23);
            Codigo_barras.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(4, 12, 67);
            label5.Location = new Point(35, 19);
            label5.Name = "label5";
            label5.Size = new Size(243, 26);
            label5.TabIndex = 10;
            label5.Text = "Nome do Produto";
            // 
            // Lista_Cadastrados
            // 
            Lista_Cadastrados.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lista_Cadastrados.ForeColor = Color.FromArgb(4, 12, 67);
            Lista_Cadastrados.FormattingEnabled = true;
            Lista_Cadastrados.ItemHeight = 20;
            Lista_Cadastrados.Location = new Point(217, 623);
            Lista_Cadastrados.Name = "Lista_Cadastrados";
            Lista_Cadastrados.Size = new Size(937, 64);
            Lista_Cadastrados.TabIndex = 11;
            // 
            // Nome
            // 
            Nome.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nome.ForeColor = Color.FromArgb(140, 91, 35);
            Nome.Location = new Point(35, 48);
            Nome.Name = "Nome";
            Nome.Size = new Size(243, 23);
            Nome.TabIndex = 4;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Transparent;
            Btn_Voltar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Voltar.Image = (Image)resources.GetObject("Btn_Voltar.Image");
            Btn_Voltar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Voltar.Location = new Point(1037, 303);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(304, 136);
            Btn_Voltar.TabIndex = 13;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_Deletar
            // 
            Btn_Deletar.BackColor = Color.Transparent;
            Btn_Deletar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Deletar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Deletar.Image = (Image)resources.GetObject("Btn_Deletar.Image");
            Btn_Deletar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Deletar.Location = new Point(1037, 161);
            Btn_Deletar.Name = "Btn_Deletar";
            Btn_Deletar.Size = new Size(304, 136);
            Btn_Deletar.TabIndex = 14;
            Btn_Deletar.Text = "Deletar";
            Btn_Deletar.UseVisualStyleBackColor = false;
            Btn_Deletar.Click += Btn_Deletar_Click;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.BackColor = Color.Transparent;
            Btn_Salvar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Salvar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Salvar.Image = (Image)resources.GetObject("Btn_Salvar.Image");
            Btn_Salvar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Salvar.Location = new Point(1037, 19);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(304, 136);
            Btn_Salvar.TabIndex = 15;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = false;
            Btn_Salvar.Click += Btn_Salvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 12, 67);
            label1.Location = new Point(35, 261);
            label1.Name = "label1";
            label1.Size = new Size(86, 26);
            label1.TabIndex = 16;
            label1.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(4, 12, 67);
            label4.Location = new Point(35, 181);
            label4.Name = "label4";
            label4.Size = new Size(169, 26);
            label4.TabIndex = 17;
            label4.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(4, 12, 67);
            label7.Location = new Point(35, 99);
            label7.Name = "label7";
            label7.Size = new Size(242, 26);
            label7.TabIndex = 18;
            label7.Text = "Código de Barras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1353, 749);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Deletar);
            Controls.Add(Btn_Voltar);
            Controls.Add(Lista_Cadastrados);
            Controls.Add(label5);
            Controls.Add(Codigo_barras);
            Controls.Add(Preço);
            Controls.Add(Nome);
            Controls.Add(Quantidade);
            Name = "Form1";
            Text = "Cadastro de Produtos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Quantidade;
        private TextBox Preço;
        private TextBox Codigo_barras;
        private Label label5;
        private ListBox Lista_Cadastrados;
        private TextBox Nome;
        private Button Btn_Voltar;
        private Button Btn_Deletar;
        private Button Btn_Salvar;
        private Label label1;
        private Label label4;
        private Label label7;
    }
}
