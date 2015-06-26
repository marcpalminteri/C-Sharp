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
    public partial class SeatPlan : Form
    {   
        public SeatPlan(string[] text, ListBox list)
        {
            InitializeComponent();

            string date;
            string price;
            string seats;
            label1.Text = list.Text;
           
            for (int i = 0; i < text.Length; i = i + 4 )
            {
                if (text[i] == label1.Text) {
                    int j = i;
                    date = text[j + 1];
                    price = text[j + 2];
                    seats = text[j + 3];
                }
            }
        }
    }
}
