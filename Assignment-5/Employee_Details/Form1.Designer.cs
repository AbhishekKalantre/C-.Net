
namespace Employee_Details
{
    partial class frm_Employee_Details
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
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Employee_name = new System.Windows.Forms.TextBox();
            this.cmb_Employee_Department = new System.Windows.Forms.ComboBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.rdb_night = new System.Windows.Forms.RadioButton();
            this.gb_Shift_time = new System.Windows.Forms.GroupBox();
            this.rdb_evening = new System.Windows.Forms.RadioButton();
            this.rdb_morning = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.gb_Gender.SuspendLayout();
            this.gb_Shift_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.Location = new System.Drawing.Point(478, 34);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(330, 51);
            this.lbl_Employee_Details.TabIndex = 2;
            this.lbl_Employee_Details.Text = "Employee Details";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.Location = new System.Drawing.Point(165, 120);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(193, 29);
            this.lbl_Employee_Name.TabIndex = 3;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.Location = new System.Drawing.Point(165, 203);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(253, 29);
            this.lbl_Employee_Department.TabIndex = 4;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(188, 320);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(94, 29);
            this.lbl_Gender.TabIndex = 5;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.Location = new System.Drawing.Point(190, 457);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(122, 29);
            this.lbl_Shift_Time.TabIndex = 6;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(188, 666);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(84, 29);
            this.lbl_Output.TabIndex = 7;
            this.lbl_Output.Text = "Output";
            // 
            // tb_Employee_name
            // 
            this.tb_Employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_name.Location = new System.Drawing.Point(486, 120);
            this.tb_Employee_name.Name = "tb_Employee_name";
            this.tb_Employee_name.Size = new System.Drawing.Size(331, 34);
            this.tb_Employee_name.TabIndex = 8;
            // 
            // cmb_Employee_Department
            // 
            this.cmb_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Department.FormattingEnabled = true;
            this.cmb_Employee_Department.Items.AddRange(new object[] {
            " HR",
            " Engineering",
            " marketing",
            " Admin ",
            " sales "});
            this.cmb_Employee_Department.Location = new System.Drawing.Point(486, 195);
            this.cmb_Employee_Department.Name = "cmb_Employee_Department";
            this.cmb_Employee_Department.Size = new System.Drawing.Size(331, 37);
            this.cmb_Employee_Department.TabIndex = 9;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Gender.Controls.Add(this.rdb_female);
            this.gb_Gender.Controls.Add(this.rdb_male);
            this.gb_Gender.Location = new System.Drawing.Point(460, 271);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(443, 100);
            this.gb_Gender.TabIndex = 10;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(236, 57);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(75, 21);
            this.rdb_female.TabIndex = 1;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "Female";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(55, 57);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(59, 21);
            this.rdb_male.TabIndex = 0;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "Male";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // rdb_night
            // 
            this.rdb_night.AutoSize = true;
            this.rdb_night.Location = new System.Drawing.Point(404, 57);
            this.rdb_night.Name = "rdb_night";
            this.rdb_night.Size = new System.Drawing.Size(62, 21);
            this.rdb_night.TabIndex = 11;
            this.rdb_night.TabStop = true;
            this.rdb_night.Text = "Night";
            this.rdb_night.UseVisualStyleBackColor = true;
            // 
            // gb_Shift_time
            // 
            this.gb_Shift_time.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Shift_time.Controls.Add(this.rdb_evening);
            this.gb_Shift_time.Controls.Add(this.rdb_night);
            this.gb_Shift_time.Controls.Add(this.rdb_morning);
            this.gb_Shift_time.Location = new System.Drawing.Point(460, 408);
            this.gb_Shift_time.Name = "gb_Shift_time";
            this.gb_Shift_time.Size = new System.Drawing.Size(590, 100);
            this.gb_Shift_time.TabIndex = 12;
            this.gb_Shift_time.TabStop = false;
            this.gb_Shift_time.Text = "Shift time";
            // 
            // rdb_evening
            // 
            this.rdb_evening.AutoSize = true;
            this.rdb_evening.Location = new System.Drawing.Point(236, 57);
            this.rdb_evening.Name = "rdb_evening";
            this.rdb_evening.Size = new System.Drawing.Size(80, 21);
            this.rdb_evening.TabIndex = 1;
            this.rdb_evening.TabStop = true;
            this.rdb_evening.Text = "Evening";
            this.rdb_evening.UseVisualStyleBackColor = true;
            // 
            // rdb_morning
            // 
            this.rdb_morning.AutoSize = true;
            this.rdb_morning.Location = new System.Drawing.Point(60, 57);
            this.rdb_morning.Name = "rdb_morning";
            this.rdb_morning.Size = new System.Drawing.Size(80, 21);
            this.rdb_morning.TabIndex = 0;
            this.rdb_morning.TabStop = true;
            this.rdb_morning.Text = "Morning";
            this.rdb_morning.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(426, 564);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(176, 62);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(749, 562);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(175, 62);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(329, 678);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(917, 34);
            this.tb_Output.TabIndex = 15;
            // 
            // frm_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1348, 786);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.gb_Shift_time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Employee_Department);
            this.Controls.Add(this.tb_Employee_name);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Employee_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Shift_time.ResumeLayout(false);
            this.gb_Shift_time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Employee_name;
        private System.Windows.Forms.ComboBox cmb_Employee_Department;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.RadioButton rdb_night;
        private System.Windows.Forms.GroupBox gb_Shift_time;
        private System.Windows.Forms.RadioButton rdb_evening;
        private System.Windows.Forms.RadioButton rdb_morning;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Output;
    }
}

