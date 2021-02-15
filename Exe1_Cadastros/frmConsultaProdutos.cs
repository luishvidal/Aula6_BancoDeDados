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
    public partial class frmConsultaProdutos : Form
    {
        MySqlConnection SQLConexao;
        MySqlCommand SQLComando;
        MySqlDataAdapter SQLDa;
        DataTable dtProdutos;

        string SQLString;

        frmNotasEntrada notasEntrada;

        public frmConsultaProdutos()
        {
            InitializeComponent();
        }

        public frmConsultaProdutos(frmNotasEntrada ne)
        {
            InitializeComponent();

            notasEntrada = ne;

            btnSelecionar.Visible = true;
        }

        public void ConsultarProdutos()
        {
            try
            {
                string stringConexao = ConfigurationManager.ConnectionStrings["CS_MYSQL"].ConnectionString;
                SQLConexao = new MySqlConnection(stringConexao);

                if (rbID.Checked)
                {
                    SQLString = "select id, descricao from produtos where id = @id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@id", txtConsultar.Text);
                }

                if (rbDescricao.Checked)
                {
                    SQLString = "select id, descricao from produtos where descricao like @descricao";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                    SQLComando.Parameters.AddWithValue("@descricao", txtConsultar.Text + "%");
                }

                if (rbTodos.Checked)
                {
                    SQLString = "select * from produtos order by id";
                    SQLComando = new MySqlCommand(SQLString, SQLConexao);
                }

                SQLConexao.Open();
                SQLDa = new MySqlDataAdapter(SQLComando);

                dtProdutos = new DataTable();

                SQLDa.Fill(dtProdutos);
                dgvProdutos.DataSource = dtProdutos;
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

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (!txtConsultar.Text.Equals(String.Empty))
            {
                ConsultarProdutos();
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            ConsultarProdutos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtProdutos.Rows.Count > 0)
            {
                notasEntrada.txtIdProduto.Text = Convert.ToString(dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value);
                notasEntrada.txtDescricaoProduto.Text = Convert.ToString(dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value);
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um registro!");
            }
        }
    }
}
