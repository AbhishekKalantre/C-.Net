
namespace MCA_Student_App
{
    partial class frm_Search_Student_Detail
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
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Student_list = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_mobile_no = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_Roll_no = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Panel();
            this.lbl_Search_Student_details = new System.Windows.Forms.Label();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Roll_no = new System.Windows.Forms.TextBox();
            this.p.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Course
            // 
            this.cmb_Course.BackColor = System.Drawing.Color.Khaki;
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BBA",
            "BCS",
            "MCA",
            "BBA",
            "MBA"});
            this.cmb_Course.Location = new System.Drawing.Point(554, 532);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(267, 47);
            this.cmb_Course.TabIndex = 18;
            // 
            // btn_Student_list
            // 
            this.btn_Student_list.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Student_list.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_list.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Student_list.Location = new System.Drawing.Point(12, 632);
            this.btn_Student_list.Name = "btn_Student_list";
            this.btn_Student_list.Size = new System.Drawing.Size(262, 59);
            this.btn_Student_list.TabIndex = 20;
            this.btn_Student_list.Text = "Student List";
            this.btn_Student_list.UseVisualStyleBackColor = false;
            this.btn_Student_list.Click += new System.EventHandler(this.btn_Student_list_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtp_DOB.CalendarMonthBackground = System.Drawing.Color.Khaki;
            this.dtp_DOB.CalendarTitleBackColor = System.Drawing.Color.Khaki;
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(554, 427);
            this.dtp_DOB.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(267, 46);
            this.dtp_DOB.TabIndex = 16;
            this.dtp_DOB.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.BackColor = System.Drawing.Color.Khaki;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(554, 328);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(267, 46);
            this.tb_Mobile_No.TabIndex = 14;
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.Khaki;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(554, 230);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(267, 46);
            this.tb_Name.TabIndex = 12;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_refresh.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Maroon;
            this.btn_refresh.Location = new System.Drawing.Point(542, 632);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(168, 59);
            this.btn_refresh.TabIndex = 22;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_close.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Location = new System.Drawing.Point(904, 632);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(148, 59);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Update.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Update.Location = new System.Drawing.Point(745, 632);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(144, 59);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_mobile_no
            // 
            this.lbl_mobile_no.AutoSize = true;
            this.lbl_mobile_no.BackColor = System.Drawing.Color.Goldenrod;
            this.lbl_mobile_no.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile_no.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_mobile_no.Location = new System.Drawing.Point(228, 337);
            this.lbl_mobile_no.Name = "lbl_mobile_no";
            this.lbl_mobile_no.Size = new System.Drawing.Size(188, 38);
            this.lbl_mobile_no.TabIndex = 19;
            this.lbl_mobile_no.Text = "Mobile no";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Goldenrod;
            this.lbl_name.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_name.Location = new System.Drawing.Point(228, 234);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(93, 38);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "Name";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.BackColor = System.Drawing.Color.Goldenrod;
            this.lbl_course.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_course.Location = new System.Drawing.Point(228, 542);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(131, 38);
            this.lbl_course.TabIndex = 15;
            this.lbl_course.Text = "Course";
            // 
            // lbl_Roll_no
            // 
            this.lbl_Roll_no.AutoSize = true;
            this.lbl_Roll_no.BackColor = System.Drawing.Color.Goldenrod;
            this.lbl_Roll_no.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_no.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Roll_no.Location = new System.Drawing.Point(228, 141);
            this.lbl_Roll_no.Name = "lbl_Roll_no";
            this.lbl_Roll_no.Size = new System.Drawing.Size(150, 38);
            this.lbl_Roll_no.TabIndex = 13;
            this.lbl_Roll_no.Text = "Roll no";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Crimson;
            this.btn_LogOut.Font = new System.Drawing.Font("Sanskrit Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_LogOut.Location = new System.Drawing.Point(903, 9);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(172, 80);
            this.btn_LogOut.TabIndex = 10;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.BackColor = System.Drawing.Color.Goldenrod;
            this.lbl_dob.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_dob.Location = new System.Drawing.Point(228, 436);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(131, 38);
            this.lbl_dob.TabIndex = 21;
            this.lbl_dob.Text = "D.O.B.";
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.CadetBlue;
            this.p.Controls.Add(this.btn_LogOut);
            this.p.Controls.Add(this.lbl_Search_Student_details);
            this.p.Location = new System.Drawing.Point(1, 3);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(1078, 100);
            this.p.TabIndex = 11;
            // 
            // lbl_Search_Student_details
            // 
            this.lbl_Search_Student_details.AutoSize = true;
            this.lbl_Search_Student_details.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Student_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Search_Student_details.Location = new System.Drawing.Point(282, 26);
            this.lbl_Search_Student_details.Name = "lbl_Search_Student_details";
            this.lbl_Search_Student_details.Size = new System.Drawing.Size(503, 43);
            this.lbl_Search_Student_details.TabIndex = 0;
            this.lbl_Search_Student_details.Text = "Search Student Details";
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Add_Student.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Add_Student.Location = new System.Drawing.Point(295, 632);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(220, 59);
            this.btn_Add_Student.TabIndex = 25;
            this.btn_Add_Student.Text = "Add Student ";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Purple;
            this.btn_Search.Font = new System.Drawing.Font("Sanskrit Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_Search.Location = new System.Drawing.Point(855, 129);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(172, 63);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Roll_no
            // 
            this.tb_Roll_no.BackColor = System.Drawing.Color.Khaki;
            this.tb_Roll_no.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_no.Location = new System.Drawing.Point(554, 141);
            this.tb_Roll_no.MaxLength = 5;
            this.tb_Roll_no.Name = "tb_Roll_no";
            this.tb_Roll_no.Size = new System.Drawing.Size(267, 46);
            this.tb_Roll_no.TabIndex = 27;
            // 
            // frm_Search_Student_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.tb_Roll_no);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add_Student);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.btn_Student_list);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_mobile_no);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_Roll_no);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.p);
            this.Name = "frm_Search_Student_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Student_Detail";
            this.p.ResumeLayout(false);
            this.p.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Student_list;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_mobile_no;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_Roll_no;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Panel p;
        protected System.Windows.Forms.Label lbl_Search_Student_details;
        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.Button btn_Search;
        protected internal System.Windows.Forms.TextBox tb_Roll_no;
    }
}