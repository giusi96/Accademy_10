using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.WinForm.Tris
{
    partial class Form1
    {
        private void txt_10_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            txt_10_IsCorrect = false;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_10_IsCorrect = true;
                }
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_10_IsCorrect = true;
                }
            }
            else
            {
                this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
                e.Handled = true;
            }

        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void txt_10_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (txt_10_IsCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 88)
                        {
                            this.lbl_error.Text = "E' il turno di B";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_10.Enabled = false;
                            IsWinner("B");
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_10.Enabled = false;
                            IsWinner("A");
                        }
                        else
                        {
                            this.lbl_error.Text = "E' il turno di A";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_10.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_10.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
            else
                e.Handled = true;
        }

        private void txt_11_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            txt_11_IsCorrect = false;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_11_IsCorrect = true;
                }
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_11_IsCorrect = true;
                }
            }
            else
            {
                this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
                e.Handled = true;
            }

        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void txt_11_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (txt_11_IsCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 88)
                        {
                            this.lbl_error.Text = "E' il turno di B";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_11.Enabled = false;
                            IsWinner("B");
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_11.Enabled = false;
                            IsWinner("A");
                        }
                        else
                        {
                            this.lbl_error.Text = "E' il turno di A";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_11.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_11.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
            else
                e.Handled = true;
        }

        private void txt_12_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            txt_12_IsCorrect = false;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_12_IsCorrect = true;
                }
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_12_IsCorrect = true;
                }
            }
            else
            {
                this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
                e.Handled = true;
            }

        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void txt_12_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (txt_12_IsCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 88)
                        {
                            this.lbl_error.Text = "E' il turno di B";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_12.Enabled = false;
                            IsWinner("B");
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_12.Enabled = false;
                            IsWinner("A");
                        }
                        else
                        {
                            this.lbl_error.Text = "E' il turno di A";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_12.Enabled = false;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_12.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
            else
                e.Handled = true;
        }
    }
}
