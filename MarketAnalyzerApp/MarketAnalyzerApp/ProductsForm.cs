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
           CustomizeGridAppearance();
            _products = CSVDataLoader.LoadData();

            grdProducts.DataSource = _products;
        }

        private void CustomizeGridAppearance()
        {
            grdProducts.AutoGenerateColumns = false;
            grdProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProducts.RowHeadersVisible = false;

            var titlecol = new DataGridViewTextBoxColumn {
                HeaderText = "Title",
                DataPropertyName = "Title",
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            grdProducts.Columns.Add(titlecol);

            var brandcol = new DataGridViewTextBoxColumn {

                HeaderText = "Brand",
                DataPropertyName = "Brand",
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
          
            grdProducts.Columns.Add(brandcol);
        }
    }
}

    
