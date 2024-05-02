using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventProject
{
	public partial class UserLogin : Form
	{
		public UserLogin()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			UnameTb.Text = "";
			PasswordTb.Text = "";
		}

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			if (UnameTb.Text == "" || PasswordTb.Text == "")
			{
				MessageBox.Show("Enter Both username and password");
			}
			else if (UnameTb.Text == "Admin" && PasswordTb.Text == "Password")
			{
				Home obj = new Home();
				obj.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Wrong Username and Password");
			}	
		}
	}
}
