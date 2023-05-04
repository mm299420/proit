using System.Windows.Forms;

namespace ProIT
{
    public partial class CustomDeleteDialog : Form
    {
        public CustomDeleteDialog()
        {
            InitializeComponent();

            btnDelete.DialogResult = DialogResult.Yes;
            btnListOnly.DialogResult = DialogResult.No;
            btnCancel.DialogResult = DialogResult.Cancel;
        }
    }
}