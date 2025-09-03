﻿namespace SistemaPizzaria
{
    partial class Pedido
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
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpOpcionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(6, 30);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(107, 17);
            this.chkBorda.TabIndex = 0;
            this.chkBorda.Text = "Borda Recheada";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(306, 414);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 53);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(50, 54);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(240, 21);
            this.cmbTamanhoPizza.TabIndex = 2;
            this.cmbTamanhoPizza.Text = "TAMANHO DA PIZZA";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(233, 244);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(746, 150);
            this.dgvPedido.TabIndex = 3;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedido_MouseDoubleClick);
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.Location = new System.Drawing.Point(410, 39);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(95, 13);
            this.lblValorPizza.TabIndex = 4;
            this.lblValorPizza.Text = "VALOR DA PIZZA";
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkTempero);
            this.grpOpcionais.Controls.Add(this.chkCatupiry);
            this.grpOpcionais.Controls.Add(this.chkCebola);
            this.grpOpcionais.Controls.Add(this.chkBorda);
            this.grpOpcionais.Location = new System.Drawing.Point(23, 244);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(172, 165);
            this.grpOpcionais.TabIndex = 5;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            this.grpOpcionais.Enter += new System.EventHandler(this.grpOpcionais_Enter);
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(6, 133);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(103, 17);
            this.chkTempero.TabIndex = 3;
            this.chkTempero.Text = "Tempero do City";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(6, 98);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(102, 17);
            this.chkCatupiry.TabIndex = 2;
            this.chkCatupiry.Text = "Catupiry Original";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 62);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(111, 17);
            this.chkCebola.TabIndex = 1;
            this.chkCebola.Text = "Cebola sem choro";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(413, 55);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(100, 20);
            this.txtValorPizza.TabIndex = 6;
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(611, 39);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 7;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(780, 39);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 8;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(614, 55);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 9;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(783, 55);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(460, 414);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 53);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(626, 414);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 53);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(783, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 53);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(676, 189);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 14;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(377, 192);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(436, 188);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(761, 185);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(218, 20);
            this.txtPesquisar.TabIndex = 17;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 546);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.lblValorPizza);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.btnNovo);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label lblValorPizza;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}