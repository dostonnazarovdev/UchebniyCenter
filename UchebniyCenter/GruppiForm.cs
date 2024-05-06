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
    public partial class GruppiForm : Form
    {
        public GruppiForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddGruppaForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
