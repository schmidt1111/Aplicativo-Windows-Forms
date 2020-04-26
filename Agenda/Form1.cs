using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //criar variavel booleana para teste de existencia
        bool isInclusao = false;

        //criar variavel do tipo lista para ser uma lista de objetos
        List<Contato> Contatos = new List<Contato>();
        
        //metodo do botão Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            isInclusao = false;

            txtid.Text = dgvContatos.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgvContatos.CurrentRow.Cells[1].Value.ToString();
            txttelefone.Text = dgvContatos.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = dgvContatos.CurrentRow.Cells[3].Value.ToString();
            txtdtnasc.Text = dgvContatos.CurrentRow.Cells[4].Value.ToString();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(isInclusao)
            {
                //instanciou o objeto
                Contato c = new Contato();
                //populando o objeto
                c.id = Contatos.Count + 1;                               //int.Parse(txtid.Text); convertendo o string em int e colocando dentro dele
                c.nome = txtnome.Text;
                c.telefone = txttelefone.Text;
                c.email = txtemail.Text;
                c.dtnasc = txtdtnasc.Text;

                //pegando o objeto e adicionando ele numa lista
                Contatos.Add(c);
            }
                else
            {
                Contato c = Contatos.Find(r => r.id == int.Parse(txtid.Text));
                c.nome = txtnome.Text;
                c.telefone = txttelefone.Text;
                c.email = txtemail.Text;
                c.dtnasc = txtdtnasc.Text;
            }
           
            //adicionar dados no grid, vinculando a lista com o grid
            dgvContatos.DataSource = null;   // é para desligar o vinculo (não se conect com ninguem)
            dgvContatos.DataSource = Contatos;  //e depois liga de novo (conecta de novo)-  depois eu seto para contatos;

            MessageBox.Show("Contato incluído/alterado com sucesso!");

            label1.Text = "";
            txtnome.Clear();
            txttelefone.Clear();
            txtemail.Clear();
            txtdtnasc.Clear();
            txtnome.Focus();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            isInclusao = true;

            txtid.Text = (Contatos.Count + 1).ToString();
            txtnome.Clear();
            txttelefone.Clear();
            txtemail.Clear();
            txtdtnasc.Clear();
            txtnome.Focus();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Confirma a exclusão?",
                                                        "Confirmação",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Contatos.RemoveAt(dgvContatos.CurrentRow.Index);

                dgvContatos.DataSource = null;
                dgvContatos.DataSource = Contatos;

                MessageBox.Show("Contato excluído com sucesso!");
            }
        }

                
    }
}
