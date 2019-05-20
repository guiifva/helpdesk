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
    public partial class TicketsSolucionados : Form
    {
        public TicketsSolucionados()
        {
            InitializeComponent();
        }

        private void TicketsSolucionados_Load(object sender, EventArgs e)
        {
            TicketDAO ticketDAO = new TicketDAO();
            dgv_solucionados.DataSource = ticketDAO.listTicketsConcluidos();
        }

        private void Btn_detalhes_Click(object sender, EventArgs e)
        {
            var ticket = new Ticket();

            ticket.ticketId = Convert.ToInt32(dgv_solucionados.CurrentRow.Cells[0].Value.ToString());
            ticket.usuario = dgv_solucionados.CurrentRow.Cells[1].Value.ToString();
            ticket.data = Convert.ToDateTime(dgv_solucionados.CurrentRow.Cells[2].Value.ToString());
            ticket.categoria = dgv_solucionados.CurrentRow.Cells[3].Value.ToString();
            ticket.software = dgv_solucionados.CurrentRow.Cells[4].Value.ToString();
            ticket.prioridade = dgv_solucionados.CurrentRow.Cells[5].Value.ToString();
            ticket.descricao = dgv_solucionados.CurrentRow.Cells[6].Value.ToString();
            ticket.departamento = dgv_solucionados.CurrentRow.Cells[7].Value.ToString();
            ticket.msgErro = dgv_solucionados.CurrentRow.Cells[8].Value.ToString();
            ticket.status = dgv_solucionados.CurrentRow.Cells[9].Value.ToString();
            ticket.solucao = dgv_solucionados.CurrentRow.Cells[9].Value.ToString();

            SolucionaTicket telaDetalhesTicket = new SolucionaTicket(ticket);
            
            telaDetalhesTicket.Show();
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
