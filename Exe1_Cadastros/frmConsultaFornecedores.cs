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
    public partial class frmConsultaFornecedores : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        DataTable dtFornecedores;

        string SQLString;

        frmNotasEntrada notasEntrada;

        public frmConsultaFornecedores()
        {
            InitializeComponent();
        }

        public frmConsultaFornecedores(frmNotasEntrada ne)
        {
            InitializeComponent();

            notasEntrada = ne;

            btnSelecionar.Visible = true;
        }

        public void ConsultarFornecedores()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                if (rbID.Checked)
                {
                    SQLString = "select id, nome, cnpj from fornecedores where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtConsultar.Text);
                }

                if (rbNome.Checked)
                {
                    SQLString = "select id, nome, cnpj from fornecedores where nome like @nome";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@nome", txtConsultar.Text + "%");
                }

                if (rbCnpj.Checked)
                {
                    SQLString = "select id, nome, cnpj from fornecedores where cpnj like @cnpj";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("cnpj", txtConsultar.Text + "%");
                }

                if (rbTodos.Checked)
                {
                    SQLString = "select * from fornecedores order by nome";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }

                SQLConexao.Open();
                SQLDa = new MySqlDataAdapter(SQLComando);

                dtFornecedores = new DataTable();

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

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (!txtConsultar.Text.Equals(String.Empty))
            {
                ConsultarFornecedores();
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            ConsultarFornecedores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtFornecedores.Rows.Count > 0)
            {
                notasEntrada.txtIdFornecedor.Text = Convert.ToString(dgvFornecedores[0, dgvFornecedores.CurrentRow.Index].Value);
                notasEntrada.txtNomeFornecedor.Text = Convert.ToString(dgvFornecedores[1, dgvFornecedores.CurrentRow.Index].Value);
                Close();
            } 
            else
            {
                MessageBox.Show("Selecione um registro!");
            }
        }
    }
}
