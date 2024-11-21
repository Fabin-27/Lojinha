namespace Provaofc_2
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            dataGridView = new DataGridView();
            label3 = new Label();
            Carrinho = new ListBox();
            Total = new Label();
            listBox1_Sucesso = new ListBox();
            comboBox1 = new ComboBox();
            Btn_Voltar = new Button();
            Btn_Comprar = new Button();
            Btn_Remover = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(485, 145);
            dataGridView.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 12, 67);
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(286, 26);
            label3.TabIndex = 16;
            label3.Text = "Forma de Pagamento";
            // 
            // Carrinho
            // 
            Carrinho.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Carrinho.ForeColor = Color.FromArgb(4, 12, 67);
            Carrinho.FormattingEnabled = true;
            Carrinho.ItemHeight = 26;
            Carrinho.Location = new Point(12, 338);
            Carrinho.Name = "Carrinho";
            Carrinho.Size = new Size(424, 108);
            Carrinho.TabIndex = 20;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = Color.Transparent;
            Total.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold);
            Total.ForeColor = Color.FromArgb(4, 12, 67);
            Total.Location = new Point(12, 449);
            Total.Name = "Total";
            Total.Size = new Size(92, 26);
            Total.TabIndex = 22;
            Total.Text = "Total:";
            // 
            // listBox1_Sucesso
            // 
            listBox1_Sucesso.Font = new Font("Linux Libertine G", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1_Sucesso.ForeColor = Color.FromArgb(4, 12, 67);
            listBox1_Sucesso.FormattingEnabled = true;
            listBox1_Sucesso.ItemHeight = 15;
            listBox1_Sucesso.Location = new Point(912, 12);
            listBox1_Sucesso.Name = "listBox1_Sucesso";
            listBox1_Sucesso.Size = new Size(446, 469);
            listBox1_Sucesso.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Alef", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(4, 12, 67);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PIX", "Cartão de Crédito", "Cartão de Débito", "Dinheiro" });
            comboBox1.Location = new Point(304, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 24);
            comboBox1.TabIndex = 24;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Transparent;
            Btn_Voltar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Voltar.Image = (Image)resources.GetObject("Btn_Voltar.Image");
            Btn_Voltar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Voltar.Location = new Point(1054, 616);
            Btn_Voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(304, 121);
            Btn_Voltar.TabIndex = 47;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_Comprar
            // 
            Btn_Comprar.BackColor = Color.Transparent;
            Btn_Comprar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Comprar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Comprar.Image = (Image)resources.GetObject("Btn_Comprar.Image");
            Btn_Comprar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Comprar.Location = new Point(12, 616);
            Btn_Comprar.Margin = new Padding(4, 3, 4, 3);
            Btn_Comprar.Name = "Btn_Comprar";
            Btn_Comprar.Size = new Size(304, 121);
            Btn_Comprar.TabIndex = 48;
            Btn_Comprar.Text = "Concluir Compra";
            Btn_Comprar.UseVisualStyleBackColor = false;
            Btn_Comprar.Click += Btn_Comprar_Click;
            // 
            // Btn_Remover
            // 
            Btn_Remover.BackColor = Color.Transparent;
            Btn_Remover.Font = new Font("Perpetua Titling MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Remover.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Remover.Image = (Image)resources.GetObject("Btn_Remover.Image");
            Btn_Remover.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Remover.Location = new Point(224, 163);
            Btn_Remover.Margin = new Padding(4, 3, 4, 3);
            Btn_Remover.Name = "Btn_Remover";
            Btn_Remover.Size = new Size(212, 84);
            Btn_Remover.TabIndex = 49;
            Btn_Remover.Text = "Remover";
            Btn_Remover.UseVisualStyleBackColor = false;
            Btn_Remover.Click += Btn_Remover_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Font = new Font("Perpetua Titling MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(4, 12, 67);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(12, 163);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(204, 84);
            button6.TabIndex = 50;
            button6.Text = "Adicionar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(button6);
            Controls.Add(Btn_Remover);
            Controls.Add(Btn_Comprar);
            Controls.Add(Btn_Voltar);
            Controls.Add(comboBox1);
            Controls.Add(listBox1_Sucesso);
            Controls.Add(Total);
            Controls.Add(Carrinho);
            Controls.Add(label3);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Vendas";
            WindowState = FormWindowState.Maximized;
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView;
        private Label label3;
        private Button button1;
        private ListBox Carrinho;
        private Label Total;
        private ListBox listBox1_Sucesso;
        private ComboBox comboBox1;
        private Button Btn_Voltar;
        private Button Btn_Comprar;
        private Button Btn_Remover;
        private Button button6;
    }
}