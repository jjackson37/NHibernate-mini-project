﻿namespace WindowsFormsViewLayer.MotorbikeViews
{
    partial class AddMotorbikeFormView
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
            this.sideCarCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(200, 207);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 30;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // milageLabel
            // 
            this.milageLabel.AutoSize = true;
            this.milageLabel.Location = new System.Drawing.Point(54, 177);
            this.milageLabel.Name = "milageLabel";
            this.milageLabel.Size = new System.Drawing.Size(67, 13);
            this.milageLabel.TabIndex = 29;
            this.milageLabel.Text = "Milage (mpg)";
            // 
            // maxFuelLabel
            // 
            this.maxFuelLabel.AutoSize = true;
            this.maxFuelLabel.Location = new System.Drawing.Point(32, 150);
            this.maxFuelLabel.Name = "maxFuelLabel";
            this.maxFuelLabel.Size = new System.Drawing.Size(89, 13);
            this.maxFuelLabel.TabIndex = 28;
            this.maxFuelLabel.Text = "Maximum Fuel (L)";
            // 
            // maxPassengersLabel
            // 
            this.maxPassengersLabel.AutoSize = true;
            this.maxPassengersLabel.Location = new System.Drawing.Point(12, 123);
            this.maxPassengersLabel.Name = "maxPassengersLabel";
            this.maxPassengersLabel.Size = new System.Drawing.Size(109, 13);
            this.maxPassengersLabel.TabIndex = 27;
            this.maxPassengersLabel.Text = "Maximum Passengers";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(58, 96);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(63, 13);
            this.weightLabel.TabIndex = 26;
            this.weightLabel.Text = "Weight (Kg)";
            // 
            // numberPlateLabel
            // 
            this.numberPlateLabel.AutoSize = true;
            this.numberPlateLabel.Location = new System.Drawing.Point(50, 42);
            this.numberPlateLabel.Name = "numberPlateLabel";
            this.numberPlateLabel.Size = new System.Drawing.Size(71, 13);
            this.numberPlateLabel.TabIndex = 23;
            this.numberPlateLabel.Text = "Number Plate";
            // 
            // vehicleNameLabel
            // 
            this.vehicleNameLabel.AutoSize = true;
            this.vehicleNameLabel.Location = new System.Drawing.Point(48, 15);
            this.vehicleNameLabel.Name = "vehicleNameLabel";
            this.vehicleNameLabel.Size = new System.Drawing.Size(73, 13);
            this.vehicleNameLabel.TabIndex = 22;
            this.vehicleNameLabel.Text = "Vehicle Name";
            // 
            // milageTextBox
            // 
            this.milageTextBox.Location = new System.Drawing.Point(127, 174);
            this.milageTextBox.Name = "milageTextBox";
            this.milageTextBox.Size = new System.Drawing.Size(148, 20);
            this.milageTextBox.TabIndex = 21;
            // 
            // maxFuelTextBox
            // 
            this.maxFuelTextBox.Location = new System.Drawing.Point(127, 147);
            this.maxFuelTextBox.Name = "maxFuelTextBox";
            this.maxFuelTextBox.Size = new System.Drawing.Size(148, 20);
            this.maxFuelTextBox.TabIndex = 20;
            // 
            // maxPassengersTextBox
            // 
            this.maxPassengersTextBox.Location = new System.Drawing.Point(127, 120);
            this.maxPassengersTextBox.Name = "maxPassengersTextBox";
            this.maxPassengersTextBox.Size = new System.Drawing.Size(148, 20);
            this.maxPassengersTextBox.TabIndex = 19;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(127, 93);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(148, 20);
            this.weightTextBox.TabIndex = 18;
            // 
            // numberPlateTextBox
            // 
            this.numberPlateTextBox.Location = new System.Drawing.Point(127, 39);
            this.numberPlateTextBox.Name = "numberPlateTextBox";
            this.numberPlateTextBox.Size = new System.Drawing.Size(148, 20);
            this.numberPlateTextBox.TabIndex = 17;
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(127, 12);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.vehicleNameTextBox.TabIndex = 16;
            // 
            // sideCarCheckBox
            // 
            this.sideCarCheckBox.AutoSize = true;
            this.sideCarCheckBox.Location = new System.Drawing.Point(209, 70);
            this.sideCarCheckBox.Name = "sideCarCheckBox";
            this.sideCarCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sideCarCheckBox.Size = new System.Drawing.Size(66, 17);
            this.sideCarCheckBox.TabIndex = 31;
            this.sideCarCheckBox.Text = "Side Car";
            this.sideCarCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddMotorbikeFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 242);
            this.Controls.Add(this.sideCarCheckBox);
            this.Controls.Add(this.submitButton);
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
            this.Name = "AddMotorbikeFormView";
            this.Text = "AddMotorbikeFormView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
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
        private System.Windows.Forms.CheckBox sideCarCheckBox;
    }
}