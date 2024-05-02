namespace EventProject
{
	partial class Feedback
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
			ResetBtn = new Button();
			SaveBtn = new Button();
			EvIdCb = new ComboBox();
			label5 = new Label();
			FeedbackDGV = new DataGridView();
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
			EvNameTb = new TextBox();
			VenueCb = new ComboBox();
			PonctualityCb = new ComboBox();
			HospitalityCb = new ComboBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label6 = new Label();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)FeedbackDGV).BeginInit();
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
			// ResetBtn
			// 
			ResetBtn.BackColor = Color.Purple;
			ResetBtn.ForeColor = SystemColors.ButtonHighlight;
			ResetBtn.Location = new Point(751, 655);
			ResetBtn.Margin = new Padding(4, 3, 4, 3);
			ResetBtn.Name = "ResetBtn";
			ResetBtn.Size = new Size(157, 47);
			ResetBtn.TabIndex = 51;
			ResetBtn.Text = "Reset";
			ResetBtn.UseVisualStyleBackColor = false;
			ResetBtn.Click += DeleteBtn_Click;
			// 
			// SaveBtn
			// 
			SaveBtn.BackColor = Color.Purple;
			SaveBtn.ForeColor = SystemColors.ButtonHighlight;
			SaveBtn.Location = new Point(497, 655);
			SaveBtn.Margin = new Padding(4, 3, 4, 3);
			SaveBtn.Name = "SaveBtn";
			SaveBtn.Size = new Size(170, 47);
			SaveBtn.TabIndex = 49;
			SaveBtn.Text = "Submit";
			SaveBtn.UseVisualStyleBackColor = false;
			SaveBtn.Click += SaveBtn_Click;
			// 
			// EvIdCb
			// 
			EvIdCb.FormattingEnabled = true;
			EvIdCb.Location = new Point(61, 555);
			EvIdCb.Margin = new Padding(4, 3, 4, 3);
			EvIdCb.Name = "EvIdCb";
			EvIdCb.Size = new Size(220, 28);
			EvIdCb.TabIndex = 45;
			EvIdCb.SelectionChangeCommitted += EvIdCb_SelectionChangeCommitted;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(331, 527);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(112, 25);
			label5.TabIndex = 34;
			label5.Text = "Event Name";
			// 
			// FeedbackDGV
			// 
			FeedbackDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			FeedbackDGV.BackgroundColor = Color.FromArgb(255, 192, 255);
			FeedbackDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			FeedbackDGV.Location = new Point(13, 118);
			FeedbackDGV.Margin = new Padding(4, 3, 4, 3);
			FeedbackDGV.Name = "FeedbackDGV";
			FeedbackDGV.RowHeadersWidth = 51;
			FeedbackDGV.Size = new Size(1350, 362);
			FeedbackDGV.TabIndex = 32;
			FeedbackDGV.CellClick += FeedbackDGV_CellClick;
			FeedbackDGV.CellContentClick += FeedbackDGV_CellContentClick;
			// 
			// panel4
			// 
			panel4.BackColor = Color.Purple;
			panel4.Location = new Point(13, 476);
			panel4.Margin = new Padding(4, 3, 4, 3);
			panel4.Name = "panel4";
			panel4.Size = new Size(1351, 10);
			panel4.TabIndex = 31;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(443, 17);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(49, 41);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 29;
			pictureBox5.TabStop = false;
			pictureBox5.Click += pictureBox5_Click;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(556, 14);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(50, 44);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 14;
			pictureBox4.TabStop = false;
			pictureBox4.Click += pictureBox4_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(894, 14);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(47, 41);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 29;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(793, 14);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(46, 41);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 30;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
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
			panel2.Location = new Point(0, 734);
			panel2.Margin = new Padding(4, 3, 4, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(1376, 58);
			panel2.TabIndex = 30;
			// 
			// pictureBox7
			// 
			pictureBox7.BackColor = Color.Thistle;
			pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.Location = new Point(675, 3);
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
			label1.Location = new Point(519, 22);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(361, 54);
			label1.TabIndex = 2;
			label1.Text = "Manage Feedback";
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
			panel1.Size = new Size(1376, 112);
			panel1.TabIndex = 29;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(1348, 0);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(28, 30);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 61;
			pictureBox6.TabStop = false;
			pictureBox6.Click += pictureBox6_Click;
			// 
			// EvNameTb
			// 
			EvNameTb.Enabled = false;
			EvNameTb.Location = new Point(331, 556);
			EvNameTb.Margin = new Padding(4, 3, 4, 3);
			EvNameTb.Name = "EvNameTb";
			EvNameTb.Size = new Size(206, 27);
			EvNameTb.TabIndex = 52;
			// 
			// VenueCb
			// 
			VenueCb.FormattingEnabled = true;
			VenueCb.Items.AddRange(new object[] { "Bad", "Ok", "Good", "Excellent" });
			VenueCb.Location = new Point(592, 556);
			VenueCb.Margin = new Padding(4, 3, 4, 3);
			VenueCb.Name = "VenueCb";
			VenueCb.Size = new Size(220, 28);
			VenueCb.TabIndex = 53;
			// 
			// PonctualityCb
			// 
			PonctualityCb.FormattingEnabled = true;
			PonctualityCb.Items.AddRange(new object[] { "Bad", "Ok", "Good!", "Excellent!" });
			PonctualityCb.Location = new Point(859, 556);
			PonctualityCb.Margin = new Padding(4, 3, 4, 3);
			PonctualityCb.Name = "PonctualityCb";
			PonctualityCb.Size = new Size(220, 28);
			PonctualityCb.TabIndex = 54;
			// 
			// HospitalityCb
			// 
			HospitalityCb.FormattingEnabled = true;
			HospitalityCb.Items.AddRange(new object[] { "Bad", "Ok", "Good!", "Excellent!" });
			HospitalityCb.Location = new Point(1121, 555);
			HospitalityCb.Margin = new Padding(4, 3, 4, 3);
			HospitalityCb.Name = "HospitalityCb";
			HospitalityCb.Size = new Size(220, 28);
			HospitalityCb.TabIndex = 55;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(592, 528);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(65, 25);
			label2.TabIndex = 56;
			label2.Text = "Venue";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(859, 527);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(105, 25);
			label3.TabIndex = 57;
			label3.Text = "Ponctuality";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(1121, 527);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(102, 25);
			label4.TabIndex = 58;
			label4.Text = "Hospitality";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Black;
			label6.Location = new Point(1121, 527);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(0, 25);
			label6.TabIndex = 59;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.Black;
			label7.Location = new Point(61, 528);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(81, 25);
			label7.TabIndex = 60;
			label7.Text = "Event ID";
			// 
			// Feedback
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1376, 792);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(HospitalityCb);
			Controls.Add(PonctualityCb);
			Controls.Add(VenueCb);
			Controls.Add(EvNameTb);
			Controls.Add(ResetBtn);
			Controls.Add(SaveBtn);
			Controls.Add(EvIdCb);
			Controls.Add(label5);
			Controls.Add(FeedbackDGV);
			Controls.Add(panel4);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Feedback";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Feedback";
			((System.ComponentModel.ISupportInitialize)FeedbackDGV).EndInit();
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

		private Button ResetBtn;
		private Button SaveBtn;
		private ComboBox EvIdCb;
		private Label label5;
		private DataGridView FeedbackDGV;
		private Panel panel4;
		private PictureBox pictureBox5;
		private PictureBox pictureBox4;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Panel panel2;
		private Label label1;
		private Panel panel1;
		private PictureBox pictureBox6;
		private TextBox EvNameTb;
		private ComboBox VenueCb;
		private ComboBox PonctualityCb;
		private ComboBox HospitalityCb;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label6;
		private Label label7;
		private PictureBox pictureBox7;
	}
}