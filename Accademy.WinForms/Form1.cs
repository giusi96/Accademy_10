using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string citta = this.comboBox1.SelectedItem.ToString();
            this.label2.Text = "Hai selezionato " + citta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Hello";
        }
    }
}
