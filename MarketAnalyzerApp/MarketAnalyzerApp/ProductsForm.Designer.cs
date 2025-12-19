namespace MarketAnalyzerApp
{
    partial class ProductsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grdProducts = new DataGridView();
            txt_Search = new TextBox();
            chart_Price = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)grdProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_Price).BeginInit();
            SuspendLayout();
            // 
            // grdProducts
            // 
            grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProducts.Location = new Point(9, 75);
            grdProducts.Name = "grdProducts";
            grdProducts.Size = new Size(372, 323);
            grdProducts.TabIndex = 0;
            grdProducts.CellContentClick += grdProducts_CellContentClick;
            grdProducts.CellDoubleClick += grdProducts_CellDoubleClick;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(9, 30);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(372, 23);
            txt_Search.TabIndex = 1;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // chart_Price
            // 
            chartArea1.Name = "ChartArea1";
            chart_Price.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_Price.Legends.Add(legend1);
            chart_Price.Location = new Point(404, 75);
            chart_Price.Name = "chart_Price";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Price.Series.Add(series1);
            chart_Price.Size = new Size(365, 323);
            chart_Price.TabIndex = 2;
            chart_Price.Text = "chart1";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart_Price);
            Controls.Add(txt_Search);
            Controls.Add(grdProducts);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_Price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdProducts;
        private TextBox txt_Search;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Price;
    }
}
