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
    public partial class frmLogin : Form
    {
        public static string nivelAcesso;
        public static string usuarioConectado;

        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataReader SQLDr;

        string SQLString;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtLogin.Text.Equals(string.Empty) && !txtSenha.Text.Equals(string.Empty))
                {
                    string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                    SQLConexao = new MySqlConnection(stringConexao);

                    SQLString = "select * from usuarios where login = @login and senha = @senha";

                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@login", txtLogin.Text);
                    SQLComando.Parameters.AddWithValue("@senha", txtSenha.Text);

                    SQLConexao.Open();

                    SQLDr = SQLComando.ExecuteReader();

                    if (SQLDr.Read())
                    {
                        usuarioConectado = Convert.ToString(SQLDr["login"]);
                        nivelAcesso = Convert.ToString(SQLDr["nivelacesso"]);

                        frmTelaPrincipal p = new frmTelaPrincipal();
                        // esconde o form login
                        this.Hide();

                        // mostra o form tela principal
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos!", "Aviso de segurança!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso de segurança!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
