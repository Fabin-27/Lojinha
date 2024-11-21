using Microsoft.Data.Sqlite;
using System.Text.RegularExpressions;

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Provaofc_2
{
    public partial class Form2 : Form
    {

        private Conexão connectionManager;
        public Form2()
        {
            InitializeComponent();

            String Path = "C:\\Users\\Loure\\source\\repos\\Provaofc_2\\Provaofc_2\\bin\\Lojinha.db";
            connectionManager = new Conexão(Path);

            Atualizar_Cadastros();
        }

        public void Atualizar_Cadastros()
        {
            Lista_Cadastrados.Items.Clear();
            string selectQuery = "SELECT * FROM Funcionario";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adiciona o ID junto com as outras informações do funcionário
                            string informacoesFuncionario = $"ID: {reader["Id"]}, Nome: {reader["Nome"]}, Cargo: {reader["Cargo"]}, " +
                                $"Salário: {reader["Salario"]}, CPF: {reader["Cpf"]}";

                            // Adiciona as informações do funcionário na ListBox
                            Lista_Cadastrados.Items.Add(informacoesFuncionario);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }


        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
        }

        private bool ValidarCampos()
        {
            // Verifica se o campo Nome está vazio
            if (string.IsNullOrWhiteSpace(Nome.Text))
            {
                MessageBox.Show("O campo Nome não pode estar vazio.");
                return false;
            }

            // Verifica se o campo Cargo está vazio
            if (string.IsNullOrWhiteSpace(Cargo.Text))
            {
                MessageBox.Show("O campo Cargo não pode estar vazio.");
                return false;
            }

            // Verifica se o CPF está vazio
            if (string.IsNullOrWhiteSpace(Cpf.Text))
            {
                MessageBox.Show("O campo CPF não pode estar vazio.");
                return false;
            }

            // Verifica se o CPF contém apenas números e tem exatamente 11 dígitos
            if (!Regex.IsMatch(Cpf.Text, @"^\d{11}$"))
            {
                MessageBox.Show("O CPF deve conter exatamente 11 dígitos numéricos e não pode conter letras.");
                return false;
            }

            // Verifica se o campo Salário está vazio
            if (string.IsNullOrWhiteSpace(Salario.Text))
            {
                MessageBox.Show("O campo Salário não pode estar vazio.");
                return false;
            }

            // Verifica se o Salário é numérico e maior que zero
            if (!decimal.TryParse(Salario.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("O Salário deve ser um número válido, sem letras, e maior que zero.");
                return false;
            }

            return true;
        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Form4 Tela_Principal = new Form4();
            Tela_Principal.Show();
            this.Hide();

        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se algum item está selecionado na ListBox
                if (Lista_Cadastrados.SelectedItem != null)
                {
                    // Obtém as informações do funcionário selecionado
                    string funcionarioInfo = Lista_Cadastrados.SelectedItem.ToString();

                    // Extrai o ID do funcionário da string
                    int idFuncionario = Convert.ToInt32(funcionarioInfo.Split(',')[0].Split(':')[1].Trim());

                    // Cria a query de exclusão do funcionário pelo ID
                    string deleteQuery = "DELETE FROM Funcionario WHERE Id = @Id";

                    using (var connection = connectionManager.GetConnection())
                    {
                        connectionManager.OpenConnection(connection);

                        using (var command = new SqliteCommand(deleteQuery, connection))
                        {
                            // Adiciona o parâmetro para a query
                            command.Parameters.AddWithValue("@Id", idFuncionario);

                            // Executa a query de exclusão
                            int rowsAffected = command.ExecuteNonQuery();

                            // Verifica se o funcionário foi excluído
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Funcionário excluído com sucesso!");
                                Atualizar_Cadastros(); // Atualiza a lista de funcionários
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível excluir o funcionário.");
                            }
                        }

                        connectionManager.CloseConnection(connection);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para excluir.");
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro, exibe a mensagem de erro
                MessageBox.Show("Erro ao tentar excluir o funcionário: " + ex.Message);
            }

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string selectCpfQuery = $"SELECT COUNT(1) FROM Funcionario WHERE Cpf = '{Cpf.Text}'";

                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);

                    using (var command = new SqliteCommand(selectCpfQuery, connection))
                    {
                        var Cpf = (long)command.ExecuteScalar();

                        if (Cpf > 0)
                        {
                            MessageBox.Show("Este funcionário já está cadastrado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }

                string insertQuery = $"INSERT INTO Funcionario (Nome, Cargo, Salario, Cpf) " +
                                     $"VALUES ('{Nome.Text}', '{Cargo.Text}', '{Salario.Text}', '{Cpf.Text}')";

                try
                {
                    connectionManager.ExecuteNonQuery(insertQuery);

                    Nome.Text = string.Empty;
                    Cargo.Text = string.Empty;
                    Salario.Text = string.Empty;
                    Cpf.Text = string.Empty;

                    Nome.Focus();
                    Atualizar_Cadastros();

                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show($"Erro ao cadastrar o funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Lista_Cadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
