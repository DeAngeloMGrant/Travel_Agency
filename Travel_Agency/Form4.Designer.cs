namespace Travel_Agency
{
    partial class Form4
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
            this.cbx_services = new System.Windows.Forms.ComboBox();
            this.cbx_depart = new System.Windows.Forms.ComboBox();
            this.cbx_Arrival = new System.Windows.Forms.ComboBox();
            this.txtPassengers = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.done = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Services";
            // 
            // cbx_services
            // 
            this.cbx_services.FormattingEnabled = true;
            this.cbx_services.Items.AddRange(new object[] {
            "Flight",
            "Bus",
            "Car",
            "Train"});
            this.cbx_services.Location = new System.Drawing.Point(27, 25);
            this.cbx_services.Name = "cbx_services";
            this.cbx_services.Size = new System.Drawing.Size(200, 21);
            this.cbx_services.TabIndex = 1;
            this.cbx_services.Text = "Choose Service";
            this.cbx_services.SelectedIndexChanged += new System.EventHandler(this.cbx_services_SelectedIndexChanged);
            // 
            // cbx_depart
            // 
            this.cbx_depart.FormattingEnabled = true;
            this.cbx_depart.Items.AddRange(new object[] {
            "Orlando",
            "Charlotte",
            "Charleston",
            "Beaufort",
            "Fayetteville",
            "Columbia"});
            this.cbx_depart.Location = new System.Drawing.Point(27, 132);
            this.cbx_depart.Name = "cbx_depart";
            this.cbx_depart.Size = new System.Drawing.Size(200, 21);
            this.cbx_depart.TabIndex = 2;
            this.cbx_depart.Text = "Depature City";
            // 
            // cbx_Arrival
            // 
            this.cbx_Arrival.FormattingEnabled = true;
            this.cbx_Arrival.Items.AddRange(new object[] {
            "Orlando",
            "Charlotte",
            "Charleston",
            "Beaufort",
            "Fayetteville",
            "Columbia"});
            this.cbx_Arrival.Location = new System.Drawing.Point(27, 159);
            this.cbx_Arrival.Name = "cbx_Arrival";
            this.cbx_Arrival.Size = new System.Drawing.Size(200, 21);
            this.cbx_Arrival.TabIndex = 3;
            this.cbx_Arrival.Text = "Arrival City";
            // 
            // txtPassengers
            // 
            this.txtPassengers.Location = new System.Drawing.Point(27, 186);
            this.txtPassengers.Name = "txtPassengers";
            this.txtPassengers.Size = new System.Drawing.Size(200, 20);
            this.txtPassengers.TabIndex = 4;
            this.txtPassengers.Text = "Number of Passengers";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(27, 238);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // cbx_class
            // 
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Items.AddRange(new object[] {
            "Coach",
            "First",
            "Economy"});
            this.cbx_class.Location = new System.Drawing.Point(27, 52);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(200, 21);
            this.cbx_class.TabIndex = 7;
            this.cbx_class.Text = "Choose Class";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(27, 106);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(200, 20);
            this.txtDays.TabIndex = 8;
            this.txtDays.Text = "Days of Rental";
            // 
            // cbx_type
            // 
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "Ford Mustang",
            "Ford F-150",
            "Chevy Traverse",
            "Chevy Camarro"});
            this.cbx_type.Location = new System.Drawing.Point(27, 79);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(200, 21);
            this.cbx_type.TabIndex = 9;
            this.cbx_type.Text = "Choose Car Type";
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(236, 25);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 10;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(236, 130);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(236, 234);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 269);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.done);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.cbx_class);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPassengers);
            this.Controls.Add(this.cbx_Arrival);
            this.Controls.Add(this.cbx_depart);
            this.Controls.Add(this.cbx_services);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_services;
        private System.Windows.Forms.ComboBox cbx_depart;
        private System.Windows.Forms.ComboBox cbx_Arrival;
        private System.Windows.Forms.TextBox txtPassengers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button back;
    }
}