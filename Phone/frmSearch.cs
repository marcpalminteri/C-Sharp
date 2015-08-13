using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phone
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\blue2.FASFG\Documents\vsprojects\Csharp-Basics\Phone\PhoneDB.mdf;Integrated Security=True");

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
            try
            {
                myConnection.Open();
                MessageBox.Show("Connection");
            }
            catch (Exception) {
                MessageBox.Show("Error");
            }

            SqlCommand myCommand = new SqlCommand("SELECT ProductCode, Description, Price, FreeInsurance FROM dbo.Phone WHERE " + cboField.SelectedItem + " " + cboOperator.SelectedItem + " " + txbxValue.Text, myConnection);



            MessageBox.Show("SELECT ProductCode, Description, Price, FreeInsurance FROM dbo.Phone WHERE " + cboField.SelectedItem + " " + cboOperator.SelectedItem + " " + txbxValue.Text);
        }
    }
}