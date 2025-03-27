namespace WindowsForms_Exercise3 {
	partial class Calculator {
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
			this.numTxt1 = new System.Windows.Forms.TextBox();
			this.numTxt2 = new System.Windows.Forms.TextBox();
			this.resTxt = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// numTxt1
			// 
			this.numTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numTxt1.Location = new System.Drawing.Point(31, 256);
			this.numTxt1.Name = "numTxt1";
			this.numTxt1.Size = new System.Drawing.Size(100, 29);
			this.numTxt1.TabIndex = 0;
			this.numTxt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// numTxt2
			// 
			this.numTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numTxt2.Location = new System.Drawing.Point(232, 256);
			this.numTxt2.Name = "numTxt2";
			this.numTxt2.Size = new System.Drawing.Size(100, 29);
			this.numTxt2.TabIndex = 1;
			this.numTxt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// resTxt
			// 
			this.resTxt.BackColor = System.Drawing.Color.DarkSlateGray;
			this.resTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.resTxt.Location = new System.Drawing.Point(31, 81);
			this.resTxt.Name = "resTxt";
			this.resTxt.Size = new System.Drawing.Size(301, 38);
			this.resTxt.TabIndex = 2;
			this.resTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this.menuStrip1.Location = new System.Drawing.Point(0, 388);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(367, 38);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.Crimson;
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 34);
			this.toolStripMenuItem1.Text = "+";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.BackColor = System.Drawing.Color.Teal;
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(34, 34);
			this.toolStripMenuItem2.Text = "-";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.BackColor = System.Drawing.Color.Indigo;
			this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Snow;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(35, 34);
			this.toolStripMenuItem3.Text = "*";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.BackColor = System.Drawing.Color.DarkGreen;
			this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(34, 34);
			this.toolStripMenuItem4.Text = "/";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 426);
			this.Controls.Add(this.resTxt);
			this.Controls.Add(this.numTxt2);
			this.Controls.Add(this.numTxt1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Calculator";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numTxt1;
		private System.Windows.Forms.TextBox numTxt2;
		private System.Windows.Forms.TextBox resTxt;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
	}
}

