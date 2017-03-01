namespace WindowsFormsViewLayer
{
    partial class MainFormView
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
            this.carButton = new System.Windows.Forms.Button();
            this.lorryButton = new System.Windows.Forms.Button();
            this.motorbikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(12, 12);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(231, 23);
            this.carButton.TabIndex = 0;
            this.carButton.Text = "Car";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // lorryButton
            // 
            this.lorryButton.Location = new System.Drawing.Point(12, 41);
            this.lorryButton.Name = "lorryButton";
            this.lorryButton.Size = new System.Drawing.Size(231, 23);
            this.lorryButton.TabIndex = 1;
            this.lorryButton.Text = "Lorry";
            this.lorryButton.UseVisualStyleBackColor = true;
            this.lorryButton.Click += new System.EventHandler(this.lorryButton_Click);
            // 
            // motorbikeButton
            // 
            this.motorbikeButton.Location = new System.Drawing.Point(12, 70);
            this.motorbikeButton.Name = "motorbikeButton";
            this.motorbikeButton.Size = new System.Drawing.Size(231, 23);
            this.motorbikeButton.TabIndex = 2;
            this.motorbikeButton.Text = "Motorbike";
            this.motorbikeButton.UseVisualStyleBackColor = true;
            this.motorbikeButton.Click += new System.EventHandler(this.motorbikeButton_Click);
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 102);
            this.Controls.Add(this.motorbikeButton);
            this.Controls.Add(this.lorryButton);
            this.Controls.Add(this.carButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHibernate mini project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Button lorryButton;
        private System.Windows.Forms.Button motorbikeButton;
    }
}

