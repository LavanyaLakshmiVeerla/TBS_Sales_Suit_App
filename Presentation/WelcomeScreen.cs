﻿using iTextSharp.xmp.properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    /// <summary>
    /// Class to implement user login
    /// </summary>
    public partial class WelcomeScreen : Form
    {
        IContext tbsDbContext;
        TBSRepository tbsRepository;

        /// <summary>
        /// constructor
        /// </summary>
        public WelcomeScreen()
        {
            InitializeComponent();
            tbsDbContext = new TBSDbContext();
            tbsRepository = new TBSRepository(tbsDbContext);
        }

        /// <summary>
        /// this method adds default users into the database when the database is first created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            try
            {
                if (tbsRepository.GetUsers().Count == 0)
                {
                    tbsRepository.AddUsers();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Connection ", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        /// <summary>
        /// his method is used to direct calls to check user login validation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
