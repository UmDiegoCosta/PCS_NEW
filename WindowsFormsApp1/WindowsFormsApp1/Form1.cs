using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[System.ComponentModel.Browsable(false)]
        //public System.Windows.Forms.AutoScaleMode AutoScaleMode { get; set; }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pCsDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.pCsDataSet.PRODUCT);
            pRODUCTBindingSource.DataSource = this.pCsDataSet.PRODUCT;
            panelProd.Enabled = false;
            // TODO: This line of code loads data into the 'pCsDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.pCsDataSet.CUSTOMER);
            cUSTOMERBindingSource.DataSource = this.pCsDataSet.CUSTOMER;
            panelCustomer.Enabled = false;
            // TODO: This line of code loads data into the 'pCsDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.pCsDataSet.EMPLOYEE);
            eMPLOYEEBindingSource.DataSource = this.pCsDataSet.EMPLOYEE;
            panelEmp.Enabled = false;

            //
            foreach (TabPage tab in TabControl.TabPages)
            {
                tab.Enabled = false;
            }
(TabControl.TabPages[0] as TabPage).Enabled = true;
        }

        //Products
        private void btnNewProd_Click(object sender, EventArgs e)
        {
            try
            {
                panelProd.Enabled = true;
                txtProdCode.Focus();
                this.pCsDataSet.PRODUCT.AddPRODUCTRow(this.pCsDataSet.PRODUCT.NewPRODUCTRow());
                pRODUCTBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pRODUCTBindingSource.ResetBindings(false);
            }
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            panelProd.Enabled = true;
            txtProdCode.Focus();
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            try
            {
                pRODUCTBindingSource.EndEdit();
                pRODUCTTableAdapter.Update(this.pCsDataSet.PRODUCT);
                panelProd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pRODUCTBindingSource.ResetBindings(false);
            }
        }

        private void dgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure about deleting this product?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pRODUCTBindingSource.RemoveCurrent();
                }
            }
        }

        private void txtProductSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtProductSearch.Text))
                {
                    dgProduct.DataSource = pRODUCTBindingSource;
                }
                else
                {
                    var query = from obj in this.pCsDataSet.PRODUCT
                                where obj.ProdCode.Contains(txtProductSearch.Text) || obj.ProdDescription.Contains(txtProductSearch.Text)
                                select obj;
                    dgProduct.DataSource = query.ToList();

                }
            }
        }

        //Employee
        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            try
            {
                panelEmp.Enabled = true;
                txtEmpNo.Focus();
                this.pCsDataSet.EMPLOYEE.AddEMPLOYEERow(this.pCsDataSet.EMPLOYEE.NewEMPLOYEERow());
                eMPLOYEEBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eMPLOYEEBindingSource.ResetBindings(false);
            }
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            panelEmp.Enabled = true;
            txtEmpNo.Focus();
        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            try
            {
                eMPLOYEEBindingSource.EndEdit();
                eMPLOYEETableAdapter.Update(this.pCsDataSet.EMPLOYEE);
                panelEmp.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eMPLOYEEBindingSource.ResetBindings(false);
            }
        }

        private void dgEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure about deleting this employee?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eMPLOYEEBindingSource.RemoveCurrent();
                }
            }
        }

        private void txtEmpSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtEmpSearch.Text))
                {
                    dgEmployee.DataSource = eMPLOYEEBindingSource;
                }
                else
                {
                    var query = from obj in this.pCsDataSet.EMPLOYEE
                                where obj.EmpName.Contains(txtEmpSearch.Text) || obj.EmpPosition.Contains(txtEmpSearch.Text)
                                select obj;
                    dgEmployee.DataSource = query.ToList();

                }
            }
        }

        //Customer
        private void txtCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtCustomerSearch.Text))
                {
                    dgCustomer.DataSource = cUSTOMERBindingSource;
                }
                else
                {
                    var query = from obj in this.pCsDataSet.CUSTOMER
                                where obj.CustName.Contains(txtCustomerSearch.Text) || obj.CustPhone.Contains(txtCustomerSearch.Text)
                                select obj;
                    dgCustomer.DataSource = query.ToList();

                }
            }
        }

        private void dgCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure about deleting this customer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cUSTOMERBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            try
            {
                panelCustomer.Enabled = true;
                txtCustomerName.Focus();
                this.pCsDataSet.CUSTOMER.AddCUSTOMERRow(this.pCsDataSet.CUSTOMER.NewCUSTOMERRow());
                cUSTOMERBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cUSTOMERBindingSource.ResetBindings(false);
            }
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            panelCustomer.Enabled = true;
            txtCustomerName.Focus();
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            try
            {
                cUSTOMERBindingSource.EndEdit();
                cUSTOMERTableAdapter.Update(this.pCsDataSet.CUSTOMER);
                panelCustomer.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cUSTOMERBindingSource.ResetBindings(false);
            }
        }



        //prepare to generate invoice
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            //variables to hold emp, cust and prd selected
            string selectedEmp;
            string selectedCust;
            string selectedProd;

            Int32 dgselectedEmp = dgEmpInvoice.GetCellCount(DataGridViewElementStates.Selected);
            //check if it is grater than zero
            if (dgselectedEmp > 3)
            {
                MessageBox.Show("Please, select only one Employee.");
            }
            else
            {
                int rowindex = dgEmpInvoice.CurrentCell.RowIndex;
                int columnindex = dgEmpInvoice.CurrentCell.ColumnIndex;
                selectedEmp = dgEmpInvoice.Rows[rowindex].Cells[columnindex].Value.ToString();
                MessageBox.Show(selectedEmp);
            }

            Int32 dgselectedCust = dgCustInvoice.GetCellCount(DataGridViewElementStates.Selected);
            //check if it is grater than zero
            if (dgselectedCust > 3)
            {
                MessageBox.Show("Please, select only one Customer.");
            }
            else
            {
                int rowindex = dgCustInvoice.CurrentCell.RowIndex;
                int columnindex = dgCustInvoice.CurrentCell.ColumnIndex;
                selectedCust = dgCustInvoice.Rows[rowindex].Cells[columnindex].Value.ToString();
                MessageBox.Show(selectedCust);
            }

            Int32 dgselectedProd = dgProductInvoice.GetCellCount(DataGridViewElementStates.Selected);
            //check if it is grater than zero
            if (dgselectedProd > 3)
            {
                MessageBox.Show("Please, select only one Customer.");
            }
            else
            {
                int rowindex = dgProductInvoice.CurrentCell.RowIndex;
                int columnindex = dgProductInvoice.CurrentCell.ColumnIndex;
                selectedProd = dgProductInvoice.Rows[rowindex].Cells[columnindex].Value.ToString();
                MessageBox.Show(selectedProd);
            }
        }
        //Login
        //for the Login Screen the password is set as the reverse order of employee no. else, the user cannot enter
        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string mystring = txtEmp_no.Text;
            string mypassword = txtEmpPassword.Text;
            string password = Reverse(mystring);
            if (mypassword == password)
            {

                if (!String.IsNullOrEmpty(mystring))
                {
                    char first = mystring[0];
                    if (first != 'M')
                    {
                        TabControl.Controls.Remove(tabEmployee);
                    }
                    TabControl.SelectedIndex = 1;
                    
                        foreach (TabPage tPage in TabControl.TabPages)
                        {
                            tPage.Enabled = true;
                        }
             (TabControl.TabPages[0] as TabPage).Enabled = false;
                    
                }
            }
            else { MessageBox.Show("Try Again!", "Password Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }

        private void txtEmp_no_TextChanged(object sender, EventArgs e)
        {
            foreach (TabPage tPage in TabControl.TabPages)
            {
                tPage.Enabled = false;
            }
          (TabControl.TabPages[0] as TabPage).Enabled = true;
        }
    }
}       
/*
 * 
 * https://stackoverflow.com/questions/418006/how-can-i-disable-a-tab-inside-a-tabcontrol
 * https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/selected-cells-rows-and-columns-datagridview
 * */
