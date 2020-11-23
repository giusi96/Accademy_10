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
    public partial class LoginForm : Form   //partial: suddivisione in più file della definizione di una classe
    {
        private Accademy.DataManager.IDataManager dataManager;

        public LoginForm()
        {
            dataManager = new FyleSistemDataManager();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //se le credenziali sono corrette ti indirizzo all'altra interfaccia grafica,
            //altrimenti ti dò un messaggio di errore
            //Per verificare le credenziali, devo creare un'altra classe

            string username = this.txt_User.Text;
            string password = this.txt_Password.Text;

            if (dataManager.LoginIsOK(username,password))
            {
                if (dataManager.IsAnOwner(username)) //se è già un cliente, allora vado in ManageForm
                {
                    ContoCorrente cc= dataManager.GetContoCorrenteByUsername(username);
                    ManageCCForm manageForm = new ManageCCForm(cc.GetNumeroConto());
                    manageForm.Tag = this;
                    manageForm.Show();
                    this.Hide();
                }
                else  //se non è cliente, quindi non ha un conto corrente, vado in OpenForm per aprirne uno
                {
                    //OpenCCForm openForm = new OpenCCForm();
                    //openForm.CurrentUser = username;
                    OpenCCForm openForm=new OpenCCForm(username);
                    openForm.Tag = this; //this è il puntatore
                    openForm.Show();
                    this.Hide();
                }
                lbl_error.Text = "";                
            }
            else
            {
                this.lbl_error.Text = "Nome utente e/o password errati";
            }
        }       
    }
}
