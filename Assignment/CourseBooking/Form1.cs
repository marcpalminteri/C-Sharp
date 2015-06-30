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
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Title = "Open file";
            myDialog.Filter = "TXT files|*.txt";
            myDialog.InitialDirectory = @"C:\Users\blue6\Desktop";

            if (myDialog.ShowDialog() == DialogResult.OK) { 
                //text = File.ReadAllLines(@"C:\Users\blue6\Desktop\save.txt");
                text = File.ReadAllLines(myDialog.FileName);

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text != null && listBox1.SelectedIndex != -1)
            {
                SeatPlan newForm = new SeatPlan(text, listBox1, names);
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Pick a course first idiot\nGawd", "Jesus Christ Moneky Balls", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                AddCourse newCourse = new AddCourse(text);
                newCourse.Show();
            }
            else
            {
                MessageBox.Show("Open a file first you eejit", "Jesus Tapdancing Christ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
