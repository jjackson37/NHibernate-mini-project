namespace WindowsFormsViewLayer.MotorbikeViews.PassengerMotorbikeFormView
{
    partial class PassengerMotorbikeFormView
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.passengersListView = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 130);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(90, 53);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 71);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 53);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 53);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // passengersListView
            // 
            this.passengersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName});
            this.passengersListView.FullRowSelect = true;
            this.passengersListView.GridLines = true;
            this.passengersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.passengersListView.Location = new System.Drawing.Point(108, 12);
            this.passengersListView.MultiSelect = false;
            this.passengersListView.Name = "passengersListView";
            this.passengersListView.Size = new System.Drawing.Size(270, 171);
            this.passengersListView.TabIndex = 8;
            this.passengersListView.UseCompatibleStateImageBehavior = false;
            this.passengersListView.View = System.Windows.Forms.View.Details;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 133;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 133;
            // 
            // PassengerMotorbikeFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 192);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passengersListView);
            this.Name = "PassengerMotorbikeFormView";
            this.Text = "PassengerMotorbikeFormView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassengerMotorbikeFormView_FormClosed);
            this.Load += new System.EventHandler(this.PassengerMotorbikeFormView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView passengersListView;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
    }
}