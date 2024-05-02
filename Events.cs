using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventProject
{
	public partial class Events : Form
	{
		public Events()
		{
			InitializeComponent();
			ShowEvents();
			GetVenue();
			GetCustomer();
			GetCustomerName();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void ShowEvents()
		{
			conn.Open();
			string Query = "Select * from EventTb1";
			SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			EventDGV.DataSource = ds.Tables[0];
			conn.Close();
		}
		private void Clear()
		{
			EvNameTb.Text = "";
			CustNameTb.Text = "";
			StatusCb.SelectedIndex = -1;
			VenueNameTb.Text = "";
		}
		SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sweta\OneDrive\Documents\EventTb2.mdf;Integrated Security=False;Connect Timeout=30");
		private void GetCustomer()
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand("Select CustId from CustomerTb1", conn);
			SqlDataReader Rdr;
			Rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("CustId", typeof(int));
			dt.Load(Rdr);
			CustIdCb.ValueMember = "CustId";
			CustIdCb.DataSource = dt;

			conn.Close();
		}
		private void GetCustomerName()
		{
			conn.Open();
			string Query = "select * from CustomerTb1 where CustId =" + CustIdCb.SelectedValue.ToString() + "";
			SqlCommand cmd = new SqlCommand(Query, conn);
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				CustNameTb.Text = dr["CustName"].ToString();

			}
			conn.Close();
		}
		private void GetVenue()
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand("Select VId from VenueTb1", conn);
			SqlDataReader Rdr;
			Rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("VId", typeof(int));
			dt.Load(Rdr);
			EVIdCb.ValueMember = "VId";
			EVIdCb.DataSource = dt;

			conn.Close();
		}
		private void GetVenueName()
		{
			conn.Open();
			string Query = "select * from VenueTb1 where VId =" + EVIdCb.SelectedValue.ToString() + "";
			SqlCommand cmd = new SqlCommand(Query, conn);
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				VenueNameTb.Text = dr["VName"].ToString();

			}
			conn.Close();
		}
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (EvNameTb.Text == "" || CustNameTb.Text == "" || VenueNameTb.Text == "" || StatusCb.SelectedIndex == -1 )
			{
				MessageBox.Show("Missing Information");
			}
			else
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Insert into EventTb1(EVName,EVDate,VenueId,EVVenue,EVTime,EVCustId,EVCustName,EVStatus)values(@EN,@ED,@VI,@EV,@EVT,@ECI,@ECN,@ES)", conn);
					cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
					cmd.Parameters.AddWithValue("@ED", EvDate.Value.Date);
					cmd.Parameters.AddWithValue("@VI", EVIdCb.SelectedValue.ToString());
					cmd.Parameters.AddWithValue("@EV", VenueNameTb.Text);
					cmd.Parameters.AddWithValue("@EVT", EvTime.Value.TimeOfDay);
					cmd.Parameters.AddWithValue("@ECI", CustIdCb.SelectedValue.ToString());
					cmd.Parameters.AddWithValue("@ECN", CustNameTb.Text);
					cmd.Parameters.AddWithValue("@ES", StatusCb.SelectedItem.ToString());
					cmd.ExecuteNonQuery();
					MessageBox.Show("Event Added Successfully!");
					conn.Close();
					ShowEvents();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}

		private void EVIdCb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			GetVenueName();
		}

		private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			GetCustomerName();
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (EvNameTb.Text == "" || CustNameTb.Text == "" || VenueNameTb.Text == "" || StatusCb.SelectedIndex == -1 )
			{
				MessageBox.Show("Missing Information");
			}
			else
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Update EventTb1 Set EVName=@EN,EVDate=@ED,EVVenue=@EV,EVTime=@EVT,EVCustId=@ECI,EVCustName=@ECN,EVStatus=@ES where EvId = @EKey", conn);
					cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
					cmd.Parameters.AddWithValue("@ED", EvDate.Value.Date);
					cmd.Parameters.AddWithValue("@VI", EVIdCb.SelectedValue.ToString());
					cmd.Parameters.AddWithValue("@EV", VenueNameTb.Text);
					cmd.Parameters.AddWithValue("@EVT", EvTime.Value.TimeOfDay);
					cmd.Parameters.AddWithValue("@ECI", CustIdCb.SelectedValue.ToString());
					cmd.Parameters.AddWithValue("@ECN", CustNameTb.Text);
					cmd.Parameters.AddWithValue("@ES", StatusCb.SelectedItem.ToString());
					cmd.Parameters.AddWithValue("@EKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Event Updated");
					conn.Close();
					ShowEvents();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}
		int Key = 0;
		private void EventDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			EvNameTb.Text = EventDGV.SelectedRows[0].Cells[1].Value.ToString();
			EvDate.Text = EventDGV.SelectedRows[0].Cells[2].Value.ToString();
			EVIdCb.SelectedValue = EventDGV.SelectedRows[0].Cells[3].Value.ToString();
			VenueNameTb.Text = EventDGV.SelectedRows[0].Cells[4].Value.ToString();
			EvTime.Text = EventDGV.SelectedRows[0].Cells[5].Value.ToString();
			CustIdCb.SelectedValue = EventDGV.SelectedRows[0].Cells[6].Value.ToString();
			CustNameTb.Text = EventDGV.SelectedRows[0].Cells[7].Value.ToString();
			StatusCb.SelectedItem = EventDGV.SelectedRows[0].Cells[8].Value.ToString();

			if (EvNameTb.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(EventDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (EvNameTb.Text == "" || CustNameTb.Text == "" || VenueNameTb.Text == "" || StatusCb.SelectedIndex == -1 )
			{
				MessageBox.Show("Missing Information");
			}
			else
			{   
				try
				{

					conn.Open();
					SqlCommand cmd = new SqlCommand("Delete from EventTb1 where EVId = @EKey", conn);
					cmd.Parameters.AddWithValue("@EKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Event Deleted");
					conn.Close();
					ShowEvents();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Customer obj = new Customer();
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

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Home obj = new Home();
			obj.Show();
			this.Hide();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void Events_Load(object sender, EventArgs e)
		{

		}

		private void EventDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			EvNameTb.Text = EventDGV.SelectedRows[0].Cells[1].Value.ToString();
			EvDate.Text = EventDGV.SelectedRows[0].Cells[2].Value.ToString();
			EVIdCb.SelectedValue = EventDGV.SelectedRows[0].Cells[3].Value.ToString();
			VenueNameTb.Text = EventDGV.SelectedRows[0].Cells[4].Value.ToString();
			EvTime.Text = EventDGV.SelectedRows[0].Cells[5].Value.ToString();
			CustIdCb.SelectedValue = EventDGV.SelectedRows[0].Cells[6].Value.ToString();
			CustNameTb.Text = EventDGV.SelectedRows[0].Cells[7].Value.ToString();
			StatusCb.SelectedItem = EventDGV.SelectedRows[0].Cells[8].Value.ToString();

			if (EvNameTb.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(EventDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}
	}
}


