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

namespace Provaofc_2
{


    public partial class Form5 : Form
    {

        private Conexão connectionManager;
        public Form5()
        {
            InitializeComponent();

            String Path = "C:\\Users\\Loure\\source\\repos\\Provaofc_2\\Provaofc_2\\bin\\Lojinha.db";
            connectionManager = new Conexão(Path);

            Atualizar_Cadastros();


        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            dataGridView_Produtos.DataSource = dtProdutos;
        }






        private void BuscarProdutos(string nome = null, string codigoBarras = null, int qualQueryUtilizar = 0)
        {
            string selectQuery = "";

            switch (qualQueryUtilizar)
            {
                case 1:
                    selectQuery = $"SELECT * FROM Produto WHERE Nome LIKE '%{nome}%'";
                    break;

                case 2:
                    selectQuery = $"SELECT * FROM Produto WHERE Codigo_de_Barras LIKE '%{codigoBarras}%'";
                    break;

                case 3:
                    selectQuery = $"SELECT * FROM Produto WHERE Nome LIKE '%{nome}%' AND Codigo_de_Barras LIKE '%{codigoBarras}%'";
                    break;

                default:
                    break;
            }

            DataTable dtProdutos = new DataTable();

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dtProdutos.Load(reader);
                    }
                }

                connectionManager.CloseConnection(connection);
            }

            // Alteração aqui: Tratar "Preco" como decimal e verificar se é numérico
            foreach (DataRow row in dtProdutos.Rows)
            {
                string precoStr = row["Preco"].ToString();

                // Limpar o valor de "Preco" de caracteres não numéricos (exceto ponto ou vírgula)
                precoStr = precoStr.Replace(",", "."); // Substitui vírgula por ponto se necessário
                precoStr = new string(precoStr.Where(c => Char.IsDigit(c) || c == '.').ToArray()); // Remove caracteres não numéricos, exceto ponto

                decimal preco;

                // Verificar se o valor de "Preco" é um número válido
                if (decimal.TryParse(precoStr, out preco))
                {
                    // Se for um número válido, formate para 2 casas decimais
                    precoStr = preco.ToString("F2");
                }
                else
                {
                    // Se não for válido, atribui um valor padrão ou uma mensagem de erro
                    precoStr = "Valor inválido";
                }

                // Monta a string do produto com o preço formatado
                string produtoInfo = $"ID: {row["Id"]}, Nome: {row["Nome"]}, Preço: {precoStr}, Quantidade: {row["Quantidade_Estoque"]}, Código de Barras: {row["Codigo_de_Barras"]}";

                // Aqui você pode processar a informação (exibição na lista ou outro processamento)
            }

            // Exibir os dados no DataGridView
            dataGridView_Produtos.DataSource = dtProdutos;
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarQuantidade(int quantidade)
        {
            // Verifica se a quantidade é maior que zero
            if (quantidade <= 0)
            {
                MessageBox.Show("A quantidade não pode ser zero ou negativa.");
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

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string busca = "";
            string codigoBarras = "";

            // Obtendo os valores dos campos de busca
            busca = Nome_grid.Text.Trim();
            codigoBarras = CodigoBarras_grid.Text.Trim();

            // Se apenas o nome for informado
            if (!string.IsNullOrEmpty(busca) && string.IsNullOrEmpty(codigoBarras))
            {
                BuscarProdutos(busca, null, 1);
            }
            // Se apenas o código de barras for informado
            if (string.IsNullOrEmpty(busca) && !string.IsNullOrEmpty(codigoBarras))
            {
                BuscarProdutos(null, codigoBarras, 2);
            }
            // Se tanto o nome quanto o código de barras forem informados
            if (!string.IsNullOrEmpty(busca) && !string.IsNullOrEmpty(codigoBarras))
            {
                BuscarProdutos(busca, codigoBarras, 3);
            }
            // Caso nenhum parâmetro seja informado
            if (string.IsNullOrEmpty(busca) && string.IsNullOrEmpty(codigoBarras))
            {
                MessageBox.Show("Por favor, insira um nome ou um código de barras.");
            }

        }

        private void dataGridView_Produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView_Produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



    }
}
