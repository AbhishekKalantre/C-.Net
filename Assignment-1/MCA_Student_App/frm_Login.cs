﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCA_Student_App
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "A" && tb_Password.Text == "A")
            {
                MessageBox.Show("Login Successful","Welcome");

                frm_add_student_detail sd = new frm_add_student_detail();
                sd.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed Enter Correct Username/Password.", "failure");
            }
            tb_Password.Clear();
            tb_Username.Clear();

            tb_Username.Focus();

        }
    }
}
