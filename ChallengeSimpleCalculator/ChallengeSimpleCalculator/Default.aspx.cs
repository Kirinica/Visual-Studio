using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            int firstvalue = int.Parse(firstvalueTextBox.Text);
            int secondvalue = int.Parse(secondvalueTextBox.Text);
            int result = firstvalue + secondvalue;
            resultLabel.Text = result.ToString();
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            int firstvalue = int.Parse(firstvalueTextBox.Text);
            int secondvalue = int.Parse(secondvalueTextBox.Text);
            int result = firstvalue - secondvalue;
            resultLabel.Text = result.ToString();
        }

        protected void multiplicationButoon_Click(object sender, EventArgs e)
        {
            int firstvalue = int.Parse(firstvalueTextBox.Text);
            int secondvalue = int.Parse(secondvalueTextBox.Text);
            int result = firstvalue * secondvalue;
            resultLabel.Text = result.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            int firstvalue = int.Parse(firstvalueTextBox.Text);
            int secondvalue = int.Parse(secondvalueTextBox.Text);
            int result = firstvalue / secondvalue;
            resultLabel.Text = result.ToString();
        }
    }
}