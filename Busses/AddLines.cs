using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busses
{
    public partial class AddLines : Form
    {
        public Line NewLine { get; set; }

        public AddLines()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // string destination, int departureHour, int departureMinute, float price
            NewLine = new Line(tbDestination.Text.Trim(), (int)nudHour.Value, (int)nudMinute.Value, (int)nudPrice.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
