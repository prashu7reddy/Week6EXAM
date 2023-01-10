using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6EXAM
{
    public partial class Form1 : Form
    {
        string EmpType = "";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            SqlConnection conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["Week6Con"].ConnectionString);
            SqlCommand cmdObj = new SqlCommand("usp_AddEmployees1", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            cmdObj.Parameters.AddWithValue("@EmployeeId", TxtEmployeeId.Text);
            cmdObj.Parameters.AddWithValue("@EmployeeName", TxtEmployeeName.Text);
            cmdObj.Parameters.AddWithValue("@EMployeeSalary", TxtSalary.Text);

            //if(RadPayRoll.Checked)
            //{
            //    cmdObj.Parameters.AddWithValue("@EMployeeType", RadPayRoll.Text);
            //}
            //else if (RadConsultant.Checked)
            //{
            //    cmdObj.Parameters.AddWithValue("@EMployeeType", RadConsultant.Text);
            //}

            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }
            int res = cmdObj.ExecuteNonQuery();
            if (res > 0)
            {
                LblMessage.Text = " Employee Added succesfully";
            }
            cmdObj.Dispose();
            conObj.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        public void ResetControls()
        {
            TxtEmployeeId.Text = " ";
            TxtEmployeeName.Text = " ";
            TxtSalary.Text = " ";
           
        }

        private void RadPayRoll_CheckedChanged(object sender, EventArgs e)
        {
            EmpType = "P";
        }

        private void RadConsultant_CheckedChanged(object sender, EventArgs e)
        {
            EmpType = "C";
        }
    }
    }

