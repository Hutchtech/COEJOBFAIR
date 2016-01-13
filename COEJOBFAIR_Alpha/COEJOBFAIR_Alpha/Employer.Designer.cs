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
            this.SuspendLayout();
            // 
            // txt_name_first
            // 
            this.txt_name_first.Location = new System.Drawing.Point(99, 74);
            this.txt_name_first.Name = "txt_name_first";
            this.txt_name_first.Size = new System.Drawing.Size(100, 20);
            this.txt_name_first.TabIndex = 0;
            // 
            // txt_name_last
            // 
            this.txt_name_last.Location = new System.Drawing.Point(99, 100);
            this.txt_name_last.Name = "txt_name_last";
            this.txt_name_last.Size = new System.Drawing.Size(100, 20);
            this.txt_name_last.TabIndex = 1;
            // 
            // txt_organization
            // 
            this.txt_organization.Location = new System.Drawing.Point(99, 126);
            this.txt_organization.Name = "txt_organization";
            this.txt_organization.Size = new System.Drawing.Size(100, 20);
            this.txt_organization.TabIndex = 2;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(99, 152);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(100, 20);
            this.txt_title.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(383, 88);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_click);
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 572);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_organization);
            this.Controls.Add(this.txt_name_last);
            this.Controls.Add(this.txt_name_first);
            this.Name = "Employer";
            this.Text = "Employer";
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
    }
}