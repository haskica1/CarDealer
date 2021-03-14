
namespace CarDealer.Forms
{
    partial class EmployeeForm
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
            this.buttonPurchaseCar = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPurchaseCar
            // 
            this.buttonPurchaseCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchaseCar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPurchaseCar.Location = new System.Drawing.Point(286, 126);
            this.buttonPurchaseCar.Name = "buttonPurchaseCar";
            this.buttonPurchaseCar.Size = new System.Drawing.Size(200, 50);
            this.buttonPurchaseCar.TabIndex = 0;
            this.buttonPurchaseCar.Text = "Purchase car";
            this.buttonPurchaseCar.UseVisualStyleBackColor = true;
            this.buttonPurchaseCar.Click += new System.EventHandler(this.buttonPurchaseCar_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddUser.Location = new System.Drawing.Point(286, 182);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(200, 50);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddCar.Location = new System.Drawing.Point(286, 238);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(200, 50);
            this.buttonAddCar.TabIndex = 2;
            this.buttonAddCar.Text = "Add car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddStore.Location = new System.Drawing.Point(286, 295);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(200, 50);
            this.buttonAddStore.TabIndex = 3;
            this.buttonAddStore.Text = "Add Store";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddStore);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonPurchaseCar);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPurchaseCar;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonAddStore;
    }
}