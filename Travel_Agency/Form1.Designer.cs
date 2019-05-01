namespace Travel_Agency
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.New_cust = new System.Windows.Forms.Button();
            this.Curr_cust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Sky\'s the Limit!";
            // 
            // New_cust
            // 
            this.New_cust.Location = new System.Drawing.Point(16, 29);
            this.New_cust.Name = "New_cust";
            this.New_cust.Size = new System.Drawing.Size(134, 117);
            this.New_cust.TabIndex = 1;
            this.New_cust.Text = "New Customer";
            this.New_cust.UseVisualStyleBackColor = true;
            this.New_cust.Click += new System.EventHandler(this.New_cust_Click);
            // 
            // Curr_cust
            // 
            this.Curr_cust.Location = new System.Drawing.Point(170, 29);
            this.Curr_cust.Name = "Curr_cust";
            this.Curr_cust.Size = new System.Drawing.Size(134, 117);
            this.Curr_cust.TabIndex = 2;
            this.Curr_cust.Text = "Current Customers";
            this.Curr_cust.UseVisualStyleBackColor = true;
            this.Curr_cust.Click += new System.EventHandler(this.Curr_cust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 158);
            this.Controls.Add(this.Curr_cust);
            this.Controls.Add(this.New_cust);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button New_cust;
        private System.Windows.Forms.Button Curr_cust;
    }
}

