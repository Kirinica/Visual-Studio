using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You're old school.";
                resultImage.ImageUrl = "320521.png";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "I hope you don't run out of ink.";
                resultImage.ImageUrl = "72244.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You're probably on Reddit";
                resultImage.ImageUrl = "kxsgxrhmzhobbcsnhjlc.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "You're definitely on Reddit.";
                resultImage.ImageUrl = "tablet-icon-small.jpg";
            }
        }
    }
}