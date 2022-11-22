using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoPages
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private WeatherService.Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            client = new WeatherService.Service1Client();
            string[] response;

            if (ZipCode.Text == null || ZipCode.Text == "" || ZipCode.Text.Length < 5)
            {
                Response.Text = "INVALID FORMAT!! TRY AGAIN WITH A VALID ZIP CODE";
            }

            // get the data
            try
            {
                int zipCode = int.Parse(ZipCode.Text);
                response = client.Weather5day(zipCode);
                Response.Text = string.Join("\n\n", response);

            } catch (Exception exception)
            {

                Response.Text = exception.Message;
            }
        }
    }
}