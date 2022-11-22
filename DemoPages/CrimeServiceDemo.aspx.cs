using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoPages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private CrimeDataService.Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        // Add on submit page
        protected void submitButton_Click(object sender, EventArgs e)
        {
            // setup client
            client = new CrimeDataService.Service1Client();
            // get the data
            // turn into doubles
            double lat = double.Parse(Latitude.Text);
            double lon = double.Parse(Longitude.Text);
            // make the service call
            int response;
            try
            {
                response = client.getCrimeData(lat, lon);
            } catch (Exception)
            {

                response = 0;
            }
            // render the text

            Response.Text = response.ToString();
        }




    }
}