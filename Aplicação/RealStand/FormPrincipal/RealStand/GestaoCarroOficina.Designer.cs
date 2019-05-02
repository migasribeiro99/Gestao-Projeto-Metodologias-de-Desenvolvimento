namespace RealStand
{
    partial class GestaoCarroOficina
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
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxCarroOficina = new System.Windows.Forms.ListBox();
            this.Clientes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEliminarCarro = new System.Windows.Forms.Button();
            this.buttonAdicionarCarro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKlms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.textBoxCombustivel = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxServico = new System.Windows.Forms.ComboBox();
            this.buttonAdicionarServico = new System.Windows.Forms.Button();
            this.listBoxServico = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.buttonAdicionarParcela = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.dateTimePickerServico = new System.Windows.Forms.DateTimePicker();
            this.Clientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(16, 29);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(169, 355);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarroOficina
            // 
            this.listBoxCarroOficina.FormattingEnabled = true;
            this.listBoxCarroOficina.Location = new System.Drawing.Point(9, 182);
            this.listBoxCarroOficina.Name = "listBoxCarroOficina";
            this.listBoxCarroOficina.Size = new System.Drawing.Size(235, 147);
            this.listBoxCarroOficina.TabIndex = 1;
            this.listBoxCarroOficina.SelectedIndexChanged += new System.EventHandler(this.listBoxCarroOficina_SelectedIndexChanged);
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.listBoxClientes);
            this.Clientes.Location = new System.Drawing.Point(12, 15);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(200, 402);
            this.Clientes.TabIndex = 2;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEliminarCarro);
            this.groupBox1.Controls.Add(this.buttonAdicionarCarro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxKlms);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxCarroOficina);
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.textBoxNumeroChassis);
            this.groupBox1.Controls.Add(this.textBoxCombustivel);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Location = new System.Drawing.Point(232, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 402);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Carro";
            // 
            // buttonEliminarCarro
            // 
            this.buttonEliminarCarro.Location = new System.Drawing.Point(40, 335);
            this.buttonEliminarCarro.Name = "buttonEliminarCarro";
            this.buttonEliminarCarro.Size = new System.Drawing.Size(159, 35);
            this.buttonEliminarCarro.TabIndex = 15;
            this.buttonEliminarCarro.Text = "Eliminar Carro";
            this.buttonEliminarCarro.UseVisualStyleBackColor = true;
            this.buttonEliminarCarro.Click += new System.EventHandler(this.buttonEliminarCarro_Click);
            // 
            // buttonAdicionarCarro
            // 
            this.buttonAdicionarCarro.Location = new System.Drawing.Point(176, 29);
            this.buttonAdicionarCarro.Name = "buttonAdicionarCarro";
            this.buttonAdicionarCarro.Size = new System.Drawing.Size(68, 147);
            this.buttonAdicionarCarro.TabIndex = 10;
            this.buttonAdicionarCarro.Text = "Adicionar Carro";
            this.buttonAdicionarCarro.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarro.Click += new System.EventHandler(this.buttonAdicionarCarro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Klm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Matricula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Combustivel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca:";
            // 
            // textBoxKlms
            // 
            this.textBoxKlms.Location = new System.Drawing.Point(70, 156);
            this.textBoxKlms.Name = "textBoxKlms";
            this.textBoxKlms.Size = new System.Drawing.Size(100, 20);
            this.textBoxKlms.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nº Chassis:";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(70, 130);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatricula.TabIndex = 8;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(70, 26);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroChassis.TabIndex = 5;
            // 
            // textBoxCombustivel
            // 
            this.textBoxCombustivel.Location = new System.Drawing.Point(70, 104);
            this.textBoxCombustivel.Name = "textBoxCombustivel";
            this.textBoxCombustivel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCombustivel.TabIndex = 7;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(70, 52);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarca.TabIndex = 4;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(70, 78);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerServico);
            this.groupBox2.Controls.Add(this.comboBoxServico);
            this.groupBox2.Controls.Add(this.buttonAdicionarServico);
            this.groupBox2.Controls.Add(this.listBoxServico);
            this.groupBox2.Location = new System.Drawing.Point(501, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 192);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviço";
            // 
            // comboBoxServico
            // 
            this.comboBoxServico.FormattingEnabled = true;
            this.comboBoxServico.Items.AddRange(new object[] {
            "Reparação",
            "Revisão"});
            this.comboBoxServico.Location = new System.Drawing.Point(7, 20);
            this.comboBoxServico.Name = "comboBoxServico";
            this.comboBoxServico.Size = new System.Drawing.Size(236, 21);
            this.comboBoxServico.TabIndex = 2;
            // 
            // buttonAdicionarServico
            // 
            this.buttonAdicionarServico.Location = new System.Drawing.Point(7, 152);
            this.buttonAdicionarServico.Name = "buttonAdicionarServico";
            this.buttonAdicionarServico.Size = new System.Drawing.Size(236, 23);
            this.buttonAdicionarServico.TabIndex = 1;
            this.buttonAdicionarServico.Text = "Adicionar Serviço";
            this.buttonAdicionarServico.UseVisualStyleBackColor = true;
            this.buttonAdicionarServico.Click += new System.EventHandler(this.buttonAdicionarServico_Click);
            // 
            // listBoxServico
            // 
            this.listBoxServico.FormattingEnabled = true;
            this.listBoxServico.Location = new System.Drawing.Point(6, 77);
            this.listBoxServico.Name = "listBoxServico";
            this.listBoxServico.Size = new System.Drawing.Size(237, 69);
            this.listBoxServico.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxParcelas);
            this.groupBox3.Controls.Add(this.buttonAdicionarParcela);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxValor);
            this.groupBox3.Controls.Add(this.textBoxDescricao);
            this.groupBox3.Location = new System.Drawing.Point(501, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parcelas";
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(7, 90);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(236, 95);
            this.listBoxParcelas.TabIndex = 4;
            // 
            // buttonAdicionarParcela
            // 
            this.buttonAdicionarParcela.Location = new System.Drawing.Point(176, 10);
            this.buttonAdicionarParcela.Name = "buttonAdicionarParcela";
            this.buttonAdicionarParcela.Size = new System.Drawing.Size(73, 78);
            this.buttonAdicionarParcela.TabIndex = 3;
            this.buttonAdicionarParcela.Text = "Adicionar Parcela";
            this.buttonAdicionarParcela.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descrição:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(70, 50);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 1;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(70, 24);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricao.TabIndex = 0;
            // 
            // dateTimePickerServico
            // 
            this.dateTimePickerServico.Location = new System.Drawing.Point(9, 47);
            this.dateTimePickerServico.Name = "dateTimePickerServico";
            this.dateTimePickerServico.Size = new System.Drawing.Size(234, 20);
            this.dateTimePickerServico.TabIndex = 6;
            // 
            // GestaoCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Clientes);
            this.Name = "GestaoCarroOficina";
            this.Text = "GestaoCarroOficina";
            this.Load += new System.EventHandler(this.GestaoCarroOficina_Load);
            this.Clientes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarroOficina;
        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKlms;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.TextBox textBoxCombustivel;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Button buttonAdicionarCarro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminarCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxServico;
        private System.Windows.Forms.Button buttonAdicionarServico;
        private System.Windows.Forms.ListBox listBoxServico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.Button buttonAdicionarParcela;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePickerServico;
    }
}