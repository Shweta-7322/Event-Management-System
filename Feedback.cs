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
	public partial class Feedback : Form
	{
		public Feedback()
		{
			InitializeComponent();
			ShowFeedback();
			GetEvent();
		}
		private void ShowFeedback()
		{
			conn.Open();
			string Query = "Select * from FeedbackTb1";
			SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			FeedbackDGV.DataSource = ds.Tables[0];
			conn.Close();
		}
		private void Clear()
		{
			EvNameTb.Text = "";
			HospitalityCb.SelectedItem = -1;
			PonctualityCb.SelectedIndex = -1;
			VenueCb.SelectedIndex = -1;
		}
		SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sweta\OneDrive\Documents\EventTb2.mdf;Integrated Security=True;Connect Timeout=30");
		private void GetEvent()
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand("Select EvId from EventTb1", conn);
			SqlDataReader Rdr;
			Rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("EvId", typeof(int));
			dt.Load(Rdr);
			EvIdCb.ValueMember = "EvId";
			EvIdCb.DataSource = dt;

			conn.Close();
		}
		private void GetEventName()
		{
			conn.Open();
			string Query = "select * from EventTb1 where EvId =" + EvIdCb.SelectedValue.ToString() + "";
			SqlCommand cmd = new SqlCommand(Query, conn);
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				EvNameTb.Text = dr["EvName"].ToString();

			}
			conn.Close();
		}
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (EvNameTb.Text == "" || VenueCb.SelectedIndex == -1 || HospitalityCb.SelectedIndex == -1 || PonctualityCb.SelectedIndex == -1)
			{
				MessageBox.Show("Missing Information");
			}
			else
			{
				try
				{
					int Overall = (HospitalityCb.SelectedIndex + VenueCb.SelectedIndex + PonctualityCb.SelectedIndex + 3) / 3;
					conn.Open();
					SqlCommand cmd = new SqlCommand("Insert into FeedbackTb1(EvId,EVName,Venue,Ponctuality,Hospitality,OverAll)values(@EI,@EN,@V,@P,@H,@O)", conn);
					cmd.Parameters.AddWithValue("@EI", EvIdCb.SelectedValue.ToString());
					cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
					cmd.Parameters.AddWithValue("@V", VenueCb.SelectedIndex + 1);
					cmd.Parameters.AddWithValue("@H", HospitalityCb.SelectedIndex + 1);
					cmd.Parameters.AddWithValue("@P", PonctualityCb.SelectedIndex + 1);
					cmd.Parameters.AddWithValue("@O", Overall);
					cmd.ExecuteNonQuery();
					MessageBox.Show("FeedBack Submitted");
					conn.Close();
					ShowFeedback();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}

		private void EvIdCb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			GetEventName();
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void FeedbackDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Customer obj = new Customer();
			obj.Show();
			this.Hide();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Events obj = new Events();
			obj.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
		
		private void FeedbackDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}


