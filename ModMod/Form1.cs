using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            int startNum = 1;
            int endNum = 100;
            double sum = 0;
            double allSq = 0;

            
            for (int i = startNum; i <= endNum; i++ ) 
            {
                sum += 1;
                allSq = Math.Pow(1, 2);
            }
            if (Convert.ToInt64(Math.Pow(Math.Pow(sum,2)-allSq,(1.0/3.0)))% 2 == 0)
            {
                label1.Text = "Even";
            }
        }
    }
}
