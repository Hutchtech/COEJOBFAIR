using System;

namespace COEJOBFAIR_Alpha
{
    partial class Employer
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
            this.txt_name_first = new System.Windows.Forms.TextBox();
            this.txt_name_last = new System.Windows.Forms.TextBox();
            this.txt_organization = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.chck_box_alumni = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.cmb_hotels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_nights = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name_first
            // 
            this.txt_name_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_first.Location = new System.Drawing.Point(3, 19);
            this.txt_name_first.Name = "txt_name_first";
            this.txt_name_first.Size = new System.Drawing.Size(160, 26);
            this.txt_name_first.TabIndex = 0;
            this.txt_name_first.Text = "First Name";
            // 
            // txt_name_last
            // 
            this.txt_name_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_last.Location = new System.Drawing.Point(169, 19);
            this.txt_name_last.Name = "txt_name_last";
            this.txt_name_last.Size = new System.Drawing.Size(164, 26);
            this.txt_name_last.TabIndex = 1;
            this.txt_name_last.Text = "Last Name";
            // 
            // txt_organization
            // 
            this.txt_organization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_organization.Location = new System.Drawing.Point(3, 48);
            this.txt_organization.Name = "txt_organization";
            this.txt_organization.Size = new System.Drawing.Size(330, 26);
            this.txt_organization.TabIndex = 2;
            this.txt_organization.Text = "Organization Name";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(3, 80);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(330, 26);
            this.txt_title.TabIndex = 3;
            this.txt_title.Text = "Title";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(357, 266);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(226, 45);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit and Print";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_click);
            // 
            // chck_box_alumni
            // 
            this.chck_box_alumni.AutoSize = true;
            this.chck_box_alumni.Location = new System.Drawing.Point(6, 19);
            this.chck_box_alumni.Name = "chck_box_alumni";
            this.chck_box_alumni.Size = new System.Drawing.Size(165, 24);
            this.chck_box_alumni.TabIndex = 7;
            this.chck_box_alumni.Text = "Are you an Alumni?";
            this.chck_box_alumni.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_name_first);
            this.groupBox1.Controls.Add(this.txt_name_last);
            this.groupBox1.Controls.Add(this.txt_organization);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_nights);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_other);
            this.groupBox2.Controls.Add(this.cmb_hotels);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chck_box_alumni);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 119);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(619, 46);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(202, 26);
            this.txt_other.TabIndex = 10;
            this.txt_other.Text = "Please Specify Other";
            this.txt_other.Visible = false;
            // 
            // cmb_hotels
            // 
            this.cmb_hotels.FormattingEnabled = true;
            this.cmb_hotels.Items.AddRange(new object[] {
            "Overton",
            "Holiday Inn",
            "La Quinta Inn North",
            "Staybridge Suites",
            "Courtyard Marriott",
            "Embassy Suites",
            "Elegante",
            "Other"});
            this.cmb_hotels.Location = new System.Drawing.Point(370, 44);
            this.cmb_hotels.Name = "cmb_hotels";
            this.cmb_hotels.Size = new System.Drawing.Size(243, 28);
            this.cmb_hotels.TabIndex = 9;
            this.cmb_hotels.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "What is the name of the Hotel you are staying at?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "How many nights will you stay in this hotel?";
            // 
            // cmb_nights
            // 
            this.cmb_nights.FormattingEnabled = true;
            this.cmb_nights.Items.AddRange(new object[] {
            "0",
            "6 or more",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cmb_nights.Location = new System.Drawing.Point(370, 74);
            this.cmb_nights.Name = "cmb_nights";
            this.cmb_nights.Size = new System.Drawing.Size(243, 28);
            this.cmb_nights.TabIndex = 12;
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1105, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submit);
            this.Name = "Employer";
            this.Text = "Employer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void submit_func(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_name_first;
        private System.Windows.Forms.TextBox txt_name_last;
        private System.Windows.Forms.TextBox txt_organization;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox chck_box_alumni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_hotels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.ComboBox cmb_nights;
        private System.Windows.Forms.Label label2;
    }
}