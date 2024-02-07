using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Demo_WPL
{
    public partial class Vhode : Form
    {
        public Vhode()
        {
            InitializeComponent();
        }

        private void Regist_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                Maine Check = new Maine();
                Check.Show();
                Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg Check = new Reg();
            Check.Show();
            Hide();
        }
    }
}
