using System;
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
    public partial class frm_add_student_detail : Form
    {
        public frm_add_student_detail()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Integrated Security=True;Encrypt=False");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }

        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }

        }

        void Clear_Controls()
        {
            tb_Roll_no.Text = "";
            tb_Name.Text = "";
            tb_Mobile_No.Text = "";
            dtp_DOB.Text = "";
            cmb_Course.SelectedIndex = 1;


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Roll_no.Text != "" &&  tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "Insert Into Student_Details values(@RNo,@Name,@MNo,@DOB,@Course)";

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_no.Text;
                cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Insert Successfull","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con.Close();

        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {
           Clear_Controls();

        }

        private void btn_Student_list_Click(object sender, EventArgs e)
        {
           frm_Student_list obj =  new frm_Student_list();
           obj.Show();
            this.Hide();

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();


        }
    }
}
