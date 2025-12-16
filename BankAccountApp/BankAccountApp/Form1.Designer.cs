namespace BankAccountApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lb_Owner = new Label();
            lb_Amount = new Label();
            txt_Owner = new TextBox();
            num_Amt = new NumericUpDown();
            grd_AccountDetails = new DataGridView();
            btn_Deposit = new Button();
            btn_Withdraw = new Button();
            btn_CreateAcc = new Button();
            ((System.ComponentModel.ISupportInitialize)num_Amt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grd_AccountDetails).BeginInit();
            SuspendLayout();
            // 
            // lb_Owner
            // 
            lb_Owner.AutoSize = true;
            lb_Owner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Owner.ForeColor = SystemColors.MenuHighlight;
            lb_Owner.Location = new Point(25, 34);
            lb_Owner.Name = "lb_Owner";
            lb_Owner.Size = new Size(51, 15);
            lb_Owner.TabIndex = 0;
            lb_Owner.Text = "Owner :";
            lb_Owner.Click += label1_Click;
            // 
            // lb_Amount
            // 
            lb_Amount.AutoSize = true;
            lb_Amount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Amount.ForeColor = SystemColors.MenuHighlight;
            lb_Amount.Location = new Point(25, 339);
            lb_Amount.Name = "lb_Amount";
            lb_Amount.Size = new Size(58, 15);
            lb_Amount.TabIndex = 1;
            lb_Amount.Text = "Amount :";
            // 
            // txt_Owner
            // 
            txt_Owner.Location = new Point(80, 30);
            txt_Owner.Name = "txt_Owner";
            txt_Owner.Size = new Size(204, 23);
            txt_Owner.TabIndex = 2;
            txt_Owner.TextChanged += textBox1_TextChanged;
            // 
            // num_Amt
            // 
            num_Amt.Location = new Point(94, 335);
            num_Amt.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            num_Amt.Minimum = new decimal(new int[] { 1410065407, 2, 0, int.MinValue });
            num_Amt.Name = "num_Amt";
            num_Amt.Size = new Size(204, 23);
            num_Amt.TabIndex = 3;
            // 
            // grd_AccountDetails
            // 
            grd_AccountDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_AccountDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_AccountDetails.Location = new Point(337, 30);
            grd_AccountDetails.Name = "grd_AccountDetails";
            grd_AccountDetails.Size = new Size(440, 239);
            grd_AccountDetails.TabIndex = 4;
            // 
            // btn_Deposit
            // 
            btn_Deposit.BackColor = SystemColors.ActiveCaption;
            btn_Deposit.Location = new Point(386, 335);
            btn_Deposit.Name = "btn_Deposit";
            btn_Deposit.Size = new Size(151, 23);
            btn_Deposit.TabIndex = 5;
            btn_Deposit.Text = "Deposit";
            btn_Deposit.UseVisualStyleBackColor = false;
            btn_Deposit.Click += btn_Deposit_Click;
            // 
            // btn_Withdraw
            // 
            btn_Withdraw.BackColor = SystemColors.ActiveCaption;
            btn_Withdraw.Location = new Point(588, 335);
            btn_Withdraw.Name = "btn_Withdraw";
            btn_Withdraw.Size = new Size(151, 23);
            btn_Withdraw.TabIndex = 6;
            btn_Withdraw.Text = "Withdraw";
            btn_Withdraw.UseVisualStyleBackColor = false;
            btn_Withdraw.Click += btn_Withdraw_Click;
            // 
            // btn_CreateAcc
            // 
            btn_CreateAcc.BackColor = SystemColors.ActiveCaption;
            btn_CreateAcc.Location = new Point(107, 68);
            btn_CreateAcc.Name = "btn_CreateAcc";
            btn_CreateAcc.Size = new Size(151, 23);
            btn_CreateAcc.TabIndex = 7;
            btn_CreateAcc.Text = "Create Account";
            btn_CreateAcc.UseVisualStyleBackColor = false;
            btn_CreateAcc.Click += btn_CreateAcc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_CreateAcc);
            Controls.Add(btn_Withdraw);
            Controls.Add(btn_Deposit);
            Controls.Add(grd_AccountDetails);
            Controls.Add(num_Amt);
            Controls.Add(txt_Owner);
            Controls.Add(lb_Amount);
            Controls.Add(lb_Owner);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ATM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)num_Amt).EndInit();
            ((System.ComponentModel.ISupportInitialize)grd_AccountDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Owner;
        private Label lb_Amount;
        private TextBox txt_Owner;
        private NumericUpDown num_Amt;
        private DataGridView grd_AccountDetails;
        private Button btn_Deposit;
        private Button btn_Withdraw;
        private Button btn_CreateAcc;
    }
}
