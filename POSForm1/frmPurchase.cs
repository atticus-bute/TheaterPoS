using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSForm1
{
    public partial class frmPurchase : Form
    {
        SaleContext salesDb;
        bool cardTransaction;
        List<Sale> saleList;
        double subtotal = 0;
        double tax, total;
        Employee currentUser;
        public frmPurchase(List<Product> finalCart, Employee employee)
        {
            InitializeComponent();
            salesDb= new SaleContext();
            saleList= salesDb.Sales.Select(s => s).ToList();
            currentUser = employee;
            foreach (Product product in finalCart)
            {
                subtotal += product.Price;
            }
            tax = .09 * subtotal;
            total = subtotal + tax;
            lblCurrentUser.Text = $"Signed in as: {employee.Name}";
            lboOrder.Items.AddRange(finalCart.ToArray());
            lblSubtotal.Text = $"Subtotal: {subtotal:c}";
            lblTax.Text = $"Tax: {tax:c}";
            lblTotal.Text = $"Total: {total:c}";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            grpPaymentMethod.Enabled = true;
            lblPaymentMethod.Text = "Enter Given Cash:";
            cardTransaction = false;
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            grpPaymentMethod.Enabled = true;
            lblPaymentMethod.Text = "Enter Card No:";
            cardTransaction = true;
        }
        private void btnFinalize_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            if (cardTransaction)
            {
                if(txtPayment.Text != string.Empty)
                {
                    Sale newSale = new Sale { Cost = total, Employee = currentUser.Name };
                    try
                    {
                        salesDb.Sales.Add(newSale);
                        salesDb.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    MessageBox.Show($"Transaction Complete.\nTotal: {total:c}\nCashier: {currentUser.Name}");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid CCN");
                }
            } else
            {
                double givenCash;
                Double.TryParse(txtPayment.Text, out givenCash);
                if (givenCash < total)
                {
                    MessageBox.Show("Cash given is less than total.");
                } else
                {
                    Sale newSale = new Sale { Cost = total, Employee = currentUser.Name };
                    try
                    {
                        salesDb.Sales.Add(newSale);
                        salesDb.SaveChanges();
                    } catch(Exception ex)
                    {

                    }
                    MessageBox.Show($"Change Due: {givenCash - total:c}");
                    MessageBox.Show($"Transaction Complete.\nTotal: {total:c}\nCashier: {currentUser.Name}");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
