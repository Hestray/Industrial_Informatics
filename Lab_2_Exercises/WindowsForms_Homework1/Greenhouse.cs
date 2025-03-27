using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms_Homework1 {
	public partial class Greenhouse : Form {
		private string filePath			= Path.Combine(Environment.CurrentDirectory, "plants.txt");
		private List<Plant> plants		= new List<Plant>();

		public Greenhouse() {
			InitializeComponent();
			LoadPlants();
			ConfigureDataGridView();
			dataGridView1.ReadOnly = true;
		}

		private void ConfigureDataGridView() {
			dataGridView1.Columns[0].AutoSizeMode	= DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns[1].AutoSizeMode	= DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[2].AutoSizeMode   = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns[3].AutoSizeMode   = DataGridViewAutoSizeColumnMode.AllCells;
		}

		private void LoadPlants() {
			if (File.Exists(filePath)) {
				plants.Clear();
				using (StreamReader reader = new StreamReader(filePath)) {
					string line;
					while ((line = reader.ReadLine()) != null) {
						string[] parts = line.Split(',');
						if (parts.Length == 4) {
							Plant plant = new Plant {
								ReferenceNumber = int.Parse(parts[0]),
								Name			= parts[1],
								IsSeasonal		= bool.Parse(parts[2]),
								Stock			= int.Parse(parts[3])
							};
							plants.Add(plant);
						}
					}
				}
				dataGridView1.DataSource = null;
				dataGridView1.DataSource = plants;
				ConfigureDataGridView();
			} else {
				// Create the file if it doesn't exist
				using (File.Create(filePath)) { }
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
		}

		private void button1_Click(object sender, EventArgs e) {
			// load form to add new plant
			AddPlant addPlantForm = new AddPlant(filePath);
			if (addPlantForm.ShowDialog() == DialogResult.OK) {
				LoadPlants(); // Reload plants after adding
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e) {
			if (dataGridView1.SelectedRows.Count > 0) {
				DialogResult confirm = MessageBox.Show(
					"Are you sure you want to delete the selected entry?",
					"Confirm Delete",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (confirm == DialogResult.Yes) {
					Plant plantToDelete = (Plant)dataGridView1.SelectedRows[0].DataBoundItem;
					plants.Remove(plantToDelete);

					// Rewrite the file with the updated plants list
					using (StreamWriter writer = new StreamWriter(filePath, false)) {
						foreach (var plant in plants) {
							writer.WriteLine($"{plant.ReferenceNumber},{plant.Name},{plant.IsSeasonal},{plant.Stock}");
						}
					}
					dataGridView1.DataSource = null;
					dataGridView1.DataSource = plants;
					ConfigureDataGridView();
				}
			} else {
				MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
