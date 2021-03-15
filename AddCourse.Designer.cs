namespace CertificatesManager
{
    partial class AddCourse
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
            this.minimizeButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.windowTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coursesData = new System.Windows.Forms.DataGridView();
            this.courseDetails = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyBeforeText = new System.Windows.Forms.TextBox();
            this.courseNameText = new System.Windows.Forms.TextBox();
            this.notifyBeforeLabel = new System.Windows.Forms.Label();
            this.courseNamelabel = new System.Windows.Forms.Label();
            this.minmaxbutton = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesData)).BeginInit();
            this.courseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButton.Location = new System.Drawing.Point(939, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(22, 31);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.Text = "−";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(982, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 31);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // windowTitle
            // 
            this.windowTitle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.ForeColor = System.Drawing.Color.LightGray;
            this.windowTitle.Location = new System.Drawing.Point(63, 0);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(874, 40);
            this.windowTitle.TabIndex = 4;
            this.windowTitle.Text = "Superior Employee Management System";
            this.windowTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.windowTitle.Click += new System.EventHandler(this.windowTitle_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.courseDetails);
            this.mainPanel.Location = new System.Drawing.Point(3, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(995, 511);
            this.mainPanel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.coursesData);
            this.groupBox1.Location = new System.Drawing.Point(40, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // coursesData
            // 
            this.coursesData.AllowUserToAddRows = false;
            this.coursesData.AllowUserToDeleteRows = false;
            this.coursesData.AllowUserToResizeColumns = false;
            this.coursesData.AllowUserToResizeRows = false;
            this.coursesData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.coursesData.BackgroundColor = System.Drawing.Color.White;
            this.coursesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesData.Location = new System.Drawing.Point(152, 11);
            this.coursesData.Name = "coursesData";
            this.coursesData.Size = new System.Drawing.Size(532, 304);
            this.coursesData.TabIndex = 0;
            this.coursesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesData_CellContentClick);
            // 
            // courseDetails
            // 
            this.courseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseDetails.Controls.Add(this.addButton);
            this.courseDetails.Controls.Add(this.label1);
            this.courseDetails.Controls.Add(this.notifyBeforeText);
            this.courseDetails.Controls.Add(this.courseNameText);
            this.courseDetails.Controls.Add(this.notifyBeforeLabel);
            this.courseDetails.Controls.Add(this.courseNamelabel);
            this.courseDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDetails.Location = new System.Drawing.Point(40, 8);
            this.courseDetails.Name = "courseDetails";
            this.courseDetails.Size = new System.Drawing.Size(912, 179);
            this.courseDetails.TabIndex = 0;
            this.courseDetails.TabStop = false;
            this.courseDetails.Text = "Add Course Details";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(196)))), ((int)(((byte)(105)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(604, 142);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 31);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Days";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notifyBeforeText
            // 
            this.notifyBeforeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifyBeforeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyBeforeText.Location = new System.Drawing.Point(308, 106);
            this.notifyBeforeText.Name = "notifyBeforeText";
            this.notifyBeforeText.Size = new System.Drawing.Size(157, 22);
            this.notifyBeforeText.TabIndex = 3;
            // 
            // courseNameText
            // 
            this.courseNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameText.Location = new System.Drawing.Point(308, 54);
            this.courseNameText.Name = "courseNameText";
            this.courseNameText.Size = new System.Drawing.Size(376, 22);
            this.courseNameText.TabIndex = 2;
            // 
            // notifyBeforeLabel
            // 
            this.notifyBeforeLabel.AutoSize = true;
            this.notifyBeforeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyBeforeLabel.Location = new System.Drawing.Point(149, 106);
            this.notifyBeforeLabel.Name = "notifyBeforeLabel";
            this.notifyBeforeLabel.Size = new System.Drawing.Size(85, 16);
            this.notifyBeforeLabel.TabIndex = 1;
            this.notifyBeforeLabel.Text = "Notify Before";
            // 
            // courseNamelabel
            // 
            this.courseNamelabel.AutoSize = true;
            this.courseNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNamelabel.Location = new System.Drawing.Point(146, 60);
            this.courseNamelabel.Name = "courseNamelabel";
            this.courseNamelabel.Size = new System.Drawing.Size(91, 16);
            this.courseNamelabel.TabIndex = 0;
            this.courseNamelabel.Text = "Course Name";
            // 
            // minmaxbutton
            // 
            this.minmaxbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minmaxbutton.AutoSize = true;
            this.minmaxbutton.Font = new System.Drawing.Font("Biting My Nails", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minmaxbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.minmaxbutton.Location = new System.Drawing.Point(963, 7);
            this.minmaxbutton.Name = "minmaxbutton";
            this.minmaxbutton.Size = new System.Drawing.Size(20, 17);
            this.minmaxbutton.TabIndex = 13;
            this.minmaxbutton.Text = "O";
            this.minmaxbutton.Click += new System.EventHandler(this.minmaxbutton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(196)))), ((int)(((byte)(105)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(3, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(61, 34);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.minmaxbutton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.windowTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesData)).EndInit();
            this.courseDetails.ResumeLayout(false);
            this.courseDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox courseDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notifyBeforeText;
        private System.Windows.Forms.TextBox courseNameText;
        private System.Windows.Forms.Label notifyBeforeLabel;
        private System.Windows.Forms.Label courseNamelabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView coursesData;
        private System.Windows.Forms.Label minmaxbutton;
        private System.Windows.Forms.Button backButton;
    }
}