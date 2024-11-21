using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Provaofc_2
{
    public partial class Form1 : Form
    {
        private Conex�o connectionManager;

        public Form1()
        {
            InitializeComponent();
            String Path = "C:\\Users\\Loure\\source\\repos\\Provaofc_2\\Provaofc_2\\bin\\Lojinha.db";
            connectionManager = new Conex�o(Path);
            Atualizar_Cadastros();
        }

        public void Atualizar_Cadastros()
        {
            Lista_Cadastrados.Items.Clear();
            string selectQuery = "SELECT * FROM Produto";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string informacoesProduto = $"ID: {reader["Id"]}, Nome: {reader["Nome"]}, Pre�o: {reader["Preco"]}, Quantidade: {reader["Quantidade_Estoque"]}, C�digo de Barras: {reader["Codigo_de_Barras"]}";
                            Lista_Cadastrados.Items.Add(informacoesProduto);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(Nome.Text))
            {
                MessageBox.Show("O campo Nome n�o pode estar vazio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Codigo_barras.Text))
            {
                MessageBox.Show("O campo C�digo de Barras n�o pode estar vazio.");
                return false;
            }

            if (!Regex.IsMatch(Codigo_barras.Text, @"^\d+$"))
            {
                MessageBox.Show("O c�digo de barras deve conter apenas n�meros.");
                return false;
            }

            if (Codigo_barras.Text.Length != 13)
            {
                MessageBox.Show("O c�digo de barras deve conter exatamente 13 d�gitos.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Pre�o.Text))
            {
                MessageBox.Show("O campo Pre�o n�o pode estar vazio.");
                return false;
            }

            if (!decimal.TryParse(Pre�o.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("O pre�o deve ser um n�mero v�lido, sem letras, e maior que zero.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Quantidade.Text))
            {
                MessageBox.Show("O campo Quantidade n�o pode estar vazio.");
                return false;
            }

            if (!int.TryParse(Quantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser um n�mero inteiro v�lido, sem letras, e maior que zero.");
                return false;
            }

            return true;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Form4 Tela_Principal = new Form4();
            Tela_Principal.Show();
            this.Hide();
        }

        private void ExcluirProduto(int productId)
        {
            string deleteQuery = "DELETE FROM Produto WHERE Id = @Id";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", productId);
                    command.ExecuteNonQuery();
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            if (Lista_Cadastrados.SelectedItem != null)
            {
                string selectedItem = Lista_Cadastrados.SelectedItem.ToString();

                try
                {
                    string idStr = selectedItem.Split(',')[0].Split(':')[1].Trim();
                    int productId = int.Parse(idStr);
                    ExcluirProduto(productId);
                    Atualizar_Cadastros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar excluir o produto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.");
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string selectCpfQuery = $"SELECT COUNT(1) FROM Produto WHERE Codigo_de_Barras = '{Codigo_barras.Text}'";

                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);

                    using (var command = new SqliteCommand(selectCpfQuery, connection))
                    {
                        var Codigo_barras = (long)command.ExecuteScalar();

                        if (Codigo_barras > 0)
                        {
                            MessageBox.Show("Este Produto j� est� cadastrado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }

                String insertQuery = $"INSERT INTO Produto (Nome, Preco, Quantidade_Estoque, Codigo_de_Barras) VALUES  ('{Nome.Text}', '{Pre�o.Text}', '{Quantidade.Text}', '{Codigo_barras.Text}')";

                try
                {
                    connectionManager.ExecuteNonQuery(insertQuery);
                    Nome.Text = string.Empty;
                    Pre�o.Text = string.Empty;
                    Quantidade.Text = string.Empty;
                    Codigo_barras.Text = string.Empty;

                    Nome.Focus();
                    Atualizar_Cadastros();

                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show($"Erro ao cadastrar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
