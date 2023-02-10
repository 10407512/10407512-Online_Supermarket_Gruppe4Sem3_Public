namespace DesktopApp
{
    public partial class MainMenuForm : Form
    {
        public OrderOverviewForm _orderOverviewForm { get; set; }
        public MainMenuForm()
        {
            InitializeComponent();
            _orderOverviewForm = new OrderOverviewForm();
            _orderOverviewForm.Load();
        }

        private void btnOrderOverview_Click(object sender, EventArgs e)
        {
            if (!_orderOverviewForm.IsDisposed)
            {
                _orderOverviewForm.Show();
            }
            else
            {
                _orderOverviewForm = new OrderOverviewForm();
                _orderOverviewForm.Load();
                _orderOverviewForm.Show();
            }
        }

        private void btnProductMenu_Click(object sender, EventArgs e)
        {
            ProductMenuForm _productMenuForm = new ProductMenuForm();

            _productMenuForm.Show();
        }
    }
}
