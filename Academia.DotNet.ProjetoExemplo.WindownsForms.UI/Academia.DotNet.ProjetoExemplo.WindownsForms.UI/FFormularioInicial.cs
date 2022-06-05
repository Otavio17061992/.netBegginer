using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.DotNet.ProjetoExemplo.WindownsForms.UI
{
    public partial class FFormularioInicial : Form
    {
        public FFormularioInicial()
        {
            InitializeComponent();
        }

        private void FFormularioInicial_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();


            var Fornecedor = new Fornecedor();

            

           


            // Criar uma lista e inclui Objeto na lista

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));



            dgvFornecedores.DataSource = listaFornecedores;

        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {
            if (txtNomeFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do fornecedor");
                
            };

            if (textEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = textEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Endereço");
                
            };

            if (NomeDoContato.Text != string.Empty)
            {
                fornecedor.NomeDoContato = textEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Nome do contato");
                

            };


            if (Telefone.Text != string.Empty)
            {
                fornecedor.Telefone = Telefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Numero de Telefone");
                
            };

            return fornecedor;
        }
    }
}
