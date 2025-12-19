using MarketAnalyzerApp.Data;
using System.Threading.Tasks;

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

            var titlecol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Title",
                DataPropertyName = "Title",
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            grdProducts.Columns.Add(titlecol);

            var brandcol = new DataGridViewTextBoxColumn
            {

                HeaderText = "Brand",
                DataPropertyName = "Brand",
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            grdProducts.Columns.Add(brandcol);
        }

        private void grdProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            // Debounce the search text changed event
            int lenthBeforePause = txt_Search.Text.Length;
           
            Task.Delay(300);
            int lengthAfterPause = txt_Search.Text.Length;

            if (lenthBeforePause == lengthAfterPause) { RefreshGrid(); }

                //else if (lenthBeforePause != lengthAfterPause)
                //{
                //    // Invoke the refresh grid on the UI thread
                //    this.Invoke((Action)(() => RefreshGrid()));
                //}
            
        }

        private void RefreshGrid()
        {
            //var searchText = txt_Search.Text.ToLower();
            //var filteredProducts = _products.Where(p =>
            //    p.Title.ToLower().Contains(searchText) ||
            //    p.Brand.ToLower().Contains(searchText)).ToList();
            //grdProducts.DataSource = filteredProducts;

            List<Product> searchResult = _products.Where(p => p.Brand.ToLower().Contains
            (txt_Search.Text.ToLower())).ToList();
            grdProducts.DataSource = searchResult;
        }
    }
}
