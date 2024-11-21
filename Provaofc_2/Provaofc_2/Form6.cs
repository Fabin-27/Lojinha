using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Provaofc_2
{
    public partial class Form6 : Form
    {

        private decimal total = 0;
        private Conexão connectionManager;

        public Form6()
        {
            InitializeComponent();

            String Path = "C:\\Users\\Loure\\source\\repos\\Provaofc_2\\Provaofc_2\\bin\\Lojinha.db";
            connectionManager = new Conexão(Path);

            Atualizar_Vendas();
            Atualizar_Cadastros();
        }

        public void Atualizar_Cadastros()
        {
            // Cria um DataTable para armazenar os dados dos produtos
            DataTable dtProdutos = new DataTable();

            // Define as colunas do DataTable
            dtProdutos.Columns.Add("Nome");
            dtProdutos.Columns.Add("Preço");
            dtProdutos.Columns.Add("Quantidade em Estoque");
            dtProdutos.Columns.Add("Código de Barras");

            // A consulta agora inclui a ordenação alfabética pelo campo Nome
            string selectQuery = "SELECT * FROM Produto ORDER BY Nome";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adiciona os dados de cada produto ao DataTable
                            dtProdutos.Rows.Add(
                                reader["Nome"].ToString(),
                                Convert.ToDecimal(reader["Preco"]),
                                Convert.ToInt32(reader["Quantidade_Estoque"]),
                                reader["Codigo_de_Barras"].ToString()
                            );
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }

            // Define o DataSource do DataGridView para o DataTable criado
            dataGridView.DataSource = dtProdutos;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }





        private void button2_Click(object sender, EventArgs e)
        {

        }


        private bool ValidarEstoqueCarrinho()
        {
            // Dicionário para armazenar a quantidade total de cada produto no carrinho
            var quantidadesNoCarrinho = new Dictionary<string, int>();

            // Percorre os itens no carrinho
            foreach (var item in Carrinho.Items)
            {
                string[] partes = item.ToString().Split(new string[] { " - R$ " }, StringSplitOptions.None);

                if (partes.Length > 1 && decimal.TryParse(partes[1], out decimal preco))
                {
                    string nomeProduto = partes[0]; // Nome do produto
                    int quantidadeComprada = 1; // Quantidade padrão 1

                    // Extrai a quantidade do item no carrinho
                    string[] partesDetalhes = item.ToString().Split(new string[] { " - Quantidade: " }, StringSplitOptions.None);
                    if (partesDetalhes.Length > 1 && int.TryParse(partesDetalhes[1], out int quantidadeCarrinho))
                    {
                        quantidadeComprada = quantidadeCarrinho; // Atualiza com a quantidade real do carrinho
                    }

                    // Verifica se o produto já está no dicionário e soma a quantidade
                    if (quantidadesNoCarrinho.ContainsKey(nomeProduto))
                    {
                        quantidadesNoCarrinho[nomeProduto] += quantidadeComprada;
                    }
                    else
                    {
                        quantidadesNoCarrinho[nomeProduto] = quantidadeComprada;
                    }
                }
            }

            // Agora, verificamos o estoque para cada produto no dicionário
            foreach (var produto in quantidadesNoCarrinho)
            {
                string nomeProduto = produto.Key; // Nome do produto
                int quantidadeTotalCarrinho = produto.Value; // Quantidade total no carrinho

                // Cria a consulta SQL para verificar o estoque do produto
                string selectQuery = "SELECT Quantidade_Estoque FROM Produto WHERE Nome = @NomeProduto;";

                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);

                    using (var command = new SqliteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                        var resultado = command.ExecuteScalar();

                        if (resultado != null && int.TryParse(resultado.ToString(), out int estoqueAtual))
                        {
                            // Exibe o estoque para depuração
                            MessageBox.Show($"Produto: {nomeProduto}, Estoque disponível: {estoqueAtual}, Quantidade no carrinho: {quantidadeTotalCarrinho}");

                            // Verifica se o estoque é suficiente para a quantidade total
                            if (estoqueAtual < quantidadeTotalCarrinho)
                            {
                                MessageBox.Show($"Estoque insuficiente para o produto: {nomeProduto}. Estoque disponível: {estoqueAtual}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false; // Retorna false se o estoque for insuficiente
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Erro ao verificar estoque para o produto: {nomeProduto}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; // Retorna false se ocorrer erro na consulta
                        }
                    }

                    connectionManager.CloseConnection(connection);
                }
            }

            return true; // Se o estoque for suficiente para todos os itens no carrinho
        }



















        public void Atualizar_Vendas()
        {

            // Limpa o ListBox para garantir que não haverá dados duplicados
            listBox1_Sucesso.Items.Clear();

            // Cria uma consulta SQL para recuperar todas as vendas
            string selectQuery = "SELECT * FROM Venda ORDER BY DataVenda DESC"; // Ordena por data da venda (opcional)

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Itera sobre os resultados e adiciona as informações no ListBox
                        while (reader.Read())
                        {
                            // Formata os dados de cada venda
                            string vendaInfo = $"Data: {Convert.ToDateTime(reader["DataVenda"]):dd/MM/yyyy}, " +
                                               $"Forma de Pagamento: {reader["FormaPagamento"]}, " +
                                               $"Total: R$ {reader["ValorDaVenda"]}";

                            // Adiciona a informação da venda no ListBox
                            listBox1_Sucesso.Items.Add(vendaInfo);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vendabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Form4 Tela_Principal = new Form4();
            Tela_Principal.Show();
            this.Hide();

        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
            // Verifica se o carrinho contém itens
            if (Carrinho.Items.Count > 0)
            {
                // Chama o método para validar se o estoque é suficiente
                if (ValidarEstoqueCarrinho())
                {
                    try
                    {
                        // Inicia uma transação
                        using (var connection = connectionManager.GetConnection())
                        {
                            connectionManager.OpenConnection(connection);
                            using (var transaction = connection.BeginTransaction())
                            {
                                // Captura a forma de pagamento selecionada
                                string formaPagamento = comboBox1.SelectedItem?.ToString() ?? "Não especificado";

                                // Criação da consulta SQL para inserir os dados na tabela Venda
                                string insertQuery = @"
INSERT INTO Venda (DataVenda, FormaPagamento, ValorDaVenda)
VALUES (@DataVenda, @FormaPagamento, @ValorDaVenda);";

                                using (var command = new SqliteCommand(insertQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@DataVenda", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                    command.Parameters.AddWithValue("@FormaPagamento", formaPagamento);
                                    command.Parameters.AddWithValue("@ValorDaVenda", total);

                                    command.ExecuteNonQuery();
                                }

                                // Agora, atualiza o estoque e verifica produtos que chegam a 0
                                List<string> produtosEmFalta = new List<string>();

                                foreach (var item in Carrinho.Items)
                                {
                                    string[] partes = item.ToString().Split(new string[] { " - R$ " }, StringSplitOptions.None);
                                    if (partes.Length > 1 && decimal.TryParse(partes[1], out decimal preco))
                                    {
                                        string nomeProduto = partes[0];
                                        int quantidadeComprada = 1;

                                        string[] partesDetalhes = item.ToString().Split(new string[] { " - Quantidade: " }, StringSplitOptions.None);
                                        if (partesDetalhes.Length > 1 && int.TryParse(partesDetalhes[1], out int quantidadeCarrinho))
                                        {
                                            quantidadeComprada = quantidadeCarrinho;
                                        }

                                        string updateQuery = @"
UPDATE Produto
SET Quantidade_Estoque = Quantidade_Estoque - @Quantidade
WHERE Nome = @NomeProduto;";

                                        using (var updateCommand = new SqliteCommand(updateQuery, connection, transaction))
                                        {
                                            updateCommand.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                                            updateCommand.Parameters.AddWithValue("@Quantidade", quantidadeComprada);

                                            updateCommand.ExecuteNonQuery();
                                        }

                                        // Verifica se o estoque chegou a 0
                                        string selectQuery = @"
SELECT Quantidade_Estoque 
FROM Produto 
WHERE Nome = @NomeProduto;";

                                        using (var selectCommand = new SqliteCommand(selectQuery, connection, transaction))
                                        {
                                            selectCommand.Parameters.AddWithValue("@NomeProduto", nomeProduto);

                                            using (var reader = selectCommand.ExecuteReader())
                                            {
                                                if (reader.Read())
                                                {
                                                    int estoqueAtual = Convert.ToInt32(reader["Quantidade_Estoque"]);
                                                    if (estoqueAtual == 0)
                                                    {
                                                        produtosEmFalta.Add(nomeProduto);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                // Confirma a transação
                                transaction.Commit();

                                // Exibe uma mensagem se houver produtos em falta
                                if (produtosEmFalta.Count > 0)
                                {
                                    MessageBox.Show(
                                        $"Os seguintes produtos estão em falta no estoque:\n{string.Join("\n", produtosEmFalta)}",
                                        "Atenção",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                            }

                            connectionManager.CloseConnection(connection);
                        }

                        // Limpa os ListBoxes
                        listBox1_Sucesso.Items.Clear();
                        Carrinho.Items.Clear();

                        // Atualiza as listas
                        Atualizar_Vendas();
                        Atualizar_Cadastros();

                        total = 0;
                        Total.Text = $"Total: R$ {total:F2}";

                        // Exibe uma mensagem de sucesso
                        MessageBox.Show("Venda registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro na transação: {ex.Message}");
                        MessageBox.Show($"Erro ao processar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Carrinho vazio. Adicione produtos antes de concluir a compra.");
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string produto = dataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (decimal.TryParse(dataGridView.SelectedRows[0].Cells[1].Value.ToString(), out decimal preco))
                {
                    string itemCarrinho = $"{produto} - R$ {preco:F2}";

                    Carrinho.Items.Add(itemCarrinho);

                    total += preco;

                    Total.Text = $"Total: R$ {total:F2}";
                }


                else
                {
                    MessageBox.Show("O preço do produto não é válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item no DataGridView.");
            }

        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            // Verifica se algum item foi selecionado no ListBox do carrinho
            if (Carrinho.SelectedIndex != -1)
            {
                // Remove o item selecionado do ListBox
                Carrinho.Items.RemoveAt(Carrinho.SelectedIndex);

                // Opcional: Mensagem de confirmação
                MessageBox.Show("Item removido do carrinho com sucesso!");
            }
            else
            {
                // Exibe mensagem de erro se nenhum item foi selecionado
                MessageBox.Show("Por favor, selecione um item no carrinho para removê-lo.");
            }

        }
    }
}
