using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using BCrypt.Net;

namespace ProIT
{
    public class HashPass
    {
        public static int userID { get; set; }
        public static string userRole { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public string HashedPassword;
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;

        public HashPass()
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

        public string HashPassword(string plainPassword)
        {
            // Generate a salt with a specified number of rounds (e.g. 10)
            string salt = BCrypt.Net.BCrypt.GenerateSalt(10);

            // Hash the plain password with the generated salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword, salt);

            return hashedPassword;
        }

        public string GetStoredHashedPassword(string username)
        {
            cmd = new OleDbCommand($"SELECT MitPasswd FROM Mitarbeiter WHERE MitUserName = '{username}'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            return HashedPassword = dr["MitPasswd"].ToString();
        }
        public bool VerifyPass(string plainPassword, string storedHashedPassword)
        {
            // Verify the plain password against the stored hashed password
            bool isVerified = BCrypt.Net.BCrypt.Verify(plainPassword, storedHashedPassword);

            return isVerified;
        }

        public bool ChangePassword(string username, string newPlainPassword)
        {
            try
            {
                // Hash the new plain password
                string newHashedPassword = HashPassword(newPlainPassword);

                // Update the database with the new hashed password
                using (OleDbCommand cmd = new OleDbCommand($"UPDATE Mitarbeiter SET MitPasswd = ? WHERE MitUserName = ?", con))
                {
                    cmd.Parameters.AddWithValue("?", newHashedPassword);
                    cmd.Parameters.AddWithValue("?", username);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message);
                return false;
            }
        }

    }
}
