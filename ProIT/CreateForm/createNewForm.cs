using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyToad.PdfPig.Fonts.TrueType.Tables;

namespace ProIT.CreateForm
{
    public partial class createNewForm : Form
    {
        public createNewForm()
        {
            InitializeComponent();
        }

        public static async Task SubmitInformationAsync(ComboBox cBoxType, TextBox txtFieldName)
        {
            await SubmitInformationAsync(cBoxType, txtFieldName);
            createNewForm form = new createNewForm();
            form.txtFieldName = txtFieldName;
            form.cBoxFieldType = cBoxType;
            form.ShowDialog();
        }
        public static void changeValues(String Value1, ComboBox Value2, String Value3)
        {
            createNewForm form = new createNewForm();
            form.txtFieldName.Text = Value1;
            form.cBoxFieldType = Value2;
        }

        private void checkChangeTarget_CheckedChanged(object sender, EventArgs e)
        {
            trackWeighting.Enabled = !trackWeighting.Enabled;
        }

        private void createNewForm_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}