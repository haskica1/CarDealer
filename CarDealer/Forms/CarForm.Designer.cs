
namespace CarDealer.Forms
{
    partial class CarForm
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
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelEngine = new System.Windows.Forms.Label();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.labelChassis = new System.Windows.Forms.Label();
            this.textBoxChassis = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddEquipment = new System.Windows.Forms.Button();
            this.richTextBoxInfoOfEquipment = new System.Windows.Forms.RichTextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxNameOfEquipment = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSelectEquipment = new System.Windows.Forms.Label();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.buttonDeleteEquipment = new System.Windows.Forms.Button();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxEquipment = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(103, 73);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(201, 20);
            this.textBoxBrand.TabIndex = 1;
            this.textBoxBrand.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBrand.Location = new System.Drawing.Point(35, 74);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(49, 19);
            this.labelBrand.TabIndex = 2;
            this.labelBrand.Text = "Brand:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelModel.Location = new System.Drawing.Point(35, 100);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 19);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Model:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(103, 99);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(201, 20);
            this.textBoxModel.TabIndex = 4;
            // 
            // labelEngine
            // 
            this.labelEngine.AutoSize = true;
            this.labelEngine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEngine.Location = new System.Drawing.Point(35, 130);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(52, 19);
            this.labelEngine.TabIndex = 5;
            this.labelEngine.Text = "Engine:";
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Location = new System.Drawing.Point(103, 129);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(201, 20);
            this.textBoxEngine.TabIndex = 6;
            // 
            // labelChassis
            // 
            this.labelChassis.AutoSize = true;
            this.labelChassis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChassis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelChassis.Location = new System.Drawing.Point(35, 159);
            this.labelChassis.Name = "labelChassis";
            this.labelChassis.Size = new System.Drawing.Size(58, 19);
            this.labelChassis.TabIndex = 7;
            this.labelChassis.Text = "Chassis:";
            // 
            // textBoxChassis
            // 
            this.textBoxChassis.Location = new System.Drawing.Point(103, 159);
            this.textBoxChassis.Name = "textBoxChassis";
            this.textBoxChassis.Size = new System.Drawing.Size(201, 20);
            this.textBoxChassis.TabIndex = 8;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelColor.Location = new System.Drawing.Point(35, 187);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(47, 19);
            this.labelColor.TabIndex = 9;
            this.labelColor.Text = "Color:";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(103, 185);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(201, 20);
            this.textBoxColor.TabIndex = 10;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPrice.Location = new System.Drawing.Point(35, 215);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 19);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(103, 213);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(201, 20);
            this.textBoxPrice.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddEquipment);
            this.groupBox1.Controls.Add(this.richTextBoxInfoOfEquipment);
            this.groupBox1.Controls.Add(this.labelInfo);
            this.groupBox1.Controls.Add(this.textBoxNameOfEquipment);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelSelectEquipment);
            this.groupBox1.Controls.Add(this.comboBoxEquipment);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(39, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 279);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAddEquipment
            // 
            this.buttonAddEquipment.Location = new System.Drawing.Point(27, 232);
            this.buttonAddEquipment.Name = "buttonAddEquipment";
            this.buttonAddEquipment.Size = new System.Drawing.Size(206, 41);
            this.buttonAddEquipment.TabIndex = 15;
            this.buttonAddEquipment.Text = "Add equipment";
            this.buttonAddEquipment.UseVisualStyleBackColor = true;
            this.buttonAddEquipment.Click += new System.EventHandler(this.buttonAddEquipment_Click);
            // 
            // richTextBoxInfoOfEquipment
            // 
            this.richTextBoxInfoOfEquipment.Location = new System.Drawing.Point(64, 166);
            this.richTextBoxInfoOfEquipment.Name = "richTextBoxInfoOfEquipment";
            this.richTextBoxInfoOfEquipment.Size = new System.Drawing.Size(195, 52);
            this.richTextBoxInfoOfEquipment.TabIndex = 14;
            this.richTextBoxInfoOfEquipment.Text = "";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(10, 166);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(36, 19);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Info:";
            // 
            // textBoxNameOfEquipment
            // 
            this.textBoxNameOfEquipment.Location = new System.Drawing.Point(64, 115);
            this.textBoxNameOfEquipment.Name = "textBoxNameOfEquipment";
            this.textBoxNameOfEquipment.Size = new System.Drawing.Size(195, 26);
            this.textBoxNameOfEquipment.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 117);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 19);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "OR";
            // 
            // labelSelectEquipment
            // 
            this.labelSelectEquipment.AutoSize = true;
            this.labelSelectEquipment.Location = new System.Drawing.Point(6, 40);
            this.labelSelectEquipment.Name = "labelSelectEquipment";
            this.labelSelectEquipment.Size = new System.Drawing.Size(115, 19);
            this.labelSelectEquipment.TabIndex = 1;
            this.labelSelectEquipment.Text = "Select equipment:";
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(127, 37);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(132, 27);
            this.comboBoxEquipment.TabIndex = 0;
            // 
            // buttonDeleteEquipment
            // 
            this.buttonDeleteEquipment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteEquipment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDeleteEquipment.Location = new System.Drawing.Point(702, 243);
            this.buttonDeleteEquipment.Name = "buttonDeleteEquipment";
            this.buttonDeleteEquipment.Size = new System.Drawing.Size(75, 48);
            this.buttonDeleteEquipment.TabIndex = 15;
            this.buttonDeleteEquipment.Text = "Delete selected";
            this.buttonDeleteEquipment.UseVisualStyleBackColor = true;
            this.buttonDeleteEquipment.Click += new System.EventHandler(this.buttonDeleteEquipment_Click);
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddCar.Location = new System.Drawing.Point(368, 506);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(409, 41);
            this.buttonAddCar.TabIndex = 16;
            this.buttonAddCar.Text = "ADD CAR";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adding car...";
            // 
            // listBoxEquipment
            // 
            this.listBoxEquipment.FormattingEnabled = true;
            this.listBoxEquipment.Location = new System.Drawing.Point(368, 73);
            this.listBoxEquipment.Name = "listBoxEquipment";
            this.listBoxEquipment.Size = new System.Drawing.Size(328, 420);
            this.listBoxEquipment.TabIndex = 18;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.listBoxEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.buttonDeleteEquipment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxChassis);
            this.Controls.Add(this.labelChassis);
            this.Controls.Add(this.textBoxEngine);
            this.Controls.Add(this.labelEngine);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBoxBrand);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.Label labelChassis;
        private System.Windows.Forms.TextBox textBoxChassis;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddEquipment;
        private System.Windows.Forms.RichTextBox richTextBoxInfoOfEquipment;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxNameOfEquipment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSelectEquipment;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.Button buttonDeleteEquipment;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxEquipment;
    }
}