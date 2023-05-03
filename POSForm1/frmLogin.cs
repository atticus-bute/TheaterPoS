namespace POSForm1
{
    public partial class frmLogin : Form
    {
        frmMenu menu;
        bool loggedIn = false;
        Employee currentUser;
        List<Employee> staff = new List<Employee>()
        {
            new Employee("Andrew Karley","0609",true),
            new Employee("Atticus Bute","9848",true),
            new Employee("Connor Otis","5555",true),
            new Employee("Nikol Glimmer","2340",false),
            new Employee("Admin","1234",true),
        };
        public frmLogin()
        {
            InitializeComponent();
        }
        public void LoginSwitch()
        {
            if (!loggedIn)
            {
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                btnToMenu.Enabled = false;
                btnRefund.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;
                btnToMenu.Enabled = true;
                btnRefund.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginSwitch();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLoginResult.Text = string.Empty;
            loggedIn = false;
            
                foreach (Employee emp in staff)
                {
                    if (loggedIn) break;
                    if (emp.Pin == txtPin.Text)
                    {
                        currentUser = emp;
                        loggedIn = true;
                    }
                }
            if (loggedIn == false) { lblLoginResult.Text = "Invalid Credentials."; }
            else
            {
                menu = new frmMenu(currentUser);
                menu.ShowDialog();
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin PIN: 1234");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            loggedIn = false;
            txtPin.Text = string.Empty;
            lblLoginResult.Text = string.Empty;
            LoginSwitch();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            LoginSwitch();
            if (currentUser != null)
            {
                lblLoginResult.Text = $"Logged in as {currentUser.Name}";
            }
        }

        private void btnToMenu_Click(object sender, EventArgs e)
        {
            menu.Show();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (!currentUser.Manager)
            {
                lblLoginResult.Text = "Manager credentials required for refunds.";
            }
            else 
            {
                frmRefund refunds = new frmRefund();
                refunds.ShowDialog();
            }
        }

        private void btnEndShift_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}