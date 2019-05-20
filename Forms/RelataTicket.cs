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
    public partial class RelataTicket : Form
    {
        private Ticket editaTicket = null;
        private VerTickets frmVerTicket;

        public RelataTicket()
        {
            InitializeComponent();

        }

        public RelataTicket(VerTickets frm)
        {
            this.frmVerTicket = frm;
            InitializeComponent();

        }

        public RelataTicket(Ticket ticket, VerTickets frm)
        {
            this.frmVerTicket = frm;
            this.editaTicket = ticket;
            InitializeComponent();

            txb_Usuario.Text = editaTicket.usuario;
            
            txb_Categoria.Text = editaTicket.categoria;
            txb_Software.Text = editaTicket.software;
            txb_Prazo.Text = editaTicket.prioridade;
            txb_Descricao.Text = editaTicket.descricao;
            txb_Setor.Text = editaTicket.departamento;
            txb_Erro.Text = editaTicket.msgErro;
            txb_Status.Text = editaTicket.status;

            //desativa a edição do usuario
            txb_Usuario.Enabled = false;
            txb_Date.Enabled = false;
            txb_Categoria.Enabled = false;
            txb_Software.Enabled = false;
            txb_Setor.Enabled = false;
            txb_Prioridade.Enabled = false;
            txb_Erro.Enabled = false;
            txb_Prazo.Enabled = false;
            txb_Status.Enabled = false;
            txb_Descricao.Enabled = false;
        }


        public bool verifica()
        {
            string[] texts = new string[9];

            texts[0] = txb_Usuario.Text;
            texts[1] = txb_Date.Text;
            texts[2] = txb_Categoria.Text;
            texts[3] = txb_Software.Text;
            texts[4] = txb_Prazo.Text;
            texts[5] = txb_Descricao.Text;
            texts[6] = txb_Setor.Text;
            texts[7] = txb_Erro.Text;
            texts[8] = txb_Status.Text;

            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i] == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (verifica())
            {
                var ticket = new Ticket();

                ticket.usuario = txb_Usuario.Text;

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
                    if(editaTicket == null)
                    {
                        ticketDAO.create(ticket);
                        MessageBox.Show("Ticket salvo com sucesso");
                    }
                    else
                    {
                        ticket.ticketId = editaTicket.ticketId;
                        ticketDAO.edit(ticket);
                        frmVerTicket.atualizaTabela();
                        frmVerTicket.Show();

                    }
                    

                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    
                    this.Dispose();
                }

            }
            else
            {
                MessageBox.Show("Preencha corretamente todas os Campos");
            }






        }

        private void RelatarTicket_Load(object sender, EventArgs e)
        {
            txb_Date.Text = DateTime.Now.ToString();
                

            txb_Categoria.Items.Add("Software");
            txb_Categoria.Items.Add("Hardware");
            txb_Categoria.Items.Add("Impressoras");
            txb_Categoria.Items.Add("Email");
            txb_Categoria.Items.Add("Sites");

            txb_Setor.Items.Add("Administração");
            txb_Setor.Items.Add("R.H");
            txb_Setor.Items.Add("Comercial");
            txb_Setor.Items.Add("Financeiro");
            txb_Setor.Items.Add("T.I");

            txb_Prazo.Items.Add("Baixa");
            txb_Prazo.Items.Add("Media");
            txb_Prazo.Items.Add("Alta");

            txb_Status.Items.Add("Aberto");
            txb_Status.Items.Add("Em Andamento");
            
            

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }
    }
}
