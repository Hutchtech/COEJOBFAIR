using System;

namespace COEJOBFAIR_Alpha
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug_cnn_chck = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_preregon = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_preregoff = new System.Windows.Forms.ToolStripMenuItem();
            this.status_cnn = new System.Windows.Forms.Button();
            this.status_db = new System.Windows.Forms.Button();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.grp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(613, 392);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(453, 127);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "R1257448";
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 758);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1405, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.employerToolStripMenuItem,
            this.preRegisterToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debug_cnn_chck,
            this.databaseCheckToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // debug_cnn_chck
            // 
            this.debug_cnn_chck.Name = "debug_cnn_chck";
            this.debug_cnn_chck.Size = new System.Drawing.Size(172, 22);
            this.debug_cnn_chck.Text = "Connection Check";
            this.debug_cnn_chck.Click += new System.EventHandler(this.debug_connection);
            // 
            // databaseCheckToolStripMenuItem
            // 
            this.databaseCheckToolStripMenuItem.Name = "databaseCheckToolStripMenuItem";
            this.databaseCheckToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.databaseCheckToolStripMenuItem.Text = "Database Check";
            this.databaseCheckToolStripMenuItem.Click += new System.EventHandler(this.debug_database);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // employerToolStripMenuItem
            // 
            this.employerToolStripMenuItem.Name = "employerToolStripMenuItem";
            this.employerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.employerToolStripMenuItem.Text = "Employer";
            this.employerToolStripMenuItem.Click += new System.EventHandler(this.employerToolStripMenuItem_Click);
            // 
            // preRegisterToolStripMenuItem
            // 
            this.preRegisterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_preregon,
            this.btn_preregoff});
            this.preRegisterToolStripMenuItem.Name = "preRegisterToolStripMenuItem";
            this.preRegisterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.preRegisterToolStripMenuItem.Text = "PreRegister";
            // 
            // btn_preregon
            // 
            this.btn_preregon.Name = "btn_preregon";
            this.btn_preregon.Size = new System.Drawing.Size(91, 22);
            this.btn_preregon.Text = "On";
            this.btn_preregon.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // btn_preregoff
            // 
            this.btn_preregoff.ForeColor = System.Drawing.Color.Red;
            this.btn_preregoff.Name = "btn_preregoff";
            this.btn_preregoff.Size = new System.Drawing.Size(91, 22);
            this.btn_preregoff.Text = "Off";
            this.btn_preregoff.Click += new System.EventHandler(this.btn_preregoff_Click);
            // 
            // status_cnn
            // 
            this.status_cnn.BackColor = System.Drawing.Color.DarkGreen;
            this.status_cnn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_cnn.Enabled = false;
            this.status_cnn.ForeColor = System.Drawing.Color.Cornsilk;
            this.status_cnn.Location = new System.Drawing.Point(0, 735);
            this.status_cnn.Name = "status_cnn";
            this.status_cnn.Size = new System.Drawing.Size(1405, 23);
            this.status_cnn.TabIndex = 10;
            this.status_cnn.Text = "Connection";
            this.status_cnn.UseVisualStyleBackColor = false;
            this.status_cnn.Visible = false;
            // 
            // status_db
            // 
            this.status_db.BackColor = System.Drawing.Color.DarkGreen;
            this.status_db.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_db.ForeColor = System.Drawing.Color.Cornsilk;
            this.status_db.Location = new System.Drawing.Point(0, 712);
            this.status_db.Name = "status_db";
            this.status_db.Size = new System.Drawing.Size(1405, 23);
            this.status_db.TabIndex = 12;
            this.status_db.Text = "Database";
            this.status_db.UseVisualStyleBackColor = false;
            this.status_db.Visible = false;
            // 
            // pBar1
            // 
            this.pBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar1.Location = new System.Drawing.Point(0, 686);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(1405, 26);
            this.pBar1.TabIndex = 13;
            this.pBar1.Visible = false;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first_name.Location = new System.Drawing.Point(37, 45);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(248, 31);
            this.txt_first_name.TabIndex = 14;
            this.txt_first_name.Text = "First Name";
            // 
            // txt_last_name
            // 
            this.txt_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_name.Location = new System.Drawing.Point(37, 82);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(292, 31);
            this.txt_last_name.TabIndex = 18;
            this.txt_last_name.Text = "Last Name";
            // 
            // grp_1
            // 
            this.grp_1.Controls.Add(this.button1);
            this.grp_1.Controls.Add(this.btn_print);
            this.grp_1.Controls.Add(this.txt_first_name);
            this.grp_1.Controls.Add(this.txt_last_name);
            this.grp_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grp_1.Location = new System.Drawing.Point(12, 252);
            this.grp_1.Name = "grp_1";
            this.grp_1.Size = new System.Drawing.Size(485, 237);
            this.grp_1.TabIndex = 19;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "Check Information";
            this.grp_1.Visible = false;
            this.grp_1.Enter += new System.EventHandler(this.grp_1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(145, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Print_if_notfound);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_print.Location = new System.Drawing.Point(145, 167);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(184, 45);
            this.btn_print.TabIndex = 20;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 94);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1405, 780);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grp_1);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.status_db);
            this.Controls.Add(this.status_cnn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grp_1.ResumeLayout(false);
            this.grp_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debug_cnn_chck;
        public System.Windows.Forms.Button status_cnn;
        public System.Windows.Forms.Button status_db;
        public System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseCheckToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_first_name;
        // private System.Windows.Forms.TextBox txt_major;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.GroupBox grp_1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_preregon;
        private System.Windows.Forms.ToolStripMenuItem btn_preregoff;
        private System.Windows.Forms.Button button1;
    }
}
