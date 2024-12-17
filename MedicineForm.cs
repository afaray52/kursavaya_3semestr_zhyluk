using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomePharmacyCatalog
{
    public partial class MedicineForm : Form
    {
        public Medicine Medicine { get; set; }

        public MedicineForm(Medicine medicine = null)
        {
            InitializeComponent();
            Medicine = medicine ?? new Medicine();
            Load += MedicineForm_Load;
            btnCancel.Click += (sender, e) => Close();
            btnSave.Click += btnSave_Click;
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            
            InitializePlaceholder(txtName, "Введите название препарата");
            InitializePlaceholder(txtActiveIngredient, "Введите активное вещество");
            InitializePlaceholder(txtStorageConditions, "Введите условия хранения");
            InitializePlaceholder(txtQuantity, "Введите количество");

            cmbForm.Items.Clear();
            cmbForm.Items.AddRange(Enum.GetNames(typeof(MedicineFormType)));
            cmbForm.SelectedItem = Medicine.MedForm.ToString();

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(MedicineCategory)));
            cmbCategory.SelectedItem = Medicine.Category.ToString();

            dtpManufactureDate.Value = Medicine.ManufactureDate < dtpManufactureDate.MinDate
                ? dtpManufactureDate.MinDate
                : Medicine.ManufactureDate;

            dtpExpiryDate.Value = Medicine.ExpiryDate < dtpExpiryDate.MinDate
                ? dtpExpiryDate.MinDate
                : Medicine.ExpiryDate;

            txtQuantity.Text = Medicine.Quantity.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string validationErrors = ValidateFormInputs();
            if (!string.IsNullOrEmpty(validationErrors))
            {
                MessageBox.Show(validationErrors, "Ошибки ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Medicine.Name = txtName.Text;
            Medicine.ActiveIngredient = txtActiveIngredient.Text;
            Medicine.MedForm = (MedicineFormType)Enum.Parse(typeof(MedicineFormType), cmbForm.SelectedItem.ToString());
            Medicine.Category = (MedicineCategory)Enum.Parse(typeof(MedicineCategory), cmbCategory.SelectedItem.ToString());
            Medicine.ManufactureDate = dtpManufactureDate.Value;
            Medicine.ExpiryDate = dtpExpiryDate.Value;
            Medicine.StorageConditions = txtStorageConditions.Text;

            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                Medicine.Quantity = quantity;
            }
            else
            {
                MessageBox.Show("Количество должно быть положительным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private string ValidateFormInputs()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == "Введите название препарата")
            {
                errors.AppendLine("Название препарата не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(txtActiveIngredient.Text) || txtActiveIngredient.Text == "Введите активное вещество")
            {
                errors.AppendLine("Введите активное вещество.");
            }

            if (string.IsNullOrWhiteSpace(txtStorageConditions.Text) || txtStorageConditions.Text == "Введите условия хранения")
            {
                errors.AppendLine("Укажите условия хранения.");
            }

            if (dtpManufactureDate.Value > DateTime.Now)
            {
                errors.AppendLine("Дата производства не может быть в будущем.");
            }

            if (dtpExpiryDate.Value <= DateTime.Now)
            {
                errors.AppendLine("Срок годности должен быть в будущем.");
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                errors.AppendLine("Количество должно быть положительным числом.");
            }

       
            return errors.ToString();
        }

        private void InitializePlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };
            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

    }
}
