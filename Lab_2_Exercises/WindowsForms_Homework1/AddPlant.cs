using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms_Homework1 {
	public partial class AddPlant : Form {
		private string filePath;

		public AddPlant(string path) {
			InitializeComponent();
			filePath = path;
		}

		private void AddPlant_Load(object sender, EventArgs e) {

		}

		private void isSeasonal_CheckedChanged(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			try {
				// Validate input
				if (string.IsNullOrWhiteSpace(numTxt.Text) ||
					string.IsNullOrWhiteSpace(nameTxt.Text)) {
					MessageBox.Show("Reference number and name are required!",
						"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int referenceNumber	= int.Parse(numTxt.Text);
				string name			= nameTxt.Text;
				bool isSeasonal		= checkSeason.Checked;
				int stock			= (int)stockVal.Value;

				string line = $"{referenceNumber},{name},{isSeasonal},{stock}";

				using (StreamWriter writer = new StreamWriter(filePath, true)) {
					writer.WriteLine(line);
				}

				MessageBox.Show("Plant added successfully!", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			} catch (FormatException) {
				// for int.Parse()
				MessageBox.Show("Reference number must be a valid integer!",
					"Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch (Exception ex) {
				// any other message
				MessageBox.Show($"Error: {ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
