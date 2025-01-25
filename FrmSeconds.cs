/*
 * Victor Perdue
 * CST-150
 * Activity 2
 * 1/24/2025
 */

namespace CST_150_Activity_2
{
    public partial class FrmSeconds : Form
    {
        public FrmSeconds()
        {
            InitializeComponent();
            //Make sure the label is not visible
            lblResults.Visible = false;
        }

        private void FrmSeconds_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event Handler to Evaluate Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            //Declare and Initialize
            int seconds = 0; //declare the value user entered in seconds
            //working with constants in C#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;
            //define flags
            //make sure the label is not visible
            lblResults.Visible = false;
            //default the color to black
            lblResults.ForeColor = Color.Black;
            //test to determine if integere was entered correctly by user
            //if try to parse string to int is succesful continue else show message to user
            if (int.TryParse(txtUserEntry.Text, out seconds))
            {
                // This block of code is where all our business logic will be placed.
                // In future classes we will put this code (Business logic) in the business layer

                // Practice with nested if statements
                if (seconds >= SecondsInMinutes)
                {
                    // if we are here we know the user has entered a value that we can, at a minimum
                    // display how many minutes are in the seconds entered.
                    lblResults.Text = string.Format("There are {0:#,#} minute(s) in {1:#,#} seconds.", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;
                    // Now that we know there were minutes - test for hours
                    // using nested if statements
                    // Nested statements stops code from being executed if there is
                    // no need.
                    if (seconds >= SecondsInHours)
                    {
                        // Display how many hours are in the seconds entered.
                        lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds.\n", seconds / SecondsInHours, seconds);

                        // Now that we know there were hours - test for days
                        if (seconds >= SecondsInHours)
                        {
                            // Display how many hours are in the seconds entered.
                            lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds.\n", seconds / SecondsInHours, seconds);

                            // Now that we know there were hours - test for days
                            // using nested if statements
                            if (seconds >= SecondsInDays)
                            {
                                // Display how many days are in the seconds entered.
                                lblResults.Text += string.Format("There are {0:#,#} days in {1:#,#} seconds.\n", seconds / SecondsInDays, seconds);
                            }
                        }
                    }
                    else
                    {
                        // if we are here we know the user did not enter a value that meets the minimum
                        // requirements of at least 60

                        // Ask the user to enter a valid number
                        lblResults.Text = "Please enter an integer larger than 59.";
                        lblResults.ForeColor = Color.Red;
                        lblResults.Visible = true;
                    }
                }
                else
                {
                    //this is the code clock that be executed if the user did not put an int in
                    lblResults.Text = "Please enter an int to continue. . .";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible = true;
                }
            }
        }
    }
}
