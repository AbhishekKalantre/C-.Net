using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class frm_Employee_Details : Form
    {
        public frm_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = " ";
            bool flag = false;

            if (tb_Employee_name.Text != " ")
            {
                Result = tb_Employee_name.Text;

                if (cmb_Employee_Department.Text != " ")
                {
                    Result += " From" + cmb_Employee_Department.Text + " is ";

                    if (rdb_male.Checked == true)
                    {
                        Result +=  rdb_male.Text + " Condidate prefers Shift Timing";

                    }
                    else if (rdb_female.Checked == true)
                    {
                        Result += rdb_female.Text + " Candidate prefers shift Timing";

                    }
                    else
                    {
                        MessageBox.Show("Select Gender  of Employee");

                    }
                    if (rdb_morning.Checked == true)
                    {
                        Result += rdb_morning.Text + ".";
                    }
                    else if (rdb_evening.Checked == true)
                    {
                        Result += rdb_evening.Text + ".";
                    }
                    else if (rdb_night.Checked == true)
                    {
                        Result += rdb_night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Timing");
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Select Employee Department");
                    flag = true;

                }
            }
            else
            {
                MessageBox.Show(" Enter Employee Name");
                flag = true;

            }
            if (flag == false)
            {
                tb_Output.Text = Result;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_name.Clear();
            tb_Output.Clear();
            cmb_Employee_Department.SelectedIndex = -1;
            rdb_male.Checked = false;
            rdb_female.Checked = false;
            rdb_morning.Checked = false;
            rdb_evening.Checked = false;
            rdb_night.Checked = false;

            tb_Employee_name.Focus();
        }
    }
    } 

