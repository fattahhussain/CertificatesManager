namespace CertificatesManager
{
    partial class CourseFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.windowTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.jobtitleLbl = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.jobtitle = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.Label();
            this.courseFilesList = new System.Windows.Forms.DataGridView();
            this.files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseFilesList)).BeginInit();
            this.SuspendLayout();
            // 
            // windowTitle
            // 
            this.windowTitle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.ForeColor = System.Drawing.Color.LightGray;
            this.windowTitle.Location = new System.Drawing.Point(2, 2);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(339, 29);
            this.windowTitle.TabIndex = 5;
            this.windowTitle.Text = "Course Files";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(348, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 31);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // jobtitleLbl
            // 
            this.jobtitleLbl.AutoSize = true;
            this.jobtitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobtitleLbl.ForeColor = System.Drawing.Color.LightGray;
            this.jobtitleLbl.Location = new System.Drawing.Point(9, 109);
            this.jobtitleLbl.Name = "jobtitleLbl";
            this.jobtitleLbl.Size = new System.Drawing.Size(66, 16);
            this.jobtitleLbl.TabIndex = 9;
            this.jobtitleLbl.Text = "Job Title :";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberLabel.ForeColor = System.Drawing.Color.LightGray;
            this.employeeNumberLabel.Location = new System.Drawing.Point(9, 76);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(92, 16);
            this.employeeNumberLabel.TabIndex = 8;
            this.employeeNumberLabel.Text = "Employee ID :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.nameLabel.Location = new System.Drawing.Point(9, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(116, 16);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Employee Name :";
            // 
            // jobtitle
            // 
            this.jobtitle.AutoSize = true;
            this.jobtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobtitle.ForeColor = System.Drawing.Color.LightGray;
            this.jobtitle.Location = new System.Drawing.Point(154, 109);
            this.jobtitle.Name = "jobtitle";
            this.jobtitle.Size = new System.Drawing.Size(0, 16);
            this.jobtitle.TabIndex = 12;
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeID.ForeColor = System.Drawing.Color.LightGray;
            this.employeeID.Location = new System.Drawing.Point(154, 76);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(0, 16);
            this.employeeID.TabIndex = 11;
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.ForeColor = System.Drawing.Color.LightGray;
            this.employeeName.Location = new System.Drawing.Point(154, 48);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(0, 16);
            this.employeeName.TabIndex = 10;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.courseNameLabel.Location = new System.Drawing.Point(9, 144);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(97, 16);
            this.courseNameLabel.TabIndex = 13;
            this.courseNameLabel.Text = "Course Name :";
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.Color.LightGray;
            this.courseName.Location = new System.Drawing.Point(154, 144);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(0, 16);
            this.courseName.TabIndex = 14;
            // 
            // courseFilesList
            // 
            this.courseFilesList.AllowUserToAddRows = false;
            this.courseFilesList.AllowUserToDeleteRows = false;
            this.courseFilesList.AllowUserToResizeColumns = false;
            this.courseFilesList.AllowUserToResizeRows = false;
            this.courseFilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseFilesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseFilesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.courseFilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseFilesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.courseFilesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseFilesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.courseFilesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseFilesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.files});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseFilesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.courseFilesList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.courseFilesList.EnableHeadersVisualStyles = false;
            this.courseFilesList.GridColor = System.Drawing.Color.LightGray;
            this.courseFilesList.Location = new System.Drawing.Point(2, 188);
            this.courseFilesList.Name = "courseFilesList";
            this.courseFilesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseFilesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.courseFilesList.RowTemplate.Height = 40;
            this.courseFilesList.Size = new System.Drawing.Size(376, 311);
            this.courseFilesList.TabIndex = 15;
            this.courseFilesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseFilesList_CellContentClick);
            // 
            // files
            // 
            this.files.HeaderText = "Files";
            this.files.Name = "files";
            this.files.ReadOnly = true;
            // 
            // CourseFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 503);
            this.Controls.Add(this.courseFilesList);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.jobtitle);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.jobtitleLbl);
            this.Controls.Add(this.employeeNumberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.windowTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseFiles";
            this.Text = "CourseFiles";
            this.Load += new System.EventHandler(this.CourseFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseFilesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label jobtitleLbl;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label jobtitle;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.DataGridView courseFilesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn files;
    }
}