using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class DataGenerator
    {
        public int[,]  Cells { get; set; }
        public DataGenerator()
        {
            Cells = GenerateBoard();
        }
        
        public int[,] GenerateBoard()
        {
            int[,] cells = new int[,] { 
                {5,3,0, 0,7,0, 0,0,0},
                {6,0,0, 1,9,5, 0,0,0},
                {0,9,8, 0,0,0, 0,6,0},
                
                {8,0,0, 0,6,0, 0,0,3},
                {4,0,0, 8,0,3, 0,0,1},
                {7,0,0, 0,2,0, 0,0,6},
                
                {0,6,0, 0,0,0, 2,8,0},
                {0,0,0, 4,1,9, 0,0,5},
                {0,0,0, 0,8,0, 0,7,9}
            };
            return cells;
            /*//create "board"
            int[,,] cells = new int[,,] {
                {
                    // section 1
                    {5,3,0},
                    {6,0,0},
                    {0,9,8},
                },{
                    // section 2
                    {0,8,0},
                    {1,9,5},
                    {0,0,0}
                },{
                    // section 3
                    {0,0,0},
                    {0,0,0},
                    {0,6,0}
                },{
                    // section 4
                    {8,0,0},
                    {4,0,0},
                    {7,0,0}
                },{
                    // section 5
                    {0,6,0},
                    {8,0,3},
                    {0,2,0}
                },{
                    // section 6
                    {0,0,3},
                    {0,0,1},
                    {0,0,6}
                },{
                    // section 7
                    {0,6,0},
                    {0,0,0},
                    {0,0,0}
                },{
                    // section 8
                    {0,0,0},
                    {4,1,9},
                    {0,8,0}
                },{
                    // section 9
                    {2,8,0},
                    {0,0,5},
                    {0,7,9}
                }
            };*/
        }
        
    }
}
