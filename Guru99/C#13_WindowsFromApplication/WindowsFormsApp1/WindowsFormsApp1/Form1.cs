using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mumbai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = IstCity.GetItemText(IstCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String adress = txtAdress.Text;
            MessageBox.Show(name + adress);
        }
    }
}
