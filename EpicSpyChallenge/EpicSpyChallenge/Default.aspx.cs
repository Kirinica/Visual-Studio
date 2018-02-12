using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpyChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousassignmentCalendar.SelectedDate = DateTime.Now.Date;
                newassignmentCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                enddatenewassignmentCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void assignspyButton_Click(object sender, EventArgs e)
        {
            TimeSpan totalDurationOfAssignnemt = enddatenewassignmentCalendar.SelectedDate.Subtract(newassignmentCalendar.SelectedDate);
            double totalCost = totalDurationOfAssignnemt.TotalDays * 500.00;

            if (totalDurationOfAssignnemt.TotalDays > 21)
            {
                totalCost = +1000.0;
            }

            resultLabel.Text = string.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}",
                spycodenameTextBox.Text, newassignmentnameTextBox.Text, totalCost);

            TimeSpan timeBetweenAssignments = newassignmentCalendar.SelectedDate.Subtract(previousassignmentCalendar.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: There must be at least two weeks between previous assignment and next assignment.";
            }

            DateTime earliestNewAssignementDate = previousassignmentCalendar.SelectedDate.AddDays(14);

            newassignmentCalendar.SelectedDate = earliestNewAssignementDate;
            newassignmentCalendar.VisibleDate = earliestNewAssignementDate;
        }
    }
}