using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int x=random.Next(100,650);
            int y=random.Next(100,400);

            button1.Location = new Point(x,y);  

        }
    }
}
