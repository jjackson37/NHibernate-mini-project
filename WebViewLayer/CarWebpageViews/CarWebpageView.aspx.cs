using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebViewLayer
{
    public partial class CarWebpageView : Page
    {
        CarServices carServicesObj = new CarServices();

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateCarsTable();
        }     

        private void PopulateCarsTable()
        {
            IList<Car> carList = carServicesObj.GetAll();
            foreach (var item in carList)
            {
                TableRow newTableRow = new TableRow();
                TableCell IdTableCell = new TableCell();
                IdTableCell.Text = item.Id.ToString();
                newTableRow.Cells.Add(IdTableCell);
                TableCell nameTableCell = new TableCell();
                nameTableCell.Text = item.vehicleName;
                newTableRow.Cells.Add(nameTableCell);
                TableCell numberplateTableCell = new TableCell();
                numberplateTableCell.Text = item.numberPlate;
                newTableRow.Cells.Add(numberplateTableCell);
                TableCell carTypeTableCell = new TableCell();
                carTypeTableCell.Text = item.carType.ToString();
                newTableRow.Cells.Add(carTypeTableCell);
                TableCell weightTableCell = new TableCell();
                weightTableCell.Text = decimal.Round(item.weight.kilograms, 2).ToString();
                newTableRow.Cells.Add(weightTableCell);
                TableCell milageTableCell = new TableCell();
                milageTableCell.Text = decimal.Round(item.milage.milesPerGallon, 2).ToString();
                newTableRow.Cells.Add(milageTableCell);
                TableCell fuelTableCell = new TableCell();
                fuelTableCell.Text = string.Format("{0}/{1}L", decimal.Round(item.currentFuel.litres, 2),
                    decimal.Round(item.maximumFuel.litres, 2));
                newTableRow.Cells.Add(fuelTableCell);
                TableCell passengerTableCell = new TableCell();
                passengerTableCell.Text = string.Format("{0}/{1}", item.passengers.Count,
                    item.maximumPassengers); ;
                newTableRow.Cells.Add(passengerTableCell);
                carsTable.Rows.Add(newTableRow);
            }
        }
    }
}