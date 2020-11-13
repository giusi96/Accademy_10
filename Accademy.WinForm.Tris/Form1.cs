using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.WinForm.Tris
{
    public partial class Form1 : Form
    {
        private Moves lastMove; // "X" oppure "O"
        private int[,] matrix = new int[3, 3];

        public Form1()
        {
            lastMove = Moves.NoMoveYet;
            InitializeComponent();
           
            initTris();
        }

        #region txt correct boolean variables

        private bool txt_00_IsCorrect = false;
        private bool txt_01_IsCorrect = false;
        private bool txt_02_IsCorrect = false;
        private bool txt_10_IsCorrect = false;
        private bool txt_11_IsCorrect = false;
        private bool txt_12_IsCorrect = false;
        private bool txt_20_IsCorrect = false;
        private bool txt_21_IsCorrect = false;
        private bool txt_22_IsCorrect = false;

        #endregion

        #region text changed

        private void txt_00_TextChanged(object sender, EventArgs e)
        {
            //this.label1.Text = "Coordinate [0,0]";
            //switch (lastMove)
            //{
            //    case Moves.X:
            //        if (this.txt_00.Text == "X")
            //        {
            //            this.txt_00.Text = "";
            //            this.lbl_error.Text = "E' il turno di B";
            //        }
            //        else if (this.txt_00.Text == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_00.Enabled = false;
            //        }
            //        else
            //        {
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.O:
            //        if (this.txt_00.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;

            //            this.txt_00.Enabled = false;
            //        }
            //        else if (this.txt_00.Text.ToUpper() == "O")
            //        {
            //            this.txt_00.Text = "";
            //            this.lbl_error.Text = "E' il turno di A";
            //        }
            //        else
            //        {
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.NoMoveYet:
            //        if (this.txt_00.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;
            //            this.txt_00.Enabled = false;
            //        }
            //        else if (this.txt_00.Text.ToUpper() == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_00.Enabled = false;
            //        }
            //        else
            //        {
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    default:
            //        break;
            //}

        }

        private void txt_01_TextChanged(object sender, EventArgs e)
        {
            //this.label1.Text = "Coordinate [0,1]";
            //switch (lastMove)
            //{
            //    case Moves.X:
            //        if (this.txt_01.Text.ToUpper() == "X")
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "E' il turno di B";
            //        }
            //        else if (this.txt_01.Text.ToUpper() == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.O:
            //        if (this.txt_01.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else if (this.txt_01.Text.ToUpper() == "O")
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "E' il turno di A";
            //        }
            //        else
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.NoMoveYet:
            //        if (this.txt_01.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else if (this.txt_01.Text.ToUpper() == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    default:
            //        break;
            //}

        }

        private void txt_02_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_22_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }

   
}
