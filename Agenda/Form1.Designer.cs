using System;
using System.Windows.Forms;

namespace Agenda
{
    partial class Form1
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdtnasc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(251, 170);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 31);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "telefone";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(123, 39);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(186, 20);
            this.txtnome.TabIndex = 5;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(123, 91);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(186, 20);
            this.txttelefone.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(561, 43);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(186, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtdtnasc
            // 
            this.txtdtnasc.Location = new System.Drawing.Point(561, 91);
            this.txtdtnasc.Name = "txtdtnasc";
            this.txtdtnasc.Size = new System.Drawing.Size(186, 20);
            this.txtdtnasc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "dtnasc";
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToDeleteRows = false;
            this.dgvContatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvContatos.Location = new System.Drawing.Point(12, 211);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            this.dgvContatos.Size = new System.Drawing.Size(776, 218);
            this.dgvContatos.TabIndex = 11;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIncluir.Location = new System.Drawing.Point(48, 170);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(89, 31);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Inlcuir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterar.Location = new System.Drawing.Point(469, 170);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 31);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(660, 170);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 31);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(30, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(39, 20);
            this.txtid.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvContatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdtnasc);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdtnasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvContatos;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnExcluir;
        private Label label1;
        private TextBox txtid;
    }
}

