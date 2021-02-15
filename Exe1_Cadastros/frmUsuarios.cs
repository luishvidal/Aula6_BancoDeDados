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
    public partial class frmUsuarios : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        MySqlDataReader SQLDr;
        string SQLString;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void MostraUsuarios()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                SQLString = "select id, login, nivelacesso from usuarios order by id";

                SQLDa = new MySqlDataAdapter(SQLString, SQLConexao);

                DataTable dtUsuarios = new DataTable();

                SQLDa.Fill(dtUsuarios);

                dgvUsuarios.DataSource = dtUsuarios;
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o Banco de Dados
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                // Comando SQL
                SQLString = "insert into usuarios(login, senha, nivelacesso) values " + "(@login, @senha, @nivelacesso)";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@login", txtLogin.Text);
                SQLComando.Parameters.AddWithValue("@senha", txtSenha.Text);
                SQLComando.Parameters.AddWithValue("@nivelacesso", cbxNivelAcesso.Text);

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

                MessageBox.Show("Usuário cadastrado com sucesso!");
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

            MostraUsuarios();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdConsulta.Text.Equals(string.Empty))
            {
                MostraUsuarios();
            }
            else
            {
                try
                {
                    // Conexão com o Banco de Dados
                    string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                    SQLConexao = new MySqlConnection(stringConexao);

                    // Comando SQL
                    SQLString = "select id, login, nivelacesso from usuarios where id = @id";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtIdConsulta.Text);

                    // Abrir conexão com o BD
                    SQLConexao.Open();

                    // Executar comando SQL
                    SQLDr = SQLComando.ExecuteReader();

                    while (SQLDr.Read())
                    {
                        txtId.Text = Convert.ToString(SQLDr["id"]);
                        txtLogin.Text = Convert.ToString(SQLDr["login"]);
                        cbxNivelAcesso.Text = Convert.ToString(SQLDr["nivelacesso"]);
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            txtId.Text = Convert.ToString(dgvUsuarios[0, e.RowIndex].Value);
            txtLogin.Text = Convert.ToString(dgvUsuarios[1, e.RowIndex].Value);
            cbxNivelAcesso.Text = Convert.ToString(dgvUsuarios[2, e.RowIndex].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o BD
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                // Comando SQL
                SQLString = "update usuarios set login = @login, senha = @senha, nivelacesso = @nivelacesso where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);
                SQLComando.Parameters.AddWithValue("@login", txtLogin.Text);
                SQLComando.Parameters.AddWithValue("@senha", txtSenha.Text);
                SQLComando.Parameters.AddWithValue("@nivelacesso", cbxNivelAcesso.Text);

                // Abrir conexão com o BD
                SQLConexao.Open();

                // Executar comando SQL
                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Dados do usuário alterados com sucesso!");
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
                SQLString = "delete from usuarios where id = @id";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@id", txtId.Text);

                // Abrir conexão com o BD
                SQLConexao.Open();

                // Executar comando SQL
                SQLComando.ExecuteNonQuery();

                MessageBox.Show("Usuário excluído com sucesso!");
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
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmarSenha.Text = string.Empty;
            cbxNivelAcesso.Text = string.Empty;
            txtIdConsulta.Text = string.Empty;

            dgvUsuarios.ClearSelection();
            txtLogin.Focus();

            MostraUsuarios();
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Senha e Confirmar Senha não conferem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtSenha.Focus();
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o Banco de Dados
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                // Comando SQL
                SQLString = "select login from usuarios where login = @login";

                SQLComando = new MySqlCommand(SQLString, SQLConexao);
                SQLComando.Parameters.AddWithValue("@login", txtLogin.Text);

                // Abrir conexão com o BD
                SQLConexao.Open();

                // Executar comando SQL
                SQLDr = SQLComando.ExecuteReader();

                if (SQLDr.Read())
                {
                    MessageBox.Show("Login já cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtLogin.Focus();
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
}
