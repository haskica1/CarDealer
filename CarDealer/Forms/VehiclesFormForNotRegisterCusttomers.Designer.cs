
namespace CarDealer.Forms
{
    partial class VehiclesFormForNotRegisterCusttomers
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
            this.buttonSpecification = new System.Windows.Forms.Button();
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxLowestPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaximumPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSpecification
            // 
            this.buttonSpecification.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpecification.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSpecification.Location = new System.Drawing.Point(55, 400);
            this.buttonSpecification.Name = "buttonSpecification";
            this.buttonSpecification.Size = new System.Drawing.Size(420, 50);
            this.buttonSpecification.TabIndex = 1;
            this.buttonSpecification.Text = "Specification";
            this.buttonSpecification.UseVisualStyleBackColor = true;
            this.buttonSpecification.Click += new System.EventHandler(this.buttonSpecification_Click);
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFilters.Location = new System.Drawing.Point(532, 64);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(60, 21);
            this.labelFilters.TabIndex = 2;
            this.labelFilters.Text = "Filters:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBrand.Location = new System.Drawing.Point(532, 100);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(49, 19);
            this.labelBrand.TabIndex = 3;
            this.labelBrand.Text = "Brand:";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.ItemHeight = 13;
            this.comboBoxBrand.Location = new System.Drawing.Point(590, 99);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(164, 21);
            this.comboBoxBrand.TabIndex = 4;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelModel.Location = new System.Drawing.Point(532, 128);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 19);
            this.labelModel.TabIndex = 5;
            this.labelModel.Text = "Model:";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(590, 129);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(164, 21);
            this.comboBoxModel.TabIndex = 6;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelColor.Location = new System.Drawing.Point(532, 157);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(47, 19);
            this.labelColor.TabIndex = 7;
            this.labelColor.Text = "Color:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(590, 158);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(164, 21);
            this.comboBoxColor.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPrice.Location = new System.Drawing.Point(533, 191);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 19);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxLowestPrice
            // 
            this.textBoxLowestPrice.Location = new System.Drawing.Point(590, 191);
            this.textBoxLowestPrice.Name = "textBoxLowestPrice";
            this.textBoxLowestPrice.Size = new System.Drawing.Size(70, 20);
            this.textBoxLowestPrice.TabIndex = 10;
            // 
            // textBoxMaximumPrice
            // 
            this.textBoxMaximumPrice.Location = new System.Drawing.Point(684, 191);
            this.textBoxMaximumPrice.Name = "textBoxMaximumPrice";
            this.textBoxMaximumPrice.Size = new System.Drawing.Size(70, 20);
            this.textBoxMaximumPrice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(666, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "-";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.Location = new System.Drawing.Point(609, 400);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 50);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.Location = new System.Drawing.Point(55, 64);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.Size = new System.Drawing.Size(420, 316);
            this.listBoxVehicles.TabIndex = 14;
            // 
            // VehiclesFormForNotRegisterCusttomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 529);
            this.Controls.Add(this.listBoxVehicles);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaximumPrice);
            this.Controls.Add(this.textBoxLowestPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.buttonSpecification);
            this.Name = "VehiclesFormForNotRegisterCusttomers";
            this.Text = "Vehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSpecification;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxLowestPrice;
        private System.Windows.Forms.TextBox textBoxMaximumPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxVehicles;
    }
}