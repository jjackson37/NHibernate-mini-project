using ObjectModelLayer;
using ServicesLayer;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebViewLayer.CarWebpageViews
{
    public partial class CarPassengerWebpageView : System.Web.UI.Page
    {
        CarServices carServicesObj = new CarServices();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (idTxtBox.Text != "")
            {
                fillTable();
            }
        }

        protected void submitIdBtn_Click(object sender, EventArgs e)
        {
            idEntryPanel.Visible = false;
            tablePanel.Visible = true;
            linksPanel.Visible = true;
        }

        protected void tableLnkBtn_Click(object sender, EventArgs e)
        {
            tablePanel.Visible = true;
            addPanel.Visible = false;
            deletePanel.Visible = false;
        }

        protected void addLnkBtn_Click(object sender, EventArgs e)
        {
            tablePanel.Visible = false;
            addPanel.Visible = true;
            deletePanel.Visible = false;
        }

        protected void deleteLnkBtn_Click(object sender, EventArgs e)
        {
            tablePanel.Visible = false;
            addPanel.Visible = false;
            deletePanel.Visible = true;
        }

        private void fillTable()
        {
            Car carToEdit = carServicesObj.GetById(Guid.Parse(idTxtBox.Text));

            foreach (var item in carToEdit.passengers)
            {
                TableRow passengerRow = new TableRow();
                TableCell idCell = new TableCell();
                idCell.Text = item.Id.ToString();
                passengerRow.Cells.Add(idCell);
                TableCell firstNameCell = new TableCell();
                firstNameCell.Text = item.firstName;
                passengerRow.Cells.Add(firstNameCell);
                TableCell lastNameCell = new TableCell();
                lastNameCell.Text = item.lastName;
                passengerRow.Cells.Add(lastNameCell);
                passengerTable.Rows.Add(passengerRow);
            }
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            Car carToEdit = carServicesObj.GetById(Guid.Parse(idTxtBox.Text));
            if (carToEdit.passengers.Count < carToEdit.maximumPassengers)
            {
                Passenger passengerToAdd = new Passenger();
                passengerToAdd.firstName = firstNameTxtBox.Text;
                passengerToAdd.lastName = lastNameTxtBox.Text;
                carToEdit.passengers.Add(passengerToAdd);
                carServicesObj.Update(carToEdit);
            }
        }

        protected void removeBtn_Click(object sender, EventArgs e)
        {
            Car carToEdit = carServicesObj.GetById(Guid.Parse(idTxtBox.Text));
            Passenger passengerToDelete = carToEdit.passengers
                .SingleOrDefault(x => x.Id == Guid.Parse(removeIdTxtBox.Text));
            carToEdit.passengers.Remove(passengerToDelete);
            carServicesObj.Update(carToEdit);
        }
    }
}