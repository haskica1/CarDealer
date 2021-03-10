
namespace CarDealer.Forms
{
    partial class StartingForm
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
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.labelStore = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.linkLabelLogIn = new System.Windows.Forms.LinkLabel();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(182, 95);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(162, 21);
            this.comboBoxStore.TabIndex = 0;
            this.comboBoxStore.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelStore.Location = new System.Drawing.Point(93, 94);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(83, 19);
            this.labelStore.TabIndex = 1;
            this.labelStore.Text = "Select store:";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNext.Location = new System.Drawing.Point(154, 166);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(120, 30);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.Location = new System.Drawing.Point(280, 166);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 30);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelWelcome.Location = new System.Drawing.Point(92, 15);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(252, 26);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Welcome to Car Dealer";
            // 
            // linkLabelLogIn
            // 
            this.linkLabelLogIn.AutoSize = true;
            this.linkLabelLogIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogIn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelLogIn.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabelLogIn.Location = new System.Drawing.Point(377, 15);
            this.linkLabelLogIn.Name = "linkLabelLogIn";
            this.linkLabelLogIn.Size = new System.Drawing.Size(47, 19);
            this.linkLabelLogIn.TabIndex = 5;
            this.linkLabelLogIn.Text = "Log in";
            this.linkLabelLogIn.UseMnemonic = false;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelRegister.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabelRegister.Location = new System.Drawing.Point(377, 34);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(58, 19);
            this.linkLabelRegister.TabIndex = 6;
            this.linkLabelRegister.Text = "Register";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelName.Location = new System.Drawing.Point(151, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 23);
            this.labelName.TabIndex = 7;
            this.labelName.Visible = false;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 225);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.linkLabelLogIn);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.comboBoxStore);
            this.Name = "StartingForm";
            this.Text = "Car Dealer";
            this.Load += new System.EventHandler(this.StartingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.LinkLabel linkLabelLogIn;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Label labelName;
    }
}