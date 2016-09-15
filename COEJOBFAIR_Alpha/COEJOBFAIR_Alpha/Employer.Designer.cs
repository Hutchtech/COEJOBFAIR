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
            this.lst_hotels = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.submit.Location = new System.Drawing.Point(467, 494);
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
            this.chck_box_alumni.Location = new System.Drawing.Point(351, 25);
            this.chck_box_alumni.Name = "chck_box_alumni";
            this.chck_box_alumni.Size = new System.Drawing.Size(165, 24);
            this.chck_box_alumni.TabIndex = 7;
            this.chck_box_alumni.Text = "Are you an Alumni?";
            this.chck_box_alumni.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.txt_name_first);
            this.groupBox1.Controls.Add(this.txt_name_last);
            this.groupBox1.Controls.Add(this.txt_organization);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chck_box_alumni);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(116, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 254);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // lst_hotels
            // 
            this.lst_hotels.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lst_hotels.ItemHeight = 20;
            this.lst_hotels.Location = new System.Drawing.Point(366, 19);
            this.lst_hotels.Name = "lst_hotels";
            this.lst_hotels.Size = new System.Drawing.Size(240, 84);
            this.lst_hotels.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "How many nights will you stay in this hotel?";
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(612, 77);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(202, 26);
            this.txt_other.TabIndex = 10;
            this.txt_other.Text = "Please Specify Other";
            this.txt_other.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "What is the name of the Hotel you are staying at?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 26);
            this.textBox1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lst_hotels);
            this.groupBox3.Controls.Add(this.txt_other);
            this.groupBox3.Location = new System.Drawing.Point(6, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(865, 122);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_hotels;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}