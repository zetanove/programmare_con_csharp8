using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text="Hello Windows";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 figlia = new Form2();
            figlia.MdiParent = this;
            figlia.Show();

        }
    }
}
