using Helpdesk.ConnectioDB;
using Helpdesk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.Forms
{
    public partial class FuncionariosTicket : Form
    {
        private Inicial frmTelaInicial;


        private void FuncionariosTicket_Load(object sender, EventArgs e)
        {
            atualizaTabela();
        }

        public void atualizaTabela()
        {
            TicketDAO ticketDAO = new TicketDAO();
            dgv_TicketsFuncionarios.DataSource = ticketDAO.list();

        }

        private void Btn_solucionar_Click(object sender, EventArgs e)
        {
            try
            {
                var ticket = new Ticket();

                ticket.ticketId = Convert.ToInt32(dgv_TicketsFuncionarios.CurrentRow.Cells[0].Value.ToString());
                ticket.usuario = dgv_TicketsFuncionarios.CurrentRow.Cells[1].Value.ToString();
                ticket.data = Convert.ToDateTime(dgv_TicketsFuncionarios.CurrentRow.Cells[2].Value.ToString());
                ticket.categoria = dgv_TicketsFuncionarios.CurrentRow.Cells[3].Value.ToString();
                ticket.software = dgv_TicketsFuncionarios.CurrentRow.Cells[4].Value.ToString();
                ticket.prioridade = dgv_TicketsFuncionarios.CurrentRow.Cells[5].Value.ToString();
                ticket.descricao = dgv_TicketsFuncionarios.CurrentRow.Cells[6].Value.ToString();
                ticket.departamento = dgv_TicketsFuncionarios.CurrentRow.Cells[7].Value.ToString();
                ticket.msgErro = dgv_TicketsFuncionarios.CurrentRow.Cells[8].Value.ToString();
                ticket.status = dgv_TicketsFuncionarios.CurrentRow.Cells[9].Value.ToString();

                SolucionaTicket solucionaTicket = new SolucionaTicket(ticket, this);
                solucionaTicket.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecione um Ticket");
            }

            

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
