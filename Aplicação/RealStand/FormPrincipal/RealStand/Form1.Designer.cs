namespace RealStand
{
    partial class Form1
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
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonGestaoCarroOficina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Real Stand";
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(18, 68);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(184, 85);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Gestão de Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonGestaoCarroOficina
            // 
            this.buttonGestaoCarroOficina.Location = new System.Drawing.Point(222, 68);
            this.buttonGestaoCarroOficina.Name = "buttonGestaoCarroOficina";
            this.buttonGestaoCarroOficina.Size = new System.Drawing.Size(184, 85);
            this.buttonGestaoCarroOficina.TabIndex = 2;
            this.buttonGestaoCarroOficina.Text = "Gestão de Carros Oficina";
            this.buttonGestaoCarroOficina.UseVisualStyleBackColor = true;
            this.buttonGestaoCarroOficina.Click += new System.EventHandler(this.buttonGestaoCarroOficina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 381);
            this.Controls.Add(this.buttonGestaoCarroOficina);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonGestaoCarroOficina;
    }
}

