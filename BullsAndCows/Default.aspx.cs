using System;
using System.Web.UI;

namespace BullsAndCows
{
    public partial class Default : Page
    {
        /// <summary>
        /// Create the secret and populate the secret label with the number of characters in the secret as asterisks
        /// RULES
        /// - Secret must be numeric only
        /// - Secret must be 8 digits long
        /// - Secret must not repeat any digits
        /// - Secret must be stored between requests for comparison purposes
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {

            btnSubmit.Click += new EventHandler(btnSubmit_OnClick);
            btnReset.Click += new EventHandler(btnReset_OnClick);
            bcNumber.Text = "123456";
        }
        
        /// <summary>
        /// Use the comparison method to generate a result string and append it to the result list
        /// </summary>
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            var calcResult = areThereBC(guess.Text);
            results.Text = calcResult;
        }

        /// <summary>
        /// Clear the result list and generate a new secret
        /// RULES
        /// - See above for Secret rules
        /// </summary>
        protected void btnReset_OnClick(object sender, EventArgs e)
        {
            results.Text = string.Empty;
            guess.Text = string.Empty;
        }

        /// <summary>
        /// Compare the submitted guess against the secret to return a result string in the format "xByC"
        /// RULES
        /// - B or Bulls are the number of digits that exist in the secret and are in the same position
        /// - C or Cows are the number of digits that exist in the secret but are not in the same position
        /// - The length of a guess is variable - it may be less than, equal to, or greater than the length of the secret
        /// - Guesses may contain the same digit multiple times, but they should only be matched once i.e. Secret = 1234, Guess = 1111 will return 1B0C rather than 1B3C
        /// </summary>
        private string areThereBC(string guess)
        {
            var secret = bcNumber.Text;
            char[] arrSecret = secret.ToCharArray();
            char[] arrGuess = guess.ToCharArray();
            int cntBulls =0 , cntCows = 0;

            for (int x=0; x <= secret.Length-1; x++ )
            {
                for(int y=0; y <= guess.Length-1; y++)
                {
                    if (arrGuess[y] == arrSecret[x])
                    {
                        if (x == y)
                        {
                            cntBulls++;
                        }
                        else cntCows++;
                    }
                }
            }

            String ret = cntBulls.ToString() + "B" + cntCows.ToString() + "C";
            return ret;
        }
    }
}