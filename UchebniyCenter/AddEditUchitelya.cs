using System;
using System.Windows.Forms;

namespace UchebniyCenter
{
    public partial class AddEditUchitelya : Form
    {
        public AddEditUchitelya()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void AddEditUchitelya_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                this.Text = "Редактирование учителя";
                btnSave.Text = "Сохранить";
            }
            else
            {
                this.Text = "Добавление учителя";
                btnSave.Text = "Добавить";
            }
        }

        public bool IsEditMode { get; set; }
    }
}
