namespace Provaofc_2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Lista_Cadastrados = new ListBox();
            label1 = new Label();
            Nome = new TextBox();
            Cargo = new TextBox();
            Salario = new TextBox();
            Cpf = new TextBox();
            Btn_Voltar = new Button();
            Btn_Deletar = new Button();
            Btn_Salvar = new Button();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // Lista_Cadastrados
            // 
            Lista_Cadastrados.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lista_Cadastrados.ForeColor = Color.FromArgb(4, 12, 67);
            Lista_Cadastrados.FormattingEnabled = true;
            Lista_Cadastrados.ItemHeight = 26;
            Lista_Cadastrados.Location = new Point(196, 617);
            Lista_Cadastrados.Margin = new Padding(4, 3, 4, 3);
            Lista_Cadastrados.Name = "Lista_Cadastrados";
            Lista_Cadastrados.Size = new Size(961, 108);
            Lista_Cadastrados.TabIndex = 23;
            Lista_Cadastrados.SelectedIndexChanged += Lista_Cadastrados_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 14;
            // 
            // Nome
            // 
            Nome.ForeColor = Color.FromArgb(140, 91, 35);
            Nome.Location = new Point(35, 48);
            Nome.Margin = new Padding(4, 3, 4, 3);
            Nome.Name = "Nome";
            Nome.Size = new Size(199, 23);
            Nome.TabIndex = 27;
            // 
            // Cargo
            // 
            Cargo.ForeColor = Color.FromArgb(140, 91, 35);
            Cargo.Location = new Point(35, 243);
            Cargo.Margin = new Padding(4, 3, 4, 3);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(199, 23);
            Cargo.TabIndex = 28;
            // 
            // Salario
            // 
            Salario.ForeColor = Color.FromArgb(140, 91, 35);
            Salario.Location = new Point(35, 175);
            Salario.Margin = new Padding(4, 3, 4, 3);
            Salario.Name = "Salario";
            Salario.Size = new Size(199, 23);
            Salario.TabIndex = 29;
            // 
            // Cpf
            // 
            Cpf.ForeColor = Color.FromArgb(140, 91, 35);
            Cpf.Location = new Point(35, 109);
            Cpf.Margin = new Padding(4, 3, 4, 3);
            Cpf.Name = "Cpf";
            Cpf.Size = new Size(199, 23);
            Cpf.TabIndex = 33;
            Cpf.TextChanged += textBox4_TextChanged;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Transparent;
            Btn_Voltar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Voltar.Image = (Image)resources.GetObject("Btn_Voltar.Image");
            Btn_Voltar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Voltar.Location = new Point(1012, 350);
            Btn_Voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(304, 136);
            Btn_Voltar.TabIndex = 36;
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
            Btn_Deletar.Location = new Point(1012, 192);
            Btn_Deletar.Margin = new Padding(4, 3, 4, 3);
            Btn_Deletar.Name = "Btn_Deletar";
            Btn_Deletar.Size = new Size(304, 136);
            Btn_Deletar.TabIndex = 37;
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
            Btn_Salvar.Location = new Point(1012, 36);
            Btn_Salvar.Margin = new Padding(4, 3, 4, 3);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(304, 136);
            Btn_Salvar.TabIndex = 38;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = false;
            Btn_Salvar.Click += Btn_Salvar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(4, 12, 67);
            label6.Location = new Point(35, 19);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 26);
            label6.TabIndex = 40;
            label6.Text = "Nome";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(4, 12, 67);
            label8.Location = new Point(35, 214);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 26);
            label8.TabIndex = 42;
            label8.Text = "Cargo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(4, 12, 67);
            label9.Location = new Point(35, 146);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(112, 26);
            label9.TabIndex = 43;
            label9.Text = "Salário";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(4, 12, 67);
            label10.Location = new Point(35, 80);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(52, 26);
            label10.TabIndex = 44;
            label10.Text = "CPF";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Deletar);
            Controls.Add(Btn_Voltar);
            Controls.Add(Cpf);
            Controls.Add(Salario);
            Controls.Add(Cargo);
            Controls.Add(Nome);
            Controls.Add(Lista_Cadastrados);
            Controls.Add(label1);
            Font = new Font("Perpetua Titling MT", 9.75F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Cadastro de Funcionários";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Lista_Cadastrados;
        private Label label1;
        private TextBox Nome;
        private TextBox Cargo;
        private TextBox Salario;
        private TextBox Cpf;
        private Button Btn_Voltar;
        private Button Btn_Deletar;
        private Button Btn_Salvar;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}