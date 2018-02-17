using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] name = new string[0];
                int[] rigged = new int[0];
                int[] acts = new int[0];


                ViewState.Add("Name", name);
                ViewState.Add("Rigged", rigged);
                ViewState.Add("Acts", acts);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] name = (string[])ViewState["Name"];
            int[] rigged = (int[])ViewState["Rigged"];
            int[] acts = (int[])ViewState["Acts"];

            int newLength = name.Length + 1;

            Array.Resize(ref name, newLength);
            Array.Resize(ref rigged, newLength);
            Array.Resize(ref acts, newLength);

            int newIndex = name.GetUpperBound(0);

            name[newIndex] = nameTextBox.Text;
            rigged[newIndex] = int.Parse(riggedTextBox.Text);
            acts[newIndex] = int.Parse(actsTextBox.Text);

            ViewState["Name"] = name;
            ViewState["Rigged"] = rigged;
            ViewState["Acts"] = acts;

            resultLabel.Text = string.Format("Total Elections Rigged: {0}" +
                "<br />Average Acts of Subterfuge per Asset: {1}<br />(Last Asset you Added {2})",
                rigged.Sum(),
                acts.Average(),
                name[newIndex]);

            nameTextBox.Text = "";
            riggedTextBox.Text = "";
            actsTextBox.Text = "";

        }
    }
}