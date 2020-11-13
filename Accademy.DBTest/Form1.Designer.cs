namespace Accademy.DBTest
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
            this.btn_clienti = new System.Windows.Forms.Button();
            this.lst_clienti = new System.Windows.Forms.ListBox();
            this.lst_ContiCorrenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_clienti
            // 
            this.btn_clienti.Location = new System.Drawing.Point(54, 48);
            this.btn_clienti.Name = "btn_clienti";
            this.btn_clienti.Size = new System.Drawing.Size(103, 31);
            this.btn_clienti.TabIndex = 0;
            this.btn_clienti.Text = "Clienti";
            this.btn_clienti.UseVisualStyleBackColor = true;
            this.btn_clienti.Click += new System.EventHandler(this.btn_clienti_Click);
            // 
            // lst_clienti
            // 
            this.lst_clienti.FormattingEnabled = true;
            this.lst_clienti.ItemHeight = 20;
            this.lst_clienti.Location = new System.Drawing.Point(54, 114);
            this.lst_clienti.Name = "lst_clienti";
            this.lst_clienti.Size = new System.Drawing.Size(224, 204);
            this.lst_clienti.TabIndex = 1;
            this.lst_clienti.SelectedIndexChanged += new System.EventHandler(this.lst_clienti_SelectedIndexChanged);
            // 
            // lst_ContiCorrenti
            // 
            this.lst_ContiCorrenti.FormattingEnabled = true;
            this.lst_ContiCorrenti.ItemHeight = 20;
            this.lst_ContiCorrenti.Location = new System.Drawing.Point(414, 114);
            this.lst_ContiCorrenti.Name = "lst_ContiCorrenti";
            this.lst_ContiCorrenti.Size = new System.Drawing.Size(222, 204);
            this.lst_ContiCorrenti.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_ContiCorrenti);
            this.Controls.Add(this.lst_clienti);
            this.Controls.Add(this.btn_clienti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clienti;
        private System.Windows.Forms.ListBox lst_clienti;
        private System.Windows.Forms.ListBox lst_ContiCorrenti;
    }
}

