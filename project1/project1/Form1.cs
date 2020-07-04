using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class jsq : Form
    {
        public jsq()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try 
            {
                int op1Number = int.Parse(this.textBoxop1.Text);
                int op2Number = int.Parse(this.textBoxop2.Text);

                int result = op1Number + op2Number;

                this.labelResult.Text = result.ToString();  

            }
           catch (Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }     
        } 
 
    }
}
