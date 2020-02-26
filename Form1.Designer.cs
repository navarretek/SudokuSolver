

using System.Drawing;
using System.Windows.Forms;

namespace SudokuSolver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.SolveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.FilePathErrorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 9);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(387, 299);
            this.display.TabIndex = 0;
            this.display.Text = "9";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SolveBtn
            // 
            this.SolveBtn.Location = new System.Drawing.Point(115, 343);
            this.SolveBtn.Name = "SolveBtn";
            this.SolveBtn.Size = new System.Drawing.Size(97, 70);
            this.SolveBtn.TabIndex = 1;
            this.SolveBtn.Text = "Solve";
            this.SolveBtn.UseVisualStyleBackColor = true;
            this.SolveBtn.Click += new System.EventHandler(this.Solve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(405, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(12, 311);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(97, 26);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FileName
            // 
            this.FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileName.Location = new System.Drawing.Point(115, 317);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(263, 20);
            this.FileName.TabIndex = 4;
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(12, 343);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(97, 70);
            this.DisplayBtn.TabIndex = 5;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // FilePathErrorLbl
            // 
            this.FilePathErrorLbl.AutoSize = true;
            this.FilePathErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.FilePathErrorLbl.Location = new System.Drawing.Point(227, 343);
            this.FilePathErrorLbl.Name = "FilePathErrorLbl";
            this.FilePathErrorLbl.Size = new System.Drawing.Size(136, 13);
            this.FilePathErrorLbl.TabIndex = 6;
            this.FilePathErrorLbl.Text = "No valid file path to display!";
            this.FilePathErrorLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 593);
            this.Controls.Add(this.FilePathErrorLbl);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SolveBtn);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label display;
        private Button SolveBtn;
        private PictureBox pictureBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button BrowseBtn;
        private Label FileName;
        private Button DisplayBtn;
        private Label FilePathErrorLbl;
    }
}

