using System;
using System.Windows.Forms;

namespace ProIT
{
    public partial class AIForm : Form
    {
        public AIForm()
        {
            InitializeComponent();
        }

        private void AIForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://huntercorp.org/");
        }
    }
}