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

namespace POSForm1
{
    public partial class frmRefund : Form
    {
        SaleContext salesDb;
        List<Sale> saleList;

        public frmRefund()
        {
            InitializeComponent();
            salesDb = new SaleContext();
            saleList = salesDb.Sales.Select(s => s).ToList();
            lboSales.Items.AddRange(saleList.ToArray());
            lboSales.SelectedIndex= lboSales.Items.Count-1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            Sale selectedSale = (Sale)lboSales.SelectedItem;
            Sale? saleToDelete = salesDb.Sales.Find(selectedSale.SaleId);
            if (saleToDelete != null)
            {
                salesDb.Sales.Remove(saleToDelete);
                salesDb.SaveChanges();
            }
            saleList = salesDb.Sales.Select(s => s).ToList();
            lboSales.Items.Clear();
            lboSales.Items.AddRange(saleList.ToArray());
            lboSales.SelectedIndex= lboSales.Items.Count-1;
        }
    }
}
