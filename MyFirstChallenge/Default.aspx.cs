﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void okButton_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string money = moneyTextBox.Text;

            string result = "At " + age + " years old I would expect more than " + money + " dollars in your pocket...";

            resultLabel.Text = result;
        }

 
    }
}