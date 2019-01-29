/* Program Name: ICE-14 "Space Eaters"
 * Programmed By: Rahul Upadhyay
 * Last Updated: April 05, 2017
 * 
 * Description: It is the windows form apllication to calculate the area and perimeter of the rectangle.
 *              User input the length of the rectangle in txtLength field and the width in txtWidth field.
 *              If user clicks the calcualte button then it will calculate the area and perimeter and display it in lblOutputArea and lblOutputPerimeter.
 *              If user clicks on Exit button it will close the form and if user clicks on Reset button it will reset the form. 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceEaters
{
    public partial class frmrectangularCalculator : Form
    {
        public frmrectangularCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is for when user changed the width text value
        /// </summary>
        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            lblOutputPerimeter.Text = "";   //set Perimeter Output to blank
            lblOutputArea.Text = "";        //set Area Output to blank
            txtLength.Focus();              //set focus to Length field
        }

        /// <summary>
        /// it is for calculate button and error messages. 
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declarations:

            decimal rectangleLength;
            decimal rectangleWidth;
            decimal rectangleArea;
            decimal rectanglePerimeter;

            if (Decimal.TryParse(txtLength.Text, out rectangleLength) && (rectangleLength > 0) == false) //check user input in length field is numeric or not and > than 0
            {
                MessageBox.Show("Please enter a numeric value.");     
                txtLength.Focus();      //set focus to length
                
            }

            if (Decimal.TryParse(txtWidth.Text, out rectangleWidth) && (rectangleWidth > 0) == false)   //check user input in Width field is numeric or not and > than 0
            {
                MessageBox.Show("Please enter a numeric value.");
                txtWidth.Focus();      //set focus to width
            }

            else
            {
                //Processing
                rectangleArea = rectangleLength * rectangleWidth;            //Area of rectangle
                rectanglePerimeter = 2*(rectangleLength + rectangleWidth);   //Perimeter of rectangle

                //OUTPUT
                lblOutputArea.Text = Math.Round(rectangleArea,2).ToString();             //Output the Area in lblOuputArea
                lblOutputPerimeter.Text=Math.Round(rectanglePerimeter,2).ToString();     //Output the Perimeter in lblOutputPerimeter
            }
        }

        /// <summary>
        ///this is for reset button 
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLength.Text = "";
            txtWidth.Text  = "";
            lblOutputArea.Text = "";
            lblOutputPerimeter.Text = "";
            txtLength.Focus();

        }

        /// <summary>
        /// this closes the form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();      //closes the form
        }

        /// <summary>
        /// This is for when user changed the width text value
        /// </summary>
        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            lblOutputArea.Text = "";            //set Area Output to blank
            lblOutputPerimeter.Text = "";       //set Perimeter Output to blank
            txtWidth.Focus();                   //set focus to Width field
        }
    }
}
