using System;
using System.Windows.Forms;

namespace HomePharmacyCatalog
{
    partial class MedicineForm
    {
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtActiveIngredient;
        private System.Windows.Forms.ComboBox cmbForm;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.TextBox txtStorageConditions;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblActiveIngredient;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblStorageConditions;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;
        

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtActiveIngredient = new System.Windows.Forms.TextBox();
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.txtStorageConditions = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblActiveIngredient = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblStorageConditions = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtActiveIngredient
            // 
            this.txtActiveIngredient.Location = new System.Drawing.Point(200, 80);
            this.txtActiveIngredient.Name = "txtActiveIngredient";
            this.txtActiveIngredient.Size = new System.Drawing.Size(500, 30);
            this.txtActiveIngredient.TabIndex = 3;
            // 
            // cmbForm
            // 
            this.cmbForm.DropDownHeight = 250;
            this.cmbForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForm.IntegralHeight = false;
            this.cmbForm.Location = new System.Drawing.Point(200, 130);
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(500, 31);
            this.cmbForm.TabIndex = 5;
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Location = new System.Drawing.Point(200, 180);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(500, 30);
            this.dtpManufactureDate.TabIndex = 7;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(300, 230);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(400, 30);
            this.dtpExpiryDate.TabIndex = 9;
            // 
            // txtStorageConditions
            // 
            this.txtStorageConditions.Location = new System.Drawing.Point(200, 280);
            this.txtStorageConditions.Name = "txtStorageConditions";
            this.txtStorageConditions.Size = new System.Drawing.Size(500, 30);
            this.txtStorageConditions.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(200, 330);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(500, 30);
            this.txtQuantity.TabIndex = 13;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(200, 383);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(500, 31);
            this.cmbCategory.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(200, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(466, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название:";
            // 
            // lblActiveIngredient
            // 
            this.lblActiveIngredient.Location = new System.Drawing.Point(30, 80);
            this.lblActiveIngredient.Name = "lblActiveIngredient";
            this.lblActiveIngredient.Size = new System.Drawing.Size(150, 30);
            this.lblActiveIngredient.TabIndex = 2;
            this.lblActiveIngredient.Text = "Активное вещество:";
            // 
            // lblForm
            // 
            this.lblForm.Location = new System.Drawing.Point(30, 130);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(150, 30);
            this.lblForm.TabIndex = 4;
            this.lblForm.Text = "Форма:";
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.Location = new System.Drawing.Point(30, 180);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(150, 30);
            this.lblManufactureDate.TabIndex = 6;
            this.lblManufactureDate.Text = "Дата производства:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Location = new System.Drawing.Point(30, 230);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(250, 30);
            this.lblExpiryDate.TabIndex = 8;
            this.lblExpiryDate.Text = "Дата окончания срока годности:";
            // 
            // lblStorageConditions
            // 
            this.lblStorageConditions.Location = new System.Drawing.Point(30, 280);
            this.lblStorageConditions.Name = "lblStorageConditions";
            this.lblStorageConditions.Size = new System.Drawing.Size(150, 30);
            this.lblStorageConditions.TabIndex = 10;
            this.lblStorageConditions.Text = "Условия хранения:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(30, 330);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(150, 30);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Количество:";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(30, 383);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(150, 30);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Категория:";
            // 
            // MedicineForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblActiveIngredient);
            this.Controls.Add(this.txtActiveIngredient);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.cmbForm);
            this.Controls.Add(this.lblManufactureDate);
            this.Controls.Add(this.dtpManufactureDate);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.lblStorageConditions);
            this.Controls.Add(this.txtStorageConditions);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить/Редактировать лекарство";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
