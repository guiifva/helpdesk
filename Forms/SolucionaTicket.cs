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
    public partial class SolucionaTicket : Form
    {
        private Ticket ticketParaSolucao;
        private FuncionariosTicket frm;

        public SolucionaTicket()
        {

            InitializeComponent();

        }

        public SolucionaTicket(Ticket t, FuncionariosTicket frm)
        {
            this.frm = frm;
            this.ticketParaSolucao = t;
            InitializeComponent();

            txb_Usuario.Text = ticketParaSolucao.usuario;

            txb_Categoria.Text = ticketParaSolucao.categoria;
            txb_Software.Text = ticketParaSolucao.software;
            txb_Prazo.Text = ticketParaSolucao.prioridade;
            txb_Descricao.Text = ticketParaSolucao.descricao;
            txb_Setor.Text = ticketParaSolucao.departamento;
            txb_Erro.Text = ticketParaSolucao.msgErro;
            txb_Status.Text = ticketParaSolucao.status;
            txb_Status.Items.Add("Em Andamento");
            txb_Status.Items.Add ("Aberto");
            txb_Status.Items.Add ("Concluido");

        }

        public SolucionaTicket(Ticket t)
        {
            
            InitializeComponent();

            txb_Usuario.Text = t.usuario;
            txb_Status.Enabled = false;
            txb_solucao.Enabled = false;
            txb_Categoria.Text = t.categoria;
            txb_Software.Text = t.software;
            txb_Prazo.Text = t.prioridade;
            txb_Descricao.Text = t.descricao;
            txb_Setor.Text = t.departamento;
            txb_Erro.Text = t.msgErro;
            txb_Status.Text = t.status;
            txb_solucao.Text = t.solucao;
            txb_Status.Text = t.status;

            btn_Salvar.Hide();
            btn_Cancelar.Text = "Sair";
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var ticket = new Ticket();

            ticket.usuario = txb_Usuario.Text;
            ticket.ticketId = ticketParaSolucao.ticketId;

            var arrayData = txb_Date.Text.Split('/');
            string data = (arrayData[2] + "-" + arrayData[1] + "-" + arrayData[0]);
            ticket.data = Convert.ToDateTime(data);

            ticket.categoria = txb_Categoria.Text;
            ticket.software = txb_Software.Text;
            ticket.prioridade = txb_Prazo.Text;
            ticket.descricao = txb_Descricao.Text;
            ticket.departamento = txb_Setor.Text;
            ticket.msgErro = txb_Erro.Text;
            ticket.status = txb_Status.Text;

            var ticketDAO = new TicketDAO();
            try
            {
                if (ticket.status == "Concluido")
                {
                    ticketDAO.edit(ticket);
                    ticket.solucao = txb_solucao.Text;
                    
                    ticketDAO.createSolucaoTicket(ticket);

                    MessageBox.Show("Ticket Concluido com sucesso!");
                    this.Dispose();
                    frm.Show();
                    frm.atualizaTabela();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RelatarTicket_Load(object sender, EventArgs e)
        {

            

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
