namespace BankAccountApp
{
    public partial class Form1 : Form
    {

        List<BankAccount> BankAccounts = new List<BankAccount>(); // GLOBAL VARIABLE TO HOLD BANK ACCOUNTS
        //good practice to use uppercase for global variables
        public Form1()
        {
            InitializeComponent();

            //BankAccount ACC1 = new BankAccount();
            //BankAccount ACC2 = new BankAccount();
            //BankAccount ACC3 = new BankAccount();

            //ACC1.AccountOwner = "Steve Jobs";
            //ACC2.AccountOwner = "Elon Musk";
            //ACC3.AccountOwner = "Mark Zuckerberg";

            //ACC1.AccountNumber = Guid.NewGuid();
            //ACC2.AccountNumber = Guid.NewGuid();
            //ACC3.AccountNumber = Guid.NewGuid();

            //ACC1.AccountBalance = 1800;
            //ACC2.AccountBalance = 2700;
            //ACC3.AccountBalance = 3600;


            /* using constructors*/
            //BankAccount ACC1 = new BankAccount("Steve Jobs");
            //BankAccount ACC2 = new BankAccount("Elon Musk");
            //BankAccount ACC3 = new BankAccount("Mark Zuckerberg");
            //BankAccount ACC4 = new BankAccount("Bill Gates");


            //List<BankAccount> bankAccounts = new List<BankAccount>(); ---MOVED THIS TO CLASS LEVEL AS A GLOBAL VARIABLE
            //bankAccounts.Add(ACC1);
            //bankAccounts.Add(ACC2);
            //bankAccounts.Add(ACC3);
            //bankAccounts.Add(ACC4);

            //grd_AccountDetails.DataSource = bankAccounts;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Owner.Text))
            {
                MessageBox.Show("Owner field can't be empty");
                return;
            }
            if (num_IntRate.Value > 0)
            {

                // BankAccount savAcc = new SavingsAccount(txt_Owner.Text, num_IntRate.Value);
                BankAccounts.Add(new SavingsAccount(txt_Owner.Text, num_IntRate.Value));

            }
            else { BankAccounts.Add(new BankAccount(txt_Owner.Text)); }
           // BankAccount bankAcc = new BankAccount(txt_Owner.Text);
            
            //grd_AccountDetails.DataSource = null;
            //grd_AccountDetails.DataSource = BankAccounts; MOVED TO REFRESH GRID METHOD FOR REUSABILITY
            MessageBox.Show("Account Created Successfully!");
            RefreshGrid();
            txt_Owner.Text = string.Empty;//clears the text box
            num_IntRate.Value = 0;
        }

        private void RefreshGrid()
        {
            grd_AccountDetails.DataSource = null;
            grd_AccountDetails.DataSource = BankAccounts;
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            if (grd_AccountDetails.SelectedRows.Count == 1)
            {
                BankAccount selAcc = grd_AccountDetails.SelectedRows[0].DataBoundItem as BankAccount;
                string msg = selAcc.Deposit(num_Amt.Value);
                MessageBox.Show(msg);
                RefreshGrid();
                num_Amt.Value = 0;
            }
            else
            {
                MessageBox.Show("Please select an account and enter a valid amount greater than zero.");

            }
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            if (grd_AccountDetails.SelectedRows.Count == 1)
            {
                BankAccount selAcc = grd_AccountDetails.SelectedRows[0].DataBoundItem as BankAccount;
                string msg = selAcc.Withdraw(num_Amt.Value);
                MessageBox.Show(msg);
                RefreshGrid();
                num_Amt.Value = 0;
            }
            else
            {
                MessageBox.Show("Please select an account and enter a valid amount greater than zero.");

            }
        }

        
    }
}
