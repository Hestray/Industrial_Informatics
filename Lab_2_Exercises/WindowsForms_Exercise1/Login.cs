using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsForms_Exercise1 {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void label2_Click(object sender, EventArgs e) {

		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void textBox2_TextChanged(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			string username = userTxt.Text;
			string password = passTxt.Text;

			// Check if there exist a user with the provided credentials
			if (AuthenticateUser(username, password)) {
				// Create and show the WelcomeForm
				WelcomeForm welcomeForm = new WelcomeForm(username);
				this.Hide();
				welcomeForm.ShowDialog();
				this.Close();
			} else {
				MessageBox.Show("Incorrect username or password!", "Authentication error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool AuthenticateUser(string username, string password) {
			try {
				// read the data from the file
				string[] lines = File.ReadAllLines("credentials.txt");

				foreach (string line in lines) {
					string[] credentials = line.Split(',');
					if (credentials.Length == 2) {
						string storedUsername = credentials[0].Trim();
						string storedPassword = credentials[1].Trim();

						if (username == storedUsername && password == storedPassword) {
							return true;
						}
					}
				}

				return false;
			} catch (Exception ex) {
				MessageBox.Show($"Error when reading credentials: {ex.Message}",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}
