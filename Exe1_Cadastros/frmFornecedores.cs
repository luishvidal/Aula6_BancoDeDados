using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Exe1_Cadastros
{
    public partial class frmFornecedores : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;
        string SQLString;

        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void MostraFornecedores()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "select id, nome, cnpj from fornecedores order by id";

                SQLDa = new MySqlDataAdapter(SQLString, SQLConexao);

                DataTable dtFornecedores = new DataTable();

                SQLDa.Fill(dtFornecedores);

                dgvFornecedores.DataSource = dtFornecedores;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o Banco de Dados
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                // Comando SQL
                SQLString = "insert into fornecedores(nome, cnpj) values " + "(@nome, @cnpj)";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@nome", txtNome.Text);
                SQLComando.Parameters.AddWithValue("@cnpj", txtCnpj.Text);

                // Abrir conexão com o BD
                SQLConexao.Open();

                // Executar comando SQL
                SQLComando.ExecuteNonQuery();

                // Mostrar ID do registro inserido 
                if (SQLComando.LastInsertedId != 0)
                {
                    SQLComando.Parameters.Add(new MySqlParameter("ultimoId", SQLComando.LastInsertedId));
                    txtId.Text = Convert.ToString(SQLComando.Parameters["@ultimoId"].Value);
                }

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }

            MostraFornecedores();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdConsulta.Text.Equals(string.Empty))
            {
                MostraFornecedores();
            }
            else
            {
                try
                {
                    // Conexão com o Banco de Dados
                    string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                    SQLConexao = new MySqlConnection(stringConexao);

                    // Comando SQL
                    SQLString = "select id, nome, cnpj from fornecedores where id = @id";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtIdConsulta.Text);

                    // Abrir conexão com o BD
                    SQLConexao.Open();

                    // Executar comando SQL
                    SQLDr = SQLComando.ExecuteReader();

                    while (SQLDr.Read())
                    {
                        txtId.Text = Convert.ToString(SQLDr["id"]);
                        txtNome.Text = Convert.ToString(SQLDr["nome"]);
                        txtCnpj.Text = Convert.ToString(SQLDr["cnpj"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SQLConexao.Close();
                    SQLConexao = null;
                    SQLComando = null;
                }
            }
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            txtId.Text = Convert.ToString(dgvFornecedores[0, e.RowIndex].Value);
            txtNome.Text = Convert.ToString(dgvFornecedores[1, e.RowIndex].Value);
            txtCnpj.Text = Convert.ToString(dgvFornecedores[2, e.RowIndex].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o BD
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                // Comando SQL
                SQLString = "update fornecedores set nome = @nome, cnpj = @cnpj where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);
                SQLComando.Parameters.AddWithValue("@nome", txtNome.Text);
                SQLComando.Parameters.AddWithValue("@cnpj", txtCnpj.Text);

                // Abrir conexão com o BD
                SQLConexao.Open();

                // Executar comando SQL
                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Dados do fornecedor alterados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o BD
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                // Comando SQL
                SQLString = "delete from fornecedores where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);

                // Abrir conexão com o BD
                SQLConexao.Open();

                // Executar comando SQL
                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConexao.Close();
                SQLConexao = null;
                SQLComando = null;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            txtIdConsulta.Text = string.Empty;

            dgvFornecedores.ClearSelection();
            txtNome.Focus();

            MostraFornecedores();
        }
    }
}
