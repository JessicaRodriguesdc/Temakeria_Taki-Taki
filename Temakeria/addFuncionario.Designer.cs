namespace Temakeria
{
    partial class rg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rg));
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.maskedTel = new System.Windows.Forms.MaskedTextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.buscarNome = new System.Windows.Forms.Label();
            this.Cel = new System.Windows.Forms.Label();
            this.maskedCel = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(60, 164);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 160);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(67, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 62);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // maskedTel
            // 
            this.maskedTel.Location = new System.Drawing.Point(121, 193);
            this.maskedTel.Mask = "(00)00000-0000";
            this.maskedTel.Name = "maskedTel";
            this.maskedTel.Size = new System.Drawing.Size(117, 20);
            this.maskedTel.TabIndex = 3;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(58, 200);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(52, 13);
            this.Tel.TabIndex = 4;
            this.Tel.Text = "Telefone:";
            // 
            // textBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(155, 130);
            this.txtBuscarNome.Name = "textBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(298, 20);
            this.txtBuscarNome.TabIndex = 6;
            // 
            // buscarNome
            // 
            this.buscarNome.AutoSize = true;
            this.buscarNome.Location = new System.Drawing.Point(60, 137);
            this.buscarNome.Name = "buscarNome";
            this.buscarNome.Size = new System.Drawing.Size(87, 13);
            this.buscarNome.TabIndex = 5;
            this.buscarNome.Text = "Pesquisar Nome:";
            // 
            // Cel
            // 
            this.Cel.AutoSize = true;
            this.Cel.Location = new System.Drawing.Point(276, 200);
            this.Cel.Name = "Cel";
            this.Cel.Size = new System.Drawing.Size(42, 13);
            this.Cel.TabIndex = 8;
            this.Cel.Text = "Celular:";
            // 
            // maskedCel
            // 
            this.maskedCel.Location = new System.Drawing.Point(340, 193);
            this.maskedCel.Mask = "(00)00000-0000";
            this.maskedCel.Name = "maskedCel";
            this.maskedCel.Size = new System.Drawing.Size(112, 20);
            this.maskedCel.TabIndex = 7;
            this.maskedCel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedCel_MaskInputRejected);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(375, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(71, 62);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.Image = ((System.Drawing.Image)(resources.GetObject("btnEdt.Image")));
            this.btnEdt.Location = new System.Drawing.Point(298, 36);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(71, 62);
            this.btnEdt.TabIndex = 10;
            this.btnEdt.UseVisualStyleBackColor = true;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(221, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 62);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(144, 36);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(71, 62);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(60, 237);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 13;
            this.email.Text = "E-mail:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(155, 265);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(298, 20);
            this.txtEnd.TabIndex = 16;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(61, 272);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(56, 13);
            this.endereco.TabIndex = 15;
            this.endereco.Text = "Endereço:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(90, 298);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(43, 20);
            this.txtNum.TabIndex = 18;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(96, 332);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(148, 20);
            this.txtRG.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "RG:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(206, 298);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(247, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // bairro
            // 
            this.bairro.AutoSize = true;
            this.bairro.Location = new System.Drawing.Point(154, 304);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(37, 13);
            this.bairro.TabIndex = 21;
            this.bairro.Text = "Bairro:";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(62, 304);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(22, 13);
            this.num.TabIndex = 23;
            this.num.Text = "N°:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(305, 331);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(148, 20);
            this.txtCpf.TabIndex = 25;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(267, 338);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 24;
            this.cpf.Text = "CPF:";
            // 
            // rg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 400);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.num);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEdt);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.Cel);
            this.Controls.Add(this.maskedCel);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.buscarNome);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.maskedTel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "rg";
            this.ShowIcon = false;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.addFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox maskedTel;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label buscarNome;
        private System.Windows.Forms.Label Cel;
        private System.Windows.Forms.MaskedTextBox maskedCel;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Button btnExcluir;
    }
}