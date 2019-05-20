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
    public partial class Login : Form
    {
        private Inicial frm;


        public Login()
        {
            InitializeComponent();
        }

        public Login(Inicial frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            if (txbLogin.TextLength > 3 && txbSenha.TextLength > 4)
            {
                string login = txbLogin.Text;
                string senha = txbSenha.Text;

                Funcionario funcionario = new Funcionario();

                funcionario.login = login;
                funcionario.senha = senha;

                FuncionarioDAO dao = new FuncionarioDAO();
                List<Funcionario> listaFuncionario = new List<Funcionario>();

                listaFuncionario = dao.verificaLogin(funcionario);

                if (listaFuncionario.Count == 1)
                {
                    FuncionariosTicket telaFuncTicket = new FuncionariosTicket();
                    telaFuncTicket.Show();
                    this.Dispose();


                }
                else
                {
                    MessageBox.Show("Insira um login valido");
                }
            }
            else
            {
                MessageBox.Show("Informações invalidas!\nVerifique o numero de caracteres.");
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

