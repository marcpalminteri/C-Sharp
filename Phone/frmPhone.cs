using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone
{
    public partial class frmPhone : Form
    {
        public frmPhone()
        {
            InitializeComponent();
        }

        private void phoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneDBDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.phoneDBDataSet.Phone);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this.phoneBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.phoneDBDataSet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.phoneBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.phoneBindingSource.RemoveCurrent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch srch = new frmSearch();
            srch.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}