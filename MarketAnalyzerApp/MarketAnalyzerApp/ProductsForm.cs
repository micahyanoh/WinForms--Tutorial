using MarketAnalyzerApp.Data;

namespace MarketAnalyzerApp
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        List<Product> _products; 
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            _products = CSVDataLoader.LoadData();

            grdProducts.DataSource = _products;
        }
    }
}

    
