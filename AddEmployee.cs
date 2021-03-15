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

namespace CertificatesManager
{
    public partial class AddEmployee : Form
    {
        
        DateTimePicker oDateTimePicker;
        public AddEmployee()
        {
            InitializeComponent();
            windowTitle.MouseDown += WindowTitle_MouseDown;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void WindowTitle_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void addPhotoLabel_Click(object sender, EventArgs e)
        {
            addPhotoLabel.Text = "";
            OpenFileDialog choosePhoto = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Images",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = ".jpg",
                Filter = "Images (*.BMP;*.JPG;)|*.BMP;*.JPG;",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (choosePhoto.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp1 = new Bitmap(choosePhoto.FileName);
                addPhotoLabel.Image = bmp1.GetThumbnailImage(112, 112, null, IntPtr.Zero);
                bmp1.Dispose();
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            
            if(overviewWindow.updateFlag)
            {
                saveButton.Text = "Update";
                loadFilledCourseData();
            }
            else
                loadCourseData();
        }

        public void loadCourseData()
        {
            SQLiteConnection sqlite_conn= new SQLiteConnection("Data Source= certificates.sqlite; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Database!!");
            }
            string cmd = "select * from courses";

            DataTable dt = new DataTable();
            SQLiteCommand c = new SQLiteCommand(cmd, sqlite_conn);
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(c);
            
            adapt.Fill(dt);
            
            adapt.Dispose();
            sqlite_conn.Close();
            dt.Columns.Remove("ID");
            dt.Columns.Remove("Notify_Before");
            coursesData.DataSource = dt;
            DataGridViewTextBoxColumn issueDate = new DataGridViewTextBoxColumn();
            issueDate.Name = "Issue Date";
            
            coursesData.Columns.Insert(1, issueDate);
            DataGridViewTextBoxColumn expiryDate = new DataGridViewTextBoxColumn();
            expiryDate.Name = "Expiry Date";

            coursesData.Columns.Insert(2, expiryDate);
            DataGridViewButtonColumn uploadCert = new DataGridViewButtonColumn();
            uploadCert.Name = "Upload Certificate";
            uploadCert.Text = "Upload";
            uploadCert.UseColumnTextForButtonValue = true;
            coursesData.Columns.Insert(3, uploadCert);


            DataGridViewTextBoxColumn selectedDocs = new DataGridViewTextBoxColumn();
            selectedDocs.Name = " ";
            coursesData.Columns.Insert(4, selectedDocs);

            coursesData.Columns[0].Width = 250;
            coursesData.Columns[0].ReadOnly = true;
            coursesData.Columns[4].Width = 200;
            for (int i=0; i<coursesData.RowCount; i++)
            {
                coursesData.Rows[i].Cells[1].Value = "dd/mm/yy";
                coursesData.Rows[i].Cells[2].Value = "dd/mm/yy";
                coursesData.Rows[i].Cells[4].Value = "";
            }
            coursesData.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            coursesData.ClearSelection();
        }
        public void loadFilledCourseData()
        {

            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source= certificates.sqlite; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Database!!");
            }

            
            string q1 = "select * from employee where EmployeeID='" + overviewWindow.employeeID + "'";
            using (SQLiteCommand c1 = new SQLiteCommand(q1, sqlite_conn))
            {
                using (SQLiteDataReader dr = c1.ExecuteReader())
                {
                    dr.Read();
                    nameText.Text = dr["Employee_Name"].ToString();
                    employeeNumberText.Text = dr["EmployeeID"].ToString();
                    jobTitleText.Text = dr["Job_Title"].ToString();
                    string p = Path.GetDirectoryName(Application.ExecutablePath) + @"\Certificates\" + dr["Employee_Name"].ToString().Replace(" ","") + @"\" + dr["Employee_Name"].ToString().Replace(" ", "") + "ProfilePic.jpg";
                    addPhotoLabel.Text = "";

                    Bitmap bmp1 = new Bitmap(p);
                    Image imgNew = Image.FromHbitmap(bmp1.GetHbitmap());
                    addPhotoLabel.Image = imgNew.GetThumbnailImage(112, 112, null, IntPtr.Zero);
                    bmp1.Dispose();
                    
                }
            }
            
            string cmd = "select * from courses";

            DataTable dt = new DataTable();
            SQLiteCommand c = new SQLiteCommand(cmd, sqlite_conn);
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(c);

            adapt.Fill(dt);

            adapt.Dispose();
            
            dt.Columns.Remove("ID");
            dt.Columns.Remove("Notify_Before");
            coursesData.DataSource = dt;
            DataGridViewTextBoxColumn issueDate = new DataGridViewTextBoxColumn();
            issueDate.Name = "Issue Date";

            coursesData.Columns.Insert(1, issueDate);
            DataGridViewTextBoxColumn expiryDate = new DataGridViewTextBoxColumn();
            expiryDate.Name = "Expiry Date";

            coursesData.Columns.Insert(2, expiryDate);
            DataGridViewButtonColumn uploadCert = new DataGridViewButtonColumn();
            uploadCert.Name = "Upload Certificate";
            uploadCert.Text = "Upload";
            uploadCert.UseColumnTextForButtonValue = true;
            coursesData.Columns.Insert(3, uploadCert);


            DataGridViewTextBoxColumn selectedDocs = new DataGridViewTextBoxColumn();
            selectedDocs.Name = " ";
            coursesData.Columns.Insert(4, selectedDocs);

            coursesData.Columns[0].Width = 250;
            
            coursesData.Columns[0].ReadOnly = true;
            coursesData.Columns[4].Width = 200;
            for (int i = 0; i < coursesData.RowCount; i++)
            {
                coursesData.Rows[i].Cells[1].Value = "dd/mm/yy";
                coursesData.Rows[i].Cells[2].Value = "dd/mm/yy";
                coursesData.Rows[i].Cells[4].Value = "";
            }

            string q2 = "select * from certificates where EmployeeID='" + overviewWindow.employeeID + "'";
            using (SQLiteCommand c1 = new SQLiteCommand(q2, sqlite_conn))
            {
                using (SQLiteDataReader dr = c1.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        foreach(DataGridViewRow row in coursesData.Rows)
                        {
                            if(row.Cells[coursesData.Columns["Course"].Index].Value.ToString().Replace(" ","") == dr["courseID"].ToString())
                            {
                                row.Cells[1].Value = dr["issueDate"].ToString();
                                row.Cells[2].Value = dr["expiryDate"].ToString();
                                row.Cells[4].Value = dr["files"].ToString();
                            }
                        }
                    }
                }
            }

            sqlite_conn.Close();
            coursesData.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            coursesData.ClearSelection();
        }
        private void coursesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                OpenFileDialog chooseCert = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Browse Docs",

                    CheckFileExists = true,
                    CheckPathExists = true,
                    Multiselect = true,
                    DefaultExt = ".pdf",
                    Filter = "Documents (*.pdf;*.docx;*.bmp;*.jpg;*.png;)|*.pdf;*.docx;*.bmp;*.jpg;*.png",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (chooseCert.ShowDialog() == DialogResult.OK)
                {
                    string fileLocations = "";
                    foreach (string name in chooseCert.FileNames)
                        fileLocations += name + "#";
                    coursesData.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value = fileLocations;
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (nameText.Text == "" || employeeNumberText.Text  == "" || jobTitleText.Text == "")
            {
                MessageBox.Show("Please Fill Information");
            }
            else if(isDataValid()!="")
            {
                MessageBox.Show("Fill Course '" + isDataValid() + "' properly");
            }
            else if(addPhotoLabel.Image == null)
            {
                MessageBox.Show("Please select a Photo");
            }
            else
            {
                if (overviewWindow.updateFlag)
                {
                    overviewWindow.deleteThisRecord(overviewWindow.deletingRow);
                }
                string empname = nameText.Text;
                string empnum = employeeNumberText.Text;
                string jtitle = jobTitleText.Text;
                string empN = empname.Replace(" ", "");

                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Certificates\" + empN + @"\";
                if (Directory.Exists(appPath) == false)                                              // <---
                {                                                                                    // <---
                    Directory.CreateDirectory(appPath);                                              // <---
                }
                try
                {
                    Bitmap bmp1 = new Bitmap(addPhotoLabel.Image);

                    if (System.IO.File.Exists(appPath + empN + "ProfilePic.jpg"))
                        System.IO.File.Delete(appPath + empN + "ProfilePic.jpg");

                    bmp1.Save(appPath + empN + "ProfilePic.jpg");
                    // Dispose of the image files.
                    bmp1.Dispose();

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Image Error!"+exp.Message);
                }
                SQLiteConnection.ClearAllPools();
                GC.Collect();
                using (SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source= certificates.sqlite; Version = 3; New = True; Compress = True; "))
                {
                    // Open the connection:
                    try
                    {
                        sqlite_conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Loading Database!!");
                    }
                    string cmd = "insert into employee (EmployeeID, Employee_Name, Job_Title, Profile_Pic)"
                                + " values ('" + empnum + "','" + empname + "','" + jtitle + "','" + appPath + empN + "ProfilePic.jpg')";
                    try
                    {
                        using (SQLiteCommand c = new SQLiteCommand(cmd, sqlite_conn))
                            c.ExecuteNonQuery();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Error Saving Employee! : " + exp.Message);
                        sqlite_conn.Close();
                        return;
                    }


                    //Saving Files of Certificates

                    // <---

                    List<string> filesLocations = new List<string>();
                    List<string> courseIDs = new List<string>();
                    foreach (DataGridViewRow row in coursesData.Rows)
                    {
                        if (row.Cells[1].Value.ToString() != "dd/mm/yy")
                        {
                            filesLocations.Add(row.Cells[4].Value.ToString());
                            courseIDs.Add(row.Cells[0].Value.ToString());
                        }

                    }

                    ProgressBar pb = new ProgressBar();
                    pb.Location = new System.Drawing.Point(200, 200);
                    pb.Name = "Copying Files";
                    pb.Width = 300;
                    pb.Height = 30;
                    pb.Minimum = 0;
                    pb.Maximum = filesLocations.Count;
                    this.Controls.Add(pb);
                    pb.Visible = true;
                    List<string> newFilesLocations = new List<string>();
                    for (int i = 0; i < filesLocations.Count; i++)
                    {
                        pb.Value = i;
                        List<string> fileLocations = new List<string>();
                        fileLocations = filesLocations[i].Split('#').ToList();
                        fileLocations.RemoveAt(fileLocations.Count-1);
                        string tempFileLocation = "";
                        foreach (string file in fileLocations)
                        {
                            string fileExtension = file.Split('.')[1];
                            string newFileName = empN + courseIDs[i] + "File" + i + "." + fileExtension;
                            try
                            {
                                File.Copy(file, appPath + newFileName);
                                
                                tempFileLocation += appPath + newFileName + "#";
                                
                            }
                            catch (Exception exp)
                            {
                                try
                                {
                                    File.Replace(file, appPath + newFileName, appPath+"old" + newFileName);

                                    tempFileLocation += appPath + newFileName + "#";
                                }
                                catch(Exception ep)
                                {
                                    tempFileLocation += appPath + newFileName + "#";
                                }
                                
                                
                            }
                        }
                        newFilesLocations.Add(tempFileLocation);
                    }

                    pb.Hide();


                    int counter = 0;
                    foreach (DataGridViewRow row in coursesData.Rows)
                    {
                        if (row.Cells[1].Value.ToString() != "dd/mm/yy")
                        {
                            string insertQuery = "insert into certificates (EmployeeID, courseID, files, issueDate, expiryDate)" +
                                            "values ('" + empnum + "','" + row.Cells[0].Value.ToString().Replace(" ", "") +
                                            "','" + newFilesLocations[counter] + "','" + row.Cells[1].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "')";

                            using (SQLiteCommand sc = new SQLiteCommand(insertQuery, sqlite_conn))
                                sc.ExecuteNonQuery();
                            counter++;
                        }

                    }
                    sqlite_conn.Close();
                    MessageBox.Show("Employee " + empname + " Saved");
                }
            }
                
        }

        public string isDataValid()
        {
            string invalidCourse = "";

            foreach(DataGridViewRow row in coursesData.Rows)
            {
                if((row.Cells[1].Value.ToString()!="dd/mm/yy"||row.Cells[2].Value.ToString()!="dd/mm/yy"||row.Cells[4].Value.ToString() != "")
                    && (row.Cells[1].Value.ToString() == "dd/mm/yy" || row.Cells[2].Value.ToString() == "dd/mm/yy" || row.Cells[4].Value.ToString() == ""))
                {
                    invalidCourse = row.Cells[0].Value.ToString();
                }
            }
                

            return invalidCourse;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void minmaxbutton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
