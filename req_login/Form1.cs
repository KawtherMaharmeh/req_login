using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace req_login
{
    public partial class Form1 : Form
    {
       

        public object form1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void btn1_Click_1(object sender, EventArgs e)
        {
            string us = "kawther";
            string pass = "1234";




            if (txt_name.Text == us && txt_pass.Text == pass)
            {
                this.Hide();

                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {

                MessageBox.Show("the username or password false");
            }
        }
    }
    
}
