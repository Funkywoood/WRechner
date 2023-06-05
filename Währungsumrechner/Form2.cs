using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Währungsumrechner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 f1;

        public Form2(Form1 f1)
        {
            InitializeComponent();
       
            this.f1 = f1;
        }
        

        public void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }


}
