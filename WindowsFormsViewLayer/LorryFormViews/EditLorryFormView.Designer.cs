﻿namespace WindowsFormsViewLayer.LorryFormViews
{
    partial class EditLorryFormView
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
            this.submitButton = new System.Windows.Forms.Button();
            this.loadWeightLabel = new System.Windows.Forms.Label();
            this.loadWeightTextBox = new System.Windows.Forms.TextBox();
            this.loadCheckBox = new System.Windows.Forms.CheckBox();
            this.milageLabel = new System.Windows.Forms.Label();
            this.maxFuelLabel = new System.Windows.Forms.Label();
            this.maxPassengersLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.numberPlateLabel = new System.Windows.Forms.Label();
            this.vehicleNameLabel = new System.Windows.Forms.Label();
            this.milageTextBox = new System.Windows.Forms.TextBox();
            this.maxFuelTextBox = new System.Windows.Forms.TextBox();
            this.maxPassengersTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.numberPlateTextBox = new System.Windows.Forms.TextBox();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(199, 226);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 48;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // loadWeightLabel
            // 
            this.loadWeightLabel.AutoSize = true;
            this.loadWeightLabel.Enabled = false;
            this.loadWeightLabel.Location = new System.Drawing.Point(55, 117);
            this.loadWeightLabel.Name = "loadWeightLabel";
            this.loadWeightLabel.Size = new System.Drawing.Size(65, 13);
            this.loadWeightLabel.TabIndex = 47;
            this.loadWeightLabel.Text = "Load weight";
            // 
            // loadWeightTextBox
            // 
            this.loadWeightTextBox.Enabled = false;
            this.loadWeightTextBox.Location = new System.Drawing.Point(126, 114);
            this.loadWeightTextBox.Name = "loadWeightTextBox";
            this.loadWeightTextBox.Size = new System.Drawing.Size(148, 20);
            this.loadWeightTextBox.TabIndex = 46;
            // 
            // loadCheckBox
            // 
            this.loadCheckBox.AutoSize = true;
            this.loadCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadCheckBox.Location = new System.Drawing.Point(161, 91);
            this.loadCheckBox.Name = "loadCheckBox";
            this.loadCheckBox.Size = new System.Drawing.Size(113, 17);
            this.loadCheckBox.TabIndex = 45;
            this.loadCheckBox.Text = "Has load attached";
            this.loadCheckBox.UseVisualStyleBackColor = true;
            this.loadCheckBox.CheckedChanged += new System.EventHandler(this.loadCheckBox_CheckedChanged);
            // 
            // milageLabel
            // 
            this.milageLabel.AutoSize = true;
            this.milageLabel.Location = new System.Drawing.Point(53, 197);
            this.milageLabel.Name = "milageLabel";
            this.milageLabel.Size = new System.Drawing.Size(67, 13);
            this.milageLabel.TabIndex = 44;
            this.milageLabel.Text = "Milage (mpg)";
            // 
            // maxFuelLabel
            // 
            this.maxFuelLabel.AutoSize = true;
            this.maxFuelLabel.Location = new System.Drawing.Point(31, 170);
            this.maxFuelLabel.Name = "maxFuelLabel";
            this.maxFuelLabel.Size = new System.Drawing.Size(89, 13);
            this.maxFuelLabel.TabIndex = 43;
            this.maxFuelLabel.Text = "Maximum Fuel (L)";
            // 
            // maxPassengersLabel
            // 
            this.maxPassengersLabel.AutoSize = true;
            this.maxPassengersLabel.Location = new System.Drawing.Point(11, 143);
            this.maxPassengersLabel.Name = "maxPassengersLabel";
            this.maxPassengersLabel.Size = new System.Drawing.Size(109, 13);
            this.maxPassengersLabel.TabIndex = 42;
            this.maxPassengersLabel.Text = "Maximum Passengers";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(57, 68);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(63, 13);
            this.weightLabel.TabIndex = 41;
            this.weightLabel.Text = "Weight (Kg)";
            // 
            // numberPlateLabel
            // 
            this.numberPlateLabel.AutoSize = true;
            this.numberPlateLabel.Location = new System.Drawing.Point(49, 42);
            this.numberPlateLabel.Name = "numberPlateLabel";
            this.numberPlateLabel.Size = new System.Drawing.Size(71, 13);
            this.numberPlateLabel.TabIndex = 40;
            this.numberPlateLabel.Text = "Number Plate";
            // 
            // vehicleNameLabel
            // 
            this.vehicleNameLabel.AutoSize = true;
            this.vehicleNameLabel.Location = new System.Drawing.Point(47, 15);
            this.vehicleNameLabel.Name = "vehicleNameLabel";
            this.vehicleNameLabel.Size = new System.Drawing.Size(73, 13);
            this.vehicleNameLabel.TabIndex = 39;
            this.vehicleNameLabel.Text = "Vehicle Name";
            // 
            // milageTextBox
            // 
            this.milageTextBox.Location = new System.Drawing.Point(126, 194);
            this.milageTextBox.Name = "milageTextBox";
            this.milageTextBox.Size = new System.Drawing.Size(148, 20);
            this.milageTextBox.TabIndex = 38;
            // 
            // maxFuelTextBox
            // 
            this.maxFuelTextBox.Location = new System.Drawing.Point(126, 167);
            this.maxFuelTextBox.Name = "maxFuelTextBox";
            this.maxFuelTextBox.Size = new System.Drawing.Size(148, 20);
            this.maxFuelTextBox.TabIndex = 37;
            // 
            // maxPassengersTextBox
            // 
            this.maxPassengersTextBox.Location = new System.Drawing.Point(126, 140);
            this.maxPassengersTextBox.Name = "maxPassengersTextBox";
            this.maxPassengersTextBox.Size = new System.Drawing.Size(148, 20);
            this.maxPassengersTextBox.TabIndex = 36;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(126, 65);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(148, 20);
            this.weightTextBox.TabIndex = 35;
            // 
            // numberPlateTextBox
            // 
            this.numberPlateTextBox.Location = new System.Drawing.Point(126, 39);
            this.numberPlateTextBox.Name = "numberPlateTextBox";
            this.numberPlateTextBox.Size = new System.Drawing.Size(148, 20);
            this.numberPlateTextBox.TabIndex = 34;
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(126, 12);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.vehicleNameTextBox.TabIndex = 33;
            // 
            // EditLorryFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.loadWeightLabel);
            this.Controls.Add(this.loadWeightTextBox);
            this.Controls.Add(this.loadCheckBox);
            this.Controls.Add(this.milageLabel);
            this.Controls.Add(this.maxFuelLabel);
            this.Controls.Add(this.maxPassengersLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.numberPlateLabel);
            this.Controls.Add(this.vehicleNameLabel);
            this.Controls.Add(this.milageTextBox);
            this.Controls.Add(this.maxFuelTextBox);
            this.Controls.Add(this.maxPassengersTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.numberPlateTextBox);
            this.Controls.Add(this.vehicleNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditLorryFormView";
            this.Text = "EditLorryFormView";
            this.Load += new System.EventHandler(this.EditLorryFormView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label loadWeightLabel;
        private System.Windows.Forms.TextBox loadWeightTextBox;
        private System.Windows.Forms.CheckBox loadCheckBox;
        private System.Windows.Forms.Label milageLabel;
        private System.Windows.Forms.Label maxFuelLabel;
        private System.Windows.Forms.Label maxPassengersLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label numberPlateLabel;
        private System.Windows.Forms.Label vehicleNameLabel;
        private System.Windows.Forms.TextBox milageTextBox;
        private System.Windows.Forms.TextBox maxFuelTextBox;
        private System.Windows.Forms.TextBox maxPassengersTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox numberPlateTextBox;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
    }
}