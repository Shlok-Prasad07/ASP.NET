using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7
{
    public partial class calculatertheme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double a = Convert.ToDouble(tb1.Text);
            double b = Convert.ToDouble(tb2.Text);
            double result = 0;
            switch (button.ID)
            {
                case "btadd":
                    result = a + b;
                    break;

                case "btsub":
                    result = a - b;
                    break;


                case "btmul":
                    result = a * b;
                    break;

                case "btdiv":
                    result = a / b;
                    break;

                case "btmod":
                    result = a % b;
                    break;
            }
            btres.Text = result.ToString();
        }

    }
}