using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseBooking
{
    public partial class Form1 : Form
    {
        string[] text;
        List<string> textLinesList = new List<string>();
        List<string> names = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text = File.ReadAllLines(@"C:\Users\blue6\Desktop\save.txt");

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = text[i].Trim('"');
            }

            for (int i = 0; i < text.Length; i = i + 4)
            {
                names.Add(text[i]);
            }

            names = names.Distinct().ToList<String>();
            listBox1.Items.Clear();

            foreach (string item in names)
            {
                listBox1.Items.Add(item);
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text != null && listBox1.SelectedIndex != -1)
            {
                SeatPlan newForm = new SeatPlan(text, listBox1);
                newForm.Show();
            }
            else if (text == null)
            {
                MessageBox.Show("Unable to load course, no course file opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Unable to load course, no course selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
