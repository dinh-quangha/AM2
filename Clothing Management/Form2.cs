using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Are you want to exit..?",
               "Warning",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (cc == DialogResult.No)
            {
                MessageBox.Show("Thanks for using.");
            }
            else
            {
                Hide();
            }
            

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            FormEmploy form7 = new FormEmploy();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            FormProduct form6 = new FormProduct();
            form6.Show();
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            FormStatic Form5 = new FormStatic();
            Form5.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
