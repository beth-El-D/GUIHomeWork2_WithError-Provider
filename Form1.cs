using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWorkGUI1.Model;


namespace HomeWorkGUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            productModel p = new productModel();
            p.invNumber = int.Parse(txtNumber.Text);
            p.date = dtpReg.Text;
            p.unknown = int.Parse(txtUnknown.Text);
            p.itemName = txtItemName.Text;
            p.count = int.Parse(txtCount.Text);
            p.price = double.Parse(txtPrice.Text);




            if (String.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("The Item name field is Required.");
            }

            else
            {
                p.Save();
            }

                    dgvDisplay.DataSource = null;
                    dgvDisplay.DataSource = p.GetProducts();
            }

        private bool ValidateName()
        {
            bool bStatus = true;
            if (txtItemName.Text == "")
            {
                errorProvider1.SetError(txtItemName, "Please enter Item Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtItemName, "");
            return bStatus;
        }


        private bool ValidateInventory()
        {
            bool bStatus = true;
            if (txtUnknown.Text == "")
            {
                errorProvider1.SetError(txtUnknown, "Please enter Inventory Number");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtUnknown, "");
            return bStatus;
        }

        private bool ValidateNameLength()
        {
            bool bStatus = true;
            if (txtItemName.Text.Length<3)
            {
                errorProvider1.SetError(txtItemName, "Item Name should have at least 3 characters ");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtItemName, "");
            return bStatus;
        }

        private bool ValidatePrice()
        {
            bool bStatus = true;
            if (txtPrice.Text.Length <= 0)
            {
                errorProvider1.SetError(txtItemName, "Price is Required.");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtPrice, "");
            return bStatus;
        }


        private bool ValidateCount()
        {
            bool bStatus = true;
            if (txtCount.Text.Length <= 0)
            {
                errorProvider1.SetError(txtItemName, "This field is Required");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtCount, "");
            return bStatus;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtItemName.Text = "";
            txtCount.Text = "";
            txtPrice.Text = "";
            txtUnknown.Text = "";
            
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            ValidateName();
            ValidateNameLength();
        }

        private void txtCount_Leave(object sender, EventArgs e)
        {
            ValidateCount();
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            ValidatePrice();
        }

        private void txtUnknown_Leave(object sender, EventArgs e)
        {
            ValidateInventory();
        }
    }
}
