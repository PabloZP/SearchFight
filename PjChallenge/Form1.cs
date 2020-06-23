using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BL;

namespace PjChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {         
            Searching Sea = new Searching(txtText.Text);
            if (Sea.getParsedOk())
            {
                if (Sea.bSearchOk)
                {
                    txtSearchRes.ForeColor = Color.Green;
                }
                else
                {
                    txtSearchRes.ForeColor = Color.Red;
                }
            }
            else
            {
                txtSearchRes.ForeColor = Color.Red;
            }
            txtSearchRes.Text = Sea.Results();
           
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
