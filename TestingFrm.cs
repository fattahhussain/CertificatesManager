using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace CertificatesManager
{
    public partial class TestingFrm : Form
    {
        public TestingFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= certificates.sqlite; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Database!!");
            }
            string cmd = "select * from certificates";
            SQLiteCommand insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            //insertCourse.ExecuteNonQuery();
            //cmd = "drop table employee";
            //insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            //insertCourse.ExecuteNonQuery();
            //cmd = "drop table courses";
            //insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            //insertCourse.ExecuteNonQuery();
            //cmd = "create table certificates (EmployeeID varchar(20), courseID varchar(50), files varchar(500), issueDate varchar(20), expiryDate varchar(20))";
            //insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            //insertCourse.ExecuteNonQuery();
            //cmd = "create table courses (ID varchar(50), Course varchar(100), Notify_Before varchar(20))";
            //insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            //insertCourse.ExecuteNonQuery();
            //cmd = "create table employee (EmployeeID varchar(20), Employee_Name varchar(50), Job_Title varchar(50), Profile_Pic varchar(100), PRIMARY KEY(EmployeeID))";

            //string cmd = "select * from courses";
            //insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            //insertCourse.ExecuteNonQuery();
            SQLiteDataReader reader = insertCourse.ExecuteReader();
            while (reader.Read())
                 MessageBox.Show("Name: " + reader["EmployeeID"] + " : "+reader["courseID"] + " : " + reader["files"]);

                sqlite_conn.Close();

        }
    }
}
