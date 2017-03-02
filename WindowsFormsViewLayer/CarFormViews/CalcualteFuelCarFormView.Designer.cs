namespace WindowsFormsViewLayer.CarFormViews
{
    partial class CalcualteFuelCarFormView
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
            this.DistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DistanceNumericUpDown
            // 
            this.DistanceNumericUpDown.Location = new System.Drawing.Point(99, 7);
            this.DistanceNumericUpDown.Name = "DistanceNumericUpDown";
            this.DistanceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DistanceNumericUpDown.TabIndex = 0;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(12, 9);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(81, 13);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Distance (miles)";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(144, 33);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CalcualteFuelCarFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 66);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.DistanceNumericUpDown);
            this.Name = "CalcualteFuelCarFormView";
            this.Text = "Calculate fuel";
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown DistanceNumericUpDown;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Button submitButton;
    }
}