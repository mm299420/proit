using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using ProIT;
using ProIT.CreateForm;

namespace ProIT
{
    public partial class createApplicationForm : Form
    {
        DataSet Mitarb = new DataSet();
        DataSet Frag = new DataSet();
        DataSet Abt = new DataSet();
        DataSet Stellen = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        HashPass hashPass = new HashPass(); 
        private static readonly ILog log  = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Thread t;
        Color dark = System.Drawing.SystemColors.ControlDark;
        Color light = System.Drawing.SystemColors.Control;
        DataGridView dgv = new DataGridView();
        
        Color btnForm_fieldColor { get; set;}
        Color btnField_fieldColor { get; set;}
        public createApplicationForm()
        {
            InitializeComponent();
        }

        private void createApplicationForm_Load(object sender, EventArgs e)
        {
            try
            {
                try
                { 
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=ProITDatBase.accdb";
                    con.Open();
                }
                catch
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProITDatBase.accdb";
                    con.Open();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                throw;
            }
            PopulateTable();
            try {
                changes_Click(sender, e);
            } catch (Exception close)
            {
                var exception = new Exception($"Error: {close}");
                log.Debug(exception);
            }
        }
        private void PopulateTable()
        {
            cmd = new OleDbCommand("SELECT * FROM FragebogenKategorien", con);
            dr = cmd.ExecuteReader();
            cBoxForm.BeginUpdate();
            cBoxForm.Items.Clear();
            cBoxForm.Update();
            while (dr.Read())
            {
                cBoxForm.Items.Add(dr["FragebogenKatBez"].ToString());
            }
            cBoxForm.EndUpdate();
            
            cmd = new OleDbCommand("SELECT * FROM Abteilung", con);
            dr = cmd.ExecuteReader();
            cBoxAbt.BeginUpdate();
            cBoxAbt.Items.Clear();
            cBoxAbt.Update();
            while (dr.Read())
            {
                cBoxAbt.Items.Add(dr["AbteilungsBez"].ToString());
            }
            cBoxAbt.EndUpdate();
        }
        private void btnField_Click(object sender, EventArgs e)
        {
            var btnField_fieldColor = btnField.BackColor;
            if (btnField_fieldColor == light)
            {
                btnField.BackColor = dark;
                btnForm.BackColor = light;
            }
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            var btnForm_fieldColor = btnForm.BackColor;
            if (btnForm_fieldColor == light)
            {
                btnField.BackColor = light;
                btnForm.BackColor = dark;
            }
        }

        protected void fieldColorChange(object sender, EventArgs e)
        {
            btnForm_fieldColor = btnForm.BackColor;
            btnField_fieldColor = btnField.BackColor;
            
            if (btnForm_fieldColor == dark)
            {
                cBoxForm.Text = "Formtyp";
                lblForm.Text = "Formtyp";
                btnAdd.Text = "Form hinzufügen";
                btnField.BackColor = dark;
                btnForm.BackColor = light;
            } else {
                cBoxForm.Text = "Feldtyp";
                lblForm.Text = "Feldtyp";
                btnAdd.Text = "Feld hinzufügen";
                btnField.BackColor = light;
                btnForm.BackColor = dark;
            }
        }
        private void changes_Click(object sender, EventArgs e)
        {            
            log.Debug("Before defining the thread");
            t = new Thread(() =>
            {            
                log.Debug("Starting the loop");
                while (true)
                {
                    if (btnForm.InvokeRequired || btnField.InvokeRequired)
                    {
                        log.Debug("Starting invoke method");
                        btnForm.Invoke(new Action(() =>
                        {
                            // Check if the button is currently being clicked
                            if (btnForm.Capture)
                            {
                                log.Debug("Before starting the fieldColorChange handler");
                                fieldColorChange(sender, e);
                                log.Debug("After starting the fieldColorChange handler");
                            }
                        }));
                        log.Debug("Stopping invoke method");

                        log.Debug("Starting invoke method");
                        btnField.Invoke(new Action(() =>
                        {
                            // Check if the button is currently being clicked
                            if (btnField.Capture)
                            {
                                fieldColorChange(sender, e);
                            }
                        }));
                        log.Debug("Stopping invoke method");
                    }
                    else
                    {
                        log.Debug("InvokeRequired is false");
                    }
                }
                log.Debug("Stopping the loop");
            });

            log.Debug("Setting up the thread's apartment state");
            t.SetApartmentState(ApartmentState.STA);
            
            log.Debug("Starting the thread");
            t.Start();
        }
        
        /*private async void changes_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (btnForm.InvokeRequired || btnField.InvokeRequired)
                {
                    btnForm.Invoke(new Action(() =>
                    {
                        // Check if the button is currently being clicked
                        if (btnForm.Capture)
                        {
                            fieldColorChange(sender, e);
                        }
                    }));

                    btnField.Invoke(new Action(() =>
                    {
                        // Check if the button is currently being clicked
                        if (btnField.Capture)
                        {
                            fieldColorChange(sender, e);
                        }
                    }));
                }
                else
                {
                    // This is the code that will be executed on the UI thread when the form is closed
                    // and the method is called from the UI thread. We don't want to do anything in this case.
                    Console.WriteLine("InvokeRequired = false");
                }
                // This sleep will allow the UI thread to actually process the button click event
                // and change the Capture property. Without it, the code will loop too quickly and
                // the Capture property will always be false.
                Thread.Sleep(10);
            }
        }*/
        
        private void createApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                t.Abort(); // Abort the thread when the form is closing
            } catch (Exception close)
            {
                var exception = new Exception($"Error: {close}");
                log.Debug(exception);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!formGroupBox.Enabled)
            {
                formGroupBox.Enabled = true;
                formGroupBox.Enabled = true;
                return;
            }

            btnForm_fieldColor = btnForm.BackColor;
            btnField_fieldColor = btnField.BackColor;
            if (btnForm_fieldColor == dark) {
                btnForm_Click(sender, e);
                formGroupBox.Text = "Formular hinzufügen";
            } 
            else {
                btnField_Click(sender, e);
                formGroupBox.Text = "Feld hinzufügen";
            }
            if (formGroupBox.Enabled)
            {
                if (btnForm_fieldColor == dark)
                {
                    log.Debug("Formular hinzufügen");
                    /*await createNewForm.*/SubmitInformationAsync(true);
                }
                else
                {
                    log.Debug("Feld hinzufügen");
                    /*await createNewField.*/SubmitInformationAsync(false);
                }
            }
        }
        public static async Task SubmitInformationAsync(bool create_form)
        {   
            createApplicationForm cAF = new createApplicationForm();

            if (create_form)
            {
                createNewForm form = new createNewForm();
                form.txtFieldName.Text = cAF.txtFieldName.Text;
                form.cBoxFieldType = cAF.cBoxForm;
                form.ShowDialog();
            }
            else
            {
                createNewField field = new createNewField();
                field.txtFieldName = cAF.txtFieldName;
                field.cBoxFieldType = cAF.cBoxForm;
                field.ShowDialog();
            }
        }
        private void cBoxAbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxProcess.Enabled = true;
            cmd = new OleDbCommand($"SELECT Stellenauschreibung.StellenID " +
                                   $"From Stellenauschreibung, Abteilung where Stellenauschreibung.StellenAbtID = AbteilungsID and AbteilungsBez = '{cBoxAbt.Text}'", con);
            dr = cmd.ExecuteReader();
            cBoxProcess.BeginUpdate();
            cBoxProcess.Items.Clear();
            cBoxProcess.Update();
            while (dr.Read())
            {
                cBoxProcess.Items.Add(dr["StellenID"].ToString());
            }
            cBoxProcess.EndUpdate();

        }
    }
}