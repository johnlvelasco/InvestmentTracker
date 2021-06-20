using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentTracker
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            this.AcceptButton = uxSubmit; 
        }
        /// <summary>
        /// User-inputted username.
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// User-inputted password. Should be encrypted at this level with no access to a key.
        /// The Program.cs should have a decrypter. 
        /// </summary>
        public string Password { get; private set;  }

        /// <summary>
        /// Click event to submit username and password input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSubmit_Click(object sender, EventArgs e)
        {
            Username = uxUsername.Text;
            Password = uxPassword.Text;
            Application.Exit(); 
        }

    }
}
