namespace Travel_Agency
{
    partial class Form3
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
            this.cbx_destination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_duration = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.services = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_destination
            // 
            this.cbx_destination.FormattingEnabled = true;
            this.cbx_destination.Items.AddRange(new object[] {
            "Orlando",
            "Jamaica",
            "Las Vegas",
            "New York",
            "Oregon",
            "Washington D.C",
            "New Orleans"});
            this.cbx_destination.Location = new System.Drawing.Point(58, 25);
            this.cbx_destination.Name = "cbx_destination";
            this.cbx_destination.Size = new System.Drawing.Size(162, 21);
            this.cbx_destination.TabIndex = 0;
            this.cbx_destination.Text = "Pick a Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popular Destinations";
            // 
            // cbx_duration
            // 
            this.cbx_duration.FormattingEnabled = true;
            this.cbx_duration.Items.AddRange(new object[] {
            "1 Day",
            "2 Days",
            "3 Days",
            "4 Days",
            "5 Days",
            "6 Days",
            "1 Week"});
            this.cbx_duration.Location = new System.Drawing.Point(58, 72);
            this.cbx_duration.Name = "cbx_duration";
            this.cbx_duration.Size = new System.Drawing.Size(162, 21);
            this.cbx_duration.TabIndex = 2;
            this.cbx_duration.Text = "How  Long Are You Staying?";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(244, 41);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // services
            // 
            this.services.Location = new System.Drawing.Point(244, 12);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(75, 23);
            this.services.TabIndex = 4;
            this.services.Text = "Services";
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(244, 70);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 112);
            this.Controls.Add(this.back);
            this.Controls.Add(this.services);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.cbx_duration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_destination);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_destination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_duration;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button services;
        private System.Windows.Forms.Button back;
    }
}