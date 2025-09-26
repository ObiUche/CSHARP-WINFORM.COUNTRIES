using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstCountries.Items.Add(txtCountries.Text);  // Add contents of the textbox;

            txtCountries.Clear();

            txtCountries.Focus();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lstCountries.Items.RemoveAt(lstCountries.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException ej)
            {
                Console.WriteLine(ej.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCountries.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCountries.Text = "";
        }
    }
}
