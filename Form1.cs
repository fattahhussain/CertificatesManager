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
using System.Drawing.Drawing2D;

namespace CertificatesManager
{
    public partial class overviewWindow : Form
    {
        int statusColIndex;
        public static bool updateFlag;
        public static string employeeID;
        public static string employeeName;
        public static string jobTitle;
        public static string courseName;
        string profilePicPath;
        public static DataGridViewRow deletingRow;
        public overviewWindow()
        {
            InitializeComponent();
            windowTitle.MouseDown += WindowTitle_MouseDown;
            updateFlag = false;
        }

        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            var window = new AddCourse();
            window.Show();
            window.Closed += (s, args) => this.Show();
            window.Closed += (s, args) => loadCertificatesData();
            this.Hide();

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var window = new AddEmployee();
            window.Show();
            window.Closed += (s, args) => this.Show();
            window.Closed += (s, args) => loadCertificatesData();
            window.Closed += (s, args) => toUpdateFalse();
            this.Hide();
        }

        private void overviewWindow_Load(object sender, EventArgs e)
        {
            if(!File.Exists("a.txt"))
            {
                Database.createDatabase();
                File.Create("a.txt");
            }
            loadCertificatesData();
        }

        public void loadCertificatesData()
        {
            int addedExpiry = 0;
            
            detailedViewGrid.Columns.Clear();
            expiringSoonGrid.Columns.Clear();
            SQLiteConnection.ClearAllPools();
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
            string cmd = "select * from employee";

            DataTable dt = new DataTable();
            SQLiteCommand c = new SQLiteCommand(cmd, sqlite_conn);
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(c);
            
            adapt.Fill(dt);
            adapt.Dispose();
            DataGridViewImageColumn profilePic = new DataGridViewImageColumn();
            profilePic.Name = " ";
            detailedViewGrid.Columns.Insert(0, profilePic);

            dt.Columns.Remove("Profile_Pic");
            detailedViewGrid.DataSource = dt;
            List<Image> profilePictures = new List<Image>();
            if (dt.Rows.Count > 0 && detailedViewGrid.Rows.Count >0)
            {
                string p = Path.GetDirectoryName(Application.ExecutablePath) + @"\Certificates\";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    detailedViewGrid.Rows[i].Height = 40;
                    
                    string t = dt.Rows[i].ItemArray[1].ToString().Replace(" ", "");
                    profilePicPath = p + t + "\\" + t + "ProfilePic.jpg";
                    Bitmap bmp1 = new Bitmap(profilePicPath);
                    Image imgNew = Image.FromHbitmap(bmp1.GetHbitmap());
                    
                    detailedViewGrid.Rows[i].Cells[0].Value = RoundCorners(imgNew.GetThumbnailImage(40,40, null, IntPtr.Zero), 20, Color.Transparent);
                    profilePictures.Add(imgNew.GetThumbnailImage(70, 70, null, IntPtr.Zero));
                    bmp1.Dispose();
                }
            }
            string q2 = "select * from courses";
            List<string[]> coursesList = new List<string[]>();

            using (SQLiteCommand c2 = new SQLiteCommand(q2, sqlite_conn))
            {
                SQLiteDataReader dreader = c2.ExecuteReader();
                while (dreader.Read())
                    coursesList.Add(new string[3] { dreader[0].ToString(), dreader[1].ToString(), dreader[2].ToString() });
                dreader.Close();
            }
                
            int colCount = 4;
            foreach(string[] course in coursesList)
            {
                DataGridViewTextBoxColumn tempCol = new DataGridViewTextBoxColumn();
                tempCol.Name = course[1];
                detailedViewGrid.Columns.Insert(colCount++, tempCol);

            }

            DataGridViewButtonColumn statusCol = new DataGridViewButtonColumn();
            statusCol.Name = "Status";
            statusCol.FlatStyle = FlatStyle.Flat;
            
            detailedViewGrid.Columns.Insert(colCount++, statusCol);

            statusColIndex = colCount++;
            DataGridViewImageColumn ebc = new DataGridViewImageColumn();
            ebc.Name = " ";
            ebc.Width = 40;
            ebc.Image = Properties.Resources.editIcon.GetThumbnailImage(22, 22, null, IntPtr.Zero);            
            detailedViewGrid.Columns.Insert(statusColIndex, ebc);

            DataGridViewImageColumn dbc = new DataGridViewImageColumn();
            dbc.Name = "  ";
            dbc.Width = 40;
            dbc.Image = Properties.Resources.delete.GetThumbnailImage(22, 22, null, IntPtr.Zero);
            detailedViewGrid.Columns.Insert(colCount++, dbc);

            SQLiteDataReader drd = null;
            
            
            foreach (DataGridViewRow row in detailedViewGrid.Rows)
            {
                int courseIndexCounter = 4;
                int expiryFlag = -1;
                string tempCourses = "";
                foreach (string[] course in coursesList)
                {
                    string q3 = "select * from certificates where EmployeeID='" + row.Cells[1].Value.ToString() + "' and courseID='" + course[0] + "'";
                    using (SQLiteCommand c2 = new SQLiteCommand(q3, sqlite_conn))
                    {
                        drd = c2.ExecuteReader();
                        drd.Read();
                        try
                        {
                            row.Cells[detailedViewGrid.Columns[course[1]].Index].Value = drd["issueDate"] + "\n" + drd["expiryDate"];
                            
                            if (DateTime.ParseExact(drd["expiryDate"].ToString(), "d/M/y", null).Subtract(DateTime.Today) <= TimeSpan.FromDays(0))
                            {
                                if (expiryFlag < 2)
                                {
                                    expiryFlag = 2;
                                    row.Cells[detailedViewGrid.Columns["Status"].Index].Style.BackColor = Color.FromArgb(255, 0, 0);
                                    row.Cells[detailedViewGrid.Columns["Status"].Index].Value = "Expired";
                                    row.Cells[courseIndexCounter].DataGridView.GridColor = Color.DarkGray;

                                }
                                    
                            }
                            else if (DateTime.ParseExact(drd["expiryDate"].ToString(), "d/M/y", null).Subtract(DateTime.Today) >= TimeSpan.FromDays(0)
                                && DateTime.ParseExact(drd["expiryDate"].ToString(), "d/M/y", null).Subtract(DateTime.Today) <= TimeSpan.FromDays(Double.Parse(course[2])))
                            {
                                if (expiryFlag < 1)
                                {
                                    expiryFlag = 1;
                                    row.Cells[detailedViewGrid.Columns["Status"].Index].Style.BackColor = Color.FromArgb(255, 0, 0);
                                    row.Cells[detailedViewGrid.Columns["Status"].Index].Value = "Expiring Soon";
                                    row.Cells[courseIndexCounter].DataGridView.GridColor = Color.DarkGray;
                                    
                                }
                                    
                            }
                            else
                            {
                                expiryFlag = 0;
                                DataGridViewButtonCell tempCell = (DataGridViewButtonCell)row.Cells[detailedViewGrid.Columns["Status"].Index];
                                tempCell.FlatStyle = FlatStyle.Flat;
                                
                                row.Cells[detailedViewGrid.Columns["Status"].Index].Style.BackColor = Color.FromArgb(49, 56, 59);
                            }
                            tempCourses += course[1] + ",";
                                
                        }
                        catch (Exception exp)
                        {
                            row.Cells[detailedViewGrid.Columns[course[1]].Index].Value = "──";
                            row.Cells[detailedViewGrid.Columns[course[1]].Index].Style.ForeColor = Color.FromArgb(16, 196, 105);
                            row.Cells[detailedViewGrid.Columns[course[1]].Index].Style.Font = new Font("Arial Black", 25, FontStyle.Bold);
                        }
                        drd.Close();
                    }
                    courseIndexCounter++;
                    
                }
                
                if(expiryFlag >= 1)
                {
                    string tempEmployeeName = row.Cells["Employee_Name"].Value.ToString();

                    Image tempProfilePic = profilePictures[row.Index];
                    if ( addedExpiry == 0)
                    {
                        string[] ttt = new string[2];
                        expiringSoonGrid.DataSource = ttt;
                        expiringSoonGrid.Columns[0].Width = 10;
                        expiringSoonGrid.Rows[0].Height = 80;
                        expiringSoonGrid.Rows[1].Height = 20;
                        addedExpiry++;
                        //DataGridViewRow r1 = new DataGridViewRow();
                        //r1.Cells[0].Value = "";
                        //DataGridViewRow r2 = new DataGridViewRow();
                        //r2.Cells[1].Value = "";

                        //DataGridViewColumn cc2 = new DataGridViewTextBoxColumn();
                        //expiringSoonGrid.Columns.Add(cc2);

                        //expiringSoonGrid.Rows.Add(r1);
                        //expiringSoonGrid.Rows.Add(r2);
                    }
                    DataGridViewColumn col1 = new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell() };
                    expiringSoonGrid.Columns.Add(col1);
                    col1.Width = 80;
                    expiringSoonGrid.Columns[expiringSoonGrid.Columns.Count - 1].CellTemplate = new DataGridViewTextBoxCell();
                    expiringSoonGrid.Rows[1].Cells[expiringSoonGrid.Columns.Count - 1].Value = tempEmployeeName;

                    expiringSoonGrid.Columns[expiringSoonGrid.Columns.Count - 1].CellTemplate = new DataGridViewImageCell();
                    DataGridViewImageCell imcell = new DataGridViewImageCell();
                    imcell.Value = RoundCorners(tempProfilePic, 35, Color.Transparent);
                    expiringSoonGrid.Rows[0].Cells[expiringSoonGrid.Columns.Count - 1] = imcell;

                    
                    DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                    col2.Width = 150;
                    expiringSoonGrid.Columns.Add(col2);

                    expiringSoonGrid.Rows[0].Cells[expiringSoonGrid.Columns.Count - 1].Value = "Courses:\n" + tempCourses;

                    expiringSoonGrid.Rows[1].Cells[expiringSoonGrid.Columns.Count - 1].Value = " ";

                    
                }
                expiryFlag = -1;  
            }    

            
            detailedViewGrid.Columns[0].Width = 40;
            detailedViewGrid.Columns[2].Width = 200;
            detailedViewGrid.ClearSelection();
            sqlite_conn.Close();
        }
        void toUpdateFalse()
        {
            updateFlag = false;
        }
        public Image RoundCorners(Image StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);

            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Brush brush = new TextureBrush(StartImage);

                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);

                return RoundedImage;
            }
        }

        private void detailedViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == statusColIndex)
            {
                AddEmployee window = new AddEmployee();

                DataGridViewRow row = detailedViewGrid.Rows[e.RowIndex];
                updateFlag = true;
                employeeID = row.Cells["EmployeeID"].Value.ToString();
                deletingRow = row;
                updateFlag = true;
                window.Show();
                window.Closed += (s, args) => this.Show();
                window.Closed += (s, args) => loadCertificatesData();
                window.Closed += (s, args) => toUpdateFalse();

                this.Hide();
            }
            if (e.ColumnIndex == statusColIndex + 1)
            {
                DataGridViewRow row = detailedViewGrid.Rows[e.RowIndex];
                deleteThisRecord(row);
                detailedViewGrid.Columns.Clear();
                loadCertificatesData();
            }
            if(e.ColumnIndex >3 && e.ColumnIndex < statusColIndex-1)
            {
                DataGridViewRow row = detailedViewGrid.Rows[e.RowIndex];
                
                    employeeID = row.Cells["EmployeeID"].Value.ToString();
                    employeeName = row.Cells["Employee_Name"].Value.ToString();
                    jobTitle = row.Cells["Job_Title"].Value.ToString();

                    courseName = detailedViewGrid.Columns[e.ColumnIndex].HeaderText;

                    CourseFiles window = new CourseFiles();
                    window.Show();
                    window.Closed += (s, args) => this.Show();
                    window.Closed += (s, args) => loadCertificatesData();
                    window.Closed += (s, args) => toUpdateFalse();

                    this.Hide();
            }

        }

        public static void deleteThisRecord(DataGridViewRow row)
        {
            string en = row.Cells["Employee_Name"].Value.ToString();
            string cn = row.Cells["EmployeeID"].Value.ToString();
            if(!updateFlag)
            {
                if (MessageBox.Show(string.Format("Do you want to delete Employee : {0}?", en), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    string cmd = "delete from employee where EmployeeID='" + cn + "'";
                    using (SQLiteCommand deleteCourse = new SQLiteCommand(cmd, sqlite_conn))
                        deleteCourse.ExecuteNonQuery();
                    cmd = "delete from certificates where EmployeeID='" + cn + "'";
                    using (SQLiteCommand deleteCourse = new SQLiteCommand(cmd, sqlite_conn))
                        deleteCourse.ExecuteNonQuery();
                    row.Cells[0].Value = "";
                    if(updateFlag == false)
                    {
                        string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Certificates\" + en.Replace(" ", "");

                        foreach (string file in Directory.GetFiles(appPath))
                        {
                            File.Delete(file);
                        }
                        Directory.Delete(appPath);
                        sqlite_conn.Close();
                    }
                    

                }
            }
            else
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
                string cmd = "delete from employee where EmployeeID='" + cn + "'";
                using (SQLiteCommand deleteCourse = new SQLiteCommand(cmd, sqlite_conn))
                    deleteCourse.ExecuteNonQuery();
                cmd = "delete from certificates where EmployeeID='" + cn + "'";
                using (SQLiteCommand deleteCourse = new SQLiteCommand(cmd, sqlite_conn))
                    deleteCourse.ExecuteNonQuery();

                sqlite_conn.Close();
            }
        }

        private void scrollButton_Click(object sender, EventArgs e)
        {
            expiringSoonGrid.HorizontalScrollingOffset = expiringSoonGrid.HorizontalScrollingOffset + 10;
        }
        
        private void minmaxbutton_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
