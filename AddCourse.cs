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
    public partial class AddCourse : Form
    {
        bool updating;
        string cn;
        public AddCourse()
        {
            InitializeComponent();
            windowTitle.MouseDown += WindowTitle_MouseDown;
            updating = false;
            cn = "";
        }

        private void windowTitle_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (courseNameText.Text.Equals("") || courseNameText.Text.Equals(""))
                MessageBox.Show("Please fill the information");
            else
            {
                String courseName = courseNameText.Text;
                int notifyBeforeDays = Int32.Parse(notifyBeforeText.Text);

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
                if(updating)
                {
                    string cmd = "update courses set ID='"+ courseName.Replace(" ", "") + "', Course='"+courseName+"',Notify_Before="+notifyBeforeDays + " where ID='"+cn.Replace(" ","")+"'";

                    SQLiteCommand insertCourse = new SQLiteCommand(cmd, sqlite_conn);
                    insertCourse.ExecuteNonQuery();
                    MessageBox.Show(courseName + " Updated");
                    addButton.Text = "Add";
                    updating = false;
                }
                else if(!updating)
                {
                    string cmd = "insert into courses (ID, Course, Notify_Before) values ('" + courseName.Replace(" ", "") + "','" + courseName + "'," + notifyBeforeDays + ")";

                    SQLiteCommand insertCourse = new SQLiteCommand(cmd, sqlite_conn);
                    insertCourse.ExecuteNonQuery();                    
                    MessageBox.Show(courseName + " Added");
                    
                }
                coursesData.Columns.Clear();
                loadCourseData();
                sqlite_conn.Close();
                courseNameText.Text = "";
                notifyBeforeText.Text = "";
            }
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

            loadCourseData();
        }

        public void loadCourseData()
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
            string cmd = "select * from courses";

            DataTable dt = new DataTable();
            SQLiteCommand c = new SQLiteCommand(cmd, sqlite_conn);
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(c);

            adapt.Fill(dt);
            dt.Columns.Remove("ID");
            coursesData.DataSource = dt;
            DataGridViewImageColumn ebc = new DataGridViewImageColumn();
            ebc.Name = " ";
            ebc.Width = 40;
            ebc.Image = Properties.Resources.editIcon.GetThumbnailImage(22,22, null, IntPtr.Zero);
            
                            
            coursesData.Columns.Insert(2, ebc);
            DataGridViewImageColumn dbc = new DataGridViewImageColumn();
            dbc.Name = "  ";
            dbc.Width = 40;
            dbc.Image = Properties.Resources.delete.GetThumbnailImage(22, 22, null, IntPtr.Zero);
            coursesData.Columns.Insert(3, dbc);
            coursesData.Columns[0].Width = 270;
            coursesData.Columns[1].Width = 137;
            coursesData.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            coursesData.ClearSelection();
            sqlite_conn.Close();
        }

        private void coursesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                
                DataGridViewRow row = coursesData.Rows[e.RowIndex];
                string cn = row.Cells["Course"].Value.ToString();
                if (MessageBox.Show(string.Format("Do you want to delete Course: {0}?", cn), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    string cmd = "delete from courses where ID='"+cn.Replace(" ","")+"'";
                    SQLiteCommand deleteCourse = new SQLiteCommand(cmd, sqlite_conn);
                    deleteCourse.ExecuteNonQuery();
                    coursesData.Columns.Clear();
                    loadCourseData();
                    sqlite_conn.Close();
                }
            }
            if (e.ColumnIndex == 2)
            {
                updating = true;
                DataGridViewRow row = coursesData.Rows[e.RowIndex];
                cn = row.Cells["Course"].Value.ToString();
                string nb = row.Cells["Notify_Before"].Value.ToString();
                courseNameText.Text = cn;
                notifyBeforeText.Text = nb;
                addButton.Text = "Update";
                
            }
        }

        private void minmaxbutton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void isMaximizedWindow()
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
