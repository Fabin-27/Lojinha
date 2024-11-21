namespace Provaofc_2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button2 = new Button();
            label1 = new Label();
            button7 = new Button();
            button1 = new Button();
            button6 = new Button();
            button8 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(4, 12, 67);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(30, 305);
            button2.Name = "button2";
            button2.Size = new Size(304, 136);
            button2.TabIndex = 1;
            button2.Text = "Buscar Produto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            label1.Click += label1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(4, 12, 67);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(30, 103);
            button7.Name = "button7";
            button7.Size = new Size(304, 136);
            button7.TabIndex = 7;
            button7.Text = "Inserir Produto";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(4, 12, 67);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(30, 604);
            button1.Name = "button1";
            button1.Size = new Size(304, 124);
            button1.TabIndex = 8;
            button1.Text = "Estoque";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(4, 12, 67);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(1004, 305);
            button6.Name = "button6";
            button6.Size = new Size(319, 136);
            button6.TabIndex = 9;
            button6.Text = "Editar Funcionário";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(4, 12, 67);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleRight;
            button8.Location = new Point(1004, 103);
            button8.Name = "button8";
            button8.Size = new Size(319, 136);
            button8.TabIndex = 10;
            button8.Text = "Inserir Funcionário";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(4, 12, 67);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(1004, 598);
            button3.Name = "button3";
            button3.Size = new Size(319, 136);
            button3.TabIndex = 11;
            button3.Text = "Venda";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1324, 729);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form4";
            ShowIcon = false;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Button button7;
        private Button button1;
        private Button button6;
        private Button button8;
        private Button button3;
    }
}