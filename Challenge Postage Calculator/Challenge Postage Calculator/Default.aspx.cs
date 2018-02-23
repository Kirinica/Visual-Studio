using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Postage_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void nextdayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }
        
        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void lenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        private void performChanged()
        {
            if (!valuesExist()) return;
            int volume = 0;
            if (!tryGetVolume(out volume)) return;
            double postageMultiplier = getPostageMultiplier();
            double cost = volume * postageMultiplier;
            resultLabel.Text = string.Format("Your parcel will cost {0} to ship.", cost);
        }

        private double getPostageMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextdayRadioButton.Checked) return .45;
            else return 0;
        }

        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lenghtTextBox.Text.Trim(), out length)) return false;

            volume = width * height * length;
            return true;
        }

        private bool valuesExist()
        {
            if (!airRadioButton.Checked &&
                !groundRadioButton.Checked &&
                !nextdayRadioButton.Checked)
                return false;

            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }
    }
}


