namespace Accademy.Bank
{
    partial class OpenCCForm
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
            this.btn_Conferma = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Annulla = new System.Windows.Forms.Button();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_NumeroConto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cognome = new System.Windows.Forms.TextBox();
            this.txt_CF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(227, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apertura Conto Corrente";
            // 
            // btn_Conferma
            // 
            this.btn_Conferma.Location = new System.Drawing.Point(39, 314);
            this.btn_Conferma.Name = "btn_Conferma";
            this.btn_Conferma.Size = new System.Drawing.Size(152, 67);
            this.btn_Conferma.TabIndex = 1;
            this.btn_Conferma.Text = "Conferma";
            this.btn_Conferma.UseVisualStyleBackColor = true;
            this.btn_Conferma.Click += new System.EventHandler(this.btn_Conferma_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(646, 390);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(126, 39);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Conto Corrente:";
            // 
            // btn_Annulla
            // 
            this.btn_Annulla.Location = new System.Drawing.Point(285, 314);
            this.btn_Annulla.Name = "btn_Annulla";
            this.btn_Annulla.Size = new System.Drawing.Size(152, 67);
            this.btn_Annulla.TabIndex = 5;
            this.btn_Annulla.Text = "Annulla";
            this.btn_Annulla.UseVisualStyleBackColor = true;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(143, 80);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(0, 20);
            this.lbl_cliente.TabIndex = 6;
            // 
            // lbl_NumeroConto
            // 
            this.lbl_NumeroConto.AutoSize = true;
            this.lbl_NumeroConto.Location = new System.Drawing.Point(260, 130);
            this.lbl_NumeroConto.Name = "lbl_NumeroConto";
            this.lbl_NumeroConto.Size = new System.Drawing.Size(0, 20);
            this.lbl_NumeroConto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cognome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CF:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(157, 179);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(202, 26);
            this.txt_nome.TabIndex = 11;
            // 
            // txt_cognome
            // 
            this.txt_cognome.Location = new System.Drawing.Point(157, 215);
            this.txt_cognome.Name = "txt_cognome";
            this.txt_cognome.Size = new System.Drawing.Size(202, 26);
            this.txt_cognome.TabIndex = 12;
            // 
            // txt_CF
            // 
            this.txt_CF.Location = new System.Drawing.Point(157, 256);
            this.txt_CF.Name = "txt_CF";
            this.txt_CF.Size = new System.Drawing.Size(202, 26);
            this.txt_CF.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // OpenCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CF);
            this.Controls.Add(this.txt_cognome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_NumeroConto);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.btn_Annulla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Conferma);
            this.Controls.Add(this.label1);
            this.Name = "OpenCCForm";
            this.Text = "OpenCCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Conferma;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Annulla;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_NumeroConto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cognome;
        private System.Windows.Forms.TextBox txt_CF;
        private System.Windows.Forms.Label label7;
    }
}