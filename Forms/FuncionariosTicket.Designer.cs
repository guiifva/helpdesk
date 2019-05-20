namespace Helpdesk.Forms
{
    partial class FuncionariosTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_TicketsFuncionarios = new System.Windows.Forms.DataGridView();
            this.btn_solucionar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketsFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets Em Aberto";
            // 
            // dgv_TicketsFuncionarios
            // 
            this.dgv_TicketsFuncionarios.AllowUserToAddRows = false;
            this.dgv_TicketsFuncionarios.AllowUserToDeleteRows = false;
            this.dgv_TicketsFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TicketsFuncionarios.Location = new System.Drawing.Point(34, 88);
            this.dgv_TicketsFuncionarios.Name = "dgv_TicketsFuncionarios";
            this.dgv_TicketsFuncionarios.ReadOnly = true;
            this.dgv_TicketsFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TicketsFuncionarios.Size = new System.Drawing.Size(893, 396);
            this.dgv_TicketsFuncionarios.TabIndex = 1;
            // 
            // btn_solucionar
            // 
            this.btn_solucionar.Location = new System.Drawing.Point(365, 504);
            this.btn_solucionar.Name = "btn_solucionar";
            this.btn_solucionar.Size = new System.Drawing.Size(81, 28);
            this.btn_solucionar.TabIndex = 2;
            this.btn_solucionar.Text = "Solucionar";
            this.btn_solucionar.UseVisualStyleBackColor = true;
            this.btn_solucionar.Click += new System.EventHandler(this.Btn_solucionar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(506, 504);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(81, 28);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // FuncionariosTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 562);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_solucionar);
            this.Controls.Add(this.dgv_TicketsFuncionarios);
            this.Controls.Add(this.label1);
            this.Name = "FuncionariosTicket";
            this.Text = "SolucionaTicket";
            this.Load += new System.EventHandler(this.FuncionariosTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketsFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_TicketsFuncionarios;
        private System.Windows.Forms.Button btn_solucionar;
        private System.Windows.Forms.Button btn_sair;
    }
}