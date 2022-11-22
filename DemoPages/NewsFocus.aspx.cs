using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoPages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private NewsFocusService.Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitFormButton_Click(object sender, EventArgs e)
        {

            client = new NewsFocusService.Service1Client();

            // Get the data from the text field
            string topics = TextBox1.Text;

            // split it up 
            List<string> listTopics = topics.Split(',').ToList<string>();

            // Make the request to the service
            var response = client.NewsFocus(listTopics.ToArray());

            if (response.Length == 0)
            {
                Response.Text = "www.google.com/?q=asu";
            } else
            {
                // Display the text 
                Response.Text = string.Join("\n\n", response);

            }


        }
    }
}