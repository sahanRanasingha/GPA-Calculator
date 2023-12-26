namespace GPA_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.year1 = new System.Windows.Forms.Button();
            this.year2 = new System.Windows.Forms.Button();
            this.year3 = new System.Windows.Forms.Button();
            this.year4 = new System.Windows.Forms.Button();
            this.first_year = new System.Windows.Forms.Label();
            this.second_year = new System.Windows.Forms.Label();
            this.third_year = new System.Windows.Forms.Label();
            this.fourth_year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(207, 396);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(130, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(18, 370);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(30, 17);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Exit";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Final GPA";
            // 
            // year1
            // 
            this.year1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year1.Location = new System.Drawing.Point(220, 84);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(188, 126);
            this.year1.TabIndex = 15;
            this.year1.Text = "First Year";
            this.year1.UseVisualStyleBackColor = true;
            this.year1.Click += new System.EventHandler(this.year1_Click);
            // 
            // year2
            // 
            this.year2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year2.Location = new System.Drawing.Point(428, 84);
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(188, 126);
            this.year2.TabIndex = 16;
            this.year2.Text = "Second Year";
            this.year2.UseVisualStyleBackColor = true;
            // 
            // year3
            // 
            this.year3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year3.Location = new System.Drawing.Point(220, 244);
            this.year3.Name = "year3";
            this.year3.Size = new System.Drawing.Size(188, 126);
            this.year3.TabIndex = 17;
            this.year3.Text = "Third Year";
            this.year3.UseVisualStyleBackColor = true;
            // 
            // year4
            // 
            this.year4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year4.Location = new System.Drawing.Point(428, 244);
            this.year4.Name = "year4";
            this.year4.Size = new System.Drawing.Size(188, 126);
            this.year4.TabIndex = 18;
            this.year4.Text = "Fourth Year";
            this.year4.UseVisualStyleBackColor = true;
            // 
            // first_year
            // 
            this.first_year.AutoSize = true;
            this.first_year.BackColor = System.Drawing.SystemColors.ControlLight;
            this.first_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_year.Location = new System.Drawing.Point(247, 186);
            this.first_year.Name = "first_year";
            this.first_year.Size = new System.Drawing.Size(92, 20);
            this.first_year.TabIndex = 19;
            this.first_year.Text = "firstyeargpa";
            // 
            // second_year
            // 
            this.second_year.AutoSize = true;
            this.second_year.BackColor = System.Drawing.SystemColors.ControlLight;
            this.second_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_year.Location = new System.Drawing.Point(453, 186);
            this.second_year.Name = "second_year";
            this.second_year.Size = new System.Drawing.Size(118, 20);
            this.second_year.TabIndex = 20;
            this.second_year.Text = "secondyeargpa";
            // 
            // third_year
            // 
            this.third_year.AutoSize = true;
            this.third_year.BackColor = System.Drawing.SystemColors.ControlLight;
            this.third_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third_year.Location = new System.Drawing.Point(247, 344);
            this.third_year.Name = "third_year";
            this.third_year.Size = new System.Drawing.Size(97, 20);
            this.third_year.TabIndex = 21;
            this.third_year.Text = "thirdyeargpa";
            // 
            // fourth_year
            // 
            this.fourth_year.AutoSize = true;
            this.fourth_year.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fourth_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourth_year.Location = new System.Drawing.Point(453, 344);
            this.fourth_year.Name = "fourth_year";
            this.fourth_year.Size = new System.Drawing.Size(108, 20);
            this.fourth_year.TabIndex = 22;
            this.fourth_year.Text = "fourthyeargpa";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 396);
            this.Controls.Add(this.fourth_year);
            this.Controls.Add(this.third_year);
            this.Controls.Add(this.second_year);
            this.Controls.Add(this.first_year);
            this.Controls.Add(this.year4);
            this.Controls.Add(this.year3);
            this.Controls.Add(this.year2);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "GPA Calculator - Main";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button year1;
        private System.Windows.Forms.Button year2;
        private System.Windows.Forms.Button year3;
        private System.Windows.Forms.Button year4;
        private System.Windows.Forms.Label first_year;
        private System.Windows.Forms.Label second_year;
        private System.Windows.Forms.Label third_year;
        private System.Windows.Forms.Label fourth_year;
    }
}