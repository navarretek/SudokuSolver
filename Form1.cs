using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        public static DataGenerator dg;

        public Form1()
        {
            InitializeComponent();
            dg = new DataGenerator();
            DisplayBoard(dg);
            
            
        }
        public bool SolveBoardBT(DataGenerator dg)
        {

            var find = FindEmpty(dg);
            //if theres no empty that means the puzzle is solved
            if (find == null) return true;
            else
            {
                //iterate thru possible answeres 1-9
                for (int i = 1; i < 10; i++)
                {
                    //check if anser is valid, and able to be inserted. via game rules.
                    if (valid(dg, i, find)){
                        //sets the answer to the box
                        //       row     column
                        dg.Cells[find[0], find[1]] = i;
                        // continue to next iteration of this method.. next box
                        if (SolveBoardBT(dg)) return true;
                        // if return false, it backtracked so need to reset back to 0
                        dg.Cells[find[0], find[1]] = 0;

                    }
                    //continue until all numbers are tried
                }
                //if no more answers are valid 
                return false;
            }
        }

        public bool valid(DataGenerator dg, int num, int[] pos)
        {
            //row
            for (int i = 0; i < dg.Cells.GetLength(0); i++)
            {
                if (dg.Cells[pos[0], i] == num && pos[1] != i) return false;               
            }
            //column
            for (int i = 0; i < dg.Cells.GetLength(1); i++)
            {
                if (dg.Cells[i, pos[1]] == num && pos[0] != i) return false;
            }
            //box
           int box_x = pos[1] / 3; 
           int box_y = pos[0] / 3;
            for (int i = box_y * 3; i < box_y * 3 + 3; i++)
            {
                for (int j = box_x * 3;  j < box_x * 3 + 3;  j++)
                {
                    if (dg.Cells[i, j] == num && i != pos[0] && j != pos[1]) return false;
                }
            }
            return true;
        }
        public void DisplayBoard(DataGenerator dg)
        {
            string board = "";
            int height = dg.Cells.GetLength(0);
            int width = dg.Cells.GetLength(1);

            for (int i = 0; i < height;i++)
            {
                if (i % 3 == 0 && i != 0) board += "-----------------------------" + "\n";
                for (int j = 0; j < width; j++)
                {
                    if (j % 3 == 0 && j != 0) board += " | ";
                    if (dg.Cells[i, j] == 0 && j == 8) board += dg.Cells[i, j].ToString().Replace('0', '_') + "\n";
                    else if (j == 8) board += dg.Cells[i, j] + "\n";
                    else if (dg.Cells[i, j] == 0 ) board += dg.Cells[i, j].ToString().Replace('0', '_') + " ";
                    else board += dg.Cells[i, j] + " ";
                }
            }
            display.Text = board;
        }

        public int[] FindEmpty(DataGenerator dg)
        {
            int height = dg.Cells.GetLength(0);
            int width = dg.Cells.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (dg.Cells[i,j] == 0) return new int[] {i,j};
                }
            }
            return null;
        }
       

        private void Solve_Click(object sender, EventArgs e)
        {
            var s = SolveBoardBT(dg);
            DisplayBoard(dg);
        }
    }
}
