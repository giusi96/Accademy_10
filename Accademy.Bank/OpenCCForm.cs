using Accademy.DataManager;
using Accademy.Entities;
using DataManager;
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
    public partial class OpenCCForm : Form
    {
        private IDataManager dataManager;

        public string CurrentUser;
        public OpenCCForm()
        {
            dataManager = new FyleSistemDataManager();
            InitializeComponent();
            
        }
        public OpenCCForm(string username)
        {
            InitializeComponent();
            dataManager = new FyleSistemDataManager();
            this.CurrentUser = username;
            this.lbl_cliente.Text = CurrentUser;
            string numConto = Accademy.Helper.Helper.GetNumConto(20);
            this.lbl_NumeroConto.Text = numConto;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = (LoginForm)Tag;
            loginform.Close();
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            string username = this.lbl_cliente.Text;
            string numconto = this.lbl_NumeroConto.Text;
            string nome = this.txt_nome.Text;
            string cognome = this.txt_cognome.Text;
            string codfisc = this.txt_CF.Text;

            ContoCorrente newCC = new ContoCorrente(numconto);
            

            Cliente newCliente = new Cliente()
            {
                Username = username,
                FirstName = nome,
                LastName = cognome,
                CF = codfisc,
                mioConto = newCC
                
            };

            DataOperationResult result = dataManager.CreatenewCliente(newCliente);
            if (result.IsOk)
            {
                ManageCCForm manageForm = new ManageCCForm(numconto);
                manageForm.Tag = this;
                manageForm.Show();
                this.Hide();
            }
            else
            {
                this.label7.Text = result.Message;
            }

        }
    }

}
