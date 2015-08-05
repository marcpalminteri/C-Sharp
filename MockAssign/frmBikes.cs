using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockAssign
{
    public partial class frmBikes : Form
    {
        public frmBikes()
        {
            InitializeComponent();
        }

        private void mcyclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mcyclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bikesDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bikesDBDataSet.mcycles' table. You can move, or remove it, as needed.
            this.mcyclesTableAdapter.Fill(this.bikesDBDataSet.mcycles);

        }

        // Show All
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.SelectAll(this.bikesDBDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // For Sale
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.ForSale(this.bikesDBDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Below or equal to 500cc
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.Below500(this.bikesDBDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Above or equal to 500cc
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.Above500(this.bikesDBDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Sold
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.mcyclesTableAdapter.Sold(this.bikesDBDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Update
        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mcyclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bikesDBDataSet);
        }

        // Cancel
        private void button7_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.CancelEdit();
            this.mcyclesTableAdapter.Fill(this.bikesDBDataSet.mcycles);
        }

        // First
        private void button8_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MoveFirst();
        }

        // Previous
        private void button9_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MovePrevious();
        }

        // Next
        private void button10_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MoveNext();
        }

        // Last
        private void button11_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MoveLast();
        }

        // Exit
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}