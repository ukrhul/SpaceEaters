namespace SpaceEaters
{
    partial class frmrectangularCalculator
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
            this.components = new System.ComponentModel.Container();
            this.lblOutputPerimeter = new System.Windows.Forms.Label();
            this.lblOutputArea = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblRectangle = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.RectangleCalculator = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOutputPerimeter
            // 
            this.lblOutputPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputPerimeter.Location = new System.Drawing.Point(153, 181);
            this.lblOutputPerimeter.Name = "lblOutputPerimeter";
            this.lblOutputPerimeter.Size = new System.Drawing.Size(87, 20);
            this.lblOutputPerimeter.TabIndex = 9;
            // 
            // lblOutputArea
            // 
            this.lblOutputArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputArea.Location = new System.Drawing.Point(34, 181);
            this.lblOutputArea.Name = "lblOutputArea";
            this.lblOutputArea.Size = new System.Drawing.Size(75, 20);
            this.lblOutputArea.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(104, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Re&set";
            this.RectangleCalculator.SetToolTip(this.btnReset, "Click to reset the form");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(92, 137);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "OUTPUT";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRectangle
            // 
            this.lblRectangle.AutoSize = true;
            this.lblRectangle.Location = new System.Drawing.Point(92, 19);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(56, 13);
            this.lblRectangle.TabIndex = 0;
            this.lblRectangle.Text = "Rectangle";
            this.lblRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(31, 154);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(150, 154);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(51, 13);
            this.lblPerimeter.TabIndex = 7;
            this.lblPerimeter.Text = "Perimeter";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 219);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.RectangleCalculator.SetToolTip(this.btnCalculate, "Click to calculate the Area and Perimeter of Rectangle");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(153, 102);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 4;
            this.RectangleCalculator.SetToolTip(this.txtWidth, "Enter Width of the rectangle");
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(153, 49);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            this.RectangleCalculator.SetToolTip(this.txtLength, "Enter Length of the rectangle ");
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(42, 102);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Wi&dth";
            // 
            // lblLength
            // 
            this.lblLength.Location = new System.Drawing.Point(42, 52);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "&Length:";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "&Exit";
            this.RectangleCalculator.SetToolTip(this.btnExit, "Cilck to exit the form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmrectangularCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutputPerimeter);
            this.Controls.Add(this.lblOutputArea);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblRectangle);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmrectangularCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Eaters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutputPerimeter;
        private System.Windows.Forms.Label lblOutputArea;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip RectangleCalculator;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnExit;
    }
}

