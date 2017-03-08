using HelperClasses.Measurements;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebViewLayer.CarWebpageViews
{
    public partial class CarCalculateFuelWebpageView : System.Web.UI.Page
    {
        CarServices carServiceObj = new CarServices();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Distance distanceToTravel = new Distance();
            distanceToTravel.miles = Convert.ToDecimal(distanceTxtBox.Text);
            carServiceObj.CalculateFuel(carServiceObj.GetById(Guid.Parse(idTxtBox.Text)), distanceToTravel);
            Response.Redirect("CarWebPageView.aspx");
        }

        protected void refuelBtn_Click(object sender, EventArgs e)
        {
            carServiceObj.Refuel(carServiceObj.GetById(Guid.Parse(idTxtBox.Text)));
        }
    }
}