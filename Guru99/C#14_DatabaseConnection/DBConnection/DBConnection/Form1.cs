using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=WIN-50GP30FG075;Initial Catalog=Demodb;User ID=sa;Password=demo123";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
            MessageBox.Show("Connection Open ! ");
            cnn.Close();
        }
    }
}
