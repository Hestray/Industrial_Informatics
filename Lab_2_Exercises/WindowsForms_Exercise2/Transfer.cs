using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms_Exercise2 {
	public partial class Transfer : Form {
		private readonly string filePath = Path.Combine(Environment.CurrentDirectory, "things.txt");

		public Transfer() {
			InitializeComponent();
			LoadItemsIntoList1();
		}

		private void LoadItemsIntoList1() {
			if (File.Exists(filePath)) {
				listBox1.Items.Clear();
				using (StreamReader reader = new StreamReader(filePath)) {
					string line;
					while (!string.IsNullOrWhiteSpace(line = reader.ReadLine())) {
						listBox1.Items.Add(line.Trim());
					}
				}
			} else {
				// Create the file if it doesn't exist
				using (File.Create(filePath)) { }
			}
		}


		private void button1_Click(object sender, EventArgs e) {
			foreach (var selItem in listBox1.SelectedItems) {
				listBox2.Items.Add(selItem);
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--) {
				listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
			}
		}
		private void button3_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {

		}
	}
}
