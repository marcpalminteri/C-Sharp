using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuff
{
    public partial class Form1 : Form
    {
        string alphabet = "ABCDEFG";
        string[] alphabetArray = {"A", "B", "C", "D", "E", "F", "G"};        
        double[] values = {2.4, 4.91, 34.233, 78.257, 98.5567437};
        string[] vocal = {"Nina Simone (f)", "Killer Mike (m)", "El Producto (m)", "Lauren Mayberry (f)", "Gonjasufi (m)", "KiloWatts (m)"};


        public Form1()
        {
            InitializeComponent();
        }

        // Q1
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + textBox1.Text);
        }

        // Q3
        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox2.Text);
            if (num < 10)
            {
                MessageBox.Show("This number is too small");
            }
            else {
                MessageBox.Show("This number is not big enough");
            }
        }

        // Q4
        private void button3_Click(object sender, EventArgs e)
        {
            string msg = textBox3.Text + " " + textBox4.Text;
            MessageBox.Show(msg);
        }

        // Q5
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Norfolk")
            {
                MessageBox.Show("This is not an Irish county");
            }
            else {
                MessageBox.Show("This is an Irish county");
            }
        }

        // Q6
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (listBox1.SelectedItem.ToString()){
                case "Poker":
                    MessageBox.Show("This is not a sport");
                    break;
                default:
                    MessageBox.Show("This is a sport");
                    break;
            }
        }

        // Q7
        private void button4_Click(object sender, EventArgs e)
        {
            int[] q7 = {1, 4, 23, 98, 172};
            for (int i = 0; i < q7.Length; i++) {
                MessageBox.Show(q7[i].ToString());
            }
        }

        // Q8
        private void button5_Click(object sender, EventArgs e)
        {
            string[] county = {"Kerry", "Dublin", "Norfolk", "Cork"};
            for (int i = 0; i < county.Length; i++)
            {
                MessageBox.Show(county[i]);
            }
        }

        // Q9
        private void button6_Click(object sender, EventArgs e)
        {
            int index = 1;
            while(index <= 10){
                MessageBox.Show("While statement " + index);
                index++;
            }
        }

        // Q10
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(values[1].ToString());
        }

        // Q11
        private void button8_Click(object sender, EventArgs e)
        {
            string total = "";
            foreach(double v in values){
                total += Math.Round(v, 2).ToString() + " ";
            }
            MessageBox.Show(total.ToString());
        }

        // Q12
        private void button9_Click(object sender, EventArgs e)
        {
            int mCounter = 0;
            int fCounter = 0;
            foreach (string v in vocal) { 
                int i = 0;
                while (v[i] != '(') {
                    i++;
                }
                switch (v[i + 1]) { 
                    case 'm':
                        mCounter++;
                        break;
                    case 'f':
                        fCounter++;
                        break;
                    default:
                        MessageBox.Show("Invalid gender");
                        break;                
                }
            }
            MessageBox.Show("Male Vocalists: " + mCounter + "\nFemale Vocalists: " + fCounter);
        }
    }
}
