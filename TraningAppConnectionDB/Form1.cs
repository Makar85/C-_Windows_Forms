using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraningAppConnectionDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=LAPTOP-82NAQJGJ\\SQLEXPRESS"))
            {
                cn.Open();



                using (SqlCommand cmd = new SqlCommand("SELECT CustomerId,CustomerFirstName, CustomerLastName FROM ApressFinancial.CustomerDetails.Customers", cn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader[0] + " " + reader[1] + " "+ reader [2]);
                        }
                    }



                }



            }
        }

    }

}
