namespace COEJOBFAIR_Alpha
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_test = new System.Windows.Forms.Label();
            this.lbl_test2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(407, 162);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(304, 267);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(57, 13);
            this.lbl_test.TabIndex = 1;
            this.lbl_test.Text = "Test Label";
            // 
            // lbl_test2
            // 
            this.lbl_test2.AutoSize = true;
            this.lbl_test2.Location = new System.Drawing.Point(307, 294);
            this.lbl_test2.Name = "lbl_test2";
            this.lbl_test2.Size = new System.Drawing.Size(57, 13);
            this.lbl_test2.TabIndex = 2;
            this.lbl_test2.Text = "Test Label";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(394, 136);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 3;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 543);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_test2);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.btn_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.Label lbl_test2;
        private System.Windows.Forms.TextBox txt_id;
    }
}

