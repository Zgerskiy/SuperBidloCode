using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void carsButton_Click(object sender, EventArgs e)
        {
            new CarsForm().ShowDialog();
        }

        private void shopsButton_Click(object sender, EventArgs e)
        {
            new ShopsForm().ShowDialog();
        }

        private void routsButton_Click(object sender, EventArgs e)
        {
            new RouteForm().ShowDialog();
        }

        private void shopRequestsButton_Click(object sender, EventArgs e)
        {
            new ShopRequestsForm().ShowDialog();
        }
    }
}
