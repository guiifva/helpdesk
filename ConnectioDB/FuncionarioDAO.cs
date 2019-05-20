using Helpdesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.ConnectioDB
{
    class FuncionarioDAO
    {
        public bool create(Funcionario funcionario)
        {
            try
            {
                AcessoDadosMySQL.LimparParametros();
                object objRetorno = null;
                if (funcionario != null)
                {

                    AcessoDadosMySQL.AdicionarParametros("@vchNome", funcionario.nome);
                    AcessoDadosMySQL.AdicionarParametros("@vchLogin", funcionario.login);
                    AcessoDadosMySQL.AdicionarParametros("@vchSenha", funcionario.senha);

                    string strSQL = "insert into funcionarios (nome, login, senha, funcionario) values (@vchNome, @vchLogin, @vchSenha, @bolfuncionario);SELECT LAST_INSERT_ID();";
                    objRetorno = AcessoDadosMySQL.ExecutarManipulacao(CommandType.Text, strSQL);
                }
                int intResultado = 0;

                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                return false;
            }

        }

        public List<Funcionario> list()
        {
            List<Funcionario> lista = new List<Funcionario>();
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca 
                string strSQL = "select funcionarioId, nome from funcionarios";

                objDataTable = AcessoDadosMySQL.ExecutaConsultar(System.Data.CommandType.Text, strSQL);

                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Funcionario objNovoFuncionario = new Funcionario();
                    objNovoFuncionario.funcionarioId = objLinha["funcionarioId"] != DBNull.Value ? Convert.ToInt32(objLinha["funcionarioId"]) : 0;
                    objNovoFuncionario.nome = objLinha["nome"] != DBNull.Value ? Convert.ToString(objLinha["nome"]) : "";
                    objNovoFuncionario.login = objLinha["login"] != DBNull.Value ? Convert.ToString(objLinha["login"]) : "";

                    lista.Add(objNovoFuncionario);
                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public bool edit(Funcionario funcionario)
        {
            try
            {
                AcessoDadosMySQL.LimparParametros();
                object objRetorno = null;
                if (funcionario != null)
                {
                    AcessoDadosMySQL.AdicionarParametros("@intFuncionarioId", funcionario.funcionarioId);
                    AcessoDadosMySQL.AdicionarParametros("@vchNome", funcionario.nome);
                    AcessoDadosMySQL.AdicionarParametros("@vchLogin", funcionario.login);
                    AcessoDadosMySQL.AdicionarParametros("@vchSenha", funcionario.senha);

                    string strSQL = "update funcionarios set nome = @vchNome, login = @vchLogin, senha = @vchSenha where Id = @intFuncionarioId;select @intFuncionarioId;";
                    objRetorno = AcessoDadosMySQL.ExecutarManipulacao(CommandType.Text, strSQL);
                }
                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool delete(Funcionario funcionario)
        {
            try
            {
                AcessoDadosMySQL.LimparParametros();
                object objRetorno = null; if (funcionario != null)
                {
                    AcessoDadosMySQL.AdicionarParametros("@intId", funcionario.funcionarioId);
                    string strSQL = "delete from funcionarios where id = @intId;select @intFuncionarioId;";
                    objRetorno = AcessoDadosMySQL.ExecutarManipulacao(CommandType.Text, strSQL);
                }
                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Funcionario> verificaLogin(Funcionario funcionario)
        {
            List<Funcionario> lista = new List<Funcionario>();
            try
            {
                AcessoDadosMySQL.LimparParametros();
                DataTable objDataTable = null;

                //Se quiser personalizar a busca 
                AcessoDadosMySQL.AdicionarParametros("@vchLogin", funcionario.login);
                AcessoDadosMySQL.AdicionarParametros("@vchSenha", funcionario.senha);

                string strSQL = "select funcionarioId, nome, login from funcionarios WHERE login = @vchLogin AND senha = @vchSenha";

                objDataTable = AcessoDadosMySQL.ExecutaConsultar(System.Data.CommandType.Text, strSQL);
                if (objDataTable.Rows.Count == 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Funcionario objNovoFuncionario = new Funcionario();
                    objNovoFuncionario.funcionarioId = objLinha["funcionarioId"] != DBNull.Value ? Convert.ToInt32(objLinha["funcionarioId"]) : 0;
                    objNovoFuncionario.nome = objLinha["nome"] != DBNull.Value ? Convert.ToString(objLinha["nome"]) : "";
                    objNovoFuncionario.login = objLinha["login"] != DBNull.Value ? Convert.ToString(objLinha["login"]) : "";
                    lista.Add(objNovoFuncionario);
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return lista;
            }
        }
    }
}
