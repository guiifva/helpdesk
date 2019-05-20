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
    public partial class VerTickets : Form
    {
        public VerTickets()
        {
            InitializeComponent();
        }

        private void VerTickets_Load(object sender, EventArgs e)
        {
            atualizaTabela();

        }

        private void Dgv_Tickets_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        public void atualizaTabela()
        {
            TicketDAO ticketDAO = new TicketDAO();
            dgv_Tickets.DataSource = ticketDAO.list();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                var ticket = new Ticket();

                ticket.ticketId = Convert.ToInt32(dgv_Tickets.CurrentRow.Cells[0].Value.ToString());
                ticket.usuario = dgv_Tickets.CurrentRow.Cells[1].Value.ToString();
                ticket.data = Convert.ToDateTime(dgv_Tickets.CurrentRow.Cells[2].Value.ToString());
                ticket.categoria = dgv_Tickets.CurrentRow.Cells[3].Value.ToString();
                ticket.software = dgv_Tickets.CurrentRow.Cells[4].Value.ToString();
                ticket.prioridade = dgv_Tickets.CurrentRow.Cells[5].Value.ToString();
                ticket.descricao = dgv_Tickets.CurrentRow.Cells[6].Value.ToString();
                ticket.departamento = dgv_Tickets.CurrentRow.Cells[7].Value.ToString();
                ticket.msgErro = dgv_Tickets.CurrentRow.Cells[8].Value.ToString();
                ticket.status = dgv_Tickets.CurrentRow.Cells[9].Value.ToString();


                RelataTicket editaTicket = new RelataTicket(ticket, this);
                editaTicket.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecione um ticket");
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
