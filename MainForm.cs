using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HomePharmacyCatalog
{
    public partial class MainForm : Form
    {
        private Aptechka aptechka; 
        private string filePath = "medicines.json";

        public MainForm()
        {
            InitializeComponent();
            aptechka = new Aptechka();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            aptechka.LoadData(filePath);
            RefreshMedicinesGrid();
            Shown += MainForm_Shown;
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aptechka.SaveData(filePath); 
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ShowProsrochka(); 
        }

        private void ShowProsrochka()
        {
            var soonToExpire = aptechka.Prosrochka(10); 

            if (soonToExpire.Any())
            {
                string message = "У следующих лекарств срок годности скоро истекает:\n\n" +
                                 string.Join("\n", soonToExpire.Select(m => $"{m.Name} (Годен до: {m.ExpiryDate:dd.MM.yyyy})"));
                MessageBox.Show(message, "Скоро истекает срок годности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshMedicinesGrid()
        {
            medicinesGrid.Rows.Clear();
            foreach (var medicine in aptechka.GetMedicines())
            {
                medicinesGrid.Rows.Add(medicine.Name, medicine.MedForm, medicine.Quantity,
                    medicine.ExpiryDate.ToShortDateString(),
                    medicine.ActiveIngredient, medicine.StorageConditions, medicine.Category);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newMedicine = new Medicine();
            var editForm = new MedicineForm(newMedicine);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                aptechka.AddMedicine(newMedicine); 
                RefreshMedicinesGrid();
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {

            var selectedRow = medicinesGrid.SelectedRows[0];
            var selectedIndex = selectedRow.Index;

            var medicine = aptechka.GetMedicines()[selectedIndex]; 

            var editForm = new MedicineForm(medicine);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                aptechka.UpdateMedicine(selectedIndex, medicine); 
                RefreshMedicinesGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = medicinesGrid.SelectedRows[0];
            var selectedIndex = selectedRow.Index;

            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить это лекарство?",
                                                "Подтверждение удаления",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                aptechka.RemoveMedicine(selectedIndex); 
                RefreshMedicinesGrid();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var query = txtSearch.Text;
            var searchResults = aptechka.SearchMedicines(query); 

            medicinesGrid.Rows.Clear();
            foreach (var medicine in searchResults)
            {
                medicinesGrid.Rows.Add(medicine.Name, medicine.MedForm, medicine.Quantity,
                    medicine.ExpiryDate.ToShortDateString(),
                    medicine.ActiveIngredient, medicine.StorageConditions, medicine.Category);
            }
        }
     

    }
}
