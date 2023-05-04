using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProIT.CreateForm
{
    public partial class createNewField : Form
    {
        public createNewField()
        {
            InitializeComponent();
        }
        private void checkChangeTarget_CheckedChanged(object sender, EventArgs e)
        {
            trackWeighting.Enabled = !trackWeighting.Enabled;
        }
    }
}