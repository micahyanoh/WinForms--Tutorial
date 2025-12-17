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
            grdProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdProducts).BeginInit();
            SuspendLayout();
            // 
            // grdProducts
            // 
            grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProducts.Location = new Point(12, 29);
            grdProducts.Name = "grdProducts";
            grdProducts.Size = new Size(776, 363);
            grdProducts.TabIndex = 0;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grdProducts);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += this.ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdProducts;
    }
}
