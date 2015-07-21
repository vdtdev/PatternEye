using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatternEye.Data;
namespace PatternEye
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            test();
        }

        private void test()
        {
            PTile t = new PTile(3, 1);
            t.sample(Color.Red, 1, 1);
            foreach (int i in new int[]{0,1,2})
            {
                foreach (int o in new int[]{0,1,2}){
                    t.sample(Color.White, i, o);
                }
            }
            t.sample(Color.Red, 1, 1);

        }
    }
}
