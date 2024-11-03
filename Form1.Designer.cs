namespace StudentRegistrationApplication
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
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMidName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMidName = new System.Windows.Forms.Label();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.lblDob = new System.Windows.Forms.Label();
            this.dropDay = new System.Windows.Forms.ComboBox();
            this.dropYear = new System.Windows.Forms.ComboBox();
            this.dropMonth = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.dropCourse = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(12, 79);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(348, 27);
            this.tbLastName.TabIndex = 0;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(12, 143);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(348, 27);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbMidName
            // 
            this.tbMidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMidName.Location = new System.Drawing.Point(12, 202);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.Size = new System.Drawing.Size(348, 27);
            this.tbMidName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 51);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last name*";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First name*";
            // 
            // lblMidName
            // 
            this.lblMidName.AutoSize = true;
            this.lblMidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidName.Location = new System.Drawing.Point(12, 174);
            this.lblMidName.Name = "lblMidName";
            this.lblMidName.Size = new System.Drawing.Size(144, 25);
            this.lblMidName.TabIndex = 5;
            this.lblMidName.Text = "Middle name*";
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMale.Location = new System.Drawing.Point(110, 236);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(76, 29);
            this.rBtnMale.TabIndex = 6;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 236);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(92, 25);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender*";
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFemale.Location = new System.Drawing.Point(192, 236);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(98, 29);
            this.rBtnFemale.TabIndex = 8;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Female";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(12, 281);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(138, 25);
            this.lblDob.TabIndex = 9;
            this.lblDob.Text = "Date of birth*";
            // 
            // dropDay
            // 
            this.dropDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDay.FormattingEnabled = true;
            this.dropDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dropDay.Location = new System.Drawing.Point(12, 309);
            this.dropDay.Name = "dropDay";
            this.dropDay.Size = new System.Drawing.Size(74, 28);
            this.dropDay.TabIndex = 10;
            this.dropDay.Text = "-Day-";
            // 
            // dropYear
            // 
            this.dropYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropYear.FormattingEnabled = true;
            this.dropYear.Items.AddRange(new object[] {
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004"});
            this.dropYear.Location = new System.Drawing.Point(266, 309);
            this.dropYear.Name = "dropYear";
            this.dropYear.Size = new System.Drawing.Size(94, 28);
            this.dropYear.TabIndex = 11;
            this.dropYear.Text = "-Year-";
            // 
            // dropMonth
            // 
            this.dropMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropMonth.FormattingEnabled = true;
            this.dropMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.dropMonth.Location = new System.Drawing.Point(92, 309);
            this.dropMonth.Name = "dropMonth";
            this.dropMonth.Size = new System.Drawing.Size(168, 28);
            this.dropMonth.TabIndex = 12;
            this.dropMonth.Text = "-Month-";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(12, 350);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(184, 25);
            this.lblCourse.TabIndex = 13;
            this.lblCourse.Text = "Program to apply*";
            // 
            // dropCourse
            // 
            this.dropCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropCourse.FormattingEnabled = true;
            this.dropCourse.Items.AddRange(new object[] {
            "BS in Computer Science",
            "BS in Information Technology",
            "BS in Hospitality Management",
            "BS in Multimedia Arts"});
            this.dropCourse.Location = new System.Drawing.Point(12, 378);
            this.dropCourse.Name = "dropCourse";
            this.dropCourse.Size = new System.Drawing.Size(348, 28);
            this.dropCourse.TabIndex = 14;
            this.dropCourse.Text = "-Select program-";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(370, 32);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "Student Registration Form";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Maroon;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(12, 419);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(228, 55);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register student";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(402, 51);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(267, 255);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 17;
            this.picBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(453, 312);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(159, 33);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 504);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dropCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.dropMonth);
            this.Controls.Add(this.dropYear);
            this.Controls.Add(this.dropDay);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.rBtnFemale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rBtnMale);
            this.Controls.Add(this.lblMidName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbMidName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMidName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMidName;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.ComboBox dropDay;
        private System.Windows.Forms.ComboBox dropYear;
        private System.Windows.Forms.ComboBox dropMonth;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox dropCourse;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

