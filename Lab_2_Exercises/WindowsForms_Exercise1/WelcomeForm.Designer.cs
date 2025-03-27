namespace WindowsForms_Exercise1 {
	partial class WelcomeForm {
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
			this.WelcomeMsg = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// WelcomeMsg
			// 
			this.WelcomeMsg.AutoSize = true;
			this.WelcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelcomeMsg.Location = new System.Drawing.Point(79, 71);
			this.WelcomeMsg.Name = "WelcomeMsg";
			this.WelcomeMsg.Size = new System.Drawing.Size(177, 31);
			this.WelcomeMsg.TabIndex = 0;
			this.WelcomeMsg.Text = "WelcomeMsg";
			this.WelcomeMsg.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(235, 164);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "EXIT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 199);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.WelcomeMsg);
			this.Name = "WelcomeForm";
			this.Text = "Welcome";
			this.Load += new System.EventHandler(this.WelcomeForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label WelcomeMsg;
		private System.Windows.Forms.Button button1;
	}
}