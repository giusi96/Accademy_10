using Accademy.DataManager;
using Accademy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Bank
{
    public partial class ManageCCForm : Form
    {
        private string CCFilename;
        private string bankDir = @"C:\Users\giusi.balsamo\Desktop\MicrosoftAccademy\temp\BancaDati";
        private string saldo;
        private Accademy.DataManager.IDataManager dataManager;

        public ManageCCForm()
        {
            dataManager = new FyleSistemDataManager();
            InitializeComponent();
        }
        public ManageCCForm(string numconto)
        {
            InitializeComponent();
            this.lbl_cc.Text = numconto; 
            CCFilename = System.IO.Path.Combine(bankDir, "ContoCorrenti.txt");
            using (System.IO.StreamReader file = new System.IO.StreamReader(CCFilename))
            {
                string line;
                char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
                chararray[0] = ';';
                while (!String.IsNullOrEmpty(line = file.ReadLine())) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
                {
                    String[] resultArray = line.Split(chararray);
                    saldo= resultArray[1];
                    lbl_saldo.Text = saldo;
                }               
                file.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = (LoginForm)Tag;
            loginform.Close();
        }

        private void btn_preleva_Click(object sender, EventArgs e)
        {

        }

        private void btn_versa_Click(object sender, EventArgs e)
        {
            string imp = txt_importo.Text;
            double importo = Convert.ToDouble(imp);
  
            


        }
    }
}
