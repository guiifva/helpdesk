using Helpdesk.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk
{
    public partial class Inicial : Form
    {
        private int logado;
        public Inicial()
        {
            InitializeComponent();
        }

        private void AbirirTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelataTicket relataTicket = new RelataTicket();
            relataTicket.MdiParent = this;
            relataTicket.Show();
        }

        private void VerTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerTickets verTickets = new VerTickets();
            verTickets.MdiParent = this;
            verTickets.Show();

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RelatarErrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.MdiParent = this;
            telaLogin.Show();
        }

        private void TicketsSolucionadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsSolucionados telaTicketsSolucionados = new TicketsSolucionados();
            telaTicketsSolucionados.MdiParent = this;
            telaTicketsSolucionados.Show();
        }



        private void Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
