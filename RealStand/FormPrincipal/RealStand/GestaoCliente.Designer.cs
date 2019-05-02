namespace RealStand
{
    partial class GestaoCliente
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
            this.listBoxNomeClientes = new System.Windows.Forms.ListBox();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxNifCliente = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.comboBoxMorada = new System.Windows.Forms.ComboBox();
            this.textBoxNomeAlterar = new System.Windows.Forms.TextBox();
            this.comboBoxMoradaAlterar = new System.Windows.Forms.ComboBox();
            this.textBoxNifAlterar = new System.Windows.Forms.TextBox();
            this.textBoxContactoAlterar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAtualizarCliente = new System.Windows.Forms.Button();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.buttonGuardarAlteracoes = new System.Windows.Forms.Button();
            this.buttonCancelarAtua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelContactoCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxNomeClientes
            // 
            this.listBoxNomeClientes.FormattingEnabled = true;
            this.listBoxNomeClientes.Location = new System.Drawing.Point(21, 134);
            this.listBoxNomeClientes.Name = "listBoxNomeClientes";
            this.listBoxNomeClientes.Size = new System.Drawing.Size(189, 251);
            this.listBoxNomeClientes.TabIndex = 0;
            this.listBoxNomeClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxNomeClientes_SelectedIndexChanged);
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(227, 134);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(101, 75);
            this.buttonAdicionarCliente.TabIndex = 1;
            this.buttonAdicionarCliente.Text = "Adicionar Cliente";
            this.buttonAdicionarCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nif Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Morada:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contacto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(62, 26);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(148, 20);
            this.textBoxNomeCliente.TabIndex = 6;
            this.textBoxNomeCliente.TextChanged += new System.EventHandler(this.textBoxNomeCliente_TextChanged);
            // 
            // textBoxNifCliente
            // 
            this.textBoxNifCliente.Location = new System.Drawing.Point(77, 52);
            this.textBoxNifCliente.Name = "textBoxNifCliente";
            this.textBoxNifCliente.Size = new System.Drawing.Size(132, 20);
            this.textBoxNifCliente.TabIndex = 7;
            this.textBoxNifCliente.TextChanged += new System.EventHandler(this.textBoxNifCliente_TextChanged);
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(71, 104);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(139, 20);
            this.textBoxContacto.TabIndex = 9;
            this.textBoxContacto.TextChanged += new System.EventHandler(this.textBoxContacto_TextChanged);
            // 
            // comboBoxMorada
            // 
            this.comboBoxMorada.FormattingEnabled = true;
            this.comboBoxMorada.Items.AddRange(new object[] {
            "Leiria",
            "Porto"});
            this.comboBoxMorada.Location = new System.Drawing.Point(70, 78);
            this.comboBoxMorada.Name = "comboBoxMorada";
            this.comboBoxMorada.Size = new System.Drawing.Size(133, 21);
            this.comboBoxMorada.TabIndex = 10;
            this.comboBoxMorada.SelectedIndexChanged += new System.EventHandler(this.comboBoxMorada_SelectedIndexChanged);
            // 
            // textBoxNomeAlterar
            // 
            this.textBoxNomeAlterar.Enabled = false;
            this.textBoxNomeAlterar.Location = new System.Drawing.Point(84, 28);
            this.textBoxNomeAlterar.Name = "textBoxNomeAlterar";
            this.textBoxNomeAlterar.Size = new System.Drawing.Size(148, 20);
            this.textBoxNomeAlterar.TabIndex = 11;
            this.textBoxNomeAlterar.TextChanged += new System.EventHandler(this.textBoxNomeAlterar_TextChanged);
            // 
            // comboBoxMoradaAlterar
            // 
            this.comboBoxMoradaAlterar.Enabled = false;
            this.comboBoxMoradaAlterar.FormattingEnabled = true;
            this.comboBoxMoradaAlterar.Items.AddRange(new object[] {
            "Leiria",
            "Porto"});
            this.comboBoxMoradaAlterar.Location = new System.Drawing.Point(84, 87);
            this.comboBoxMoradaAlterar.Name = "comboBoxMoradaAlterar";
            this.comboBoxMoradaAlterar.Size = new System.Drawing.Size(148, 21);
            this.comboBoxMoradaAlterar.TabIndex = 13;
            this.comboBoxMoradaAlterar.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoradaAlterar_SelectedIndexChanged);
            // 
            // textBoxNifAlterar
            // 
            this.textBoxNifAlterar.Enabled = false;
            this.textBoxNifAlterar.Location = new System.Drawing.Point(84, 56);
            this.textBoxNifAlterar.Name = "textBoxNifAlterar";
            this.textBoxNifAlterar.Size = new System.Drawing.Size(148, 20);
            this.textBoxNifAlterar.TabIndex = 12;
            this.textBoxNifAlterar.TextChanged += new System.EventHandler(this.textBoxNifAlterar_TextChanged);
            // 
            // textBoxContactoAlterar
            // 
            this.textBoxContactoAlterar.Enabled = false;
            this.textBoxContactoAlterar.Location = new System.Drawing.Point(84, 114);
            this.textBoxContactoAlterar.Name = "textBoxContactoAlterar";
            this.textBoxContactoAlterar.Size = new System.Drawing.Size(148, 20);
            this.textBoxContactoAlterar.TabIndex = 14;
            this.textBoxContactoAlterar.TextChanged += new System.EventHandler(this.textBoxContactoAlterar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nif Cliente:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Morada:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Contacto:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonAtualizarCliente
            // 
            this.buttonAtualizarCliente.Location = new System.Drawing.Point(227, 215);
            this.buttonAtualizarCliente.Name = "buttonAtualizarCliente";
            this.buttonAtualizarCliente.Size = new System.Drawing.Size(101, 77);
            this.buttonAtualizarCliente.TabIndex = 19;
            this.buttonAtualizarCliente.Text = "Atualizar Cliente";
            this.buttonAtualizarCliente.UseVisualStyleBackColor = true;
            this.buttonAtualizarCliente.Click += new System.EventHandler(this.buttonAtualizarCliente_Click);
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.Location = new System.Drawing.Point(227, 298);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(101, 74);
            this.buttonEliminarCliente.TabIndex = 20;
            this.buttonEliminarCliente.Text = "Eliminar Cliente";
            this.buttonEliminarCliente.UseVisualStyleBackColor = true;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // buttonGuardarAlteracoes
            // 
            this.buttonGuardarAlteracoes.Enabled = false;
            this.buttonGuardarAlteracoes.Location = new System.Drawing.Point(159, 140);
            this.buttonGuardarAlteracoes.Name = "buttonGuardarAlteracoes";
            this.buttonGuardarAlteracoes.Size = new System.Drawing.Size(73, 43);
            this.buttonGuardarAlteracoes.TabIndex = 21;
            this.buttonGuardarAlteracoes.Text = "Guardar";
            this.buttonGuardarAlteracoes.UseVisualStyleBackColor = true;
            this.buttonGuardarAlteracoes.Click += new System.EventHandler(this.buttonGuardarAlteracoes_Click);
            // 
            // buttonCancelarAtua
            // 
            this.buttonCancelarAtua.Enabled = false;
            this.buttonCancelarAtua.Location = new System.Drawing.Point(80, 140);
            this.buttonCancelarAtua.Name = "buttonCancelarAtua";
            this.buttonCancelarAtua.Size = new System.Drawing.Size(73, 43);
            this.buttonCancelarAtua.TabIndex = 22;
            this.buttonCancelarAtua.Text = "Cancelar";
            this.buttonCancelarAtua.UseVisualStyleBackColor = true;
            this.buttonCancelarAtua.Click += new System.EventHandler(this.buttonCancelarAtua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxNomeClientes);
            this.groupBox1.Controls.Add(this.buttonAdicionarCliente);
            this.groupBox1.Controls.Add(this.buttonEliminarCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonAtualizarCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNomeCliente);
            this.groupBox1.Controls.Add(this.textBoxNifCliente);
            this.groupBox1.Controls.Add(this.textBoxContacto);
            this.groupBox1.Controls.Add(this.comboBoxMorada);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 393);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Clientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxNomeAlterar);
            this.groupBox2.Controls.Add(this.buttonCancelarAtua);
            this.groupBox2.Controls.Add(this.textBoxNifAlterar);
            this.groupBox2.Controls.Add(this.buttonGuardarAlteracoes);
            this.groupBox2.Controls.Add(this.comboBoxMoradaAlterar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxContactoAlterar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(352, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 259);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar Dados";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelContactoCliente);
            this.groupBox3.Controls.Add(this.labelMoradaCliente);
            this.groupBox3.Controls.Add(this.labelNifCliente);
            this.groupBox3.Controls.Add(this.labelNomeCliente);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(353, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 128);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Cliente";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelContactoCliente
            // 
            this.labelContactoCliente.AutoSize = true;
            this.labelContactoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactoCliente.Location = new System.Drawing.Point(98, 104);
            this.labelContactoCliente.Name = "labelContactoCliente";
            this.labelContactoCliente.Size = new System.Drawing.Size(0, 13);
            this.labelContactoCliente.TabIndex = 7;
            this.labelContactoCliente.Click += new System.EventHandler(this.labelContactoCliente_Click);
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoradaCliente.Location = new System.Drawing.Point(98, 78);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(0, 13);
            this.labelMoradaCliente.TabIndex = 6;
            this.labelMoradaCliente.Click += new System.EventHandler(this.labelMoradaCliente_Click);
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.AutoSize = true;
            this.labelNifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifCliente.Location = new System.Drawing.Point(98, 52);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(0, 13);
            this.labelNifCliente.TabIndex = 5;
            this.labelNifCliente.Click += new System.EventHandler(this.labelNifCliente_Click);
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(98, 26);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(0, 13);
            this.labelNomeCliente.TabIndex = 4;
            this.labelNomeCliente.Click += new System.EventHandler(this.labelNomeCliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Contacto:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Morada:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nif Cliente:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nome Cliente:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // GestaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 407);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestaoCliente";
            this.Text = "GestaoCliente";
            this.Load += new System.EventHandler(this.GestaoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNomeClientes;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxNifCliente;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.ComboBox comboBoxMorada;
        private System.Windows.Forms.TextBox textBoxNomeAlterar;
        private System.Windows.Forms.ComboBox comboBoxMoradaAlterar;
        private System.Windows.Forms.TextBox textBoxNifAlterar;
        private System.Windows.Forms.TextBox textBoxContactoAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAtualizarCliente;
        private System.Windows.Forms.Button buttonEliminarCliente;
        private System.Windows.Forms.Button buttonGuardarAlteracoes;
        private System.Windows.Forms.Button buttonCancelarAtua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelContactoCliente;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}