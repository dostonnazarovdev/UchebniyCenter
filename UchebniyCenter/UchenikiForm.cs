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
    public partial class UchenikiForm : Form
    {
        public UchenikiForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var wnd = new AddEditUchnikiForm();
            var result = wnd.ShowDialog();

            if (result == DialogResult.OK)
            {
                // обновить список учеников
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var wnd = new AddEditUchnikiForm();
            wnd.IsEditMode = true;
            var result = wnd.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
