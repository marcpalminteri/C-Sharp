﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatsClothesShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(pcsdbDataSet1.Customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            int result = 0;
            result = customerTableAdapter1.Update(pcsdbDataSet1.Customer);
            MessageBox.Show(result.ToString());
        }
    }
}