using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBooking
{
    class myBox : CheckBox
    {
        Boolean check = false;

        public myBox()
        { 
            this.Appearance = System.Windows.Forms.Appearance.Button;
            this.MinimumSize = new System.Drawing.Size(28, 23);
            this.MaximumSize = new System.Drawing.Size(28, 23);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckedChanged += new System.EventHandler(this.CheckChanged);
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            if (check)
            {
                check = false;
                this.Text = this.TabIndex.ToString();
                this.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                check = true;
                this.Text = "B";
                this.BackColor = System.Drawing.Color.Lime;
            }

        }
    }
}
