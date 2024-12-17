using System;

namespace HomePharmacyCatalog
{
    public class Medicine
    {
        private string name;
        private string activeIngredient;
        private MedicineFormType medForm;
        private DateTime manufactureDate;
        private DateTime expiryDate;
        private string storageConditions;
        private int quantity;
        private MedicineCategory category;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название препарата не может быть пустым.");
                }
                if (value.Length > 100)
                {
                    throw new ArgumentException("Название препарата слишком длинное.");
                }
                name = value;
            }
        }

        public string ActiveIngredient
        {
            get
            {
                return activeIngredient;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Активное вещество не может быть пустым.");
                }
                activeIngredient = value;
            }
        }

        public MedicineFormType MedForm
        {
            get
            {
                return medForm;
            }
            set
            {
                if (!Enum.IsDefined(typeof(MedicineFormType), value))
                {
                    throw new ArgumentException("Указана неверная форма выпуска.");
                }
                medForm = value;
            }
        }

        public DateTime ManufactureDate
        {
            get
            {
                return manufactureDate;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата производства не может быть в будущем.");
                }
                manufactureDate = value;
            }
        }

        public DateTime ExpiryDate
        {
            get
            {
                return expiryDate;
            }
            set
            {
                if (value <= manufactureDate)
                {
                    throw new ArgumentException("Дата истечения срока годности должна быть позже даты производства.");
                }
                expiryDate = value;
            }
        }

        public string StorageConditions
        {
            get
            {
                return storageConditions;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 200)
                {
                    throw new ArgumentException("Условия хранения слишком длинные.");
                }
                storageConditions = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество не может быть отрицательным.");
                }
                quantity = value;
            }
        }

        public MedicineCategory Category
        {
            get
            {
                return category;
            }
            set
            {
                if (!Enum.IsDefined(typeof(MedicineCategory), value))
                {
                    throw new ArgumentException("Указана неверная категория.");
                }
                category = value;
            }
        }

        public Medicine()
        {
            Name = "Без названия";
            ManufactureDate = DateTime.Now; 
            ExpiryDate = DateTime.Now.AddYears(1);
            Category = MedicineCategory.Обезболивающее;
        }

    }
}
