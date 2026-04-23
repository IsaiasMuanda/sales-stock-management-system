using MySql.Data.MySqlClient;
using Projecto_YII.Projecto.YII.Conexão;
using Projecto_YII.Projecto.YII.Model;
using Projecto_YII.Projecto.YII.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.DAO
{
    public class UsuarioDAO
    {
        private MySqlConnection conexao;
        public UsuarioDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar User

        public void CadastrarUser(UsuarioModel usuarioModel)
        {
            try
            {
                string sql = @"insert into usuario (id_funcionarioFK, nome_usuario, palavra_passe, acesso)
			                values(@id_funcionario, @nome_usuario,@palavra_passe, @acesso)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id_funcionario", usuarioModel.id_funcionario);
                cmd.Parameters.AddWithValue("@nome_usuario", usuarioModel.nome_usuario);
                cmd.Parameters.AddWithValue("@palavra_passe", usuarioModel.palavra_passe);
                cmd.Parameters.AddWithValue("@acesso", usuarioModel.acesso);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário Cadstrado Com Sucesso");
                conexao.Close();

            }
            catch (Exception ex )
            {
                MessageBox.Show("Erro " +ex);
            }
        }

        #endregion

        #region Listar

        public DataTable ListarUser()
        {
            try
            {
                DataTable dataTable_ = new DataTable();

                string sql = @"Select id_usuario as 'Código Da Conta',
                id_funcionarioFK as 'Código Do Funcionário',
                nome_usuario as 'Nome De Usuário',
                acesso as 'Tipo De Acesso' from usuario";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                mySqlDataAdapter.Fill(dataTable_);

                conexao.Close();
                return dataTable_;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                return null;
            }
        }

        #endregion

        #region Editar
        public void EditarUser(UsuarioModel usuarioModel_)
        {
            try
            {
                string comando_Sql = @"update usuario set nome_usuario = @nome,
                            acesso = @acesso
                            where id_usuario = @id";

                MySqlCommand cmd = new MySqlCommand(comando_Sql, conexao);
                cmd.Parameters.AddWithValue("@nome", usuarioModel_.nome_usuario);
                cmd.Parameters.AddWithValue("@acesso", usuarioModel_.acesso);
                cmd.Parameters.AddWithValue("@id", usuarioModel_.id_usuario);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados Com Sucesso!");
                conexao.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar Dados : " + ex);
                conexao.Close() ;
            }
        }
        #endregion

        #region Remover 
        public void ExcluirUser(UsuarioModel usuarioModel_)
        {
            try
            {
                string sql = "delete from usuario where id_usuario = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", usuarioModel_.id_usuario);

                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Excluído com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Login

        public bool Login(string nome_usuario, string palavra_passe)
        {
            string sql = "select * from usuario where nome_usuario = @username and palavra_passe = @password";
            MySqlCommand cmd = new MySqlCommand( sql, conexao );

            cmd.Parameters.AddWithValue("@username", nome_usuario);
            cmd.Parameters.AddWithValue("@password", palavra_passe);

            conexao.Open();

            MySqlDataReader dataReader_ = cmd.ExecuteReader();
            if ( dataReader_.Read())
            {
                string acesso = dataReader_.GetString("acesso");
                FormTelaInicial formTelaInicial_ = new FormTelaInicial();
                formTelaInicial_.labelLateralUser.Text = nome_usuario;
                formTelaInicial_.labelLateralAcesso.Text = acesso;
                if ( acesso.Equals("Administrador") )
                {
                    formTelaInicial_.Show();
                }
                else if(acesso.Equals("Usuário"))
                {
                    formTelaInicial_.Show();
                    formTelaInicial_.buttonSistema.Enabled = false;
                    formTelaInicial_.buttonFuncionarios.Enabled = false;
                }
                return true;
           
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos");
                return false;
            }
        }
        #endregion

        #region Logout

        public void Logout()
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form is FormTelaInicial)
                {
                    form.Close();
                    break;
                }
            }

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        #endregion
    }
}
