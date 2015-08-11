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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneDBDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.phoneDBDataSet.Phone);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //this.phoneTableAdapter.SearchQuery(this.phoneDBDataSet.Phone, decimal.Parse(txbxValue.Text));
            //this.phoneTableAdapter.SearchQuery(this.phoneDBDataSet.Phone, this.cboField.SelectedItem, this.cboOperator.SelectedItem, decimal.Parse(txbxValue.Text));
        }
    }
}