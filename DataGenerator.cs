using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using Emgu.CV;
using System.Drawing;
using Emgu.CV.Structure;
using System.IO;
using Tesseract;

namespace SudokuSolver
{
    public class DataGenerator
    {
        public int[,]  Cells { get; set; }
        public Bitmap image { get; set; }
        
        public DataGenerator()
        {
            Cells = GenerateDefaultBoard();
            InsertNumsToBoard(GetNumbersFromImg(@"../../Content/SudokuBoard.png"));
        }
        public DataGenerator(string ImgPath)
        {
            Cells = GenerateDefaultBoard();
            InsertNumsToBoard(GetNumbersFromImg(ImgPath));
        }
        public void InsertNumsToBoard(string nums)
        {
            int numIndex = 0;
         
            for (int i = 0; i < Cells.GetLength(0); i++)           
            {             
                for (int j = 0; j < Cells.GetLength(1); j++)             
                {           
                    Cells[i,j] = (int) char.GetNumericValue(nums[numIndex]);
                    numIndex++;
                }         
            }     
        }
        public string GetNumbersFromImg(string ImgPath)
        {

            var grayImage = new Image<Gray, byte>(ImgPath);
            //image = grayImage.ThresholdBinary(new Gray(78), new Gray(255)).ToBitmap();
            image = grayImage.ToBitmap();
            image = ResizeBitmap(image, 400, 400);



            
            var boxWidth = image.Width / 9 ;
            var boxHeight = image.Height / 9 ;

            //This for loop is ugly and i feel it could be done differently but i couldnt figure it out so i just did it because it works
            for (int i = 0; i < 10; i++)
            { 
                var AreaOfLineV = new System.Drawing.Rectangle() { X = boxWidth * i , Y = 0, Height = image.Height, Width = 1 };
                var AreaOfLineH = new System.Drawing.Rectangle() { X = 0, Y = boxHeight * i, Height = 1, Width = image.Width };

                using (Graphics graphics = Graphics.FromImage(image))
                {
                    using (Pen pen = new Pen(Color.White, 7))
                    {
                        graphics.DrawRectangle(pen, AreaOfLineV);
                        graphics.DrawRectangle(pen, AreaOfLineH);

                    }
                }
            }

            var OCR = new AutoOcr() { ReadBarCodes = false};
            
            var Results = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var Area = new System.Drawing.Rectangle() { X = boxWidth * j, Y = boxHeight * i, Height = boxHeight, Width = boxWidth };
                   
                    var result = OCR.Read(image, Area).ToString();
                    if (result.Equals("")) result = "0";
                    if (result.Equals("§")) result = "8";
                    if (result[0] < 48 && result[0] > 57) result = "";
                    Results += result;
                }
            }
            
            return Results;

        }
      
        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        public int[,] GenerateDefaultBoard()
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
        }
    }
}
