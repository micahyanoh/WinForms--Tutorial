namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount ACC1 = new BankAccount();
            BankAccount ACC2 = new BankAccount();
            BankAccount ACC3 = new BankAccount();

            ACC1.AccountOwner = "Steve Jobs";
            ACC2.AccountOwner = "Elon Musk";
            ACC3.AccountOwner = "Mark Zuckerberg";

            ACC1.AccountNumber = Guid.NewGuid();
            ACC2.AccountNumber = Guid.NewGuid();
            ACC3.AccountNumber = Guid.NewGuid();

            ACC1.AccountBalance = 1800;
            ACC2.AccountBalance = 2700;
            ACC3.AccountBalance = 3600;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(ACC1);
            bankAccounts.Add(ACC2);
            bankAccounts.Add(ACC3);

            grd_AccountDetails.DataSource = bankAccounts;
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
    }
}
