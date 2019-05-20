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
    class TicketDAO
    {
        public bool create(Ticket relatar)
        {
            try
            {
                AcessoDadosMySQL.LimparParametros();
                object objRetorno = null;
                if (relatar != null)
                {

                    AcessoDadosMySQL.AdicionarParametros("@vchUsuario", relatar.usuario);
                    AcessoDadosMySQL.AdicionarParametros("@dteData", relatar.data);
                    AcessoDadosMySQL.AdicionarParametros("@vchCategoria", relatar.categoria);
                    AcessoDadosMySQL.AdicionarParametros("@vchSoftware", relatar.software);
                    AcessoDadosMySQL.AdicionarParametros("@vchPrioridade", relatar.prioridade);
                    AcessoDadosMySQL.AdicionarParametros("@vchDescricao", relatar.descricao);
                    AcessoDadosMySQL.AdicionarParametros("@vchDepartamento", relatar.departamento);
                    AcessoDadosMySQL.AdicionarParametros("@vchMsgErro", relatar.msgErro);
                    AcessoDadosMySQL.AdicionarParametros("@vchStatus", relatar.status);

                    string strSQL = "INSERT INTO ticket(usuario, data, categoria, software, prioridade, descricao, departamento, msgErro, status) VALUES (@vchUsuario, @dteData, @vchCategoria, @vchSoftware, @vchPrioridade, @vchDescricao, @vchDepartamento, @vchMsgErro, @vchStatus); SELECT LAST_INSERT_ID();";
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

        public List<Ticket> list()
        {
            List<Ticket> lista = new List<Ticket>();
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca 
                string strSQL = "select * from ticket WHERE status != 'Concluido'"; ;

                objDataTable = AcessoDadosMySQL.ExecutaConsultar(System.Data.CommandType.Text, strSQL);

                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Ticket objNovoTicket = new Ticket();
                    objNovoTicket.ticketId = objLinha["ticketId"] != DBNull.Value ? Convert.ToInt32(objLinha["ticketId"]) : 0;
                    objNovoTicket.usuario = objLinha["usuario"] != DBNull.Value ? Convert.ToString(objLinha["usuario"]) : "";
                    objNovoTicket.data = objLinha["data"] != DBNull.Value ? Convert.ToDateTime(objLinha["data"]) : DateTime.Now;
                    objNovoTicket.categoria = objLinha["categoria"] != DBNull.Value ? Convert.ToString(objLinha["categoria"]) : "";
                    objNovoTicket.software = objLinha["software"] != DBNull.Value ? Convert.ToString(objLinha["software"]) : "";
                    objNovoTicket.prioridade = objLinha["prioridade"] != DBNull.Value ? Convert.ToString(objLinha["prioridade"]) : "";
                    objNovoTicket.descricao = objLinha["descricao"] != DBNull.Value ? Convert.ToString(objLinha["descricao"]) : "";
                    objNovoTicket.departamento = objLinha["departamento"] != DBNull.Value ? Convert.ToString(objLinha["departamento"]) : "";
                    objNovoTicket.msgErro = objLinha["msgErro"] != DBNull.Value ? Convert.ToString(objLinha["msgErro"]) : "";
                    objNovoTicket.status = objLinha["status"] != DBNull.Value ? Convert.ToString(objLinha["status"]) : "";


                    lista.Add(objNovoTicket);
                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public bool edit(Ticket relatar)
        {
            try
            {
                AcessoDadosMySQL.LimparParametros();
                object objRetorno = null;
                if (relatar != null)
                {

                    AcessoDadosMySQL.AdicionarParametros("@intTicketId", relatar.ticketId);
                    AcessoDadosMySQL.AdicionarParametros("@vchUsuario", relatar.usuario);
                    AcessoDadosMySQL.AdicionarParametros("@dteData", relatar.data);
                    AcessoDadosMySQL.AdicionarParametros("@vchCategoria", relatar.categoria);
                    AcessoDadosMySQL.AdicionarParametros("@vchSoftware", relatar.software);
                    AcessoDadosMySQL.AdicionarParametros("@vchPrioridade", relatar.prioridade);
                    AcessoDadosMySQL.AdicionarParametros("@vchDescricao", relatar.descricao);
                    AcessoDadosMySQL.AdicionarParametros("@vchDepartamento", relatar.departamento);
                    AcessoDadosMySQL.AdicionarParametros("@vchMsgErro", relatar.msgErro);
                    AcessoDadosMySQL.AdicionarParametros("@vchStatus", relatar.status);


                    string strSQL = "UPDATE ticket SET usuario = @vchUsuario, data = @dteData, categoria = @vchCategoria, software = @vchSoftware, prioridade = @vchPrioridade," +
                        " descricao = @vchDescricao, departamento = @vchDepartamento, msgErro = @vchMsgErro, status = @vchStatus WHERE ticketId = @intTicketId;";
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool delete(Ticket ticket)
        {
            try
            {
                AcessoDadosMySQL.LimparParametros();
                object objRetorno = null; if (ticket != null)
                {
                    AcessoDadosMySQL.AdicionarParametros("@vchTicketId", ticket.ticketId);
                    string strSQL = "DELETE FROM ticket WHERE ticketId = @vchTicketId; select @vchTicketId;";
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

        public bool createSolucaoTicket(Ticket ticket)
        {
            try
            {
                AcessoDadosMySQL.LimparParametros();
                object objRetorno = null;
                if (ticket != null)
                {

                    
                    AcessoDadosMySQL.AdicionarParametros("@vchTicketId", ticket.ticketId);
                    AcessoDadosMySQL.AdicionarParametros("@vchsolucao", ticket.solucao);

                    string strSQL = "INSERT INTO ticketsconcluidos(solucao, ticket_id) VALUES (@vchsolucao, @vchTicketId); SELECT LAST_INSERT_ID();";
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
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }

        }

        public List<Ticket> listTicketsConcluidos()
        {
            List<Ticket> lista = new List<Ticket>();
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca 
                string strSQL = "SELECT t.ticketId, t.usuario, t.data, t.categoria, t.software, t.prioridade, t.descricao, t.departamento, t.msgErro, t.status, c.solucao FROM helpdesk.ticket as t JOIN helpdesk.ticketsconcluidos as c WHERE t.ticketId = c.ticket_id;";

                objDataTable = AcessoDadosMySQL.ExecutaConsultar(System.Data.CommandType.Text, strSQL);

                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Ticket objNovoTicket = new Ticket();
                    objNovoTicket.ticketId = objLinha["ticketId"] != DBNull.Value ? Convert.ToInt32(objLinha["ticketId"]) : 0;
                    objNovoTicket.usuario = objLinha["usuario"] != DBNull.Value ? Convert.ToString(objLinha["usuario"]) : "";
                    objNovoTicket.data = objLinha["data"] != DBNull.Value ? Convert.ToDateTime(objLinha["data"]) : DateTime.Now;
                    objNovoTicket.categoria = objLinha["categoria"] != DBNull.Value ? Convert.ToString(objLinha["categoria"]) : "";
                    objNovoTicket.software = objLinha["software"] != DBNull.Value ? Convert.ToString(objLinha["software"]) : "";
                    objNovoTicket.prioridade = objLinha["prioridade"] != DBNull.Value ? Convert.ToString(objLinha["prioridade"]) : "";
                    objNovoTicket.descricao = objLinha["descricao"] != DBNull.Value ? Convert.ToString(objLinha["descricao"]) : "";
                    objNovoTicket.departamento = objLinha["departamento"] != DBNull.Value ? Convert.ToString(objLinha["departamento"]) : "";
                    objNovoTicket.msgErro = objLinha["msgErro"] != DBNull.Value ? Convert.ToString(objLinha["msgErro"]) : "";
                    objNovoTicket.status = objLinha["status"] != DBNull.Value ? Convert.ToString(objLinha["status"]) : "";
                    objNovoTicket.solucao = objLinha["solucao"] != DBNull.Value ? Convert.ToString(objLinha["solucao"]) : "";


                    lista.Add(objNovoTicket);
                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }
    }
}
