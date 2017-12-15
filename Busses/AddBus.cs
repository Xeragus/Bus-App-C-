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
    public partial class AddBus : Form
    {
        public Bus Bus { get; set; }

        public AddBus()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "The name cannot be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbRegistration_Validating(object sender, CancelEventArgs e)
        {
            if (tbRegistration.Text.Trim().Length != 4)
            {
                errorProvider1.SetError(tbRegistration, "The registration number has to be 4 digits long");
                e.Cancel = true;
            }
            else
            {
                string sh = tbRegistration.Text.Trim();
                foreach (char c in sh)
                {
                    if (!Char.IsDigit(c))
                    {
                        errorProvider1.SetError(tbRegistration, "Регистрацијата треба да има точно 4 цифри");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbRegistration, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string registrationNumber, string name, bool isLocal
            Bus = new Bus(tbRegistration.Text, tbName.Text, ckbLocalBus.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
