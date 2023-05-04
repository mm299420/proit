using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;

namespace ProIT
{
  public partial class Form1 : Form
  {
    DataSet ds = new DataSet();
    public OleDbDataAdapter DataAdapt;
    private OleDbConnection con = new OleDbConnection();
    private OleDbDataReader dr;
    private OleDbCommand cmd;
    public Form1()
    {
      InitializeComponent();
    }

    private void txtUname_TextChanged(object sender, EventArgs e)
    {
      if (txtPasswd.Text == "Password")
      { 
        txtPasswd.Text = "";
        txtPasswd.PasswordChar = '*';
      }
    }

    private void txtPasswd_TextChanged(object sender, EventArgs e)
    {
      if (txtUname.Text == "Username")
      {
        txtUname.Text = "";
      }
    }
    private void Form1_Load(object sender, EventArgs e)
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
    }
    private void OnKeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        button1_Click(this, new EventArgs());
      }
    }
    private void button1_Click(object sender, EventArgs e)
    {
      HashPass hashPass = new HashPass();
      var username = txtUname.Text;
      string storedHashedPassword = hashPass.GetStoredHashedPassword(username);

      if (storedHashedPassword != null)
      {
        bool isVerified = hashPass.VerifyPass(txtPasswd.Text, storedHashedPassword);

        if (isVerified)
        {
          MessageBox.Show("Login successful!");
          
          Thread t = new Thread(() =>
          {
            MainForm mf = new MainForm();
            mf.ShowDialog();
          });
          
          t.SetApartmentState(ApartmentState.STA);
          t.Start();
          this.Close();
        }
        else
        {
          MessageBox.Show("Invalid username or password.");
        }
      }
      else
      {
        MessageBox.Show("User not found.");
      }
    }
  }
}
