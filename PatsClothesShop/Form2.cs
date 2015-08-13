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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\blue2.FASFG\Documents\vsprojects\Csharp-Basics\PatsClothesShop\PCSDB.mdf;Integrated Security=True");

            try 
            {
                myConnection.Open(); 
                Console.WriteLine("Connection");
            } 
            catch (Exception) 
            { 
                Console.WriteLine("Error"); 
            }

            SqlCommand myCommand = new SqlCommand("INSERT INTO Customer (customerID, FirstName, LastName) Values (6, 'Stanis', 'Baratheon'), (7, 'Ned', 'Stark'), (8, 'Renly', 'Baratheon'), (9, 'Ramsay', 'Bolton'), (10, 'Cersei', 'Lannister')", myConnection);

            myCommand.ExecuteNonQuery();

            try 
            { 
                SqlCommand myCommandSel = new SqlCommand("SELECT * FROM Customer", myConnection); 
            // Initialize a new instance of SqlReader, sends the CommandText to the Connection and builds a SqlDataReader 
            SqlDataReader myReader = myCommandSel.ExecuteReader();
            while (myReader.Read()) 
            { 
                Console.WriteLine(myReader["FirstName"].ToString()); 
                Console.WriteLine(myReader["LastName"].ToString()); }
            }
            catch (Exception) 
            { 
                Console.WriteLine("Broke"); 
            }
            
            customerTableAdapter1.Fill(pcsdbDataSet1.Customer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\blue2.FASFG\Documents\vsprojects\Csharp-Basics\PatsClothesShop\PCSDB.mdf;Integrated Security=True");

            try
            {
                myConnection.Open();
                Console.WriteLine("Connection");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            
            SqlCommand myCommandDel = new SqlCommand("DELETE FROM Customer WHERE CustomerID in(SELECT TOP 5 CustomerID FROM Customer ORDER BY CustomerID DESC)", myConnection);
            myCommandDel.ExecuteNonQuery();
            try 
            { 
                SqlCommand myCommandSel = new SqlCommand("SELECT * FROM Customer", myConnection); SqlDataReader myReader = myCommandSel.ExecuteReader(); 
                while (myReader.Read()) 
                { 
                    Console.WriteLine(myReader["FirstName"].ToString());
                    Console.WriteLine(myReader["LastName"].ToString()); 
                } 
            }
            catch (Exception) 
            { 
                Console.WriteLine("Broke"); 
            }
            customerTableAdapter1.Fill(pcsdbDataSet1.Customer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            //pcsdbDataSet1.Customer.AddCustomerRow(12, "Guy", "Man");
            MessageBox.Show("Name Added");
        }
    }
}