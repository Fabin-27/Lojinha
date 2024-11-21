using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provaofc_2
{
    public partial class Form7 : Form
    {
        private Conexão connectionManager;
        public Form7()
        {
            InitializeComponent();

            String Path = "C:\\Users\\Loure\\source\\repos\\Provaofc_2\\Provaofc_2\\bin\\Lojinha.db";
            connectionManager = new Conexão(Path);

            Atualizar_Cadastros();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {

            // Verifica se o campo Preço está vazio
            if (string.IsNullOrWhiteSpace(Preço.Text))
            {
                MessageBox.Show("O campo Preço não pode estar vazio.");
                return false;
            }

            // Verifica se o preço é numérico, sem letras, e maior que zero
            if (!decimal.TryParse(Preço.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("O preço deve ser um número válido, sem letras, e maior que zero.");
                return false;
            }

            // Verifica se o campo Quantidade está vazio
            if (string.IsNullOrWhiteSpace(Quantidade.Text))
            {
                MessageBox.Show("O campo Quantidade não pode estar vazio.");
                return false;
            }

            // Verifica se a quantidade é numérica, sem letras, e maior que zero
            if (!int.TryParse(Quantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser um número inteiro válido, sem letras, e maior que zero.");
                return false;
            }

            return true;
        }

        public void Atualizar_Cadastros()
        {
            listBox1.Items.Clear();

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
                            // Adiciona o ID junto com as outras informações do produto
                            string informacoesProduto = $"ID: {reader["Id"]}, Nome: {reader["Nome"]}, Preço: {reader["Preco"]}, " +
                                                        $"Quantidade: {reader["Quantidade_Estoque"]}, Código de Barras: {reader["Codigo_de_Barras"]}";

                            // Adiciona as informações do produto na ListBox
                            listBox1.Items.Add(informacoesProduto);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Verifica se um item foi selecionado
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    // Obtém a string selecionada
                    string selectedItem = listBox1.SelectedItem.ToString();

                    // Divide as partes da string para extrair as informações
                    string[] parts = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);

                    string idString = string.Empty;
                    string preco = string.Empty;
                    string quantidade = string.Empty;

                    // Extrai o ID, Preço e Quantidade
                    foreach (var part in parts)
                    {
                        if (part.Trim().StartsWith("ID:"))
                            idString = part.Split(':')[1].Trim();
                        else if (part.Trim().StartsWith("Preço:"))
                            preco = part.Split(':')[1].Trim();
                        else if (part.Trim().StartsWith("Quantidade:"))
                            quantidade = part.Split(':')[1].Trim();
                    }

                    // Preenche os TextBoxes com as informações extraídas
                    Preço.Text = preco;
                    Quantidade.Text = quantidade;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar as informações do produto: " + ex.Message);
                }
            }
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) // Certifica-se de que os campos estão validados
            {
                if (listBox1.SelectedIndex != -1) // Verifica se algum item foi selecionado na ListBox
                {
                    string selectedItem = listBox1.SelectedItem.ToString();

                    MessageBox.Show(selectedItem); // Mostra a string selecionada para debugging

                    // Divide a string com base nas vírgulas, mas usa o delimitador de forma mais robusta
                    string[] parts = selectedItem.Split(new[] { ", " }, StringSplitOptions.None);

                    string idString = string.Empty;

                    // Buscando a parte do ID de forma mais segura
                    foreach (var part in parts)
                    {
                        if (part.Trim().StartsWith("ID:")) // Verifica se a parte começa com "ID:"
                        {
                            idString = part.Split(':')[1].Trim(); // Extrai o ID
                            break;
                        }
                    }

                    // Verifica se o ID foi extraído corretamente e é válido
                    if (!string.IsNullOrEmpty(idString) && int.TryParse(idString, out int id))
                    {
                        string updateQuery = $"UPDATE Produto SET Preco = @Preço, Quantidade_Estoque = @Quantidade WHERE Id = @Id";

                        using (var connection = connectionManager.GetConnection())
                        {
                            connectionManager.OpenConnection(connection);

                            using (var command = new SqliteCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Preço", Preço.Text.Trim()); // Adiciona o novo preço
                                command.Parameters.AddWithValue("@Quantidade", Quantidade.Text.Trim()); // Adiciona a nova quantidade
                                command.Parameters.AddWithValue("@Id", id); // Passa o ID do produto selecionado

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Produto atualizado com sucesso!");
                                    Atualizar_Cadastros(); // Atualiza os cadastros no sistema
                                    Preço.Text = string.Empty; // Limpa o campo de preço
                                    Quantidade.Text = string.Empty; // Limpa o campo de quantidade
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao atualizar o produto.");
                                }
                            }

                            connectionManager.CloseConnection(connection);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao extrair o ID do produto. Verifique o formato da string.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para editar.");
                }
            }

        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Form4 Tela_Principal = new Form4();
            Tela_Principal.Show();
            this.Hide();

        }
    }
}
