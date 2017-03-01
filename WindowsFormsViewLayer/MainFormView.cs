using System;
using System.Windows.Forms;

namespace WindowsFormsViewLayer
{
    public partial class MainFormView : Form
    {

        public MainFormView()
        {
            InitializeComponent();
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            var carFormView = new CarFormView();
            carFormView.Show();
            Hide();
        }

        private void lorryButton_Click(object sender, EventArgs e)
        {
            var lorryFormView = new LorryFormView();
            lorryFormView.Show();
            Hide();
        }

        private void motorbikeButton_Click(object sender, EventArgs e)
        {
            var motorbikeFormView = new MotorbikeFormView();
            motorbikeFormView.Show();
            Hide();
        }

        private void MainFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
