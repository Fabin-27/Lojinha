using Microsoft.Data.Sqlite;
using System;
using System.Collections;
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
    public partial class Form3 : Form
    {

        private Conexão connectionManager;

        public Form3()
        {
            InitializeComponent();

            String Path = "C:\\Users\\Loure\\source\\repos\\Provaofc_2\\Provaofc_2\\bin\\Lojinha.db";
            connectionManager = new Conexão(Path);

            Atualizar_Cadastros();
            Lista_Cadastrados.SelectedIndexChanged += Lista_Cadastrados_SelectedIndexChanged;
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private bool ValidarCampos()
        {
            // Verifica se o campo Nome está vazio
            if (string.IsNullOrWhiteSpace(textBox1.Text))
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

        private void Lista_Cadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se um item foi selecionado
            if (Lista_Cadastrados.SelectedIndex != -1)
            {
                try
                {
                    // Obtém a string selecionada
                    string selectedItem = Lista_Cadastrados.SelectedItem.ToString();

                    // Divide as partes da string para extrair as informações
                    string[] parts = selectedItem.Split(',');

                    string idString = string.Empty;
                    string nome = string.Empty;
                    string cargo = string.Empty;
                    string salario = string.Empty;

                    foreach (var part in parts)
                    {
                        if (part.Trim().StartsWith("Id:"))
                            idString = part.Split(':')[1].Trim();
                        else if (part.Trim().StartsWith("Nome:"))
                            nome = part.Split(':')[1].Trim();
                        else if (part.Trim().StartsWith("Cargo:"))
                            cargo = part.Split(':')[1].Trim();
                        else if (part.Trim().StartsWith("Salário:"))
                            salario = part.Split(':')[1].Trim();
                    }

                    // Preenche os TextBoxes com os dados extraídos
                    textBox1.Text = nome;
                    Cargo.Text = cargo;
                    Salario.Text = salario;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar as informações do funcionário: " + ex.Message);
                }
            }
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
                            string informacoesFuncionario = $"Id: {reader["Id"]}, Nome: {reader["Nome"]}, Cargo: {reader["Cargo"]}, " +
                            $"Salário: {reader["Salario"]}, CPF: {reader["Cpf"]}";


                            Lista_Cadastrados.Items.Add(informacoesFuncionario);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Form4 Tela_Principal = new Form4();
            Tela_Principal.Show();
            this.Hide();

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (Lista_Cadastrados.SelectedIndex != -1)
                {
                    string selectedItem = Lista_Cadastrados.SelectedItem.ToString();

                    MessageBox.Show(selectedItem);

                    string[] parts = selectedItem.Split(',');

                    string idString = string.Empty;

                    // Buscando a parte do ID
                    foreach (var part in parts)
                    {
                        if (part.Trim().StartsWith("Id:"))
                        {
                            idString = part.Split(':')[1].Trim();
                            break;
                        }
                    }

                    if (!string.IsNullOrEmpty(idString) && int.TryParse(idString, out int id))
                    {
                        string updateQuery = $"UPDATE Funcionario SET Nome = @Nome, Cargo = @Cargo, Salario = @Salario WHERE Id = @Id";

                        using (var connection = connectionManager.GetConnection())
                        {
                            connectionManager.OpenConnection(connection);

                            using (var command = new SqliteCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Nome", textBox1.Text.Trim());
                                command.Parameters.AddWithValue("@Cargo", Cargo.Text.Trim());
                                command.Parameters.AddWithValue("@Salario", Salario.Text.Trim());
                                command.Parameters.AddWithValue("@Id", id);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Funcionário atualizado com sucesso!");
                                    Atualizar_Cadastros();
                                    textBox1.Text = string.Empty;
                                    Cargo.Text = string.Empty;
                                    Salario.Text = string.Empty;
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao atualizar o funcionário.");
                                }
                            }

                            connectionManager.CloseConnection(connection);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao extrair o ID do funcionário.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para editar.");
                }
            }

        }
    }
}
