using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseOfComponentWinform
{
    public partial class AddWin : Form
    {
        public AddWin()
        {
            InitializeComponent();
        }

        public int Count
        {
            get
            { return int.Parse(tbCount.Text); }
        }

        public string NameE {
            get
            {
                return tbName.Text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
