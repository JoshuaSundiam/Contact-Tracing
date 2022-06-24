using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Sbtn_Click(object sender, EventArgs e)
        {
            StreamWriter folder = new StreamWriter(@"C:\Users\JOSHUA\Desktop\Contact Tracing\Info.txt", true);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
