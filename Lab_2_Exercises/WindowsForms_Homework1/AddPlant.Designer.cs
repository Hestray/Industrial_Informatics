namespace WindowsForms_Homework1 {
	partial class AddPlant {
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
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.numTxt = new System.Windows.Forms.TextBox();
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.checkSeason = new System.Windows.Forms.CheckBox();
			this.stockVal = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.stockVal)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Ivory;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Plant name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Ivory;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Ivory;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Stock";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Aptos SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(29, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Aptos SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(254, 210);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// numTxt
			// 
			this.numTxt.Location = new System.Drawing.Point(138, 33);
			this.numTxt.Name = "numTxt";
			this.numTxt.Size = new System.Drawing.Size(191, 20);
			this.numTxt.TabIndex = 6;
			// 
			// nameTxt
			// 
			this.nameTxt.Location = new System.Drawing.Point(138, 76);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(191, 20);
			this.nameTxt.TabIndex = 7;
			// 
			// checkSeason
			// 
			this.checkSeason.AutoSize = true;
			this.checkSeason.BackColor = System.Drawing.Color.Ivory;
			this.checkSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkSeason.Location = new System.Drawing.Point(29, 166);
			this.checkSeason.Name = "checkSeason";
			this.checkSeason.Size = new System.Drawing.Size(121, 21);
			this.checkSeason.TabIndex = 8;
			this.checkSeason.Text = "Seasonal plant";
			this.checkSeason.UseVisualStyleBackColor = false;
			this.checkSeason.CheckedChanged += new System.EventHandler(this.isSeasonal_CheckedChanged);
			// 
			// stockVal
			// 
			this.stockVal.Location = new System.Drawing.Point(138, 121);
			this.stockVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.stockVal.Name = "stockVal";
			this.stockVal.Size = new System.Drawing.Size(191, 20);
			this.stockVal.TabIndex = 9;
			// 
			// AddPlant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(358, 258);
			this.Controls.Add(this.stockVal);
			this.Controls.Add(this.checkSeason);
			this.Controls.Add(this.nameTxt);
			this.Controls.Add(this.numTxt);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddPlant";
			this.Text = "Add new plant";
			this.Load += new System.EventHandler(this.AddPlant_Load);
			((System.ComponentModel.ISupportInitialize)(this.stockVal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox numTxt;
		private System.Windows.Forms.TextBox nameTxt;
		private System.Windows.Forms.CheckBox checkSeason;
		private System.Windows.Forms.NumericUpDown stockVal;
	}
}