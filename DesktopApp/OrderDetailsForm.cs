using RESTClient.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDTO Order { get; set; }
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public void Load(OrderDTO selectedItem)
        {
            Order = selectedItem;
            textBox1.Text = "" + Order.OrderNo;
            lvwOrderLines.View = View.Details;
            foreach (OrderLineDTO ol in Order.OrderLines)
            {
                ListViewItem item = new ListViewItem(ol.Product.Barcode);
                item.SubItems.Add(ol.Product.Name);
                item.SubItems.Add(ol.Product.Brand);
                item.SubItems.Add(Convert.ToString(ol.Quantity));
                item.SubItems.Add(ol.Product.Description);
                item.Tag = ol;
                lvwOrderLines.Items.Add(item);
            }
            lvwOrderLines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwOrderLines.Columns[0].Width = 100;
            lvwOrderLines.Columns[3].Width = 70;
            lvwOrderLines.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er orderen klar til afhenting?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Order.IsReady = true;
                //send order with updates
                this.DialogResult = DialogResult.Yes;
                this.Close(); //"This" refers to the open form
            }
        }
    }
}
