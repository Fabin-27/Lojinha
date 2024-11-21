using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Provaofc_2
{
    public partial class Form1 : Form
    {
        private Conexão connectionManager;

        public Form1()
        {
            InitializeComponent();
            String Path = "C:\\Users\\Loure\\source\\repos\\Provaofc_2\\Provaofc_2\\bin\\Lojinha.db";
            connectionManager = new Conexão(Path);
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
                            string informacoesProduto = $"ID: {reader["Id"]}, Nome: {reader["Nome"]}, Preço: {reader["Preco"]}, Quantidade: {reader["Quantidade_Estoque"]}, Código de Barras: {reader["Codigo_de_Barras"]}";
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
                MessageBox.Show("O campo Nome não pode estar vazio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Codigo_barras.Text))
            {
                MessageBox.Show("O campo Código de Barras não pode estar vazio.");
                return false;
            }

            if (!Regex.IsMatch(Codigo_barras.Text, @"^\d+$"))
            {
                MessageBox.Show("O código de barras deve conter apenas números.");
                return false;
            }

            if (Codigo_barras.Text.Length != 13)
            {
                MessageBox.Show("O código de barras deve conter exatamente 13 dígitos.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Preço.Text))
            {
                MessageBox.Show("O campo Preço não pode estar vazio.");
                return false;
            }

            if (!decimal.TryParse(Preço.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("O preço deve ser um número válido, sem letras, e maior que zero.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Quantidade.Text))
            {
                MessageBox.Show("O campo Quantidade não pode estar vazio.");
                return false;
            }

            if (!int.TryParse(Quantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser um número inteiro válido, sem letras, e maior que zero.");
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
                            MessageBox.Show("Este Produto já está cadastrado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }

                String insertQuery = $"INSERT INTO Produto (Nome, Preco, Quantidade_Estoque, Codigo_de_Barras) VALUES  ('{Nome.Text}', '{Preço.Text}', '{Quantidade.Text}', '{Codigo_barras.Text}')";

                try
                {
                    connectionManager.ExecuteNonQuery(insertQuery);
                    Nome.Text = string.Empty;
                    Preço.Text = string.Empty;
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
