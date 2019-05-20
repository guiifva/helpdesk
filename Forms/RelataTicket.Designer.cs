namespace Helpdesk.Forms
{
    partial class RelataTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Software = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Descricao = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Categoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Setor = new System.Windows.Forms.ComboBox();
            this.txb_Prioridade = new System.Windows.Forms.Label();
            this.txb_Prazo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_Erro = new System.Windows.Forms.RichTextBox();
            this.txb_Date = new System.Windows.Forms.DateTimePicker();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_Status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Software:";
            // 
            // txb_Software
            // 
            this.txb_Software.Location = new System.Drawing.Point(12, 137);
            this.txb_Software.Name = "txb_Software";
            this.txb_Software.Size = new System.Drawing.Size(811, 29);
            this.txb_Software.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição do problema:";
            // 
            // txb_Descricao
            // 
            this.txb_Descricao.Location = new System.Drawing.Point(12, 195);
            this.txb_Descricao.Name = "txb_Descricao";
            this.txb_Descricao.Size = new System.Drawing.Size(1101, 100);
            this.txb_Descricao.TabIndex = 8;
            this.txb_Descricao.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 10;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(431, 493);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(104, 32);
            this.btn_Salvar.TabIndex = 11;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(578, 493);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(104, 32);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Categoria:";
            // 
            // txb_Categoria
            // 
            this.txb_Categoria.DisplayMember = "a";
            this.txb_Categoria.FormattingEnabled = true;
            this.txb_Categoria.Items.AddRange(new object[] {
            "Suporte",
            "Correção"});
            this.txb_Categoria.Location = new System.Drawing.Point(841, 77);
            this.txb_Categoria.Name = "txb_Categoria";
            this.txb_Categoria.Size = new System.Drawing.Size(272, 31);
            this.txb_Categoria.TabIndex = 16;
            this.txb_Categoria.Text = "Selecione";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Setor:";
            // 
            // txb_Setor
            // 
            this.txb_Setor.FormattingEnabled = true;
            this.txb_Setor.Location = new System.Drawing.Point(12, 325);
            this.txb_Setor.Name = "txb_Setor";
            this.txb_Setor.Size = new System.Drawing.Size(397, 31);
            this.txb_Setor.TabIndex = 18;
            // 
            // txb_Prioridade
            // 
            this.txb_Prioridade.AutoSize = true;
            this.txb_Prioridade.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Prioridade.Location = new System.Drawing.Point(841, 111);
            this.txb_Prioridade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txb_Prioridade.Name = "txb_Prioridade";
            this.txb_Prioridade.Size = new System.Drawing.Size(85, 23);
            this.txb_Prioridade.TabIndex = 20;
            this.txb_Prioridade.Text = "Prioridade:";
            // 
            // txb_Prazo
            // 
            this.txb_Prazo.FormattingEnabled = true;
            this.txb_Prazo.Location = new System.Drawing.Point(841, 135);
            this.txb_Prazo.Name = "txb_Prazo";
            this.txb_Prazo.Size = new System.Drawing.Size(272, 31);
            this.txb_Prazo.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 358);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Mensagem de erro:";
            // 
            // txb_Erro
            // 
            this.txb_Erro.Location = new System.Drawing.Point(12, 384);
            this.txb_Erro.Name = "txb_Erro";
            this.txb_Erro.Size = new System.Drawing.Size(1108, 66);
            this.txb_Erro.TabIndex = 25;
            this.txb_Erro.Text = "";
            // 
            // txb_Date
            // 
            this.txb_Date.CustomFormat = "dd/MM/yyyy";
            this.txb_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txb_Date.Location = new System.Drawing.Point(557, 79);
            this.txb_Date.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.txb_Date.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.txb_Date.Name = "txb_Date";
            this.txb_Date.Size = new System.Drawing.Size(266, 29);
            this.txb_Date.TabIndex = 26;
            this.txb_Date.Value = new System.DateTime(2019, 4, 1, 22, 21, 33, 0);
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(12, 79);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(523, 29);
            this.txb_Usuario.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Status:";
            // 
            // txb_Status
            // 
            this.txb_Status.FormattingEnabled = true;
            this.txb_Status.Location = new System.Drawing.Point(590, 325);
            this.txb_Status.Name = "txb_Status";
            this.txb_Status.Size = new System.Drawing.Size(272, 31);
            this.txb_Status.TabIndex = 29;
            // 
            // RelataTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 550);
            this.Controls.Add(this.txb_Status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_Date);
            this.Controls.Add(this.txb_Erro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txb_Prazo);
            this.Controls.Add(this.txb_Prioridade);
            this.Controls.Add(this.txb_Setor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_Categoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Software);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "RelataTicket";
            this.Text = "Relatar um problema";
            this.Load += new System.EventHandler(this.RelatarTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Software;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txb_Descricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txb_Categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txb_Setor;
        private System.Windows.Forms.Label txb_Prioridade;
        private System.Windows.Forms.ComboBox txb_Prazo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txb_Erro;
        private System.Windows.Forms.DateTimePicker txb_Date;
        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txb_Status;
    }
}