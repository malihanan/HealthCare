using HealthCare.Model;
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

namespace HealthCare.View
{
    public partial class ViewCases : Form
    {
        Form prevForm;
        public ViewCases(Form frm)
        {
            InitializeComponent();
            prevForm = frm;
            refreshData(false);
            if (Global.Type == UserType.PATIENT)
            {
                ViewHistoryButton.Visible = false;
                PatientId.Visible = false;
                PatientName.Visible = false;
            }
        }

        public void refreshData(bool showClose)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "";
                UserType userType = (UserType)Global.Type;
                if (showClose)
                {
                    if (userType == UserType.DOCTOR)
                    {
                        cmdText = "Select [Case].Id, [Case].ModifyDate, [Case].Title, [User].Id, [User].Username from [Case], [User] where [Case].PatientId = [User].Id and [Case].DoctorId = @Id and [Case].ClosingDate IS NOT NULL order by [Case].ModifyDate desc;";
                    }
                    else if (userType == UserType.PATIENT)
                    {
                        cmdText = "Select [Case].Id, [Case].ModifyDate, [Case].Title, [User].Id, [User].Username from [Case], [User] where [Case].PatientId = [User].Id and [Case].PatientId = @Id and [Case].ClosingDate IS NOT NULL order by [Case].ModifyDate desc;";
                    }
                    ViewHistoryButton.Visible = false;
                }
                else
                {
                    if (userType == UserType.DOCTOR)
                    {
                        cmdText = "Select [Case].Id, [Case].ModifyDate, [Case].Title, [User].Id, [User].Username from [Case], [User] where [Case].PatientId = [User].Id and [Case].DoctorId = @Id and [Case].ClosingDate IS NULL order by [Case].ModifyDate desc;";
                    }
                    else if (userType == UserType.PATIENT)
                    {
                        cmdText = "Select [Case].Id, [Case].ModifyDate, [Case].Title, [User].Id, [User].Username from [Case], [User] where [Case].PatientId = [User].Id and [Case].PatientId = @Id and [Case].ClosingDate IS NULL order by [Case].ModifyDate desc;";
                    }
                }
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Id", Global.Id);
                using (con)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) // Edit / View Case
                {
                    if (Global.Type == UserType.DOCTOR)
                    {
                        EditCase editCase = new EditCase(prevForm, Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                        this.Hide();
                        editCase.Show();
                    }
                    else if (Global.Type == UserType.PATIENT)
                    {
                        ViewCase viewCase = new ViewCase(Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()), this);
                        this.Hide();
                        viewCase.Show();
                    }
                }
                else
                {
                    ViewHistory viewHistory = null;
                    if (Global.Type == UserType.DOCTOR)
                    {
                        viewHistory = new ViewHistory(Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["PatientId"].Value.ToString()), this);
                    }
                    else if (Global.Type == UserType.PATIENT)
                    {
                        viewHistory = new ViewHistory((int)Global.Id, this);
                    }
                    this.Hide();
                    viewHistory.Show();
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            if(close_button.Text.Equals("VIEW CLOSED CASES"))
            {
                close_button.Text = "VIEW OPEN CASES";
                refreshData(true);
            }
            else
            {
                close_button.Text = "VIEW CLOSE CASES";
                refreshData(false);
            }
        }
    }
}
