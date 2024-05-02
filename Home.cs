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
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Events obj = new Events();
			obj.Show();
			this.Hide();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			Customer obj = new Customer();
			obj.Show();
			this.Hide();
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			Venue obj = new Venue();
			obj.Show();
			this.Hide();
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			Feedback obj = new Feedback();
			obj.Show();
			this.Hide();
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			UserLogin obj = new UserLogin();
			obj.Show();
			this.Hide();
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			DashBoard obj = new DashBoard();
			obj.Show();
			this.Hide();
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
