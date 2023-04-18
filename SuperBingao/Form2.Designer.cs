namespace SuperBingao
{
    partial class Form2
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
            this.label8 = new System.Windows.Forms.Label();
            this.CaixaEvento = new System.Windows.Forms.TextBox();
            this.TextoDescricaoPremio = new System.Windows.Forms.Label();
            this.TextoPremio = new System.Windows.Forms.Label();
            this.TextoEdicao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaixaEdicao = new System.Windows.Forms.TextBox();
            this.CaixaNumero = new System.Windows.Forms.TextBox();
            this.CaixaDescricao = new System.Windows.Forms.TextBox();
            this.BotaoSalvarForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(98, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Atualizar detalhes do sorteio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CaixaEvento
            // 
            this.CaixaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaEvento.Location = new System.Drawing.Point(106, 59);
            this.CaixaEvento.MaxLength = 100;
            this.CaixaEvento.Name = "CaixaEvento";
            this.CaixaEvento.Size = new System.Drawing.Size(277, 24);
            this.CaixaEvento.TabIndex = 13;
            // 
            // TextoDescricaoPremio
            // 
            this.TextoDescricaoPremio.AutoSize = true;
            this.TextoDescricaoPremio.Location = new System.Drawing.Point(60, 151);
            this.TextoDescricaoPremio.Name = "TextoDescricaoPremio";
            this.TextoDescricaoPremio.Size = new System.Drawing.Size(58, 13);
            this.TextoDescricaoPremio.TabIndex = 16;
            this.TextoDescricaoPremio.Text = "Descrição:";
            // 
            // TextoPremio
            // 
            this.TextoPremio.AutoSize = true;
            this.TextoPremio.Location = new System.Drawing.Point(60, 121);
            this.TextoPremio.Name = "TextoPremio";
            this.TextoPremio.Size = new System.Drawing.Size(47, 13);
            this.TextoPremio.TabIndex = 17;
            this.TextoPremio.Text = "Número:";
            this.TextoPremio.Click += new System.EventHandler(this.TextoPremio_Click);
            // 
            // TextoEdicao
            // 
            this.TextoEdicao.AutoSize = true;
            this.TextoEdicao.Location = new System.Drawing.Point(60, 91);
            this.TextoEdicao.Name = "TextoEdicao";
            this.TextoEdicao.Size = new System.Drawing.Size(43, 13);
            this.TextoEdicao.TabIndex = 18;
            this.TextoEdicao.Text = "Edição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Evento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 15;
            // 
            // CaixaEdicao
            // 
            this.CaixaEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaEdicao.Location = new System.Drawing.Point(106, 87);
            this.CaixaEdicao.MaxLength = 100;
            this.CaixaEdicao.Name = "CaixaEdicao";
            this.CaixaEdicao.Size = new System.Drawing.Size(277, 24);
            this.CaixaEdicao.TabIndex = 26;
            // 
            // CaixaNumero
            // 
            this.CaixaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaNumero.Location = new System.Drawing.Point(106, 117);
            this.CaixaNumero.MaxLength = 100;
            this.CaixaNumero.Name = "CaixaNumero";
            this.CaixaNumero.Size = new System.Drawing.Size(277, 24);
            this.CaixaNumero.TabIndex = 27;
            // 
            // CaixaDescricao
            // 
            this.CaixaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaDescricao.Location = new System.Drawing.Point(118, 146);
            this.CaixaDescricao.MaxLength = 100;
            this.CaixaDescricao.Name = "CaixaDescricao";
            this.CaixaDescricao.Size = new System.Drawing.Size(265, 24);
            this.CaixaDescricao.TabIndex = 28;
            // 
            // BotaoSalvarForm
            // 
            this.BotaoSalvarForm.Location = new System.Drawing.Point(154, 209);
            this.BotaoSalvarForm.Name = "BotaoSalvarForm";
            this.BotaoSalvarForm.Size = new System.Drawing.Size(107, 32);
            this.BotaoSalvarForm.TabIndex = 33;
            this.BotaoSalvarForm.Text = "Salvar";
            this.BotaoSalvarForm.UseVisualStyleBackColor = true;
            this.BotaoSalvarForm.Click += new System.EventHandler(this.BotaoSalvarForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 276);
            this.Controls.Add(this.BotaoSalvarForm);
            this.Controls.Add(this.CaixaDescricao);
            this.Controls.Add(this.CaixaNumero);
            this.Controls.Add(this.CaixaEdicao);
            this.Controls.Add(this.TextoDescricaoPremio);
            this.Controls.Add(this.TextoPremio);
            this.Controls.Add(this.TextoEdicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaixaEvento);
            this.Controls.Add(this.label8);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CaixaEvento;
        private System.Windows.Forms.Label TextoDescricaoPremio;
        private System.Windows.Forms.Label TextoPremio;
        private System.Windows.Forms.Label TextoEdicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CaixaEdicao;
        private System.Windows.Forms.TextBox CaixaNumero;
        private System.Windows.Forms.TextBox CaixaDescricao;
        private System.Windows.Forms.Button BotaoSalvarForm;
    }
}