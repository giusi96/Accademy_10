using Accademy.Entities;
using DataManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.DataManager
{
    public class FyleSistemDataManager: IDataManager
    {
        private string bankDir= @"C:\Users\giusi.balsamo\Desktop\MicrosoftAccademy\temp\BancaDati";
        private string usersFilename;
        private string clientiFilename;
        private string CCFilename;
        private string movimentiFilename;
        public FyleSistemDataManager()
        {
            usersFilename = System.IO.Path.Combine(bankDir, "Users.txt");
            clientiFilename = System.IO.Path.Combine(bankDir, "Clienti.txt");
            CCFilename = System.IO.Path.Combine(bankDir, "ContoCorrenti.txt");
            movimentiFilename = System.IO.Path.Combine(bankDir, "Movimenti.txt");
        }
       

        public bool LoginIsOK(string username, string password)
        {
            //deve leggere in txt e verificare che in mariorossi ci sia la password effettivamente scritta

            bool result = false;

            string line;
            char[] chararray = new char[1];
            chararray[0] = ';';
            System.IO.StreamReader file = new System.IO.StreamReader(usersFilename);
            while ((line = file.ReadLine()) != null)
            {
                String[] resultArray = line.Split(chararray);

                if (username==resultArray[0] && password==resultArray[1])
                {                  
                        result = true;
                        break;
                }
            }
            return (result);                      
        }

        public bool IsAnOwner(string username)
        {
            bool result = false;

            string line;
            char[] chararray = new char[1];
            chararray[0] = ';';
            using (System.IO.StreamReader file = new System.IO.StreamReader(CCFilename))
            {
                while ((line = file.ReadLine()) != null)
                {
                    String[] resultArray = line.Split(chararray);

                    if (username == resultArray[2])
                    {
                        result = true;
                        break;
                    }
                }
                file.Close(); 
            }
            return (result);
        }

        public DataOperationResult CreatenewCliente(Cliente newCliente)
        {
            DataOperationResult result = new DataOperationResult();
            //scrivere una riga in Clienti.txt
            try
            {
                using (
                    System.IO.StreamWriter sw_clienti = File.AppendText(clientiFilename))
                {
                    string s_new_cliente = newCliente.Username + ";" +
                                         newCliente.FirstName + ";" +
                                         newCliente.LastName + ";" +
                                         newCliente.CF;
                    sw_clienti.WriteLine(s_new_cliente);
                    sw_clienti.Close();
                }

                using (System.IO.StreamWriter sw_cc = File.AppendText(CCFilename))
                {
                    ContoCorrente newCC = newCliente.mioConto;
                    string s_newcc = newCC.GetNumeroConto() + ";" + newCC.GetSaldo() + ";" + newCliente.Username;

                    sw_cc.WriteLine(s_newcc);
                    sw_cc.Close();  
                }
                
                result.IsOk = true;
            }
            catch (Exception excp)
            {
                result.IsOk = false;
                result.Message = excp.Message;              
            }
           
            return result;
        }

        public ContoCorrente GetContoCorrenteByUsername(string username)
        {  ContoCorrente cc_result = null;

            using (System.IO.StreamReader file = new System.IO.StreamReader(CCFilename))
            {
                string line;
                char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
                chararray[0] = ';';
                while (!String.IsNullOrEmpty(line = file.ReadLine())) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
                {
                    String[] resultArray = line.Split(chararray);
                    string current_user = resultArray[2];
                    if (username == current_user)
                    {
                        cc_result = new ContoCorrente(resultArray[0]);
                        break;
                    }
                }
                file.Close();
            }

            return cc_result;
        }

    }
}
