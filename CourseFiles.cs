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
using System.IO;
using System.Diagnostics;

namespace CertificatesManager
{
    public partial class CourseFiles : Form
    {
        string[] foundFiles = null;
        public CourseFiles()
        {
            InitializeComponent();
        }

        private void CourseFiles_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn OpenCert = new DataGridViewButtonColumn();
            OpenCert.Name = "Open";
            OpenCert.Text = "Open";
            OpenCert.HeaderText = "";
            OpenCert.UseColumnTextForButtonValue = true;
            courseFilesList.Columns.Insert(1, OpenCert);
            this.employeeName.Text = overviewWindow.employeeName;
            this.employeeID.Text = overviewWindow.employeeID;
            this.jobtitle.Text = overviewWindow.jobTitle;

            this.courseName.Text = overviewWindow.courseName;

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
            string query = "select files from certificates where EmployeeID='"+employeeID.Text+"' and courseID='"+courseName.Text.Replace(" ", "")+"'";
            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    dr.Read();

                    foundFiles = dr["files"].ToString().Split('#');
                    courseFilesList.Rows.Add(foundFiles.Length-1);
                    for(int i=0; i<foundFiles.Length-1;i++)
                    {
                        courseFilesList.Rows[i].Cells[0].Value = foundFiles[i].Split('\\')[foundFiles[i].Split('\\').Length - 1];
                    }
                }
            }
                
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void courseFilesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                try
                {
                    Process fileopener = new Process();
                    fileopener.StartInfo.FileName = "explorer";
                    fileopener.StartInfo.Arguments = "\"" + foundFiles[e.RowIndex] + "\"";
                    fileopener.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File was missing!!");
                }
            }
        }
    }
}
