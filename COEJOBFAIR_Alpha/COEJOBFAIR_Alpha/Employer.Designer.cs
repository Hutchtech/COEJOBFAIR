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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employer));
            this.txt_name_first = new System.Windows.Forms.TextBox();
            this.txt_name_last = new System.Windows.Forms.TextBox();
            this.txt_organization = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.chck_box_alumni = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nights = new System.Windows.Forms.TextBox();
            this.lst_box = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.submit.Font = new System.Drawing.Font("Charter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(434, 440);
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
            this.chck_box_alumni.Font = new System.Drawing.Font("Charter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_box_alumni.Location = new System.Drawing.Point(106, 28);
            this.chck_box_alumni.Name = "chck_box_alumni";
            this.chck_box_alumni.Size = new System.Drawing.Size(213, 29);
            this.chck_box_alumni.TabIndex = 7;
            this.chck_box_alumni.Text = "Are you an Alumni?";
            this.chck_box_alumni.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.txt_name_first);
            this.groupBox1.Controls.Add(this.txt_name_last);
            this.groupBox1.Controls.Add(this.txt_organization);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Font = new System.Drawing.Font("Charter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.txt_nights);
            this.groupBox2.Controls.Add(this.lst_box);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_other);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chck_box_alumni);
            this.groupBox2.Font = new System.Drawing.Font("Charter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(116, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 214);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // txt_nights
            // 
            this.txt_nights.Location = new System.Drawing.Point(342, 177);
            this.txt_nights.Name = "txt_nights";
            this.txt_nights.Size = new System.Drawing.Size(100, 29);
            this.txt_nights.TabIndex = 14;
            // 
            // lst_box
            // 
            this.lst_box.FormattingEnabled = true;
            this.lst_box.ItemHeight = 19;
            this.lst_box.Location = new System.Drawing.Point(360, 75);
            this.lst_box.Name = "lst_box";
            this.lst_box.Size = new System.Drawing.Size(230, 61);
            this.lst_box.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "How many nights will you stay in this hotel?";
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(596, 107);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(202, 29);
            this.txt_other.TabIndex = 10;
            this.txt_other.Text = "Please Specify Other";
            this.txt_other.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "What is the name of the Hotel you are staying at?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 196);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Charter", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 43);
            this.label3.TabIndex = 23;
            this.label3.Text = "Welcome Employers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1105, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submit);
            this.Name = "Employer";
            this.Text = "Employer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ListBox lst_box;
        private System.Windows.Forms.TextBox txt_nights;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}