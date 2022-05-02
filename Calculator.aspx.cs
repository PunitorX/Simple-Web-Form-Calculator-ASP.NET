using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationAssignment
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e) // Add button on web page
        {
            try
            {
                // Checks to see if there are numerals in the boxes.
                if (firstNum.Text != "" && secondNum.Text != "")
                {
                    resultNum.Text = (double.Parse(firstNum.Text.ToString()) + double.Parse(secondNum.Text.ToString())).ToString();
                }
            }
            catch(FormatException) // This catches and proclaims that the user must enter only numerals
            {
                resultNum.Text = "Must be a number!"; // Displayed string if the catch is executed.
            }
        }

        protected void subButton_Click(object sender, EventArgs e) // Subtract button on web page
        {
            try
            {
                // Checks to see if there are numerals in the boxes.
                if (firstNum.Text != "" && secondNum.Text != "")
                {
                    resultNum.Text = (double.Parse(firstNum.Text.ToString()) - double.Parse(secondNum.Text.ToString())).ToString();
                }
            }
            catch (FormatException) // This catches and proclaims that the user must enter only numerals
            {
                resultNum.Text = "Must be a number!"; // Displayed string if the catch is executed.
            }
        }

        protected void multiButton_Click(object sender, EventArgs e) // Multiply button on web page
        {
            try
            {
                // Checks to see if there are numerals in the boxes.
                if (firstNum.Text != "" && secondNum.Text != "")
                {
                    resultNum.Text = (double.Parse(firstNum.Text.ToString()) * double.Parse(secondNum.Text.ToString())).ToString();
                }
            }
            catch (FormatException) // This catches and proclaims that the user must enter only numerals
            {
                resultNum.Text = "Must be a number!"; // Displayed string if the catch is executed.
            }
        }

        protected void divButtin_Click(object sender, EventArgs e) // Divide button on web page
        {
            try
            {
                // Checks to see if there are numerals in the boxes.
                if (firstNum.Text != "" && secondNum.Text != "")
                {
                    resultNum.Text = (double.Parse(firstNum.Text.ToString()) / double.Parse(secondNum.Text.ToString())).ToString();
                   
                    if (secondNum.Text == "0") // If the second number text box (denominator) is zero, the following string is displayed.
                    {
                        resultNum.Text = "Can not divide by zero!"; // Displayed if the second number (denominator) is zero
                    }
                }
            }           
            catch (FormatException) // This catches and proclaims that the user must enter only numerals
            {
                resultNum.Text = "Must be a number!"; // Displayed string if the catch is executed.
            }           
        }

        protected void modButtun_Click(object sender, EventArgs e) // Modulus button on web page
        {
            try
            {
                // Checks to see if there are numerals in the boxes.
                if (firstNum.Text != "" && secondNum.Text != "")
                {
                    resultNum.Text = (double.Parse(firstNum.Text.ToString()) % double.Parse(secondNum.Text.ToString())).ToString();
                }
            }
            catch (FormatException) // This catches and proclaims that the user must enter only numerals
            {
                resultNum.Text = "Must be a number!"; // Displayed string if the catch is executed.
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            firstNum.Text = ""; // sets the number one textbox to null
            secondNum.Text = ""; // sets the number two textbox to null
            resultNum.Text = ""; // sets the result textbox to null
        }
    }
}