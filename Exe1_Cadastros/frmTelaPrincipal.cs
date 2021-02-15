using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1_Cadastros
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            if (frmLogin.nivelAcesso == "Operador")
            {
                usuáriosToolStripMenuItem.Visible = false;
            }

            tsslUsuario.Text = "Usuário: " + frmLogin.usuarioConectado + " | " + frmLogin.nivelAcesso;

            string mHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do host: " + mHost;

            System.Net.IPHostEntry mIps = System.Net.Dns.GetHostEntry(mHost);

            foreach (System.Net.IPAddress mIP in mIps.AddressList)
            {
                tsslIP.Text = "IP: " + mIP;
            }

            tsslData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFornecedores fornecedores = null;

                // faz uma varredura nos forms criados
                foreach (Form frm in this.MdiChildren)
                {
                    // verifica se tem o formulário na tela 
                    if (frm is frmFornecedores)
                    {
                        fornecedores = (frmFornecedores)frm;
                        break;
                    }
                }
                // se não está instanciado o formulário é instanciado agora 
                if (fornecedores == null)
                {
                    fornecedores = new frmFornecedores();
                    fornecedores.MdiParent = this;
                    fornecedores.Show();
                }

                fornecedores.Focus();

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProdutos produtos = null;

                // faz uma varredura nos forms criados
                foreach (Form frm in this.MdiChildren)
                {
                    // verifica se tem o formulário na tela 
                    if (frm is frmConsultaProdutos)
                    {
                        produtos = (frmConsultaProdutos)frm;
                        break;
                    }
                }
                // se não está instanciado o formulário é instanciado agora 
                if (produtos == null)
                {
                    produtos = new frmConsultaProdutos();
                    produtos.MdiParent = this;
                    produtos.Show();
                }

                produtos.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuarios usuarios = null;

                // faz uma varredura nos forms criados
                foreach (Form frm in this.MdiChildren)
                {
                    // verifica se tem o formulário na tela 
                    if (frm is frmUsuarios)
                    {
                        usuarios = (frmUsuarios)frm;
                        break;
                    }
                }
                // se não está instanciado o formulário é instanciado agora 
                if (usuarios == null)
                {
                    usuarios = new frmUsuarios();
                    usuarios.MdiParent = this;
                    usuarios.Show();
                }

                usuarios.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaFornecedores consultaForncedores = null;

                // faz uma varredura nos forms criados
                foreach (Form frm in this.MdiChildren)
                {
                    // verifica se tem o formulário na tela 
                    if (frm is frmConsultaFornecedores)
                    {
                        consultaForncedores = (frmConsultaFornecedores)frm;
                        break;
                    }
                }
                // se não está instanciado o formulário é instanciado agora 
                if (consultaForncedores == null)
                {
                    consultaForncedores = new frmConsultaFornecedores();
                    consultaForncedores.MdiParent = this;
                    consultaForncedores.Show();
                }

                consultaForncedores.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaProdutos consultaProdutos = null;

                // faz uma varredura nos forms criados
                foreach (Form frm in this.MdiChildren)
                {
                    // verifica se tem o formulário na tela 
                    if (frm is frmConsultaProdutos)
                    {
                        consultaProdutos = (frmConsultaProdutos)frm;
                        break;
                    }
                }
                // se não está instanciado o formulário é instanciado agora 
                if (consultaProdutos == null)
                {
                    consultaProdutos = new frmConsultaProdutos();
                    consultaProdutos.MdiParent = this;
                    consultaProdutos.Show();
                }

                consultaProdutos.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void notasEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotasEntrada notasEntrada = null;

                // faz uma varredura nos forms criados
                foreach (Form frm in this.MdiChildren)
                {
                    // verifica se tem o formulário na tela 
                    if (frm is frmConsultaProdutos)
                    {
                        notasEntrada = (frmNotasEntrada)frm;
                        break;
                    }
                }
                // se não está instanciado o formulário é instanciado agora 
                if (notasEntrada == null)
                {
                    notasEntrada = new frmNotasEntrada();
                    notasEntrada.MdiParent = this;
                    notasEntrada.Show();
                }

                notasEntrada.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
