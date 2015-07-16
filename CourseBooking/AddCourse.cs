using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBooking
{
    public partial class AddCourse : Form
    {
        List<string> courseText = new List<string>();
        List<string> names = new List<string>();
        ListBox list;

        public AddCourse(List<string> courseText, ListBox list, List<string> names)
        {
            InitializeComponent();
            this.courseText = courseText;
            this.list = list;
            this.names = names;
        }
        
        private void button1_Click(object sender, EventArgs e){
            names.Add(textBox1.Text);
            courseText.Add(textBox1.Text);
            courseText.Add(textBox2.Text);
            courseText.Add(textBox3.Text);
            courseText.Add("FFFFFFFFFFFF");

            var message = string.Join(Environment.NewLine, courseText.ToArray());
            MessageBox.Show(message);

            this.Close();
        }
    } 
}