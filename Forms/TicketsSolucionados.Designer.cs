namespace Helpdesk.Forms
{
    partial class TicketsSolucionados
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
            this.dgv_solucionados = new System.Windows.Forms.DataGridView();
            this.btn_detalhes = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solucionados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets Solucionados";
            // 
            // dgv_solucionados
            // 
            this.dgv_solucionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solucionados.Location = new System.Drawing.Point(31, 103);
            this.dgv_solucionados.Name = "dgv_solucionados";
            this.dgv_solucionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_solucionados.Size = new System.Drawing.Size(984, 458);
            this.dgv_solucionados.TabIndex = 1;
            // 
            // btn_detalhes
            // 
            this.btn_detalhes.Location = new System.Drawing.Point(411, 576);
            this.btn_detalhes.Name = "btn_detalhes";
            this.btn_detalhes.Size = new System.Drawing.Size(75, 29);
            this.btn_detalhes.TabIndex = 2;
            this.btn_detalhes.Text = "Detalhes";
            this.btn_detalhes.UseVisualStyleBackColor = true;
            this.btn_detalhes.Click += new System.EventHandler(this.Btn_detalhes_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(578, 576);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 29);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // TicketsSolucionados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 628);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_detalhes);
            this.Controls.Add(this.dgv_solucionados);
            this.Controls.Add(this.label1);
            this.Name = "TicketsSolucionados";
            this.Text = "TicketsSolucionados";
            this.Load += new System.EventHandler(this.TicketsSolucionados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solucionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_solucionados;
        private System.Windows.Forms.Button btn_detalhes;
        private System.Windows.Forms.Button btn_sair;
    }
}