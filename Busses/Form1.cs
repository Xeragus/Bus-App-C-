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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddBus addBus = new AddBus();
            addBus.Show();
            if (addBus.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                lbBusses.Items.Add(addBus.Bus);
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            AddLines addLine = new AddLines();
            addLine.Show();
            if(addLine.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bus newBus = lbBusses.SelectedItem as Bus;
                newBus.AddLine(addLine.NewLine);
                loadLines();
            }
        }

        public void loadLines()
        {
            lbLines.Items.Clear();
            tbAveragePrice.Clear();
            tbMostExpensive.Clear();
            Bus bus = lbBusses.SelectedItem as Bus;
            if (bus != null && bus.Lines.Count > 0)
            {
                Line maxPrice = bus.Lines[0];
                float totalPrice = 0;
                foreach (Line line in bus.Lines)
                {
                    lbLines.Items.Add(line);
                    if (line.Price > maxPrice.Price)
                    {
                        maxPrice = line;
                    }
                    totalPrice += line.Price;
                }
                tbAveragePrice.Text = string.Format("{0:#.0}", totalPrice / lbLines.Items.Count);
                tbMostExpensive.Text = maxPrice.ToString();
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to remove the bus?", "Delete bus", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbBusses.Items.RemoveAt(lbBusses.SelectedIndex);
                loadLines();    
            }
        }
    }
}
