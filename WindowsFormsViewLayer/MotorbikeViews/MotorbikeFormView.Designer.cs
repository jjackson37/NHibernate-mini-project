﻿namespace WindowsFormsViewLayer
{
    partial class MotorbikeFormView
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.passengerButton = new System.Windows.Forms.Button();
            this.calculateFuelButton = new System.Windows.Forms.Button();
            this.refuelButton = new System.Windows.Forms.Button();
            this.motorbikeList = new System.Windows.Forms.ListView();
            this.VehicleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numberplate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fuel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Milage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Passengers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SideCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 486);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(110, 73);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Reload list";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 73);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 91);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 73);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 170);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 73);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // passengerButton
            // 
            this.passengerButton.Location = new System.Drawing.Point(12, 249);
            this.passengerButton.Name = "passengerButton";
            this.passengerButton.Size = new System.Drawing.Size(110, 73);
            this.passengerButton.TabIndex = 12;
            this.passengerButton.Text = "Passengers";
            this.passengerButton.UseVisualStyleBackColor = true;
            this.passengerButton.Click += new System.EventHandler(this.passengerButton_Click);
            // 
            // calculateFuelButton
            // 
            this.calculateFuelButton.Location = new System.Drawing.Point(12, 328);
            this.calculateFuelButton.Name = "calculateFuelButton";
            this.calculateFuelButton.Size = new System.Drawing.Size(110, 73);
            this.calculateFuelButton.TabIndex = 11;
            this.calculateFuelButton.Text = "Calculate fuel";
            this.calculateFuelButton.UseVisualStyleBackColor = true;
            this.calculateFuelButton.Click += new System.EventHandler(this.calculateFuelButton_Click);
            // 
            // refuelButton
            // 
            this.refuelButton.Location = new System.Drawing.Point(12, 407);
            this.refuelButton.Name = "refuelButton";
            this.refuelButton.Size = new System.Drawing.Size(110, 73);
            this.refuelButton.TabIndex = 10;
            this.refuelButton.Text = "Refuel";
            this.refuelButton.UseVisualStyleBackColor = true;
            this.refuelButton.Click += new System.EventHandler(this.refuelButton_Click);
            // 
            // motorbikeList
            // 
            this.motorbikeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VehicleName,
            this.Numberplate,
            this.Weight,
            this.Fuel,
            this.Milage,
            this.Passengers,
            this.SideCar});
            this.motorbikeList.FullRowSelect = true;
            this.motorbikeList.GridLines = true;
            this.motorbikeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.motorbikeList.LabelWrap = false;
            this.motorbikeList.Location = new System.Drawing.Point(128, 12);
            this.motorbikeList.MultiSelect = false;
            this.motorbikeList.Name = "motorbikeList";
            this.motorbikeList.Size = new System.Drawing.Size(598, 547);
            this.motorbikeList.TabIndex = 9;
            this.motorbikeList.UseCompatibleStateImageBehavior = false;
            this.motorbikeList.View = System.Windows.Forms.View.Details;
            // 
            // VehicleName
            // 
            this.VehicleName.Text = "VehicleName";
            this.VehicleName.Width = 120;
            // 
            // Numberplate
            // 
            this.Numberplate.Text = "Numberplate";
            this.Numberplate.Width = 75;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            this.Weight.Width = 75;
            // 
            // Fuel
            // 
            this.Fuel.Text = "Fuel";
            this.Fuel.Width = 110;
            // 
            // Milage
            // 
            this.Milage.Text = "Milage";
            this.Milage.Width = 85;
            // 
            // Passengers
            // 
            this.Passengers.Text = "Passengers";
            this.Passengers.Width = 68;
            // 
            // SideCar
            // 
            this.SideCar.Text = "Side Car";
            // 
            // MotorbikeFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 572);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.passengerButton);
            this.Controls.Add(this.calculateFuelButton);
            this.Controls.Add(this.refuelButton);
            this.Controls.Add(this.motorbikeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MotorbikeFormView";
            this.Text = "MotorbikeFormView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MotorbikeFormView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button passengerButton;
        private System.Windows.Forms.Button calculateFuelButton;
        private System.Windows.Forms.Button refuelButton;
        private System.Windows.Forms.ListView motorbikeList;
        private System.Windows.Forms.ColumnHeader VehicleName;
        private System.Windows.Forms.ColumnHeader Numberplate;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Fuel;
        private System.Windows.Forms.ColumnHeader Milage;
        private System.Windows.Forms.ColumnHeader Passengers;
        private System.Windows.Forms.ColumnHeader SideCar;
    }
}