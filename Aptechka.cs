using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace HomePharmacyCatalog
{
    public class Aptechka
    {
        private List<Medicine> medicines;

        public Aptechka()
        {
            medicines = new List<Medicine>();
        }

        public List<Medicine> GetMedicines()
        {
            return medicines;
        }
        public void AddMedicine(Medicine medicine)
        {
            if (medicine == null)
                throw new ArgumentNullException(nameof(medicine));
            medicines.Add(medicine);
        }

        public void RemoveMedicine(int index)
        {
            if (index < 0 || index >= medicines.Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            medicines.RemoveAt(index);
        }

        public void UpdateMedicine(int index, Medicine updatedMedicine)
        {
            if (index < 0 || index >= medicines.Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            if (updatedMedicine == null)
                throw new ArgumentNullException(nameof(updatedMedicine));
            medicines[index] = updatedMedicine;
        }

        public void LoadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                medicines = JsonConvert.DeserializeObject<List<Medicine>>(json);
            }
            else
            {
                LoadSampleData();
            }
        }

        public void SaveData(string filePath)
        {
            var json = JsonConvert.SerializeObject(medicines, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void LoadSampleData()
        {

            medicines.Add(new Medicine
            {
                Name = "Анаферон",
                MedForm = MedicineFormType.Таблетки,
                Quantity = 30,
                ExpiryDate = new DateTime(2026, 12, 1),
                ActiveIngredient = "Антитела к интерферону",
                StorageConditions = "Хранить при температуре до 25°C",
                Category = MedicineCategory.Противовирусное
            });

        }

        public List<Medicine> Prosrochka(int daysThreshold)
        {
            return medicines.Where(medicine =>
                (medicine.ExpiryDate - DateTime.Now).TotalDays <= daysThreshold &&
                (medicine.ExpiryDate - DateTime.Now).TotalDays > 0)
                .ToList();
        }

        public List<Medicine> SearchMedicines(string query)
        {
            if (string.IsNullOrEmpty(query))
                return medicines;

            query = query.ToLower();

            return medicines.Where(m =>
                m.Name.ToLower().Contains(query) ||
                m.MedForm.ToString().ToLower().Contains(query) ||
                m.Category.ToString().ToLower().Contains(query)
            ).ToList();
        }

    }
}
