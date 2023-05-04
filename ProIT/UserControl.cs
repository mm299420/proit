using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace ProIT
{
    public partial class UserControl : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        HashPass hashPass = new HashPass(); 
        public UserControl()
        {
            InitializeComponent();
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
            txtPassword.Size = new System.Drawing.Size(234, 20);
            PopulateTable();
        }
        private void PopulateTable()
        {
            DataAdapt = new OleDbDataAdapter("SELECT * FROM Mitarbeiter", con);
            DataAdapt.Fill(ds, "Mitarbeiter");
            dataGridView1.DataSource = ds.Tables["Mitarbeiter"];

            // Load the usernames into the user ComboBox
            cBoxUserName.DataSource = ds.Tables["Mitarbeiter"];
            cBoxUserName.DisplayMember = "MitUserName";
            cBoxAbteilung.DataSource = ds.Tables["Mitarbeiter"];
            cBoxAbteilung.DisplayMember = "MitarbAbtID";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HashPass hashPass = new HashPass();
            var username = cBoxUserName.Text;
            string storedHashedPassword = hashPass.GetStoredHashedPassword(username);

            if (storedHashedPassword != null)
            {
                bool isVerified = hashPass.VerifyPass(txtPassword.Text, storedHashedPassword);
                
                if (isVerified) 
                {
                    var width = txtPassword.Size.Width;
                    if (width == 234)
                    {
                        txtPassword.Size = new System.Drawing.Size(114, 20);
                        txtPassword2.Visible = true;
                        txtPassword.PasswordChar = '\0';
                        txtPassword.Text = "New Password";
                        txtPassword2.Text = "Verify new Password";
                    }
                    else
                    {
                        if (txtPassword2.Text == txtPassword.Text)
                        {
                            // Get the currently selected row in the DataGridView
                            int rowIndex = dataGridView1.CurrentCell.RowIndex;
                            DataRow rowToUpdate = ds.Tables["Mitarbeiter"].Rows[rowIndex];
                            // Update the row's values based on user input
                            rowToUpdate["MitarbName"] = txtMitarbName.Text;
                            rowToUpdate["MitUserName"] = cBoxUserName.Text;
                            rowToUpdate["MitPasswd"] = hashPass.HashPassword(txtPassword.Text);
                            // Update the database with the changes
                            OleDbCommandBuilder builder = new OleDbCommandBuilder(DataAdapt);
                            DataAdapt.Update(ds.Tables["Mitarbeiter"]);
                            MessageBox.Show("User updated successfully.");
                        }
                        txtPassword.Size = new System.Drawing.Size(234, 20);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataRow newRow = ds.Tables["Mitarbeiter"].NewRow();
            // Set values for the new row based on user input
            newRow["MitarbName"] = txtMitarbName.Text;
            newRow["MitUserName"] = cBoxUserName.Text;
            newRow["MitarbAbtID"] = cBoxAbteilung.Text;
            newRow["MitPasswd"] = hashPass.HashPassword(txtPassword.Text);
            // Add the new row to the DataTable
            ds.Tables["Mitarbeiter"].Rows.Add(newRow);
            // Update the database with the new row
            OleDbCommandBuilder builder = new OleDbCommandBuilder(DataAdapt);
            DataAdapt.Update(ds.Tables["Mitarbeiter"]);
            MessageBox.Show("User created successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HashPass hashPass = new HashPass();
            var username = cBoxUserName.Text;
            string storedHashedPassword = hashPass.GetStoredHashedPassword(username);

            if (storedHashedPassword != null)
            {
                bool isVerified = hashPass.VerifyPass(txtPassword.Text, storedHashedPassword);
                
                if (isVerified) 
                {
                    
                    // Get the currently selected row in the DataGridView
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataRow rowToDelete = ds.Tables["Mitarbeiter"].Rows[rowIndex];
                    // Remove the row from the DataTable
                    rowToDelete.Delete();
                    // Update the database with the changes
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(DataAdapt);
                    DataAdapt.Update(ds.Tables["Mitarbeiter"]);
                    MessageBox.Show("User deleted successfully.");
                    PopulateTable();
                }
                else
                {
                    MessageBox.Show("Password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            } 
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string password = new string(Enumerable.Repeat(chars, trackBar1.Value)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            txtPasswdGen.Text = password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.Text = "";
        }
        private void txtPassword2_Click(object sender, EventArgs e)
        {
            txtPassword2.PasswordChar = '*';
            txtPassword2.Text = "";
        }
    }
}
