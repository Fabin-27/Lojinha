namespace Provaofc_2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Salario = new TextBox();
            Cargo = new TextBox();
            textBox1 = new TextBox();
            Lista_Cadastrados = new ListBox();
            Btn_Voltar = new Button();
            Btn_Editar = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Salario
            // 
            Salario.Font = new Font("Perpetua Titling MT", 9.75F);
            Salario.ForeColor = Color.FromArgb(140, 91, 35);
            Salario.Location = new Point(33, 178);
            Salario.Name = "Salario";
            Salario.Size = new Size(156, 23);
            Salario.TabIndex = 39;
            // 
            // Cargo
            // 
            Cargo.Font = new Font("Perpetua Titling MT", 9.75F);
            Cargo.ForeColor = Color.FromArgb(140, 91, 35);
            Cargo.Location = new Point(34, 248);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(156, 23);
            Cargo.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Perpetua Titling MT", 9.75F);
            textBox1.ForeColor = Color.FromArgb(140, 91, 35);
            textBox1.Location = new Point(33, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 37;
            // 
            // Lista_Cadastrados
            // 
            Lista_Cadastrados.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lista_Cadastrados.ForeColor = Color.FromArgb(4, 12, 67);
            Lista_Cadastrados.FormattingEnabled = true;
            Lista_Cadastrados.ItemHeight = 26;
            Lista_Cadastrados.Location = new Point(196, 624);
            Lista_Cadastrados.Name = "Lista_Cadastrados";
            Lista_Cadastrados.Size = new Size(961, 82);
            Lista_Cadastrados.TabIndex = 40;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Transparent;
            Btn_Voltar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Voltar.Image = (Image)resources.GetObject("Btn_Voltar.Image");
            Btn_Voltar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Voltar.Location = new Point(1012, 230);
            Btn_Voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(304, 136);
            Btn_Voltar.TabIndex = 44;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_Editar
            // 
            Btn_Editar.BackColor = Color.Transparent;
            Btn_Editar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Editar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Editar.Image = (Image)resources.GetObject("Btn_Editar.Image");
            Btn_Editar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Editar.Location = new Point(1012, 77);
            Btn_Editar.Margin = new Padding(4, 3, 4, 3);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(304, 136);
            Btn_Editar.TabIndex = 45;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = false;
            Btn_Editar.Click += Btn_Editar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(4, 12, 67);
            label6.Location = new Point(33, 77);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 26);
            label6.TabIndex = 47;
            label6.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 12, 67);
            label1.Location = new Point(33, 219);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 26);
            label1.TabIndex = 48;
            label1.Text = "Cargo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 12, 67);
            label2.Location = new Point(33, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 26);
            label2.TabIndex = 49;
            label2.Text = "Salário";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Voltar);
            Controls.Add(Lista_Cadastrados);
            Controls.Add(Salario);
            Controls.Add(Cargo);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Editar Funcionário";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Salario;
        private TextBox Cargo;
        private TextBox textBox1;
        private ListBox Lista_Cadastrados;
        private Button Btn_Voltar;
        private Button Btn_Editar;
        private Label label6;
        private Label label1;
        private Label label2;
    }
}