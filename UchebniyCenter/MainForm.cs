using System;
using System.Windows.Forms;

namespace UchebniyCenter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiUcheniki_Click(object sender, EventArgs e)
        {
            var wnd = new UchenikiForm();
            wnd.MdiParent = this;
            wnd.Show();
        }

        private void tsmiUchitelya_Click(object sender, EventArgs e)
        {
            var wnd = new UchitelyaForm();
            wnd.MdiParent = this;
            wnd.Show();
        }

        private void tsmiGruppi_Click(object sender, EventArgs e)
        {
            var wnd = new GruppiForm();
            wnd.MdiParent = this;
            wnd.Show();
        }

        private void tsmiGrafikUrokov_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/16774966/how-to-merge-datagridview-cell-in-winforms
        }

        private void tsmiPosesheniye_Click(object sender, EventArgs e)
        {
            var wnd = new AddEditPosesheniye();
            wnd.MdiParent = this;
            wnd.Show();
        }

        private void tsmiPrinyatUchenika_Click(object sender, EventArgs e)
        {
            var wnd = new DocPrinyatUchenika();
            wnd.MdiParent = this;
            wnd.Show();
        }

        private void tsmiSnyatUchenika_Click(object sender, EventArgs e)
        {
            var wnd = new DocUxodUchenika();
            wnd.MdiParent = this;
            wnd.Show();
        }

        private void tsmiSmenaUchitelya_Click(object sender, EventArgs e)
        {
            var wnd = new DocSmenaUchitelyaForm();
            wnd.MdiParent = this;
            wnd.Show();
        }

        private void tsmiUxodUchitelya_Click(object sender, EventArgs e)
        {
            var wnd = new DocUxodUchitelya();
            wnd.MdiParent = this;
            wnd.Show();
        }
    }
}
