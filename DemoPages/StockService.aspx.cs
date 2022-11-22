using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoPages
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private StockDataService.Service1Client client;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            client = new StockDataService.Service1Client();
            // get the data
            var stockName = StockName.Text;

            string[] response;
            try
            {
                response = client.getStockData(stockName);
                StockResponse.Text = string.Join("\n\n", response);

            } catch (Exception stockException)
            {

                StockResponse.Text = stockException.Message;

            }

        }
    }
}