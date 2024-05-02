using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventProject
{
	public partial class DashBoard : Form
	{
		public DashBoard()
		{
			InitializeComponent();
			CountEvents();
			CountCustomers();
			CountVenues();
			CountExcellent();
			CountGood();
			CountOkay();
			CountBad();
		}
		SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sweta\OneDrive\Documents\EventTb2.mdf;Integrated Security=True;Connect Timeout=30");
		private void CountEvents()
		{
			conn.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from EventTb1", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Eventlb.Text = dt.Rows[0][0].ToString();
			conn.Close();
		}
		private void CountCustomers()
		{
			conn.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from CustomerTb1", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Customerlb.Text = dt.Rows[0][0].ToString();
			conn.Close();
		}
		private void CountVenues()
		{
			conn.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from VenueTb1", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Venuelb.Text = dt.Rows[0][0].ToString();
			conn.Close();
		}
		private void CountExcellent()
		{
			conn.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from FeedBackTb1 where OverAll = " + 4 + "", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Excellentlb.Text = dt.Rows[0][0].ToString();
			conn.Close();
		}
		private void CountGood()
		{
			conn.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from FeedBackTb1 where OverAll = " + 3 + "", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Goodlb.Text = dt.Rows[0][0].ToString();
			conn.Close();
		}
		private void CountOkay()
		{
			conn.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from FeedBackTb1 where OverAll = " + 2 + "", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Okaylb.Text = dt.Rows[0][0].ToString();
			conn.Close();
		}
		private void CountBad()
		{
			conn.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from FeedBackTb1 where OverAll = " + 0 + "", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Badlb.Text = dt.Rows[0][0].ToString();
			conn.Close();
		}


		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Events obj = new Events();
			obj.Show();
			this.Hide();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Customer obj = new Customer();
			obj.Show();
			this.Hide();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{

			Home obj = new Home();
			obj.Show();
			this.Hide();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Venue obj = new Venue();
			obj.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Feedback obj = new Feedback();
			obj.Show();
			this.Hide();
		}
	}
}
