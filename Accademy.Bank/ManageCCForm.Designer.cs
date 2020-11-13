namespace Accademy.Bank
{
    partial class ManageCCForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_cc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_versa = new System.Windows.Forms.Button();
            this.btn_preleva = new System.Windows.Forms.Button();
            this.txt_importo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_beneficiario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eseguibonifico = new System.Windows.Forms.Button();
            this.txt_impBonifico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(34, 33);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(251, 20);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Gestione Conto Corrente Numero:";
            // 
            // lbl_cc
            // 
            this.lbl_cc.AutoSize = true;
            this.lbl_cc.Location = new System.Drawing.Point(302, 33);
            this.lbl_cc.Name = "lbl_cc";
            this.lbl_cc.Size = new System.Drawing.Size(27, 20);
            this.lbl_cc.TabIndex = 1;
            this.lbl_cc.Text = "***";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(161, 75);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(27, 20);
            this.lbl_saldo.TabIndex = 3;
            this.lbl_saldo.Text = "***";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_versa);
            this.panel1.Controls.Add(this.btn_preleva);
            this.panel1.Controls.Add(this.txt_importo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(54, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 159);
            this.panel1.TabIndex = 4;
            // 
            // btn_versa
            // 
            this.btn_versa.Location = new System.Drawing.Point(204, 102);
            this.btn_versa.Name = "btn_versa";
            this.btn_versa.Size = new System.Drawing.Size(105, 35);
            this.btn_versa.TabIndex = 6;
            this.btn_versa.Text = "Versa";
            this.btn_versa.UseVisualStyleBackColor = true;
            this.btn_versa.Click += new System.EventHandler(this.btn_versa_Click);
            // 
            // btn_preleva
            // 
            this.btn_preleva.Location = new System.Drawing.Point(23, 102);
            this.btn_preleva.Name = "btn_preleva";
            this.btn_preleva.Size = new System.Drawing.Size(105, 35);
            this.btn_preleva.TabIndex = 5;
            this.btn_preleva.Text = "Preleva";
            this.btn_preleva.UseVisualStyleBackColor = true;
            this.btn_preleva.Click += new System.EventHandler(this.btn_preleva_Click);
            // 
            // txt_importo
            // 
            this.txt_importo.Location = new System.Drawing.Point(119, 39);
            this.txt_importo.Name = "txt_importo";
            this.txt_importo.Size = new System.Drawing.Size(190, 26);
            this.txt_importo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.txt_beneficiario);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_eseguibonifico);
            this.panel2.Controls.Add(this.txt_impBonifico);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(438, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 159);
            this.panel2.TabIndex = 7;
            // 
            // txt_beneficiario
            // 
            this.txt_beneficiario.Location = new System.Drawing.Point(119, 63);
            this.txt_beneficiario.Name = "txt_beneficiario";
            this.txt_beneficiario.Size = new System.Drawing.Size(190, 26);
            this.txt_beneficiario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beneficiario:";
            // 
            // btn_eseguibonifico
            // 
            this.btn_eseguibonifico.Location = new System.Drawing.Point(23, 102);
            this.btn_eseguibonifico.Name = "btn_eseguibonifico";
            this.btn_eseguibonifico.Size = new System.Drawing.Size(286, 35);
            this.btn_eseguibonifico.TabIndex = 5;
            this.btn_eseguibonifico.Text = "Esegui Bonifico";
            this.btn_eseguibonifico.UseVisualStyleBackColor = true;
            // 
            // txt_impBonifico
            // 
            this.txt_impBonifico.Location = new System.Drawing.Point(119, 24);
            this.txt_impBonifico.Name = "txt_impBonifico";
            this.txt_impBonifico.Size = new System.Drawing.Size(190, 26);
            this.txt_impBonifico.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Importo:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(59, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 184);
            this.panel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "MOVIMENTI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "BONIFICO";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(806, 569);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(109, 40);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // ManageCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 617);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cc);
            this.Controls.Add(this.lbl_title);
            this.Name = "ManageCCForm";
            this.Text = "ManageCCForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_cc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_versa;
        private System.Windows.Forms.Button btn_preleva;
        private System.Windows.Forms.TextBox txt_importo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_beneficiario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_eseguibonifico;
        private System.Windows.Forms.TextBox txt_impBonifico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label7;
    }
}