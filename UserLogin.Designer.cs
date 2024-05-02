namespace EventProject
{
	partial class UserLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
			label1 = new Label();
			pictureBox3 = new PictureBox();
			pictureBox2 = new PictureBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			LoginBtn = new Button();
			PasswordTb = new TextBox();
			UnameTb = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Yellow;
			label1.Location = new Point(400, 439);
			label1.Name = "label1";
			label1.Size = new Size(58, 25);
			label1.TabIndex = 24;
			label1.Text = "Reset";
			label1.Click += label1_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(278, 260);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(40, 44);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 23;
			pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(278, 194);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(43, 37);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 22;
			pictureBox2.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = SystemColors.ButtonHighlight;
			label6.Location = new Point(350, 249);
			label6.Name = "label6";
			label6.Size = new Size(143, 25);
			label6.TabIndex = 21;
			label6.Text = "Enter Password:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = SystemColors.ButtonHighlight;
			label5.Location = new Point(350, 176);
			label5.Name = "label5";
			label5.Size = new Size(149, 25);
			label5.TabIndex = 20;
			label5.Text = "Enter Username:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(288, 42);
			label4.Name = "label4";
			label4.Size = new Size(281, 50);
			label4.TabIndex = 19;
			label4.Text = "Event Manager";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(436, 112);
			label3.Name = "label3";
			label3.Size = new Size(0, 20);
			label3.TabIndex = 18;
			// 
			// LoginBtn
			// 
			LoginBtn.BackColor = Color.Black;
			LoginBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LoginBtn.ForeColor = SystemColors.ButtonHighlight;
			LoginBtn.Location = new Point(373, 339);
			LoginBtn.Name = "LoginBtn";
			LoginBtn.Size = new Size(126, 47);
			LoginBtn.TabIndex = 17;
			LoginBtn.Text = "Login";
			LoginBtn.UseVisualStyleBackColor = false;
			LoginBtn.Click += LoginBtn_Click;
			// 
			// PasswordTb
			// 
			PasswordTb.BackColor = SystemColors.InfoText;
			PasswordTb.ForeColor = SystemColors.InactiveBorder;
			PasswordTb.Location = new Point(350, 277);
			PasswordTb.Name = "PasswordTb";
			PasswordTb.Size = new Size(219, 27);
			PasswordTb.TabIndex = 16;
			PasswordTb.UseSystemPasswordChar = true;
			// 
			// UnameTb
			// 
			UnameTb.BackColor = SystemColors.InfoText;
			UnameTb.ForeColor = SystemColors.Info;
			UnameTb.Location = new Point(350, 204);
			UnameTb.Name = "UnameTb";
			UnameTb.Size = new Size(218, 27);
			UnameTb.TabIndex = 15;
			// 
			// UserLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(846, 483);
			Controls.Add(label1);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(LoginBtn);
			Controls.Add(PasswordTb);
			Controls.Add(UnameTb);
			FormBorderStyle = FormBorderStyle.None;
			Name = "UserLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UserLogin";
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox pictureBox3;
		private PictureBox pictureBox2;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Button LoginBtn;
		private TextBox PasswordTb;
		private TextBox UnameTb;
	}
}