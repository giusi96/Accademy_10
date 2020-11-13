using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clienti_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=WINAPPM2JMGI3WG\SQLEXPRESS;Initial Catalog=AccademyDB;Integrated Security=True";
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlcmdText = "SELECT [ID],[FirstName],[LastName],[FiscalCode] FROM[AccademyDB].[dbo].[Clients]";
                SqlCommand cmd = new SqlCommand(sqlcmdText, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader(); //restituisce un record

                while (dr.Read())
                {
                    string id = dr[0].ToString();
                    string firstName = dr[1].ToString();
                    string lastName = dr[2].ToString();

                    string item = id + " " + firstName + " " + lastName;
                    this.lst_clienti.Items.Add(item);
                }
                conn.Close(); 
            }
        }

        private void lst_clienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = this.lst_clienti.SelectedItem.ToString();
            string[] splitedString = item.Split(new char[] { ' ' });
            int ID = Int32.Parse(splitedString[0]);
        }
    }
}
