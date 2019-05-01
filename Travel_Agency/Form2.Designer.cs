namespace Travel_Agency
{
    partial class Form2
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
            this.txtf_name = new System.Windows.Forms.TextBox();
            this.txtl_name = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.cbx_nationality = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.package = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // txtf_name
            // 
            this.txtf_name.Location = new System.Drawing.Point(12, 25);
            this.txtf_name.Name = "txtf_name";
            this.txtf_name.Size = new System.Drawing.Size(260, 20);
            this.txtf_name.TabIndex = 1;
            this.txtf_name.Text = "First Name";
            // 
            // txtl_name
            // 
            this.txtl_name.Location = new System.Drawing.Point(12, 51);
            this.txtl_name.Name = "txtl_name";
            this.txtl_name.Size = new System.Drawing.Size(260, 20);
            this.txtl_name.TabIndex = 2;
            this.txtl_name.Text = "Last Name";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(12, 77);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(260, 20);
            this.txtphone.TabIndex = 3;
            this.txtphone.Text = "Telephone Number";
            // 
            // cbx_nationality
            // 
            this.cbx_nationality.FormattingEnabled = true;
            this.cbx_nationality.Items.AddRange(new object[] {
            "US",
            "Canada",
            "England",
            "Barbados",
            "Bahama"});
            this.cbx_nationality.Location = new System.Drawing.Point(12, 103);
            this.cbx_nationality.Name = "cbx_nationality";
            this.cbx_nationality.Size = new System.Drawing.Size(260, 21);
            this.cbx_nationality.TabIndex = 4;
            this.cbx_nationality.Text = "Nationality";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 130);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(260, 20);
            this.txtAge.TabIndex = 5;
            this.txtAge.Text = "Age";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(278, 22);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 6;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(278, 109);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(279, 80);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // package
            // 
            this.package.Location = new System.Drawing.Point(278, 51);
            this.package.Name = "package";
            this.package.Size = new System.Drawing.Size(75, 23);
            this.package.TabIndex = 9;
            this.package.Text = "Packages";
            this.package.UseVisualStyleBackColor = true;
            this.package.Click += new System.EventHandler(this.Package_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "City";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "State";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 238);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Zip Code";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 279);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.package);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cbx_nationality);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtl_name);
            this.Controls.Add(this.txtf_name);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtf_name;
        private System.Windows.Forms.TextBox txtl_name;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ComboBox cbx_nationality;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button package;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}