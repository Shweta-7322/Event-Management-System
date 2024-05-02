using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EventProject
{
	public partial class Venue : Form
	{
		public Venue()
		{
			InitializeComponent();
			ShowVenue();
		}
		private void ShowVenue()
		{
			conn.Open();
			string Query = "Select * from VenueTb1";
			SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			VenueDGV.DataSource = ds.Tables[0];
			conn.Close();
		}
		private void Clear()
		{
			VNameTB.Text = "";
			VPhoneTb.Text = "";
			VCapacityTb.Text = "";
			VManagerTb.Text = "";
			VAddressTb.Text = "";
		}
		SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sweta\OneDrive\Documents\EventTb2.mdf;Integrated Security=True;Connect Timeout=30");
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (VAddressTb.Text == "" || VNameTB.Text == "" || VPhoneTb.Text == "" || VCapacityTb.Text == "" || VManagerTb.Text == "" || VPhoneTb.TextLength != 10 || VPhoneTb.TextLength > 10)
			{
				MessageBox.Show("Missing Information or Enter the 10 digit phone number");
			}
			else
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Insert into VenueTb1(VName,VCapacity,VAddress,VManager,VPhone)values(@VN,@VC,@VA,@VM,@VP)", conn);
					cmd.Parameters.AddWithValue("@VN", VNameTB.Text);
					cmd.Parameters.AddWithValue("@VC", VCapacityTb.Text);
					cmd.Parameters.AddWithValue("@VA", VAddressTb.Text);
					cmd.Parameters.AddWithValue("@VM", VManagerTb.Text);
					cmd.Parameters.AddWithValue("@VP", VPhoneTb.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Venue Added");
					conn.Close();
					ShowVenue();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}
		int Key = 0;

		private void VenueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			VNameTB.Text = VenueDGV.SelectedRows[0].Cells[1].Value.ToString();
			VCapacityTb.Text = VenueDGV.SelectedRows[0].Cells[2].Value.ToString();
			VAddressTb.Text = VenueDGV.SelectedRows[0].Cells[3].Value.ToString();
			VManagerTb.Text = VenueDGV.SelectedRows[0].Cells[4].Value.ToString();
			VPhoneTb.Text = VenueDGV.SelectedRows[0].Cells[5].Value.ToString();
			if (VNameTB.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(VenueDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{

			conn.Open();
			SqlCommand cmd = new SqlCommand("Delete from VenueTb1 where VId = @VKey", conn);
			cmd.Parameters.AddWithValue("@VKey", Key);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Venue Deleted");
			conn.Close();
			ShowVenue();
			Clear();


		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (VAddressTb.Text == "" || VNameTB.Text == "" || VPhoneTb.Text == "" || VCapacityTb.Text == "" || VManagerTb.Text == "")
			{
				MessageBox.Show("Missing Information");
			}
			else
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Update VenueTb1 Set VName=@VN,VCapacity=@VC,VAddress=@VA,VManager=@VM,VPhone=@VP where VId = @VKey", conn);
					cmd.Parameters.AddWithValue("@VN", VNameTB.Text);
					cmd.Parameters.AddWithValue("@VC", VCapacityTb.Text);
					cmd.Parameters.AddWithValue("@VA", VAddressTb.Text);
					cmd.Parameters.AddWithValue("@VM", VManagerTb.Text);
					cmd.Parameters.AddWithValue("@VP", VPhoneTb.Text);
					cmd.Parameters.AddWithValue("@VKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Venue Updated");
					conn.Close();
					ShowVenue();
					Clear();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			Home obj = new Home();
			obj.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Feedback obj = new Feedback();
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

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void VenueDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			VNameTB.Text = VenueDGV.SelectedRows[0].Cells[1].Value.ToString();
			VCapacityTb.Text = VenueDGV.SelectedRows[0].Cells[2].Value.ToString();
			VAddressTb.Text = VenueDGV.SelectedRows[0].Cells[3].Value.ToString();
			VManagerTb.Text = VenueDGV.SelectedRows[0].Cells[4].Value.ToString();
			VPhoneTb.Text = VenueDGV.SelectedRows[0].Cells[5].Value.ToString();
			if (VNameTB.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(VenueDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}
	}
}



