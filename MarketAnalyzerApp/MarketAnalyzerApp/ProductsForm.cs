using MarketAnalyzerApp.Data;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

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

            //grdProducts.DataSource = _products;
            RefreshGrid();
            ConfigureChart();
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
        //private void RefreshChart(Product selectedProduct)
        //{
        //    const string seriesName = "Price";
        //    var series = chart_Price.Series.FirstOrDefault(s => s.Name.Equals(seriesName, StringComparison.Ordinal));
        //    if (series == null)
        //    {
        //        series = new Series(seriesName) { ChartType = SeriesChartType.Area };
        //        chart_Price.Series.Add(series);
        //    }

        //    series.Points.Clear();
        //    series.Points.AddXY("Dec 2021", Calculations.ConvertToDecimal(selectedProduct.Dec2021Price));
        //    series.Points.AddXY("May 2022", Calculations.ConvertToDecimal(selectedProduct.May2022Price));
        //    series.Points.AddXY("Jul 2022", Calculations.ConvertToDecimal(selectedProduct.Jul2022Price));
        //    series.Points.AddXY("Sep 2022", Calculations.ConvertToDecimal(selectedProduct.Sep2022Price));
        //    series.Points.AddXY("Oct 2022", Calculations.ConvertToDecimal(selectedProduct.Oct2022Price));


        //    foreach (DataPoint point in series.Points)
        //        point.Label = point.YValues[0].ToString();
        //}
        //private void RefreshChart(Product selectedProduct)
        //{
        //    chart_Price.Series["Price"].Points.Clear();
        //    chart_Price.Series["Price"].Points.AddXY("Dec 2021", Calculations.ConvertToDecimal(selectedProduct.Dec2021Price));
        //    chart_Price.Series["Price"].Points.AddXY("May 2022", Calculations.ConvertToDecimal(selectedProduct.May2022Price));
        //    chart_Price.Series["Price"].Points.AddXY("Jul 2022", Calculations.ConvertToDecimal(selectedProduct.Jul2022Price));
        //    chart_Price.Series["Price"].Points.AddXY("Sep 2022", Calculations.ConvertToDecimal(selectedProduct.Sep2022Price));
        //    chart_Price.Series["Price"].Points.AddXY("Oct 2022", Calculations.ConvertToDecimal(selectedProduct.Oct2022Price));


        //    foreach (DataPoint point in chart_Price.Series["Price"].Points)

        //        //point.IsValueShownAsLabel = true;
        //        //point.LabelFormat = "C2"; // Format as currency
        //        point.Label = point.YValues[0].ToString();


        //}

        private void RefreshChart(Product selectedProduct)
        {
            var series = chart_Price.Series["Price"];
            series.Points.Clear();

            string[] labels =
            {
        "Dec 2021",
        "May 2022",
        "Jul 2022",
        "Sep 2022",
        "Oct 2022"
    };

            decimal?[] prices =
            {
        Calculations.ConvertToDecimal(selectedProduct.Dec2021Price),
        Calculations.ConvertToDecimal(selectedProduct.May2022Price),
        Calculations.ConvertToDecimal(selectedProduct.Jul2022Price),
        Calculations.ConvertToDecimal(selectedProduct.Sep2022Price),
        Calculations.ConvertToDecimal(selectedProduct.Oct2022Price)
    };

            for (int i = 0; i < prices.Length; i++)
            {
                decimal price = prices[i] ?? 0m; // Use 0 if null, or handle as needed
                int pointIndex = series.Points.AddXY(i, price);
                series.Points[pointIndex].AxisLabel = labels[i];
            }

            series.IsValueShownAsLabel = true;
            series.LabelFormat = "C2";
        }

        //private void ConfigureChart()
        //{
        //    chart_Price.Series.Clear();
        //    chart_Price.ChartAreas.Clear();

        //    chart_Price.ChartAreas.Add(new ChartArea());
        //    chart_Price.Series.Add(new Series("Price")
        //    {
        //        ChartType = SeriesChartType.Column
        //    });

        //}

        private void ConfigureChart()
        {
            chart_Price.Series.Clear();
            chart_Price.ChartAreas.Clear();

            var area = new ChartArea();
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;

            chart_Price.ChartAreas.Add(area);

            chart_Price.Series.Add(new Series("Price")
            {
                ChartType = SeriesChartType.Area,
                XValueType = ChartValueType.Int32
            });
        }



        private void grdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product selectedProduct = grdProducts.CurrentRow.DataBoundItem as Product;
            RefreshChart(selectedProduct);
        }
    }


}
