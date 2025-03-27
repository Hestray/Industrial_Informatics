namespace WindowsForms_Exercise1 {
	partial class Login {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.userTxt = new System.Windows.Forms.TextBox();
			this.passTxt = new System.Windows.Forms.TextBox();
			this.loginBttn = new System.Windows.Forms.Button();
			this.exitBttn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "USERNAME";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "PASSWORD";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// userTxt
			// 
			this.userTxt.Location = new System.Drawing.Point(106, 20);
			this.userTxt.Name = "userTxt";
			this.userTxt.Size = new System.Drawing.Size(181, 20);
			this.userTxt.TabIndex = 2;
			this.userTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// passTxt
			// 
			this.passTxt.Location = new System.Drawing.Point(106, 59);
			this.passTxt.Name = "passTxt";
			this.passTxt.PasswordChar = '*';
			this.passTxt.Size = new System.Drawing.Size(181, 20);
			this.passTxt.TabIndex = 3;
			this.passTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// loginBttn
			// 
			this.loginBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBttn.Location = new System.Drawing.Point(13, 111);
			this.loginBttn.Name = "loginBttn";
			this.loginBttn.Size = new System.Drawing.Size(75, 23);
			this.loginBttn.TabIndex = 4;
			this.loginBttn.Text = "LOGIN";
			this.loginBttn.UseVisualStyleBackColor = true;
			this.loginBttn.Click += new System.EventHandler(this.button1_Click);
			// 
			// exitBttn
			// 
			this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBttn.Location = new System.Drawing.Point(212, 111);
			this.exitBttn.Name = "exitBttn";
			this.exitBttn.Size = new System.Drawing.Size(75, 23);
			this.exitBttn.TabIndex = 5;
			this.exitBttn.Text = "EXIT";
			this.exitBttn.UseVisualStyleBackColor = true;
			this.exitBttn.Click += new System.EventHandler(this.button2_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(312, 154);
			this.Controls.Add(this.exitBttn);
			this.Controls.Add(this.loginBttn);
			this.Controls.Add(this.passTxt);
			this.Controls.Add(this.userTxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "Authenticate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox userTxt;
		private System.Windows.Forms.TextBox passTxt;
		private System.Windows.Forms.Button exitBttn;
		internal System.Windows.Forms.Button loginBttn;
	}
}

