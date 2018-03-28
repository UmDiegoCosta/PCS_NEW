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

        //Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*string var;

            var = txtEmp_no.Text;
            if (var.ElementAt(0) == M) { }*/
            string mystring = txtEmp_no.Text; ;
            if (!String.IsNullOrEmpty(mystring))
            {
                char first = mystring[0];
                if (first != 'M')
                {
                    TabControl.Controls.Remove(tabEmployee);
                }
                TabControl.SelectedIndex = 1;
            }
        }


    }
}
/*
 * 
 * https://stackoverflow.com/questions/418006/how-can-i-disable-a-tab-inside-a-tabcontrol
 * */
