using Projecto_YII.Projecto.YII.DAO;
using Projecto_YII.Projecto.YII.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_YII.Projecto.YII.View
{
    public partial class FormClientes : Form
    {
        #region Comandos
        FormTelaInicial formTelaInicial_obj = new FormTelaInicial();
        Repositorio repositorio_obj = new Repositorio();
        #endregion
        public FormClientes()
        {
            InitializeComponent();
        }

        #region Métodos Gerais

        //Método para alterar os tamanhos das colunas do DataGridViewClientes
        public void TamanhoColunas(string n, int tamanho)
        {
            if (dataGridViewClientes.Columns.Contains(n))
            {
                dataGridViewClientes.Columns[n].Width = tamanho;
            }
        }

        #endregion

        #region Eventos Gerais 

        //Evento Click Do ButtonEditarCliente
        private void buttonEditarCliente_Click_1(object sender, EventArgs e)
        {
            FormEditarCliente formEditarCliente_ = new FormEditarCliente();
            formTelaInicial_obj.AbrirFormulárioExtra(formEditarCliente_, "formEditarCliente_");

            //Método para capturar dados do cliente selecionado no DataGridViewClientes
            repositorio_obj.Capturar(formEditarCliente_.textBoxID_EditarCl, dataGridViewClientes, 0);
            repositorio_obj.Capturar(formEditarCliente_.textBoxEditarNomeCliente, dataGridViewClientes, 1);
            repositorio_obj.Capturar(formEditarCliente_.maskedTextBoxEditarTelefoneCliente, dataGridViewClientes, 2);
            repositorio_obj.Capturar(formEditarCliente_.textBoxEditarEnderecoCliente, dataGridViewClientes, 3);
        }

        //Evento Click do botao remover clientes
        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            repositorio_obj.Capturar(textBoxID_Cliente, dataGridViewClientes, 0);

            ClienteModel clienteModel_ = new ClienteModel();

            clienteModel_.id_cliente = int.Parse(textBoxID_Cliente.Text);

            ClienteDAO clienteDAO_ = new ClienteDAO();
            if (MessageBox.Show("Excluir Cliente?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteDAO_.ExcluirCliente(clienteModel_);
                textBoxID_Cliente.Text = "";
                dataGridViewClientes.DataSource = clienteDAO_.ListarClientes();
            }
            else
            {
                MessageBox.Show("Operação Cancelada", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Implementação Método Cadastrar Cliente
        private void buttonGuardarCliente_Click_1(object sender, EventArgs e)
        {
            ClienteDAO ClienteDAO_ = new ClienteDAO();

            ClienteModel clienteModel_ = new ClienteModel(textBoxNomeCliente.Text, maskedTextBoxTelefoneCliente.Text, textBoxEnderecoCliente.Text);
            ClienteDAO_.CadastrarClientes(clienteModel_);

            dataGridViewClientes.DataSource = ClienteDAO_.ListarClientes();

        }
        //Método para carregar automaticamente os clientes no DataGridViewClientes
        private void FormClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO ClienteDAO_ = new ClienteDAO();

            dataGridViewClientes.DataSource = ClienteDAO_.ListarClientes();
        }
        /*Evento DataBindingComplete
        * Acionado quando dados são vinculados no dataGridView
        * Permitindo que acções são executadas após o preenchimento dos dados
        */
        private void dataGridViewClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridViewClientes.Columns.Contains("endereco"))
            {
                dataGridViewClientes.Columns["endereco"].Width = 398;
            }
            TamanhoColunas("nome_completo", 190);
            TamanhoColunas("telefone", 150);
        }

        private void pictureBoxPesquisarCliente_Click(object sender, EventArgs e)
        {
            string n = textBoxPesqClientes.Text;
            ClienteDAO clienteDAO_ = new ClienteDAO();
            dataGridViewClientes.DataSource = clienteDAO_.PesquisarPorNome(n);

            if (dataGridViewClientes.Rows.Count == 0)
            {
                MessageBox.Show("Não Encontrado");
                dataGridViewClientes.DataSource = clienteDAO_.ListarClientes();
            }
        }

        private void textBoxPesqClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "%" + textBoxPesqClientes.Text + "%";
            ClienteDAO clienteDAO_ = new ClienteDAO();
            dataGridViewClientes.DataSource = clienteDAO_.PesquisarPorNomeAprox(n);
        }

        private void pictureBoxActualizarDataGr_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = new ClienteDAO().ListarClientes();

            textBoxEnderecoCliente.Text = string.Empty;
            textBoxNomeCliente.Text = string.Empty;
            maskedTextBoxTelefoneCliente.Text = string.Empty;
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
