using RESTClient.RestClient;
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
    public partial class OrderOverviewForm : Form
    {
        //OrderRestClient _client = new OrderRestClient("http://79.171.148.188/api/Order");
        IOrderClient _client = new OrderRestClient("https://localhost:7067/api/Order");

        public OrderOverviewForm()
        {
            InitializeComponent();
        }

        public void Load()
        {
            cklOrders.DisplayMember = "Date";
            _client.GetAll().ToList().ForEach(order => cklOrders.Items.Add(order));
        }

        private void btnHandleOrder_Click(object sender, EventArgs e)
        {
            OrderDetailsForm _orderDetailsForm = new OrderDetailsForm();
            if(cklOrders.SelectedItem != null)
            {
                _orderDetailsForm.Load((RESTClient.DTOs.OrderDTO)cklOrders.SelectedItem);
            }
            if(cklOrders.SelectedItem != null && _orderDetailsForm.ShowDialog(this) == DialogResult.Yes) //"This" refers to the open form
            {
                cklOrders.SetItemChecked(cklOrders.SelectedIndex, true);
                this.Refresh(); 
                _client.UpdateOrder((RESTClient.DTOs.OrderDTO)cklOrders.SelectedItem);
            }
            else
            {
                _orderDetailsForm.Close();
            }
        }
    }
}
