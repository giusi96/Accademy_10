using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.WinForm.Tris
{
    partial class Form1
    {
        private void initTris()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = 0;
            }
        }

        private new void Move(int player, int i, int j) //new-> perchè abbiamo già un metodo che si chiami Move. Bata cambiare il nome ed evitare il new(PlayerMove)
        {
            matrix[i, j] = player;   
        }




        private void IsWinner(string player)
        {
            if (player == "A")
            {

            }
            else
            {

            }
        }









    }
}
