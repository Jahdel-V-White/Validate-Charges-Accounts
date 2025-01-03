using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_Ch7._3
{
    public partial class ChargeAccValidation : Form
    {
        public ChargeAccValidation()
        {
            InitializeComponent();
        }

        private void ChargeAccValidation_Load(object sender, EventArgs e)
        {

        }
        int UserGuess;

        //Ensure tha the user can only enter digits
        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
            
            //Turn user input into an integer that can be used for calculation
            if (int.TryParse(UserInput.Text, out UserGuess))
            {

            }

            
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            //try catch is done to catch any errors that may occur with the file itself
            try
            {
                //creating the size of the array I know it will hold 18 elements
                
                int[] nums = new int[19];

                //create index
                int count = 0;

                //file will be read to array
                StreamReader inputFile;

                //file opened
                inputFile = File.OpenText("ChargeAccounts.txt");

                //loop adds each new line from the file as a new element to the array until the end of the file
                while (count < nums.Length && !inputFile.EndOfStream)
                {
                    //new element created for evert new line in the file
                    nums[count] = int.Parse(inputFile.ReadLine());
                    count++;
                }
                inputFile.Close();

                 
                
                //loop that parses through each line that has been read into the array
                foreach (int num in nums)
                {

                    //if statement will check the user input up against each element in the array
                    //the count representing each element
                    {
                        if (UserGuess == nums[count])
                        {
                            MessageBox.Show("You Have the Correct Charge Number.");
                            //the found variable becomes true because the user has guess correct
                            

                            //the break statement was what I had to add or else the user had to click ok 19 times to exit the message
                            //the code was making the user click as many times as there are elements in the array the break stops this
                            break;
                        }

                        
                        else if (UserGuess != nums[count])
                        {
                            MessageBox.Show("Your Answer is wrong click Ok Button to try again");
                        }
                        break;
                    } 

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("FILE ERROR: " + ex.Message);
            }

            

        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            int maxDigits = 7;
            //ensure that the user cannot enter any digits that exceed 6 digits as all the charge numbers are 6 digits
            if (UserInput.Text.Length > maxDigits)
            {
                MessageBox.Show("Cannot Enter a number that exceeds the 7 digits try again.");
            }

        }

        

    }
}
