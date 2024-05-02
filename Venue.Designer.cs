namespace EventProject
{
	partial class Venue
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venue));
			DeleteBtn = new Button();
			EditBtn = new Button();
			SaveBtn = new Button();
			label5 = new Label();
			VNameTB = new TextBox();
			VenueDGV = new DataGridView();
			panel4 = new Panel();
			pictureBox5 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			panel2 = new Panel();
			pictureBox7 = new PictureBox();
			label1 = new Label();
			panel1 = new Panel();
			pictureBox6 = new PictureBox();
			VCapacityTb = new TextBox();
			VAddressTb = new TextBox();
			VManagerTb = new TextBox();
			VPhoneTb = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)VenueDGV).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			// 
			// DeleteBtn
			// 
			DeleteBtn.BackColor = Color.Purple;
			DeleteBtn.ForeColor = SystemColors.ButtonHighlight;
			DeleteBtn.Location = new Point(758, 685);
			DeleteBtn.Margin = new Padding(4, 3, 4, 3);
			DeleteBtn.Name = "DeleteBtn";
			DeleteBtn.Size = new Size(121, 47);
			DeleteBtn.TabIndex = 51;
			DeleteBtn.Text = "Delete";
			DeleteBtn.UseVisualStyleBackColor = false;
			DeleteBtn.Click += DeleteBtn_Click;
			// 
			// EditBtn
			// 
			EditBtn.BackColor = Color.Purple;
			EditBtn.ForeColor = SystemColors.ButtonHighlight;
			EditBtn.Location = new Point(571, 685);
			EditBtn.Margin = new Padding(4, 3, 4, 3);
			EditBtn.Name = "EditBtn";
			EditBtn.Size = new Size(124, 47);
			EditBtn.TabIndex = 50;
			EditBtn.Text = "Edit";
			EditBtn.UseVisualStyleBackColor = false;
			EditBtn.Click += EditBtn_Click;
			// 
			// SaveBtn
			// 
			SaveBtn.BackColor = Color.Purple;
			SaveBtn.ForeColor = SystemColors.ButtonHighlight;
			SaveBtn.Location = new Point(368, 685);
			SaveBtn.Margin = new Padding(4, 3, 4, 3);
			SaveBtn.Name = "SaveBtn";
			SaveBtn.Size = new Size(137, 47);
			SaveBtn.TabIndex = 49;
			SaveBtn.Text = "Save";
			SaveBtn.UseVisualStyleBackColor = false;
			SaveBtn.Click += SaveBtn_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(86, 479);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(119, 25);
			label5.TabIndex = 34;
			label5.Text = "Venue Name";
			// 
			// VNameTB
			// 
			VNameTB.Location = new Point(86, 507);
			VNameTB.Margin = new Padding(4, 3, 4, 3);
			VNameTB.Name = "VNameTB";
			VNameTB.Size = new Size(206, 27);
			VNameTB.TabIndex = 33;
			// 
			// VenueDGV
			// 
			VenueDGV.AccessibleRole = AccessibleRole.Row;
			VenueDGV.AllowUserToDeleteRows = false;
			VenueDGV.AllowUserToOrderColumns = true;
			VenueDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			VenueDGV.BackgroundColor = Color.FromArgb(255, 192, 255);
			VenueDGV.BorderStyle = BorderStyle.Fixed3D;
			VenueDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 255);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			VenueDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			VenueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			VenueDGV.GridColor = Color.FromArgb(255, 192, 255);
			VenueDGV.Location = new Point(26, 118);
			VenueDGV.Margin = new Padding(4, 3, 4, 3);
			VenueDGV.Name = "VenueDGV";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 255);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			VenueDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			VenueDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			VenueDGV.Size = new Size(1343, 338);
			VenueDGV.TabIndex = 32;
			VenueDGV.CellClick += VenueDGV_CellClick;
			VenueDGV.CellContentClick += VenueDGV_CellContentClick;
			// 
			// panel4
			// 
			panel4.BackColor = Color.Purple;
			panel4.Location = new Point(36, 462);
			panel4.Margin = new Padding(4, 3, 4, 3);
			panel4.Name = "panel4";
			panel4.Size = new Size(1333, 5);
			panel4.TabIndex = 31;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(416, 3);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(62, 52);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 29;
			pictureBox5.TabStop = false;
			pictureBox5.Click += pictureBox5_Click;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(553, 3);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(53, 55);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 14;
			pictureBox4.TabStop = false;
			pictureBox4.Click += pictureBox4_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(919, 6);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(65, 52);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 29;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(795, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(52, 52);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 30;
			pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Purple;
			panel2.Controls.Add(pictureBox7);
			panel2.Controls.Add(pictureBox5);
			panel2.Controls.Add(pictureBox4);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(pictureBox2);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 766);
			panel2.Margin = new Padding(4, 3, 4, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(1403, 58);
			panel2.TabIndex = 30;
			panel2.Paint += panel2_Paint;
			// 
			// pictureBox7
			// 
			pictureBox7.BackColor = Color.Thistle;
			pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.Location = new Point(669, 3);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new Size(53, 55);
			pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox7.TabIndex = 32;
			pictureBox7.TabStop = false;
			pictureBox7.Click += pictureBox7_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(482, 24);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(303, 54);
			label1.TabIndex = 2;
			label1.Text = "Manage Venue";
			// 
			// panel1
			// 
			panel1.BackColor = Color.Purple;
			panel1.Controls.Add(pictureBox6);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(1403, 112);
			panel1.TabIndex = 29;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(1375, 3);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(28, 30);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 60;
			pictureBox6.TabStop = false;
			pictureBox6.Click += pictureBox6_Click;
			// 
			// VCapacityTb
			// 
			VCapacityTb.Location = new Point(339, 507);
			VCapacityTb.Margin = new Padding(4, 3, 4, 3);
			VCapacityTb.Name = "VCapacityTb";
			VCapacityTb.Size = new Size(206, 27);
			VCapacityTb.TabIndex = 52;
			// 
			// VAddressTb
			// 
			VAddressTb.Location = new Point(591, 507);
			VAddressTb.Margin = new Padding(4, 3, 4, 3);
			VAddressTb.Multiline = true;
			VAddressTb.Name = "VAddressTb";
			VAddressTb.Size = new Size(210, 76);
			VAddressTb.TabIndex = 53;
			// 
			// VManagerTb
			// 
			VManagerTb.Location = new Point(877, 507);
			VManagerTb.Margin = new Padding(4, 3, 4, 3);
			VManagerTb.Name = "VManagerTb";
			VManagerTb.Size = new Size(206, 27);
			VManagerTb.TabIndex = 54;
			// 
			// VPhoneTb
			// 
			VPhoneTb.Location = new Point(1103, 507);
			VPhoneTb.Margin = new Padding(4, 3, 4, 3);
			VPhoneTb.Name = "VPhoneTb";
			VPhoneTb.Size = new Size(206, 27);
			VPhoneTb.TabIndex = 55;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(339, 479);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(81, 25);
			label2.TabIndex = 56;
			label2.Text = "Capacity";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(591, 479);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(79, 25);
			label3.TabIndex = 57;
			label3.Text = "Address";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(877, 479);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(144, 25);
			label4.TabIndex = 58;
			label4.Text = "Venue Manager";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Black;
			label6.Location = new Point(1103, 479);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(65, 25);
			label6.TabIndex = 59;
			label6.Text = "Phone";
			// 
			// Venue
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1403, 824);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(VPhoneTb);
			Controls.Add(VManagerTb);
			Controls.Add(VAddressTb);
			Controls.Add(VCapacityTb);
			Controls.Add(DeleteBtn);
			Controls.Add(EditBtn);
			Controls.Add(SaveBtn);
			Controls.Add(label5);
			Controls.Add(VNameTB);
			Controls.Add(VenueDGV);
			Controls.Add(panel4);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Venue";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Venuecs";
			((System.ComponentModel.ISupportInitialize)VenueDGV).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button DeleteBtn;
		private Button EditBtn;
		private Button SaveBtn;
		private Label label5;
		private TextBox VNameTB;
		private DataGridView VenueDGV;
		private Panel panel4;
		private PictureBox pictureBox5;
		private PictureBox pictureBox4;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Panel panel2;
		private Label label1;
		private Panel panel1;
		private TextBox VCapacityTb;
		private TextBox VAddressTb;
		private TextBox VManagerTb;
		private TextBox VPhoneTb;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label6;
		private PictureBox pictureBox6;
		private PictureBox pictureBox7;
	}
}