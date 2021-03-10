
using System;

namespace CarDealer.Forms
{
    partial class AddStoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxStorages = new System.Windows.Forms.ListBox();
            this.comboBoxStorage = new System.Windows.Forms.ComboBox();
            this.labelSelectStorage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddStorage = new System.Windows.Forms.Button();
            this.linkLabelCreateStorage = new System.Windows.Forms.LinkLabel();
            this.groupBoxStorage = new System.Windows.Forms.GroupBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.linkLabelCreateEmployee = new System.Windows.Forms.LinkLabel();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectEmployee = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonDeleteStorage = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.groupBoxStorage.SuspendLayout();
            this.groupBoxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBrand.Location = new System.Drawing.Point(38, 51);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(49, 19);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(201, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // listBoxStorages
            // 
            this.listBoxStorages.FormattingEnabled = true;
            this.listBoxStorages.Location = new System.Drawing.Point(377, 366);
            this.listBoxStorages.Name = "listBoxStorages";
            this.listBoxStorages.Size = new System.Drawing.Size(371, 225);
            this.listBoxStorages.TabIndex = 15;
            // 
            // comboBoxStorage
            // 
            this.comboBoxStorage.FormattingEnabled = true;
            this.comboBoxStorage.Location = new System.Drawing.Point(109, 37);
            this.comboBoxStorage.Name = "comboBoxStorage";
            this.comboBoxStorage.Size = new System.Drawing.Size(199, 27);
            this.comboBoxStorage.TabIndex = 0;
            // 
            // labelSelectStorage
            // 
            this.labelSelectStorage.AutoSize = true;
            this.labelSelectStorage.Location = new System.Drawing.Point(6, 40);
            this.labelSelectStorage.Name = "labelSelectStorage";
            this.labelSelectStorage.Size = new System.Drawing.Size(97, 19);
            this.labelSelectStorage.TabIndex = 1;
            this.labelSelectStorage.Text = "Select storage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "OR";
            // 
            // buttonAddStorage
            // 
            this.buttonAddStorage.Location = new System.Drawing.Point(53, 152);
            this.buttonAddStorage.Name = "buttonAddStorage";
            this.buttonAddStorage.Size = new System.Drawing.Size(206, 41);
            this.buttonAddStorage.TabIndex = 15;
            this.buttonAddStorage.Text = "Add storage";
            this.buttonAddStorage.UseVisualStyleBackColor = true;
            this.buttonAddStorage.Click += new System.EventHandler(this.buttonAddStorage_Click);
            // 
            // linkLabelCreateStorage
            // 
            this.linkLabelCreateStorage.AutoSize = true;
            this.linkLabelCreateStorage.Location = new System.Drawing.Point(86, 117);
            this.linkLabelCreateStorage.Name = "linkLabelCreateStorage";
            this.linkLabelCreateStorage.Size = new System.Drawing.Size(127, 19);
            this.linkLabelCreateStorage.TabIndex = 16;
            this.linkLabelCreateStorage.TabStop = true;
            this.linkLabelCreateStorage.Text = "Create new storage";
            // 
            // groupBoxStorage
            // 
            this.groupBoxStorage.Controls.Add(this.linkLabelCreateStorage);
            this.groupBoxStorage.Controls.Add(this.buttonAddStorage);
            this.groupBoxStorage.Controls.Add(this.label2);
            this.groupBoxStorage.Controls.Add(this.labelSelectStorage);
            this.groupBoxStorage.Controls.Add(this.comboBoxStorage);
            this.groupBoxStorage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStorage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxStorage.Location = new System.Drawing.Point(32, 366);
            this.groupBoxStorage.Name = "groupBoxStorage";
            this.groupBoxStorage.Size = new System.Drawing.Size(314, 225);
            this.groupBoxStorage.TabIndex = 14;
            this.groupBoxStorage.TabStop = false;
            this.groupBoxStorage.Text = "Storage";
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.linkLabelCreateEmployee);
            this.groupBoxEmployee.Controls.Add(this.buttonAddEmployee);
            this.groupBoxEmployee.Controls.Add(this.label1);
            this.groupBoxEmployee.Controls.Add(this.labelSelectEmployee);
            this.groupBoxEmployee.Controls.Add(this.comboBoxEmployee);
            this.groupBoxEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxEmployee.Location = new System.Drawing.Point(32, 117);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(314, 225);
            this.groupBoxEmployee.TabIndex = 16;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee";
            // 
            // linkLabelCreateEmployee
            // 
            this.linkLabelCreateEmployee.AutoSize = true;
            this.linkLabelCreateEmployee.Location = new System.Drawing.Point(86, 115);
            this.linkLabelCreateEmployee.Name = "linkLabelCreateEmployee";
            this.linkLabelCreateEmployee.Size = new System.Drawing.Size(141, 19);
            this.linkLabelCreateEmployee.TabIndex = 16;
            this.linkLabelCreateEmployee.TabStop = true;
            this.linkLabelCreateEmployee.Text = "Create new employee";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(53, 150);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(206, 41);
            this.buttonAddEmployee.TabIndex = 15;
            this.buttonAddEmployee.Text = "Add employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "OR";
            // 
            // labelSelectEmployee
            // 
            this.labelSelectEmployee.AutoSize = true;
            this.labelSelectEmployee.Location = new System.Drawing.Point(6, 40);
            this.labelSelectEmployee.Name = "labelSelectEmployee";
            this.labelSelectEmployee.Size = new System.Drawing.Size(111, 19);
            this.labelSelectEmployee.TabIndex = 1;
            this.labelSelectEmployee.Text = "Select employee:";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(123, 37);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(185, 27);
            this.comboBoxEmployee.TabIndex = 0;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(377, 117);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(371, 225);
            this.listBoxEmployees.TabIndex = 17;
            // 
            // buttonDeleteStorage
            // 
            this.buttonDeleteStorage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStorage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDeleteStorage.Location = new System.Drawing.Point(787, 445);
            this.buttonDeleteStorage.Name = "buttonDeleteStorage";
            this.buttonDeleteStorage.Size = new System.Drawing.Size(100, 50);
            this.buttonDeleteStorage.TabIndex = 18;
            this.buttonDeleteStorage.Text = "Delete storage";
            this.buttonDeleteStorage.UseVisualStyleBackColor = true;
            this.buttonDeleteStorage.Click += new System.EventHandler(this.buttonDeleteStorage_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteEmployee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(787, 196);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(100, 50);
            this.buttonDeleteEmployee.TabIndex = 19;
            this.buttonDeleteEmployee.Text = "Delete employee";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddStore.Location = new System.Drawing.Point(106, 626);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(689, 46);
            this.buttonAddStore.TabIndex = 20;
            this.buttonAddStore.Text = "ADD STORE";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(42, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Adding store";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(38, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(106, 76);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(201, 20);
            this.textBoxAddress.TabIndex = 22;
            // 
            // AddStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 694);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddStore);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonDeleteStorage);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.groupBoxEmployee);
            this.Controls.Add(this.listBoxStorages);
            this.Controls.Add(this.groupBoxStorage);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddStoreForm";
            this.Text = "Add store";
            this.groupBoxStorage.ResumeLayout(false);
            this.groupBoxStorage.PerformLayout();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxStorages;
        private System.Windows.Forms.ComboBox comboBoxStorage;
        private System.Windows.Forms.Label labelSelectStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddStorage;
        private System.Windows.Forms.LinkLabel linkLabelCreateStorage;
        private System.Windows.Forms.GroupBox groupBoxStorage;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.LinkLabel linkLabelCreateEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSelectEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonDeleteStorage;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}