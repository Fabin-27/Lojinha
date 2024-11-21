namespace Provaofc_2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            dataGridView_Produtos = new DataGridView();
            CodigoBarras_grid = new TextBox();
            Nome_grid = new TextBox();
            Btn_Voltar = new Button();
            Btn_Pesquisar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Location = new Point(375, 235);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.Size = new Size(635, 315);
            dataGridView_Produtos.TabIndex = 0;
            dataGridView_Produtos.CellContentClick += dataGridView_Produtos_CellContentClick;
            // 
            // CodigoBarras_grid
            // 
            CodigoBarras_grid.Font = new Font("Perpetua Titling MT", 9.75F);
            CodigoBarras_grid.ForeColor = Color.FromArgb(140, 91, 35);
            CodigoBarras_grid.Location = new Point(13, 654);
            CodigoBarras_grid.Name = "CodigoBarras_grid";
            CodigoBarras_grid.Size = new Size(141, 23);
            CodigoBarras_grid.TabIndex = 12;
            // 
            // Nome_grid
            // 
            Nome_grid.Font = new Font("Perpetua Titling MT", 9.75F);
            Nome_grid.ForeColor = Color.FromArgb(140, 91, 35);
            Nome_grid.Location = new Point(12, 83);
            Nome_grid.Name = "Nome_grid";
            Nome_grid.Size = new Size(141, 23);
            Nome_grid.TabIndex = 11;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Transparent;
            Btn_Voltar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Voltar.Image = (Image)resources.GetObject("Btn_Voltar.Image");
            Btn_Voltar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Voltar.Location = new Point(1037, 625);
            Btn_Voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(320, 102);
            Btn_Voltar.TabIndex = 45;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_Pesquisar
            // 
            Btn_Pesquisar.BackColor = Color.Transparent;
            Btn_Pesquisar.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Pesquisar.ForeColor = Color.FromArgb(4, 12, 67);
            Btn_Pesquisar.Image = (Image)resources.GetObject("Btn_Pesquisar.Image");
            Btn_Pesquisar.ImageAlign = ContentAlignment.MiddleRight;
            Btn_Pesquisar.Location = new Point(1053, 54);
            Btn_Pesquisar.Margin = new Padding(4, 3, 4, 3);
            Btn_Pesquisar.Name = "Btn_Pesquisar";
            Btn_Pesquisar.Size = new Size(304, 121);
            Btn_Pesquisar.TabIndex = 46;
            Btn_Pesquisar.Text = "Pesquisar";
            Btn_Pesquisar.UseVisualStyleBackColor = false;
            Btn_Pesquisar.Click += Btn_Pesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 12, 67);
            label1.Location = new Point(12, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 26);
            label1.TabIndex = 49;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(4, 12, 67);
            label2.Location = new Point(13, 625);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(242, 26);
            label2.TabIndex = 50;
            label2.Text = "Código de Barras";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Pesquisar);
            Controls.Add(Btn_Voltar);
            Controls.Add(CodigoBarras_grid);
            Controls.Add(Nome_grid);
            Controls.Add(dataGridView_Produtos);
            Name = "Form5";
            Text = "Buscar Produto";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Produtos;
        private TextBox CodigoBarras_grid;
        private TextBox Nome_grid;
        private Button Btn_Voltar;
        private Button Btn_Pesquisar;
        private Label label1;
        private Label label2;
    }
}