using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CertificatesManager
{
    class Database
    {
        public static void createDatabase()
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
            string cmd;
            SQLiteCommand insertCourse;
            cmd = "create table certificates (EmployeeID varchar(20), courseID varchar(50), files varchar(500), issueDate varchar(20), expiryDate varchar(20))";
            insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            insertCourse.ExecuteNonQuery();
            cmd = "create table courses (ID varchar(50), Course varchar(100), Notify_Before varchar(20))";
            insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            insertCourse.ExecuteNonQuery();
            cmd = "create table employee (EmployeeID varchar(20), Employee_Name varchar(50), Job_Title varchar(50), Profile_Pic varchar(100), PRIMARY KEY(EmployeeID))";
            insertCourse = new SQLiteCommand(cmd, sqlite_conn);
            insertCourse.ExecuteNonQuery();
            
        }
    }
}
