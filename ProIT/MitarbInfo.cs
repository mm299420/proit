using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System;
namespace ProIT
{
    public class MitarbInfo
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        
        public int userID { get; set; }
        public string userRole { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string passwordHash { get; set; }
        public string name { get; set; }
        public string geb { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        
        
        public MitarbInfo()
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

        public int getUserID(string username)
        {
            cmd = new OleDbCommand($"SELECT UserID FROM Users WHERE Username = '{username}'", con);
            dr = cmd.ExecuteReader();
            return userID = Convert.ToInt16(dr.Read());
        }
        
        public void getAllUserinfo(string username)
        {
            int id = getUserID(username);
            cmd = new OleDbCommand("select * from Mitarbeiter where MitUserName = {id}", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                userID = Convert.ToInt16(dr["MitarbID"].ToString());
                passwordHash = dr["MitPasswd"].ToString();
                name = dr["MitarbName"].ToString();
                geb = dr["MitarbGeb"].ToString();
                email = dr["MitarbMail"].ToString();
                phone = dr["MitarbTel"].ToString();
                address = dr["MitarbAdress"].ToString();
                zip = dr["MitarbPLZ"].ToString();
                city = dr["MitarbCity"].ToString();
                country = dr["MitarbCountry"].ToString();
            }
        }
    }
}