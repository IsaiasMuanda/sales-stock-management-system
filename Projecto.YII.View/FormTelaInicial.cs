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
    public partial class FormTelaInicial : Form
    {
        #region Comandos
        /*Comandos para mover e arrastar o programa PanelTop
         *Adicionar o evento MouseDown
         */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int lParam);

        //Configurações do Timer
        private System.Windows.Forms.Timer timer;
        #endregion

        public FormTelaInicial()
        {
            InitializeComponent();

            //Definir a visibilidade inicial do ícone minimizar como "false"
            pictureBoxMinimizar.Visible = false;
        }
        #region Métodos Gerais
        //Método para abrir/carregar formulários no PanelConteudo
        /*
            1. Verificação do Controle Existente:
               - Primeiro, o método verifica se o `panelPrincipal` (provavelmente um painel em seu formulário) já contém algum controle.
                Isso é feito com a condição `if (this.panelPrincipal.Controls.Count > 0).

            2. Remoção do Controle Existente (se houver):
               - Se o `panelPrincipal` já contiver algum controle, ele é removido. Isso é feito com a linha
                `this.panelPrincipal.Controls.RemoveAt(0);`.
               - Essa linha de código garante que apenas um controle (geralmente um formulário) seja exibido por vez no `panelPrincipal`. 
                Se já houver um controle exibido, ele é removido para dar lugar ao novo.

            3. Conversão para Formulário:
               - O parâmetro `formularios_obj` é convertido em um objeto do tipo `Form` usando a instrução `Form form1 = formularios_obj as Form;

            4. Configuração do Formulário:
               - O formulário (`form1`) é configurado para não ser exibido como um formulário de nível superior (`form1.TopLevel = false;`).
                Isso significa que ele será incorporado dentro do `panelPrincipal` e não aparecerá como uma janela separada.

               - O formulário é configurado para preencher todo o espaço disponível no `panelPrincipal` (`form1.Dock = DockStyle.Fill;`).
                Isso faz com que o formulário se ajuste ao tamanho do `panelPrincipal`.

            5. Adição do Formulário ao Painel:
               - O formulário é adicionado como um controle ao `panelPrincipal` usando a linha `this.panelPrincipal.Controls.Add(form1);`.

            6. Configuração do Tag do Painel:
               - O `panelPrincipal` também recebe uma tag que aponta para o formulário atual. Isso pode ser útil para acessar o formulário
                posteriormente.

            7. Exibição do Formulário:
               - Por fim, o formulário é exibido usando `form1.Show();`.

            Em resumo, esse método permite que você abra formulários dentro de um painel (`panelPrincipal`) em seu formulário principal.
            Ele garante que apenas um formulário seja exibido por vez no painel e configura o formulário para ocupar todo o espaço disponível.
            Isso é útil para criar uma interface de várias páginas em um único formulário.
         */
        public void AbrirForms(object formularios_obj)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form f = formularios_obj as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(f);
            this.panelPrincipal.Tag = f;
            f.Show();
        }

        //Método Geral para abrir formulários extras
        public void AbrirFormulárioExtra(Form form_obj1, string nome)
        {
            Form form_obj2 = (Form)Application.OpenForms[nome];
            if (form_obj2 == null)
            {
                form_obj2 = new Form();
                form_obj2.Name = nome;
                form_obj1.Show();
            }
            else
            {
                MessageBox.Show("Formulário ja se encontra aberto!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Método para diminuir tamanho de controles
        public void TamanhoDeControles(Control control_, int s1, int s2)
        {
            control_.Size = new Size(s1, s2);
        }
        #endregion

        #region Eventos Do PanelTop

        /*Região de eventos do panelTop
         * 1 - Eventos Click
         */

        //Evento Click para deslizar o menu lateral
        private void pictureBoxDeslizar_Click(object sender, EventArgs e)
        {
            if (panelLateral.Width == 282)
            {
                panelLateral.Width = 61;
            }
            else
                panelLateral.Width = 282;
        }

        //Evento click para fechar 
        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento click para esconder
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Evento click para maximizar
        private void pictureBoxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMaximizar.Visible = false;
            pictureBoxMinimizar.Visible = true;

        }
        //Evento click para minimizar
        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMinimizar.Visible = false;
            pictureBoxMaximizar.Visible = true;
        }
        /*Eventos Do panelTop
        * MouseEnter
        * MouseLeave
        */
        private void pictureBoxFechar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(22, 22);
        }

        private void pictureBoxFechar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(25, 25);
        }

        private void pictureBoxMinimizar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMinimizar.Size = new Size(22, 22);
        }

        private void pictureBoxMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMinimizar.Size = new Size(25, 25);
        }

        private void pictureBoxEsconder_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxEsconder.Size = new Size(22, 22);
        }

        private void pictureBoxEsconder_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxEsconder.Size = new Size(25, 25);
        }
        private void pictureBoxMaximizar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMaximizar.Size = new Size(22, 22);
        }

        private void pictureBoxMaximizar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMaximizar.Size = new Size(25, 25);
        }
        private void pictureBoxDeslizar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxDeslizar.Size = new Size(42, 42);
        }

        private void pictureBoxDeslizar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDeslizar.Size = new Size(48, 48);
        }

        /*Evento do MouseDown do panelTop
         * Evento para arrastar o programa com o mouse
         */
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Eventos Do PanelLateral
        //Evento click do buttonPrincipal no panelLateral
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormPrincipal());
        }
        //Evento click do buttonProductos no panelLateral
        private void button1Productos_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormProductos());
        }
        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormFuncionarios());
        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormClientes());
        }
        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormFornecedores());
        }
        private void buttonVendas_Click(object sender, EventArgs e)
        {
            AbrirForms(new Formvendas());
        }
        private void buttonSistema_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormSistema());
        }
        private void labelSair_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO_ = new UsuarioDAO();

            if(MessageBox.Show("Tem a certeza que quer sair?","AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usuarioDAO_.Logout();
            }
            else
            {
                MessageBox.Show("OK");
            }
        }
        #endregion

        #region Eventos Do panelConteudo
        private void FormTelaInicial_Load(object sender, EventArgs e)
        {
            AbrirForms(new FormPrincipal());
        }
        #endregion


    }
}
