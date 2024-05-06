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
    public partial class AddGruppaForm : Form
    {
        public AddGruppaForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public bool IsEditMode { get; set; }

        private void AddGruppaForm_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                this.Text = "Редактирование группы";
                btnSave.Text = "Сохранить";
            }
            else
            {
                this.Text = "Добавление группы";
                btnSave.Text = "Добавить";
            }
        }
    }
}
