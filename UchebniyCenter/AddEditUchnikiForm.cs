using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebniyCenter
{
    public partial class AddEditUchnikiForm : Form
    {
        public AddEditUchnikiForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
    }
}
