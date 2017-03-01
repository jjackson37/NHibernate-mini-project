namespace WindowsFormsViewLayer.CarFormViews
{
    partial class AddCarFormView
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
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.numberPlateTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.vehicleNameLabel = new System.Windows.Forms.Label();
            this.numberPlateLabel = new System.Windows.Forms.Label();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(256, 77);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleNameTextBox.TabIndex = 0;
            // 
            // numberPlateTextBox
            // 
            this.numberPlateTextBox.Location = new System.Drawing.Point(256, 104);
            this.numberPlateTextBox.Name = "numberPlateTextBox";
            this.numberPlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberPlateTextBox.TabIndex = 1;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(256, 158);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(256, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(256, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(256, 239);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // vehicleNameLabel
            // 
            this.vehicleNameLabel.AutoSize = true;
            this.vehicleNameLabel.Location = new System.Drawing.Point(177, 80);
            this.vehicleNameLabel.Name = "vehicleNameLabel";
            this.vehicleNameLabel.Size = new System.Drawing.Size(73, 13);
            this.vehicleNameLabel.TabIndex = 7;
            this.vehicleNameLabel.Text = "Vehicle Name";
            // 
            // numberPlateLabel
            // 
            this.numberPlateLabel.AutoSize = true;
            this.numberPlateLabel.Location = new System.Drawing.Point(179, 107);
            this.numberPlateLabel.Name = "numberPlateLabel";
            this.numberPlateLabel.Size = new System.Drawing.Size(71, 13);
            this.numberPlateLabel.TabIndex = 8;
            this.numberPlateLabel.Text = "Number Plate";
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Items.AddRange(new object[] {
            "Hatchback",
            "Sedan",
            "SUV",
            "Coupe",
            "Convertible"});
            this.carTypeComboBox.Location = new System.Drawing.Point(256, 131);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.carTypeComboBox.TabIndex = 9;
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(200, 134);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.carTypeLabel.TabIndex = 10;
            this.carTypeLabel.Text = "Car Type";
            // 
            // AddCarFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 354);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.carTypeComboBox);
            this.Controls.Add(this.numberPlateLabel);
            this.Controls.Add(this.vehicleNameLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.numberPlateTextBox);
            this.Controls.Add(this.vehicleNameTextBox);
            this.Name = "AddCarFormView";
            this.Text = "Add car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.TextBox numberPlateTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label vehicleNameLabel;
        private System.Windows.Forms.Label numberPlateLabel;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Label carTypeLabel;
    }
}