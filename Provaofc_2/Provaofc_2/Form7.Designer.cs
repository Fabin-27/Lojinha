namespace Provaofc_2
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            listBox1 = new ListBox();
            label1 = new Label();
            Quantidade = new TextBox();
            Preço = new TextBox();
            label2 = new Label();
            Btn_Atualizar = new Button();
            Btn_Voltar = new Button();
            label6 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Bold);
            listBox1.ForeColor = Color.FromArgb(4, 12, 67);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(306, 331);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(762, 180);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // Quantidade
            // 
            Quantidade.Font = new Font("Perpetua Titling MT", 9.75F);
            Quantidade.ForeColor = Color.FromArgb(140, 91, 35);
            Quantidade.Location = new Point(18, 63);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(139, 23);
            Quantidade.TabIndex = 3;
            // 
            // Preço
            // 
            Preço.Font = new Font("Perpetua Titling MT", 9.75F);
            Preço.ForeColor = Color.FromArgb(140, 91, 35);
            Preço.Location = new Point(12, 695);
            Preço.Name = "Preço";
            Preço.Size = new Size(145, 23);
            Preço.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // Btn_Atualizar
            // 
            Btn_Atualizar.BackColor = Color.Transparent;
            Btn_Atualizar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Atualizar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Atualizar.Image = (Image)resources.GetObject("Btn_Atualizar.Image");
            Btn_Atualizar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Atualizar.Location = new Point(1053, 34);
            Btn_Atualizar.Margin = new Padding(4, 3, 4, 3);
            Btn_Atualizar.Name = "Btn_Atualizar";
            Btn_Atualizar.Size = new Size(304, 121);
            Btn_Atualizar.TabIndex = 49;
            Btn_Atualizar.Text = "Atualizar";
            Btn_Atualizar.UseVisualStyleBackColor = false;
            Btn_Atualizar.Click += Btn_Atualizar_Click;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Transparent;
            Btn_Voltar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Voltar.Image = (Image)resources.GetObject("Btn_Voltar.Image");
            Btn_Voltar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Voltar.Location = new Point(1053, 616);
            Btn_Voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(304, 121);
            Btn_Voltar.TabIndex = 50;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(4, 12, 67);
            label6.Location = new Point(12, 34);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(318, 26);
            label6.TabIndex = 52;
            label6.Text = "Atualizar Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 12, 67);
            label3.Location = new Point(12, 669);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(235, 26);
            label3.TabIndex = 53;
            label3.Text = "Atualizar Preço:";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(Btn_Voltar);
            Controls.Add(Btn_Atualizar);
            Controls.Add(Preço);
            Controls.Add(label2);
            Controls.Add(Quantidade);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form7";
            Text = "Estoque";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private TextBox Quantidade;
        private TextBox Preço;
        private Label label2;
        private Button Btn_Atualizar;
        private Button Btn_Voltar;
        private Label label6;
        private Label label3;
    }
}