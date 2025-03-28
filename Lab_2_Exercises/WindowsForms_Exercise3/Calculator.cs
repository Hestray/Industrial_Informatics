﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Exercise3 {
	public partial class Calculator : Form {
		public Calculator() {
			InitializeComponent();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e) {
			// addition
			double num1 = double.Parse(numTxt1.Text);
			double num2 = double.Parse(numTxt2.Text);
			resTxt.Text = (num1 + num2).ToString();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e) {
			// subtraction
			double num1 = double.Parse(numTxt1.Text);
			double num2 = double.Parse(numTxt2.Text);
			resTxt.Text = (num1 - num2).ToString();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e) {
			// multiplication
			double num1 = double.Parse(numTxt1.Text);
			double num2 = double.Parse(numTxt2.Text);
			resTxt.Text = (num1 * num2).ToString();
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e) {
			// division
			double num1 = double.Parse(numTxt1.Text);
			double num2 = double.Parse(numTxt2.Text);
			if (num2 != 0) resTxt.Text = (num1 / num2).ToString();
			else resTxt.Text = "Cannot divide by 0";
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void textBox2_TextChanged(object sender, EventArgs e) {

		}

		private void textBox3_TextChanged(object sender, EventArgs e) {

		}
	}
}
