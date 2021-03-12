
namespace CarDealer.Forms
{
    partial class PurchaseForm
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
            this.labelNameOfOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonStore = new System.Windows.Forms.RadioButton();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelNameOfProduct = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameOfOrder
            // 
            this.labelNameOfOrder.AutoSize = true;
            this.labelNameOfOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfOrder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNameOfOrder.Location = new System.Drawing.Point(50, 49);
            this.labelNameOfOrder.Name = "labelNameOfOrder";
            this.labelNameOfOrder.Size = new System.Drawing.Size(49, 19);
            this.labelNameOfOrder.TabIndex = 0;
            this.labelNameOfOrder.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(50, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of delivery:";
            // 
            // radioButtonStore
            // 
            this.radioButtonStore.AutoSize = true;
            this.radioButtonStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonStore.Location = new System.Drawing.Point(191, 81);
            this.radioButtonStore.Name = "radioButtonStore";
            this.radioButtonStore.Size = new System.Drawing.Size(60, 23);
            this.radioButtonStore.TabIndex = 2;
            this.radioButtonStore.TabStop = true;
            this.radioButtonStore.Text = "Store";
            this.radioButtonStore.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDelivery.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonDelivery.Location = new System.Drawing.Point(284, 81);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(77, 23);
            this.radioButtonDelivery.TabIndex = 3;
            this.radioButtonDelivery.TabStop = true;
            this.radioButtonDelivery.Text = "Delivery";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.textBoxEmail);
            this.groupBoxUser.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxUser.Controls.Add(this.textBoxAddress);
            this.groupBoxUser.Controls.Add(this.textBoxLastName);
            this.groupBoxUser.Controls.Add(this.textBoxFirstName);
            this.groupBoxUser.Controls.Add(this.labelEmail);
            this.groupBoxUser.Controls.Add(this.labelPhoneNumber);
            this.groupBoxUser.Controls.Add(this.labelAddress);
            this.groupBoxUser.Controls.Add(this.labelLastName);
            this.groupBoxUser.Controls.Add(this.labelFirstName);
            this.groupBoxUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxUser.Location = new System.Drawing.Point(54, 143);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(322, 215);
            this.groupBoxUser.TabIndex = 4;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(137, 169);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(170, 26);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(137, 136);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(170, 26);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(137, 103);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(170, 26);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(137, 71);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(170, 26);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(137, 38);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(170, 26);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(14, 172);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 19);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(14, 139);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(99, 19);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "Phone number:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(14, 106);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(63, 19);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(14, 74);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(74, 19);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(14, 41);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name:";
            // 
            // labelNameOfProduct
            // 
            this.labelNameOfProduct.AutoSize = true;
            this.labelNameOfProduct.Location = new System.Drawing.Point(191, 54);
            this.labelNameOfProduct.Name = "labelNameOfProduct";
            this.labelNameOfProduct.Size = new System.Drawing.Size(35, 13);
            this.labelNameOfProduct.TabIndex = 5;
            this.labelNameOfProduct.Text = "label2";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuy.Location = new System.Drawing.Point(88, 387);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(250, 30);
            this.buttonBuy.TabIndex = 6;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 437);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelNameOfProduct);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.radioButtonDelivery);
            this.Controls.Add(this.radioButtonStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameOfOrder);
            this.Name = "PurchaseForm";
            this.Text = "Purchase Car";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameOfOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonStore;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelNameOfProduct;
        private System.Windows.Forms.Button buttonBuy;
    }
}