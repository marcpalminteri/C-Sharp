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
        List<string> text = new List<string>();
        List<string> names = new List<string>();        
        List<string> textLinesList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Title = "Open file";
            myDialog.Filter = "TXT files|*.txt";
            myDialog.InitialDirectory = @"C:\Users\blue9\Desktop";

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                text = File.ReadAllLines(myDialog.FileName).ToList();

                for (int i = 0; i < text.Capacity; i++)
                {
                    text[i] = text[i].Trim('"');
                }

                for (int i = 0; i < text.Capacity; i = i + 4)
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
            else {
                MessageBox.Show("Error code 002\nFile open error or dialog cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Error\nA file was not opened or a course was not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                AddCourse newCourse = new AddCourse(text, listBox1, names);
                newCourse.Show();
            }
            else
            {
                MessageBox.Show("A file was not opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string item in names)
            {
                listBox1.Items.Add(item);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Text File";
            save.Filter = "TXT files|*.txt";
            save.InitialDirectory = @"C:\Users\blue9\Desktop";
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.OpenFile());
                var message = string.Join(Environment.NewLine, text.ToArray());
                MessageBox.Show(message);
                
                sw.Write(text);
            }
        }
    }
}
