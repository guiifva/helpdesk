namespace Helpdesk
{
    partial class Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.abirirTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsSolucionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatarErrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abirirTicketToolStripMenuItem,
            this.verTicketsToolStripMenuItem,
            this.ticketsSolucionadosToolStripMenuItem,
            this.relatarErrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1130, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // abirirTicketToolStripMenuItem
            // 
            this.abirirTicketToolStripMenuItem.Name = "abirirTicketToolStripMenuItem";
            this.abirirTicketToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.abirirTicketToolStripMenuItem.Text = "Abrir Ticket";
            this.abirirTicketToolStripMenuItem.Click += new System.EventHandler(this.AbirirTicketToolStripMenuItem_Click);
            // 
            // verTicketsToolStripMenuItem
            // 
            this.verTicketsToolStripMenuItem.Name = "verTicketsToolStripMenuItem";
            this.verTicketsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.verTicketsToolStripMenuItem.Text = "Ver Tickets";
            this.verTicketsToolStripMenuItem.Click += new System.EventHandler(this.VerTicketsToolStripMenuItem_Click);
            // 
            // ticketsSolucionadosToolStripMenuItem
            // 
            this.ticketsSolucionadosToolStripMenuItem.Name = "ticketsSolucionadosToolStripMenuItem";
            this.ticketsSolucionadosToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.ticketsSolucionadosToolStripMenuItem.Text = "Tickets Solucionados";
            this.ticketsSolucionadosToolStripMenuItem.Click += new System.EventHandler(this.TicketsSolucionadosToolStripMenuItem_Click);
            // 
            // relatarErrosToolStripMenuItem
            // 
            this.relatarErrosToolStripMenuItem.Name = "relatarErrosToolStripMenuItem";
            this.relatarErrosToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.relatarErrosToolStripMenuItem.Text = "Login Administrativo";
            this.relatarErrosToolStripMenuItem.Click += new System.EventHandler(this.RelatarErrosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 702);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Inicial";
            this.Text = "Helpdesk";
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem abirirTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatarErrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsSolucionadosToolStripMenuItem;
    }
}

