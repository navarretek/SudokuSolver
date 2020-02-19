

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
            this.Solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 9);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(768, 556);
            this.display.TabIndex = 0;
            this.display.Text = "9";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(814, 85);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(97, 70);
            this.Solve.TabIndex = 1;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 574);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label display;
        private Button Solve;
    }
}

