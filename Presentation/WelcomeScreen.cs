using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBS_Sales_Suit_App.BusinessLogic;
using TBS_Sales_Suit_App.DataAccess;
using TBS_Sales_Suit_App.Presentation;

namespace TBS_Sales_Suit_App
{
    public partial class WelcomeScreen : Form
    {
        TBSDbContext tbsDbContext;
        TBSRepository tbsRepository;
        public WelcomeScreen()
        {
            InitializeComponent();
            tbsDbContext = new TBSDbContext();
            tbsRepository = new TBSRepository(tbsDbContext);
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            //IHelper excelHelper = new ExcelHelper(tbsRepository);
            //excelHelper.ImportData(@"C:\1_Lavanya\Workspace\ABBAsignment\Files\TwinkleBookStoreRecord1.xlsx");

            if (tbsRepository.GetUsers().Count == 0)
            {
                tbsRepository.AddUsers();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User loggedInUser = new User();
            loggedInUser.UserName = txtBxUserName.Text;
            loggedInUser.Password = txtBxPassword.Text;

            loggedInUser = tbsRepository.ValidateUser(loggedInUser);
            if (loggedInUser != null)
            {
                this.Hide();

                MainForm mainForm = new MainForm(loggedInUser);
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();             
            }
            else
            {
                MessageBox.Show("Login failed. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
