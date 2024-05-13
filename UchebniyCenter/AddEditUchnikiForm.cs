using EducationCenterDAL;
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

namespace UchebniyCenter
{
    public partial class AddEditUchnikiForm : Form
    {
      SqlConnection con = new SqlConnection("Server=DESKTOP-Q5U0TJS\\SQLEXPRESS;Database=EduCenterDb;Trusted_Connection=true;Connect Timeout=900;");
      
        
        
      
        int num_rows;
        int studentId = 1;
        public AddEditUchnikiForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentModel values('" + studentId + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "' )", con);
            num_rows = cmd.ExecuteNonQuery();
            if (num_rows >= 1)
            {
                MessageBox.Show("StudentModel successfully saved!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Sorry error in saving data!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }

        public bool IsEditMode { get; set; }

        private void AddEditUchnikiForm_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                this.Text = "Редактирование ученика";
                btnSave.Text = "Сохранить";
            }
            else
            {
                this.Text = "Добавление ученика";
                btnSave.Text = "Добавить";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
