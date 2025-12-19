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
            txt_Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdProducts).BeginInit();
            SuspendLayout();
            // 
            // grdProducts
            // 
            grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProducts.Location = new Point(9, 68);
            grdProducts.Name = "grdProducts";
            grdProducts.Size = new Size(372, 220);
            grdProducts.TabIndex = 0;
            grdProducts.CellContentClick += grdProducts_CellContentClick;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(9, 30);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(372, 23);
            txt_Search.TabIndex = 1;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Search);
            Controls.Add(grdProducts);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdProducts;
        private TextBox txt_Search;
    }
}
