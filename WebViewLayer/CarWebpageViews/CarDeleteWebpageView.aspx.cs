using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebViewLayer.CarWebpageViews
{
    public partial class CarDeleteWebpageView : System.Web.UI.Page
    {
        CarServices carServicesObj = new CarServices();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            carServicesObj.Delete(carServicesObj.GetById(Guid.Parse(idTxtBox.Text)));
            Response.Redirect("CarWebPageView.aspx");
        }
    }
}