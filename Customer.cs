using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventProject
{
	public partial class Customer : Form
	{
		public Customer()
		{
			InitializeComponent();
			ShowCustomer();
		}
		SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sweta\OneDrive\Documents\EventTb2.mdf;Integrated Security=True;Connect Timeout=30");

		private void ShowCustomer()
		{
			conn.Open();
			string Query = "Select * from CustomerTb1";
			SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			CustomerDGV.DataSource = ds.Tables[0];
			conn.Close();
		}
		private void Clear()
		{
			CustNameTb.Text = "";
			CustPhoneTb.Text = "";
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

		private void pictureBox3_Click(object sender, EventArgs e)
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

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (CustNameTb.Text == "" || CustPhoneTb.Text == "" || CustPhoneTb.TextLength != 10 || CustPhoneTb.TextLength > 10)
			{
				MessageBox.Show("Missing Information or Enter the 10 digit phone number");
			}
			else
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Insert into CustomerTb1(CustName,CustPhone)values(@CN,@CP)", conn);
					cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
					cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Customer Added Successfully");
					conn.Close();
					ShowCustomer();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}
		int Key = 0;
		private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
			CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
			if (CustNameTb.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (CustNameTb.Text == "" || CustPhoneTb.Text == "" || CustPhoneTb.TextLength != 10 || CustPhoneTb.TextLength > 10)
			{
				MessageBox.Show("Missing Information or Enter the 10 digit phone number");
			}
			else
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Update CustomerTb1 Set CustName=@CN,CustPhone=@CP where CustId = @CKey", conn);
					cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
					cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);
					cmd.Parameters.AddWithValue("@CKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Customer Updated");
					conn.Close();
					ShowCustomer();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (CustNameTb.Text == "" || CustPhoneTb.Text == "")
			{
				MessageBox.Show("Missing Information");
			}
			else
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Delete from CustomerTb1 where  CustId = @CKey", conn);
					cmd.Parameters.AddWithValue("@CKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Customer Deleted Successfully");
					conn.Close();
					ShowCustomer();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}

		private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
			CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
			if (CustNameTb.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void Customer_Load(object sender, EventArgs e)
		{

		}
	}
}

